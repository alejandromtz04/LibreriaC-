using Libreria.DataAccess;
using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.BussinessLogic
{
    public class UsuarioBL
    {
        private static UsuarioBL _instance;

        public static UsuarioBL Instance
        {
            get
            {
                return _instance ?? (_instance = new UsuarioBL());
            }
        }


        public bool CreateUser(Usuario user)
        {
            bool Result = false;
            try
            {
                Result = UsuarioDAL.Instance.CreateUser(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear Usuario: " + ex.Message);
            }
            return Result;
        }



        public bool UpdatePassword(Usuario user)
        {
            bool result = false;
            try
            {
                result = UsuarioDAL.Instance.UpdatePassword(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la contraseña: " + ex.Message);
            }
            return result;
        }
    }
}
