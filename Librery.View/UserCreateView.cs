using Libreria.BussinessLogic;
using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librery.view
{
    public partial class UserCreateView : Form
    {
        public UserCreateView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserView userView = new UserView();
            userView.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Add
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            Usuario newUser = new Usuario
            {
                UserName = username,
                Password = password
            };

            bool result = UsuarioBL.Instance.CreateUser(newUser);

            if (result != null)
            {
                MessageBox.Show("Usuario creado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error al crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        
    }
}
