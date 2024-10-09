USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spClientCreate]    Script Date: 2/10/2024 14:38:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spClientCreate]
(
    @ClientName VARCHAR(100),
    @ClientLastName VARCHAR(100),
    @ClientAge INT,
    @State BIT,

    @ClientEmail VARCHAR(100),
    @ClientPhone VARCHAR(50),
    @ClientAddress VARCHAR(100)
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Client (ClientName, ClientLastName, ClientAge, State)
        VALUES (@ClientName, @ClientLastName, @ClientAge, @State);

        DECLARE @NewClientId INT = SCOPE_IDENTITY();

        INSERT INTO ClientContact (Id, ClientEmail, ClientPhone, ClientAddress, State)
        VALUES (@NewClientId, @ClientEmail, @ClientPhone, @ClientAddress, @State);

        COMMIT TRANSACTION;
        RETURN 1;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN 0;
    END CATCH
END;