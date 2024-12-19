CREATE DATABASE task4;
go
USE task4;

CREATE TABLE Sales (
    sale_id INT PRIMARY KEY,
    product_id INT,
    quantity_sold INT,
    sale_date DATE,
    total_price DECIMAL(10, 2)
);

INSERT INTO Sales (sale_id, product_id, quantity_sold, sale_date, total_price) VALUES
(1, 101, 5, '2024-01-01', 2500.00),
(2, 102, 3, '2024-01-02', 900.00),
(3, 103, 2, '2024-01-02', 60.00),
(4, 104, 4, '2024-01-03', 80.00),
(5, 105, 6, '2024-01-03', 90.00);

CREATE TABLE Products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    category VARCHAR(50),
    unit_price DECIMAL(10, 2)
);

INSERT INTO Products (product_id, product_name, category, unit_price) VALUES
(101, 'Laptop', 'PC', 500.00),
(102, 'Smartphone', 'Electronics', 300.00),
(103, 'Headphones', 'Electronics', 30.00),
(104, 'Keyboard', 'PC', 20.00),
(105, 'Mouse', 'PC', 15.00);

---------------1--------------
SELECT * FROM Sales;

---------------2--------------
SELECT product_name,unit_price FROM Products;

---------------3--------------
SELECT sale_id,sale_date FROM sales;

---------------4--------------
SELECT * FROM Sales
WHERE total_price > 100;

---------------5--------------
SELECT * FROM products
WHERE category = 'Electronics';

---------------6--------------
SELECT sale_id,total_price FROM Sales
WHERE sale_date='2024-01-03';

---------------7--------------
SELECT product_id,product_name FROM Products
WHERE unit_price > 100;

---------------8--------------
SELECT SUM(total_price) FROM Sales;

---------------9--------------
SELECT sale_id,product_id,total_price FROM Sales
WHERE quantity_sold > 4;

---------------10--------------
SELECT SUM(total_price) FROM Sales s,Products p
WHERE P.category='Electronics' AND P.product_id=S.product_id;

---------------10(another way)--------------
SELECT SUM(total_price) FROM Sales s join Products p
on P.product_id=S.product_id 
WHERE P.category='Electronics';

---------------11--------------
SELECT SUM(quantity_sold) FROM Sales s,Products p
WHERE P.category='Electronics' AND P.product_id=S.product_id;

---------------11(another way)--------------
SELECT SUM(quantity_sold) FROM Sales s join Products p
on P.product_id=S.product_id 
WHERE P.category='Electronics';
