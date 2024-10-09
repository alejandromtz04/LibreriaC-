USE [LibreriaDB]
GO
/****** Object:  StoredProcedure [dbo].[spEmployeeGetAll]    Script Date: 2/10/2024 14:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spEmployeeGetAll]
AS
BEGIN
	SELECT 
		employee.Id, employee.EmployeeName, employee.EmployeeLastName, employee.EmployeeAge,
		employeeContact.EmployeeEmail, employeeContact.EmployeePhone, employeeContact.EmployeeAddress
	FROM 
		Employee employee
	INNER JOIN
		EmployeeContact employeeContact ON employee.Id = employeeContact.Id
	WHERE 
		employee.State = 1 AND employeeContact.State = 1;
END