USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spEmployeeUpdate]    Script Date: 2/10/2024 14:47:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spEmployeeUpdate]
(
    @Id INT,
    @EmployeeName VARCHAR(100),
    @EmployeeLastName VARCHAR(100),
    @EmployeeAge INT,
    @State BIT,
    @EmployeeEmail VARCHAR(100),
    @EmployeePhone VARCHAR(50),
    @EmployeeAddress VARCHAR(100)
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY

        DECLARE @ExistingEmployeeId INT;

        SELECT @ExistingEmployeeId = Id
        FROM Employee
        WHERE Id = @Id;

        IF @ExistingEmployeeId IS NOT NULL
        BEGIN

            IF NOT EXISTS (SELECT 1 FROM EmployeeContact 
                           WHERE EmployeeEmail = @EmployeeEmail AND Id <> @ExistingEmployeeId)
            BEGIN

                UPDATE Employee
                SET EmployeeName = @EmployeeName,
                    EmployeeLastName = @EmployeeLastName,
                    EmployeeAge = @EmployeeAge,
                    State = @State
                WHERE Id = @ExistingEmployeeId;

                UPDATE EmployeeContact
                SET EmployeeEmail = @EmployeeEmail,
                    EmployeePhone = @EmployeePhone,
                    EmployeeAddress = @EmployeeAddress,
                    State = @State
                WHERE Id = @ExistingEmployeeId;
            END
            ELSE
            BEGIN
                PRINT 'El correo electrónico ya está en uso por otro empleado.';
            END
        END
        ELSE
        BEGIN
            PRINT 'El empleado no existe.';
        END

        COMMIT TRANSACTION;
        RETURN 1;
    END TRY

    BEGIN CATCH
        PRINT 'Error encontrado: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
        RETURN 0;
    END CATCH
END
