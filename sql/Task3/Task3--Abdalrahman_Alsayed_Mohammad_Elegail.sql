CREATE DATABASE SalesAgency;
go
USE SalesAgency;
go
CREATE TABLE salesmen
(
	Salesman_Id INT PRIMARY KEY,
	Salesman_Name VARCHAR(60) NOT NULL,
	city VARCHAR(50),
	commission DECIMAL(5,2)
);
go
INSERT INTO salesmen (Salesman_Id, Salesman_Name, city, commission) VALUES
(5001, 'James Hoog', 'New York', 0.15),
(5002, 'Nail Knite', 'Paris', 0.13),
(5005, 'Pit Alex', 'London', 0.11),
(5006, 'Mc Lyon', 'Paris', 0.14),
(5007, 'Adam Roma', 'Rome', 0.13),
(5003, 'Lauson Hen', 'San Jose', 0.12);
go
CREATE TABLE customers
(
	Customer_Id INT PRIMARY KEY,
	Customer_Name VARCHAR(60) NOT NULL,
	city VARCHAR(50),
	grade DECIMAL(7,2) NOT NULL,
	Salesman_Id INT FOREIGN KEY REFERENCES Salesmen(Salesman_Id)
);
go
INSERT INTO customers(Customer_Id, Customer_Name, city, grade, Salesman_Id) VALUES
(3002, 'Nick Rimando', 'New York', 100, 5001),
(3007, 'Brad Davis', 'New York', 200, 5001),
(3005, 'Graham Zusi', 'California', 200, 5002),
(3008, 'Julian Green', 'London', 300, 5002),
(3004, 'Fabian Johnson', 'Paris', 300, 5006),
(3009, 'Geoff Cameron', 'Berlin', 100, 5003),
(3003, 'Jozy Altidore', 'Moscow', 200, 5007),
(3001, 'Brad Guzan', 'London', 200, 5005);
go
CREATE TABLE orders 
(
	Order_Number INT PRIMARY KEY,
	Purchase_Amount DECIMAL(7,2) NOT NULL,
	Order_Date DATE NOT NULL,
	Customer_Id INT FOREIGN KEY REFERENCES customers(Customer_Id),
	Salesman_Id INT FOREIGN KEY REFERENCES Salesmen(Salesman_Id)
);
go
INSERT INTO orders (Order_Number, Purchase_Amount, Order_Date, Customer_Id, Salesman_Id) VALUES
(70001, 150.5, '2012-10-05', 3005, 5002),
(70009, 270.65, '2012-09-10', 3001, 5005),
(70002, 65.26, '2012-10-05', 3002, 5001),
(70004, 110.5, '2012-08-17', 3009, 5003),
(70007, 948.5, '2012-09-10', 3004, 5006),
(70005, 2400.6, '2012-07-27', 3007, 5001),
(70008, 5760, '2012-09-27', 3002, 5001),
(70010, 1983.43, '2012-10-10', 3004, 5006),
(70003, 2480.4, '2012-10-10', 3003, 5007),
(70012, 250.45, '2012-06-27', 3008, 5002),
(70011, 75.29, '2012-08-17', 3003, 5007);
go
SELECT s.Salesman_Name salesman , c.Customer_Name customer ,c.city [common city] 
FROM salesmen s JOIN customers c
ON s.city=c.city
ORDER BY c.city;
go
SELECT o.Order_Number  ,o.Purchase_Amount, c.Customer_Name ,c.city 
FROM orders o JOIN customers c
ON o.Customer_Id=c.Customer_Id
WHERE Purchase_Amount BETWEEN 500 AND 2000;