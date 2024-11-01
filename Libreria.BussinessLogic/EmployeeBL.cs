using Libreria.DataAccess;
using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.BussinessLogic
{
    public class EmployeeBL
    {
        private static EmployeeBL _instance;

        public static EmployeeBL Instance
        {
            get
            {
                return _instance ?? (_instance = new EmployeeBL());
            }
        }

        public bool CreateEmployee(Employee employee, EmployeeContact employeeContact)
        {
            bool Result = false;
            try
            {
                Result = EmployeeDAL.Instance.CreateEmployee(employee, employeeContact);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear empleado: " + ex.Message);
            }
            return Result;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> Result = null;
            try
            {
                Result = EmployeeDAL.Instance.GetAllEmployees();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Empleados: " + ex.Message);
            }
            return Result;
        }

        public bool UpdateEmployee(Employee employee)
        {
            bool result = false;
            try
            {
                result = EmployeeDAL.Instance.UpdateEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Empleado: " + ex.Message);
            }
            return result;
        }


        public bool DeleteEmployee(int Id)
        {
            bool result = false;
            try
            {
                result = EmployeeDAL.Instance.DeleteEmployee(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Empleado: " + ex.Message);
            }
            return result;
        }
    }
}
