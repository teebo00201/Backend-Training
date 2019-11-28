1
SELECT * FROM Employees

2
SELECT RegionID,RegionDescription FROM Region

3
SELECT CustomerID,CompanyName,ContactName,Region FROM Customers ORDER BY CompanyName ASC 
SELECT CustomerID AS ID ,ContactName AS Name ,Region AS Region FROM Customers ORDER BY CompanyName ASC 
 
4
SELECT * FROM Orders
SELECT CustomerID,Freight FROM Orders WHERE OrderDate BETWEEN '1997-01-01' AND '1997-12-31' AND Freight <= '100' AND ShipCountry = 'Brazil'
SELECT CustomerID FROM Orders WHERE OrderDate BETWEEN '1997-01-01' AND '1997-12-31' AND Freight <= '100' AND ShipCountry = 'Brazil'

5
SELECT * FROM Customers
SELECT CompanyName,Country,ContactName FROM Customers WHERE Country IN('Mexico','Sweden','Germany')
SELECT CompanyName,ContactName FROM Customers WHERE Country IN('Mexico','Sweden','Germany')

6
SELECT * FROM Suppliers
SELECT CompanyName,City,Country,PostalCode FROM Suppliers
SELECT CompanyName,City,Country,PostalCode,Address FROM Suppliers WHERE Address LIKE '%rue%'
SELECT CompanyName,City,Country,PostalCode FROM Suppliers WHERE Address LIKE '%rue%'

7
SELECT * FROM Customers
SELECT * FROM Orders
SELECT ContactName FROM Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID

8
SELECT * FROM Products
SELECT COUNT(*)AS CountDiscontinued FROM Products WHERE Discontinued = '1'

9
SELECT * FROM Products
SELECT * FROM Categories
SELECT UnitPrice,CategoryName FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID WHERE CategoryName = 'Beverages'
SELECT AVG(UnitPrice) as AVGUnitprice FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID WHERE CategoryName = 'Beverages'

10
SELECT * FROM Products
SELECT DISTINCT ProductName FROM Products 
SELECT MIN(UnitPrice) as price FROM Products
SELECT UnitPrice,ProductName FROM Products
SELECT UnitPrice FROM Products

11
SELECT * FROM Employees
SELECT * FROM Orders
SELECT * FROM Shippers 
SELECT CompanyName,CustomerID,ShipperID,ShipVia as shortname  FROM Orders INNER JOIN Shippers ON Shippers.ShipperID = Orders.ShipVia
SELECT CompanyName,ShipVia as EmsThai  FROM Orders INNER JOIN Shippers ON Shippers.ShipperID = Orders.ShipVia WHERE ShipperID = '1' 
SELECT CompanyName,ShipVia as KerryExpress  FROM Orders INNER JOIN Shippers ON Shippers.ShipperID = Orders.ShipVia WHERE ShipperID = '2'  
SELECT CompanyName,ShipVia as Lazada  FROM Orders INNER JOIN Shippers ON Shippers.ShipperID = Orders.ShipVia WHERE ShipperID = '3'

12
SELECT * FROM [Order Details] INNER JOIN Orders 
ON Orders.OrderID = [Order Details].OrderID 
WHERE OrderDate = '1996-07-04'
SELECT * FROM  Orders 
WHERE OrderDate = '1996-07-04'
SELECT SUM(UnitPrice*Quantity) as Price
FROM [Order Details] INNER JOIN Orders 
ON Orders.OrderID = [Order Details].OrderID 
WHERE OrderDate = '1996-07-04'

13
SELECT * FROM Shippers 
INSERT INTO Shippers (CompanyName)
VALUES ('Amazon' )

14
UPDATE Shippers
SET CompanyName = 'Amazon Prime Shipping'
WHERE ShipperID = 4
SELECT * FROM Shippers 

15
DELETE FROM Shippers WHERE CompanyName='Amazon Prime Shipping'
SELECT * FROM Shippers 