CREATE DATABASE BookShop;
go 
USE BookShop;
go

CREATE TABLE Books
(
	BookID INT PRIMARY KEY,
	Title VARCHAR(255)NOT NULL,
	Author VARCHAR(255) NOT NULL,
	PuplishedYear INT NOT NULL,
	Price FLOAT NOT NULL
)
go

INSERT INTO Books (BookID, Title, Author, PuplishedYear, Price)
VALUES(1, 'To Kill a Mockingbird', 'Harper Lee', 1960, 10.99),
	  (2, '1984', 'George Orwell', 1949, 9.99),
	  (3, 'Pride and Prejudice', 'Jane Austen', 1813, 8.99),
	  (4, 'The Great Gatsby', 'F. Scott Fitzgerald', 1925, 12.99),
      (5, 'Moby Dick', 'Herman Melville', 1851, 11.99);
go

UPDATE Books
SET Price = 15.50
where BookId = 3;
go

DELETE FROM Books WHERE BookID = 2;
go

SELECT * FROM Books
ORDER BY PuplishedYear;
go

SELECT * FROM Books
WHERE PuplishedYear<2000
go
