using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using xSAD_VIES.BL;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;

namespace xSAD_VIES.Common;

public static class XmlFuncs
{
	public static ViesEntity ReadEntityFromXml(string xmlFileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(xmlFileName);
		ViesEntity viesEntity = new ViesEntity();
		XmlElement xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:vies1-declaration")[0];
		viesEntity.TaxPayer = xmlElement.GetAttribute("taxpayer");
		xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:period")[0];
		try
		{
			viesEntity.PeriodFrom = Convert.ToDateTime(xmlElement.GetAttribute("from"));
			viesEntity.PeriodTo = Convert.ToDateTime(xmlElement.GetAttribute("to"));
			xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:month")[0];
			viesEntity.DeclarationMonth = Convert.ToInt32(xmlElement.InnerText);
			xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:year")[0];
			viesEntity.DeclarationYear = Convert.ToInt32(xmlElement.InnerText);
		}
		catch
		{
			viesEntity.PeriodFrom = DateTime.Now;
			viesEntity.PeriodTo = DateTime.Now;
			viesEntity.DeclarationMonth = DateTime.Now.Month;
			viesEntity.DeclarationYear = DateTime.Now.Year;
		}
		xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:sum-supplies-amount")[0];
		viesEntity.SumSuppliesAmount = Convert.ToDecimal(xmlElement.InnerText);
		xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:sum-triangle-transactions-amount")[0];
		viesEntity.SumTriangleTransactionsAmount = Convert.ToDecimal(xmlElement.InnerText);
		xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:sum-services-amount")[0];
		viesEntity.SumServicesAmount = Convert.ToDecimal(xmlElement.InnerText);
		xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:total-rows")[0];
		int num = Convert.ToInt32(xmlElement.InnerText);
		for (int i = 0; i < num; i++)
		{
			ViesRowEntity viesRowEntity = new ViesRowEntity();
			viesEntity.ViesRows.Add(viesRowEntity);
			viesRowEntity.RowNumber = i + 1;
			xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:vat-number")[i];
			viesRowEntity.VatRegistrationNumber = xmlElement.InnerText;
			viesRowEntity.CountryCode = xmlElement.GetAttribute("country");
			xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:supplies-amount")[i];
			viesRowEntity.SuppliesAmount = Convert.ToDecimal(xmlElement.InnerText);
			xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:triangle-transactions-amount")[i];
			viesRowEntity.TriangleTransactionsAmount = Convert.ToDecimal(xmlElement.InnerText);
			xmlElement = (XmlElement)xmlDocument.GetElementsByTagName("mof:services-amount")[i];
			viesRowEntity.ServicesAmount = Convert.ToDecimal(xmlElement.InnerText);
		}
		return viesEntity;
	}

	// Tax For All only accepts UTF-8 without a byte-order mark: Encoding.UTF8 writes one (EF BB BF) and the
	// portal then rejects the upload with "content does not match its extension".
	private static readonly Encoding Utf8NoBom = new UTF8Encoding(false);

	// XmlTextWriter declares encoding="utf-8"; the portal's instructions spell it encoding="UTF-8".
	private static void UppercaseEncodingDeclaration(string xmlFileName)
	{
		string xml = File.ReadAllText(xmlFileName, Utf8NoBom);
		int end = xml.IndexOf("?>", StringComparison.Ordinal);
		if (end > 0)
		{
			xml = xml.Substring(0, end).Replace("encoding=\"utf-8\"", "encoding=\"UTF-8\"") + xml.Substring(end);
			File.WriteAllText(xmlFileName, xml, Utf8NoBom);
		}
	}

	public static void SaveEntityToXml(ViesEntity entity, string xmlFileName, bool replaceGrWithEl)
	{
		Directory.CreateDirectory(Path.GetDirectoryName(xmlFileName));
		XmlTextWriter xmlTextWriter = new XmlTextWriter(xmlFileName, Utf8NoBom);
		xmlTextWriter.Indentation = 2;
		xmlTextWriter.IndentChar = ' ';
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("mof:vies1-declarations");
		xmlTextWriter.WriteAttributeString("xmlns:mof", "http://www.mof.gov.cy");
		xmlTextWriter.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
		xmlTextWriter.WriteAttributeString("xsi:schemaLocation", "http://www.mof.gov.cy http://taxisnet.mof.gov.cy/schema/cy-vies1-2010-declaration.xsd");
		WriteViesEntity(xmlTextWriter, entity, replaceGrWithEl);
		xmlTextWriter.WriteEndDocument();
		xmlTextWriter.Close();
		UppercaseEncodingDeclaration(xmlFileName);
	}

	private static void SaveEntityToXml(IEnumerable<ViesEntity> entities, string xmlFileName, bool replaceGrWithEl)
	{
		Directory.CreateDirectory(Path.GetDirectoryName(xmlFileName));
		XmlTextWriter xmlTextWriter = new XmlTextWriter(xmlFileName, Utf8NoBom);
		xmlTextWriter.Indentation = 2;
		xmlTextWriter.IndentChar = ' ';
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("mof:vies1-declarations");
		xmlTextWriter.WriteAttributeString("xmlns:mof", "http://www.mof.gov.cy");
		xmlTextWriter.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
		xmlTextWriter.WriteAttributeString("xsi:schemaLocation", "http://www.mof.gov.cy http://taxisnet.mof.gov.cy/schema/cy-vies1-2010-declaration.xsd");
		foreach (ViesEntity entity in entities)
		{
			WriteViesEntity(xmlTextWriter, entity, replaceGrWithEl);
		}
		xmlTextWriter.WriteEndDocument();
		xmlTextWriter.Close();
		UppercaseEncodingDeclaration(xmlFileName);
	}

	private static void WriteViesEntity(XmlTextWriter textWriter, ViesEntity entity, bool replaceGrWithEl)
	{
		textWriter.WriteStartElement("mof:vies1-declaration");
		textWriter.WriteAttributeString("taxpayer", entity.TaxPayer);
		textWriter.WriteAttributeString("version", "2010-1.0");
		textWriter.WriteStartElement("mof:period");
		textWriter.WriteAttributeString("from", entity.PeriodFrom.ToString("yyyy-MM-dd"));
		textWriter.WriteAttributeString("to", entity.PeriodTo.ToString("yyyy-MM-dd"));
		textWriter.WriteEndElement();
		textWriter.WriteStartElement("mof:month");
		textWriter.WriteValue(entity.DeclarationMonth);
		textWriter.WriteEndElement();
		textWriter.WriteStartElement("mof:year");
		textWriter.WriteValue(entity.DeclarationYear);
		textWriter.WriteEndElement();
		textWriter.WriteStartElement("mof:total-rows");
		textWriter.WriteValue(entity.ViesRows.Count.ToString());
		textWriter.WriteEndElement();
		textWriter.WriteStartElement("mof:sum-supplies-amount");
		textWriter.WriteValue(entity.SumSuppliesAmount.ToString("0"));
		textWriter.WriteEndElement();
		textWriter.WriteStartElement("mof:sum-triangle-transactions-amount");
		textWriter.WriteValue(entity.SumTriangleTransactionsAmount.ToString("0"));
		textWriter.WriteEndElement();
		textWriter.WriteStartElement("mof:sum-services-amount");
		textWriter.WriteValue(entity.SumServicesAmount.ToString("0"));
		textWriter.WriteEndElement();
		foreach (ViesRowEntity viesRow in entity.ViesRows)
		{
			textWriter.WriteStartElement("mof:row");
			textWriter.WriteAttributeString("number", viesRow.RowNumber.ToString());
			string text = viesRow.CountryCode;
			if (replaceGrWithEl && text == "GR")
			{
				text = "EL";
			}
			textWriter.WriteStartElement("mof:vat-number");
			textWriter.WriteAttributeString("country", text);
			textWriter.WriteValue(viesRow.VatRegistrationNumber);
			textWriter.WriteEndElement();
			textWriter.WriteStartElement("mof:supplies-amount");
			textWriter.WriteValue(viesRow.SuppliesAmount.ToString("0"));
			textWriter.WriteEndElement();
			textWriter.WriteStartElement("mof:triangle-transactions-amount");
			textWriter.WriteValue(viesRow.TriangleTransactionsAmount.ToString("0"));
			textWriter.WriteEndElement();
			textWriter.WriteStartElement("mof:services-amount");
			textWriter.WriteValue(viesRow.ServicesAmount.ToString("0"));
			textWriter.WriteEndElement();
			textWriter.WriteEndElement();
		}
		textWriter.WriteEndElement();
	}

	private static IEnumerable<string> GetCompanyXmlFiles(SageCompany sageCompany)
	{
		Directory.CreateDirectory(sageCompany.CompanyXmlPath);
		List<string> list = new List<string>();
		string[] files = Directory.GetFiles(sageCompany.CompanyXmlPath, "*_cyvies_*.xml");
		foreach (string text in files)
		{
			if (File.Exists(text))
			{
				list.Add(text);
			}
		}
		return list;
	}

	public static string GenerateXmlFilename(string companyName, DateTime periodFrom, DateTime periodTo)
	{
		return string.Format("{2}_cyvies_{0}_to_{1}.xml", periodFrom.ToString("yyyy-MM-dd"), periodTo.ToString("yyyy-MM-dd"), companyName);
	}

	public static string GenerateXmlFilename(DateTime periodFrom, DateTime periodTo, SageCompany sageCompany)
	{
		string path = GenerateXmlFilename(sageCompany.CompanyCode, periodFrom, periodTo);
		return Path.Combine(sageCompany.CompanyXmlPath, path);
	}

	public static List<ViesEntity> GetCompanyViesEntities(SageCompany sageCompany)
	{
		IEnumerable<string> companyXmlFiles = GetCompanyXmlFiles(sageCompany);
		List<ViesEntity> list = new List<ViesEntity>();
		foreach (string item2 in companyXmlFiles)
		{
			try
			{
				ViesEntity item = ReadEntityFromXml(item2);
				list.Add(item);
			}
			catch
			{
			}
		}
		list.Sort((ViesEntity c1, ViesEntity c2) => c1.PeriodFrom.CompareTo(c2.PeriodFrom));
		return list;
	}

	public static List<ViesEntity> GetGroupViesEntities(int groupId)
	{
		IEnumerable<string> groupXmlFiles = GetGroupXmlFiles(Controller.GetGroupName(groupId));
		List<ViesEntity> list = new List<ViesEntity>();
		foreach (string item2 in groupXmlFiles)
		{
			try
			{
				ViesEntity item = ReadEntityFromXml(item2);
				list.Add(item);
			}
			catch
			{
			}
		}
		list.Sort((ViesEntity c1, ViesEntity c2) => c1.PeriodFrom.CompareTo(c2.PeriodFrom));
		return list;
	}

	private static IEnumerable<string> GetGroupXmlFiles(string groupName)
	{
		string path = GenerateXmlFilenameForGroupEntity(groupName);
		Directory.CreateDirectory(path);
		List<string> list = new List<string>();
		string[] files = Directory.GetFiles(path, "*_cyvies_*.xml");
		foreach (string text in files)
		{
			if (File.Exists(text))
			{
				list.Add(text);
			}
		}
		return list;
	}

	public static void GenerateXmlForListOfEntities(string xmlFilename, List<ViesEntity> entities, bool replaceGrWithEl)
	{
		SaveEntityToXml(entities, xmlFilename, replaceGrWithEl);
		string directoryName = Path.GetDirectoryName(xmlFilename);
		Directory.CreateDirectory(directoryName);
		Process.Start(directoryName);
	}

	public static string GenerateXmlFilenameForMultipleEntity(string multiGroupName)
	{
		multiGroupName = CommonFuncs.SanitizeName(multiGroupName);
		return Path.Combine(Service.GetUserXmlFolder, "Multiple_" + multiGroupName);
	}

	public static string GenerateXmlFilenameForGroupEntity(string groupName)
	{
		groupName = CommonFuncs.SanitizeName(groupName);
		return Path.Combine(Service.GetUserXmlFolder, "Group_" + groupName);
	}
}
