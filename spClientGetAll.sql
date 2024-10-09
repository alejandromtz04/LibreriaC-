USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spClientGetAll]    Script Date: 2/10/2024 14:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spClientGetAll]
AS
BEGIN
    SELECT 
        client.Id,
        client.ClientName,
        client.ClientLastName,
        client.ClientAge,
        clientContact.ClientEmail,
        clientContact.ClientPhone,
        clientContact.ClientAddress
    FROM Client client
    JOIN ClientContact clientContact ON client.Id = clientContact.Id
    WHERE client.State = 1 AND clientContact.State = 1;
END;