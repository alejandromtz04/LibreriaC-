USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spEmployeeCreate]    Script Date: 2/10/2024 14:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spEmployeeCreate]
(
    @EmployeeName VARCHAR (100),
    @EmployeeLastName VARCHAR (100),
    @EmployeeAge INT,
    @State BIT,
    @EmployeeEmail VARCHAR (100),
    @EmployeePhone VARCHAR (50),
    @EmployeeAddress VARCHAR (100)
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY

        IF NOT EXISTS (SELECT 1 FROM EmployeeContact WHERE EmployeeEmail = @EmployeeEmail)
        BEGIN
            INSERT INTO Employee (EmployeeName, EmployeeLastName, EmployeeAge, State)
            VALUES (@EmployeeName, @EmployeeLastName, @EmployeeAge, @State);

            DECLARE @NewEmployeeId INT = SCOPE_IDENTITY();

            IF NOT EXISTS (SELECT 1 FROM EmployeeContact WHERE Id = @NewEmployeeId)
            BEGIN
                INSERT INTO EmployeeContact (Id, EmployeeEmail, EmployeePhone, EmployeeAddress, State)
                VALUES (@NewEmployeeId, @EmployeeEmail, @EmployeePhone, @EmployeeAddress, @State);
            END
        END
        ELSE
        BEGIN
            PRINT 'The employee already exist.';
        END

        COMMIT TRANSACTION;
        RETURN 1;
    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN 0;
    END CATCH
END