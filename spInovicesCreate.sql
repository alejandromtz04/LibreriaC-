USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spInvoiceCreate]    Script Date: 2/10/2024 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spInvoiceCreate]
    @BranchAddress VARCHAR(255),
    @InvoiceDescription VARCHAR(255),
    @Quantity INT,
    @TotalAmount DECIMAL(18, 2),
    @InvoiceDate DATETIME,
    @EmployeeId INT,
    @ClientId INT = NULL,
    @ProductId INT,
    @GuestName VARCHAR(255) = NULL
AS
BEGIN 
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Employee WHERE Id = @EmployeeId)
    BEGIN
        RAISERROR('El empleado no existe.', 16, 1);
        RETURN;
    END

    IF @ClientId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM Client WHERE Id = @ClientId)
    BEGIN
        RAISERROR('El cliente no existe.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Product WHERE Id = @ProductId)
    BEGIN
        RAISERROR('El producto no existe.', 16, 1);
        RETURN;
    END

    DECLARE @ProductCategoryId INT;
    SELECT @ProductCategoryId = ProductCategoryId FROM Product WHERE Id = @ProductId;

    DECLARE @ProductStock INT;
    SELECT @ProductStock = ProductStock FROM ProductCategory WHERE Id = @ProductCategoryId;

    IF @ProductStock < @Quantity
    BEGIN
        RAISERROR('Stock insuficiente para el producto.', 16, 1);
        RETURN;
    END

    INSERT INTO Invoice (BranchAddress, InvoiceDescription, Quantity, TotalAmount, InvoiceDate, EmployeeId, ClientId, ProductId, GuestName)
    VALUES (@BranchAddress, @InvoiceDescription, @Quantity, @TotalAmount, @InvoiceDate, @EmployeeId, @ClientId, @ProductId, @GuestName);
END;
