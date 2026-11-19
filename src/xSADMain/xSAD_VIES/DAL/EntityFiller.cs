using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;

namespace xSAD_VIES.DAL;

public class EntityFiller<TEntity> where TEntity : new()
{
	private readonly IDictionary<string, MemberInfo> _properties = new Dictionary<string, MemberInfo>();

	private readonly Type _type = typeof(TEntity);

	public IList<TEntity> Fill(DbDataReader dataReader)
	{
		if (dataReader == null)
		{
			throw new ArgumentNullException("dataReader");
		}
		List<TEntity> list = new List<TEntity>();
		List<IDictionary<string, object>> list2 = new List<IDictionary<string, object>>();
		while (dataReader.Read())
		{
			list2.Add(ReadRow(dataReader));
		}
		dataReader.Close();
		foreach (IDictionary<string, object> item in list2)
		{
			list.Add(BuildEntity(item));
		}
		return list;
	}

	private static IDictionary<string, object> ReadRow(IDataRecord record)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		for (int i = 0; i < record.FieldCount; i++)
		{
			dictionary.Add(record.GetName(i), record.GetValue(i));
		}
		return dictionary;
	}

	private TEntity BuildEntity(IDictionary<string, object> row)
	{
		TEntity val = new TEntity();
		foreach (KeyValuePair<string, object> item in row)
		{
			string key = item.Key;
			object obj = item.Value;
			if (obj == DBNull.Value)
			{
				obj = null;
			}
			SetProperty(key, val, obj);
		}
		return val;
	}

	private void SetProperty(string key, TEntity entity, object value)
	{
		if (_properties.ContainsKey(key))
		{
			SetPropertyFromDictionary(_properties[key], entity, value);
			return;
		}
		PropertyInfo property = _type.GetProperty(key, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		if (property != null && property.CanWrite)
		{
			_properties.Add(key, property);
			property.SetValue(entity, value, null);
		}
		else
		{
			FieldInfo field = _type.GetField("_" + key, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic);
			_properties.Add(key, field);
			field.SetValue(entity, value);
		}
	}

	private static void SetPropertyFromDictionary(MemberInfo member, TEntity entity, object value)
	{
		PropertyInfo propertyInfo = member as PropertyInfo;
		if (propertyInfo != null)
		{
			propertyInfo.SetValue(entity, value, null);
		}
		FieldInfo fieldInfo = member as FieldInfo;
		if (fieldInfo != null)
		{
			fieldInfo.SetValue(entity, value);
		}
	}
}
