USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spClientDelete]    Script Date: 2/10/2024 14:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spClientDelete]
(
    @Id INT
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Client
        SET State = 0
        WHERE Id = @Id AND State = 1;

        UPDATE ClientContact
        SET State = 0
        WHERE Id = @Id AND State = 1;

        COMMIT TRANSACTION;
        RETURN 1;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN 0;
    END CATCH
END;