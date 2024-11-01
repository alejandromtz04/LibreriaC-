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
            btnModify.Enabled = false;
        }

        private void GetListEmployees()
        {
            try
            {
                var employees = EmployeeBL.Instance.GetAllEmployees();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Id", "Numero");
                dataGridView1.Columns.Add("EmployeeName", "Nombre");
                dataGridView1.Columns.Add("EmployeeLastName", "Apellido");
                dataGridView1.Columns.Add("EmployeeAge", "Edad");
                dataGridView1.Columns.Add("EmployeeEmail", "Email");
                dataGridView1.Columns.Add("EmployeePhone", "telefono");
                dataGridView1.Columns.Add("EmployeeAddress", "Direccion");

                foreach (var employee in employees)
                {
                    dataGridView1.Rows.Add(
                            employee.Id,
                            employee.EmployeeName,
                            employee.EmployeeLastName,
                            employee.EmployeeAge,
                            employee.EmployeeContact?.EmployeeEmail ?? "",
                            employee.EmployeeContact?.EmployeePhone ?? "",
                            employee.EmployeeContact?.EmployeeAddress ?? ""
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Empleados: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeCreateView employeeCreateView = new EmployeeCreateView();
            employeeCreateView.Show();
            this.Hide();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRows = dataGridView1.SelectedRows[0];

                int employeeId = (int)selectedRows.Cells["Id"].Value;
                string employeeName = (string)selectedRows.Cells["EmployeeName"].Value;
                string employeeLastName = (string)selectedRows.Cells["EmployeeLastName"].Value;
                int employeeAge = (int)selectedRows.Cells["EmployeeAge"].Value;
                string employeeEmail = (string)selectedRows.Cells["EmployeeEmail"].Value;
                string employeePhone = (string)selectedRows.Cells["EmployeePhone"].Value;
                string employeeAddress = (string)selectedRows.Cells["EmployeeAddress"].Value;

                EmployeeModifyView employeeModifyView = new EmployeeModifyView(employeeId, employeeName, employeeLastName, employeeAge, employeeEmail, employeePhone, employeeAddress);

                if (employeeModifyView.ShowDialog() == DialogResult.OK)
                {
                    GetListEmployees();
                }
                this.Hide();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnModify.Enabled = true;
            }
            else
            {
                btnModify.Enabled = false;
            }
        }
    }
}
