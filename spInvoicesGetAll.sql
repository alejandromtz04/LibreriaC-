USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllInvoices]    Script Date: 2/10/2024 14:48:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spGetAllInvoices]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        i.Id AS InvoiceId,
        i.BranchAddress,
        i.InvoiceDescription,
        i.Quantity,
        i.TotalAmount,
        i.InvoiceDate,
        e.EmployeeName,
        e.EmployeeLastName,
        c.ClientName,
        c.ClientLastName,
        p.ProductName,
        p.ProductCode,
        p.ProductPrice,
        i.GuestName
    FROM 
        Invoice i
    LEFT JOIN 
        Employee e ON i.EmployeeId = e.Id
    LEFT JOIN 
        Client c ON i.ClientId = c.Id
    LEFT JOIN 
        Product p ON i.ProductId = p.Id;
END;
