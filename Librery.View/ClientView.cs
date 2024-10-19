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
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start start = new start();
            start.Show();
            this.Close();
        }

        private void ClientView_Load(object sender, EventArgs e)
        {
            btnModifyClient.Enabled = false;
            GetListClients();
        }


        // GET CLIENTS LIST
        public void GetListClients()
        {
            try
            {
                var clients = ClientBL.Instance.GetAllClients();
                //dataGridView1.DataSource = clients;

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("ClientName", "ClientName");
                dataGridView1.Columns.Add("ClientlastName", "ClientLastName");
                dataGridView1.Columns.Add("ClientAge", "ClientAge");

                dataGridView1.Columns.Add("ClientEmail", "ClientEmail");
                dataGridView1.Columns.Add("ClientPhone", "ClientPhone");
                dataGridView1.Columns.Add("ClientAddress", "ClientAddress");

                foreach (var client in clients)
                {
                    dataGridView1.Rows.Add(
                            client.Id,
                            client.ClientName,
                            client.ClientLastName,
                            client.ClientAge,
                            client.ClientContact?.ClientEmail ?? "",
                            client.ClientContact?.ClientPhone ?? "",
                            client.ClientContact?.ClientAddress ?? ""
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer la lista de clientes: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)  // Create
        {
            ClientCreateView clientCreateView = new ClientCreateView();
            clientCreateView.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)  // Modify
        {
            //ClientModifyView clientModifyView = new ClientModifyView();
            //clientModifyView.Show();
            //this.Hide();
        }

        // SELECT A REGISTER TO BE MODIFIED
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var selectClient = (Client)dataGridView1.SelectedRows[0].DataBoundItem;

                var selectClientContact = new ClientContact
                {
                    ClientEmail = dataGridView1.SelectedRows[0].Cells["ClientEmail"].Value.ToString(),
                    ClientPhone = dataGridView1.SelectedRows[0].Cells["ClientPhone"].Value.ToString(),
                    ClientAddress = dataGridView1.SelectedRows[0].Cells["ClientAddress"].Value.ToString()

                };

                ClientModifyView clientModifyView = new ClientModifyView(selectClient, selectClientContact);
                this.Hide();
                clientModifyView.ShowDialog();

                GetListClients();

            }
        }
    }
}
