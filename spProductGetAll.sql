USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spProductGetAll]    Script Date: 2/10/2024 14:52:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spProductGetAll]
AS
BEGIN
    SELECT 
        p.Id,
        p.ProductName,
        p.ProductCode,
        p.ProductDescription,
        p.ProductPrice,

        pc.Id,
        pc.ProductCategoryName,
        pc.ProductStock
    FROM 
        Product p
    INNER JOIN 
        ProductCategory pc ON p.ProductCategoryId = pc.Id
    WHERE 
        p.State = 1
    AND 
        pc.State = 1
END;