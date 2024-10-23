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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            start start = new start();
            start.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            Usuario user = new Usuario
            {
                UserName = userName,
                Password = password
            };

            bool isAuthenticated = UsuarioBL.Instance.LoginUser(user);

            if (isAuthenticated)
            {
                MessageBox.Show("Login exitoso. Bienvenido!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                start start = new start();
                start.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
