CREATE DATABASE e_commerce;
GO

USE e_commerce;
GO

CREATE TABLE customers
	(
	customer_id INT PRIMARY KEY,
	customer_name VARCHAR(60) NOT NULL,
	customer_email VARCHAR(60) NOT NULL UNIQUE,
	customer_phone VARCHAR(15) UNIQUE
	);

CREATE TABLE orders
	(
	order_id INT PRIMARY KEY,
	customer_id INT NOT NULL
	);

CREATE TABLE orders_details
	(
	order_details_id INT PRIMARY KEY,
	order_id INT NOT NULL ,
	product_id INT NOT NULL,
	quantity INT NOT NULL,
	);

CREATE TABLE products
	(
	product_id INT PRIMARY KEY,
	product_name VARCHAR(60) NOT NULL,
	product_description TEXT 
	);