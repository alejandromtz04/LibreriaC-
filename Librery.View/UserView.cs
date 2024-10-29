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
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
            GetListUsers();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start start = new start();
            start.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCreateView userCreateView = new UserCreateView();
            userCreateView.Show();
            this.Hide();
        }

        private void UserView_Load(object sender, EventArgs e)
        {

        }

        public void GetListUsers()
        {
            try
            {
                var users = UsuarioBL.Instance.GetAllUsers();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Id", "Numero");
                dataGridView1.Columns.Add("UserName", "Nombre de usario");

                foreach (var user in users)
                {
                    dataGridView1.Rows.Add(
                            user.Id,
                            user.UserName
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer la lista de usuarios: " + ex.Message);

            }
        }
    }
}
