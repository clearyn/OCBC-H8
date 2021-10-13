-- Buat Database
CREATE DATABASE db_bank;

--Tabel customers
CREATE TABLE customers(
	customerNumber INT identity(1,1) primary key,
	customerName VARCHAR(50) NOT NULL,
	contactLastName VARCHAR(20),
	contactFirstName VARCHAR(20),
	addressLine1 VARCHAR(50) NOT NULL,
	addressLine2 VARCHAR(50),
	city VARCHAR(20) NOT NULL,
	state VARCHAR(20) NOT NULL,
	postalCode VARCHAR(8) NOT NULL,
	country VARCHAR(20) NOT NULL,
	salesRepEmployeeNumber INT NOT NULL,
	creditLimit DECIMAL(19,2)
);
INSERT INTO customers (customerName, contactLastName, contactFirstName, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES ('Dhanny Rachmat', NULL, NULL, 'Jl Meikarta 99', NULL, 'Bandung', 'Indonesia', '40177', 'Indonesia', 1, NULL),
('Ferdinand Lanvino', NULL, NULL, 'Jl Sejahtera 29', '/20c', 'Jakarta', 'Indonesia', '40235', 'Indonesia', 2, NULL),
('Andreas Adiputra', NULL, NULL, 'Jl Banda 01C', NULL, 'Surabaya', 'Indonesia', '40123', 'Indonesia', 3, NULL),
('Diki Agustina', NULL, NULL, 'Jl Subang 92', '/60a', 'Tangerang', 'Indonesia', '40152', 'Indonesia', 4, NULL),
('Ajeng Sri Wulan', NULL, NULL, 'Jl Jakarta 4', NULL, 'Bandung', 'Indonesia', '40179', 'Indonesia', 4, NULL);
SELECT * FROM customers;

--Tabel products
CREATE TABLE products(
	productCode INT identity(1,1) primary key,
	productName VARCHAR(30) NOT NULL,
	productLine INT NOT NULL,
	productVendor VARCHAR(30) NOT NULL,
	productDescription VARCHAR(50) NOT NULL,
	quantityinStock INT DEFAULT 1,
	buyPrice DECIMAL(19,2) NOT NULL,
	MSRP DECIMAL(19,2) NOT NULL
);
INSERT INTO products (productName, productLine, productVendor, productDescription, quantityinStock, buyPrice, MSRP)
VALUES ('VARIO', 1, 'Honda', 'Sepeda motor Honda VARIO', 50, 15000000, 14500000),
('NMAX', 1, 'Yamaha', 'Sepeda motor Yamaha NMAX', 50, 22000000, 20000000),
('RUSH', 2, 'Toyota', 'Mobil Toyota RUSH', 20, 200000000, 190000000),
('XENIA', 2, 'Daihatsu', 'Mobil Daihatsu XENIA', 20, 180000000, 170000000),
('Ideapad', 3, 'Lenovo', 'Laptop Lenovo Ideapad', 15, 8000000, 7000000),
('S28', 4, 'Samsung', 'Smartphone Samsung S28', 30, 11000000, 10000000),
('IPad', 5, 'Apple', 'Tablet IPad', 30, 9000000, 8000000);
SELECT * FROM products;

--Tabel productlines
CREATE TABLE productlines(
	productLine INT primary key NOT NULL,
	textDescription VARCHAR(50) NOT NULL,
	htmlDescription VARCHAR(200),
	image VARCHAR(50)
);
INSERT INTO productlines (productLine, textDescription, htmlDescription, image)
VALUES (1, 'Motor', '<p>Ullamcorper velit lectus mus adipiscing.</p>','https://www.CBANK.id/Motor'),
(2, 'Mobil', '<p>Mobil velit lectus mus adipiscing.</p>','https://www.CBANK.id/Mobil'),
(3, 'Laptop', '<p>Laptop velit lectus mus adipiscing.</p>','https://www.CBANK.id/Laptop'),
(4, 'Smartphone', '<p>Smartphone velit lectus mus adipiscing.</p>','https://www.CBANK.id/Smartphone'),
(5, 'Tablet', '<p>Tablet velit lectus mus adipiscing.</p>','https://www.CBANK.id/Tablet');
SELECT * FROM productlines;


--Tabel orders
CREATE TABLE orders(
	orderNumber INT identity(1,1) primary key,
	orderDate DATE DEFAULT GETDATE(),
	requiredDate DATE NOT NULL,
	shippedDate DATE NOT NULL,
	status VARCHAR(20),
	comments VARCHAR(50),
	customerNumber INT NOT NULL
);
INSERT INTO orders (requiredDate, shippedDate, status, comments, customerNumber)
VALUES ('2020-11-01', '2020-11-02', 'Packing', 'Dont late', 1),
('2020-11-23', '2020-11-25', 'Shipping', 'Dont late', 2),
('2020-11-05', '2020-11-12', 'Courier', 'For my birthday', 3),
('2020-11-03', '2020-11-08', 'Waiting Vendor', 'Fragile', 4),
('2020-11-08', '2020-11-10', 'Lost', 'Dont late', 5);
SELECT * FROM orders;

--Tabel orderdetails
CREATE TABLE orderdetails(
	orderNumber INT NOT NULL,
	productCode INT NOT NULL,
	quantityOrdered INT NOT NULL,
	priceEach DECIMAL(19,2) NOT NULL,
	orderLineNumber INT NOT NULL
);
INSERT INTO orderdetails (orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber)
VALUES (1, 1, 1, 14600000, 1),
(2, 7, 4, 8500000, 2),
(3, 6, 1, 11000000, 3),
(4, 6, 2, 11000000, 4),
(5, 3, 1, 190000000, 5);
SELECT * FROM orderdetails;

--Tabel payments
CREATE TABLE payments(
	customerNumber INT NOT NULL,
	checkNumber INT identity(1,1) primary key,
	paymentDate DATE DEFAULT GETDATE(),
	amount DECIMAL(19,2) NOT NULL
);
INSERT INTO payments (customerNumber, amount)
VALUES (1, 14600000),
(2, 34000000),
(3, 11000000),
(4, 22000000),
(5, 190000000);
SELECT * FROM payments;

--Tabel employees
CREATE TABLE employees(
	employeeNumber INT identity(1,1) primary key,
	lastName VARCHAR(20),
	firstName VARCHAR(20) NOT NULL,
	extension VARCHAR(20),
	email VARCHAR(20) NOT NULL,
	officeCode INT NOT NULL,
	reportsTo VARCHAR(20) NOT NULL,
	jobTitle VARCHAR(20) NOT NULL
);
INSERT INTO employees (lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES ('Sanjaya', 'Indra', NULL, 'indra@bank.com', 1, 'Budiman', 'SalesRep'),
('Wijaya', 'Rahmat', NULL, 'rahmat@bank.com', 1, 'Budiman', 'SalesRep'),
('Sanjaya', 'Dani', NULL, 'dani@bank.com', 1, 'Budiman', 'SalesRep'),
('Susanti', 'Susi', NULL, 'susi@bank.com', 1, 'Budiman', 'SalesRep'),
( NULL, 'Willyanti', NULL, 'willyanti@bank.com', 1, 'Wicaksono', 'Officer');
SELECT * FROM employees;

--Tabel offices
CREATE TABLE offices(
	officeCode INT identity(1,1) primary key,
	city VARCHAR(20) NOT NULL,
	phone VARCHAR(20) NOT NULL,
	addressLine1 VARCHAR(50) NOT NULL,
	addressLine2 VARCHAR(50),
	state VARCHAR(20) NOT NULL,
	country VARCHAR(20) NOT NULL,
	postalCode VARCHAR(20) NOT NULL,
	teritory VARCHAR(20)
);
INSERT INTO offices (city, phone, addressLine1, addressLine2, state, country, postalCode, teritory)
VALUES ('Bandung', '08911111', 'Jl Jawa 82', NULL, 'Indonesia', 'Indonesia', '40122', 'Bandung'),
('Bandung', '08911112', 'Jl Banda 22', '/90c', 'Indonesia', 'Indonesia', '40122', NULL),
('Bandung', '08911113', 'Jl Subang 18', NULL, 'Indonesia', 'Indonesia', '40125', 'Bandung');
SELECT * FROM offices;

-- More Improvement

-- Largest Relation
SELECT ctm.customerNumber, ctm.customerName, od.orderNumber, ods.quantityOrdered, pro.productName, pro.productLine, (emp.firstName +' '+ emp.lastName) as SalesRep 
FROM customers ctm 
JOIN orders od ON ctm.customerNumber = od.customerNumber
JOIN orderDetails ods ON od.orderNumber = ods.orderNumber
JOIN products pro ON ods.productCode = pro.productCode
JOIN employees emp ON ctm.salesRepEmployeeNumber = emp.employeeNumber;