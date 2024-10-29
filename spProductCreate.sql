USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spProductCreate]    Script Date: 2/10/2024 14:51:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spProductCreate]
(
    @ProductName VARCHAR(100),
    @ProductCode VARCHAR(50),
    @ProductDescription VARCHAR(255),
    @ProductPrice DECIMAL(18, 2),

    @ProductCategoryName VARCHAR(100),
    @ProductStock INT
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DECLARE @NewCategoryId INT;

        SELECT @NewCategoryId = Id 
        FROM ProductCategory 
        WHERE ProductCategoryName = @ProductCategoryName;

        IF @NewCategoryId IS NULL
        BEGIN
            INSERT INTO ProductCategory (ProductCategoryName, ProductStock)
            VALUES (@ProductCategoryName, @ProductStock);

            SET @NewCategoryId = SCOPE_IDENTITY();
        END

        INSERT INTO Product (ProductName, ProductCode, ProductDescription, ProductPrice , ProductCategoryId)
        VALUES (@ProductName, @ProductCode, @ProductDescription, @ProductPrice, @NewCategoryId);

        COMMIT TRANSACTION;
        RETURN 1;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN 0
    END CATCH
END;
