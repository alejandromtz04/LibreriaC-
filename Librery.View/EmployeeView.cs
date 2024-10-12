using Libreria.BussinessLogic;
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
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start start = new start();
            start.Show();
            this.Hide();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            GetListEmployees();
        }

        private void GetListEmployees()
        {
            try
            {
                var employee = EmployeeBL.Instance.GetAllEmployees();
                dataGridView1.DataSource = employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Empleados: " + ex.Message);
            }
        }
    }
}
