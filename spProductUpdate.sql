USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spProductUpdate]    Script Date: 2/10/2024 14:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spProductUpdate]
(
    @ProductId INT,
    @ProductName VARCHAR(100),
    @ProductCode VARCHAR(50),
    @ProductDescription VARCHAR(255),
    @ProductPrice DECIMAL(18, 2),


    @ProductCategoryId INT,
    @ProductCategoryName VARCHAR(100),
    @ProductStock INT,
    @State BIT
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DECLARE @ExistingCategoryId INT;

        SELECT @ExistingCategoryId = Id 
        FROM ProductCategory 
        WHERE ProductCategoryName = @ProductCategoryName
        AND Id <> @ProductCategoryId;

        IF @ExistingCategoryId IS NULL
        BEGIN

            UPDATE ProductCategory
            SET ProductCategoryName = @ProductCategoryName,
                ProductStock = @ProductStock,
                State = @State
            WHERE Id = @ProductCategoryId;
        END
        ELSE
        BEGIN
            RAISERROR ('Ya existe una categoría con este nombre.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN 0;
        END

        UPDATE Product
        SET ProductName = @ProductName,
            ProductCode = @ProductCode,
            ProductDescription = @ProductDescription,
            ProductPrice = @ProductPrice,
            ProductCategoryId = @ProductCategoryId
        WHERE Id = @ProductId;


        COMMIT TRANSACTION;
        RETURN 1;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN 0;
    END CATCH
END;
