USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spProductDelete]    Script Date: 2/10/2024 14:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spProductDelete]
(
    @Id INT
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Product
        SET State = 0
        WHERE Id = @Id AND State = 1;

        UPDATE ProductCategory
        SET State = 0
        WHERE Id = @Id;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error encontrado: ' + ERROR_MESSAGE();
    END CATCH;
END
