-- Crear la base de datos
CREATE DATABASE LibreriaDB;
GO

-- Usar la base de datos
USE LibreriaDB;
GO

-- Tabla Employee
CREATE TABLE Employee (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName VARCHAR(100),
    EmployeeLastName VARCHAR(100),
    EmployeeAge INT,
    State BIT
);
GO

-- Tabla EmployeeContact
CREATE TABLE EmployeeContact (
    Id INT PRIMARY KEY,
    EmployeeEmail VARCHAR(100) UNIQUE,
    EmployeePhone VARCHAR(50),
    EmployeeAddress VARCHAR(100),
    State BIT,
    FOREIGN KEY (Id) REFERENCES Employee(Id)
);
GO

-- Tabla Client
CREATE TABLE Client (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ClientName VARCHAR(100),
    ClientLastName VARCHAR(100),
    ClientEmail VARCHAR(100),
    ClientPhone VARCHAR(50),
    ClientAddress VARCHAR(100),
    State BIT
);
GO

-- Tabla ProductCategory
CREATE TABLE ProductCategory (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductCategoryName VARCHAR(100) UNIQUE,
    ProductStock INT,
    State BIT
);
GO

-- Tabla Product
CREATE TABLE Product (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100),
    ProductCode VARCHAR(50) UNIQUE,
    ProductDescription VARCHAR(255),
    ProductPrice DECIMAL(18, 2),
    ProductCategoryId INT,
    State BIT,
    FOREIGN KEY (ProductCategoryId) REFERENCES ProductCategory(Id)
);
GO

-- Tabla Invoice
CREATE TABLE Invoice (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    BranchAddress VARCHAR(255),
    InvoiceDescription VARCHAR(255),
    Quantity INT,
    TotalAmount DECIMAL(18, 2),
    InvoiceDate DATETIME,
    EmployeeId INT,
    ClientId INT,
    ProductId INT,
    GuestName VARCHAR(255),
    FOREIGN KEY (EmployeeId) REFERENCES Employee(Id),
    FOREIGN KEY (ClientId) REFERENCES Client(Id),
    FOREIGN KEY (ProductId) REFERENCES Product(Id)
);
GO
