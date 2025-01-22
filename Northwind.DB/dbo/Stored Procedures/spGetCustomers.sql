CREATE PROCEDURE [dbo].[spGetCustomers]
AS
	SELECT [CustomerID] ,[CompanyName] ,[ContactName] ,[ContactTitle] ,[Address] ,[City] ,[Region] ,[PostalCode] ,[Country] ,[Phone] ,[Fax] 
	FROM [dbo].[Customers] 
