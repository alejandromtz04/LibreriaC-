USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spClientUpdate]    Script Date: 2/10/2024 14:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spClientUpdate]
(
    @Id INT,
    @ClientName VARCHAR(100),
    @ClientLastName VARCHAR(100),
    @ClientAge INT,
    @ClientEmail VARCHAR(100),
    @ClientPhone VARCHAR(50),
    @ClientAddress VARCHAR(100)
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY

        UPDATE Client
        SET ClientName = @ClientName,
            ClientLastName = @ClientLastName,
            ClientAge = @ClientAge
        WHERE Id = @Id AND State = 1;


        UPDATE ClientContact
        SET ClientEmail = @ClientEmail,
            ClientPhone = @ClientPhone,
            ClientAddress = @ClientAddress
        WHERE Id = @Id AND State = 1;

        COMMIT TRANSACTION;
        RETURN 1;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN 0;
    END CATCH
END;
