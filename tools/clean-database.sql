-- Empties the bundled xSAD-VIESv1.sdf before it is shipped.
-- The v1.7.1 copy still holds a developer's groups, companies, tax codes and XML folder (X1-CARBON\user).
-- Run against a COPY of src\xSADMain\Database\xSAD-VIESv1.sdf with any SQL CE 3.5 tool
-- (e.g. SQL Server Compact Toolbox in Visual Studio), then replace the original.
-- Settings is left alone: the app expects its single row to exist.

DELETE FROM ChildrenCompanies;
DELETE FROM Companies;
DELETE FROM MultipleCompany;
DELETE FROM Groups;
DELETE FROM UserXmlFolders;

-- Leftovers from the sibling VAT product; v1.7.1 never reads them.
DROP TABLE CompanyTaxCodes;
DROP TABLE Banks;
