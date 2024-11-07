﻿using Libreria.BussinessLogic;
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
            //inicializamos todo
            InitializeComponent();
        }

        // definimos dentro de este metodo que sera usado para volver a la pantalla de inicio
        private void button1_Click(object sender, EventArgs e)
        {
            start start = new start();
            start.Show();
            this.Close();
        }

        // carga la vista de cliente y establece los botonos de modificar y eliminar en falso
        private void ClientView_Load(object sender, EventArgs e)
        {
            btnModifyClient.Enabled = false;
            btnDelete.Enabled = false;
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

                dataGridView1.Columns.Add("Id", "Numero");
                dataGridView1.Columns.Add("ClientName", "Nombre");
                dataGridView1.Columns.Add("ClientlastName", "Apellido");
                dataGridView1.Columns.Add("ClientAge", "Edad");

                dataGridView1.Columns.Add("ClientEmail", "Email");
                dataGridView1.Columns.Add("ClientPhone", "Telefono");
                dataGridView1.Columns.Add("ClientAddress", "Direccion");

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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                int clientId = (int)selectedRow.Cells["Id"].Value;
                string clientName = (string)selectedRow.Cells["ClientName"].Value;
                string clientLastName = (string)selectedRow.Cells["ClientLastName"].Value;
                int clientAge = (int)selectedRow.Cells["ClientAge"].Value;
                string clientEmail = (string)selectedRow.Cells["ClientEmail"].Value;
                string clientPhone = (string)selectedRow.Cells["ClientPhone"].Value;
                string clientAddress = (string)selectedRow.Cells["ClientAddress"].Value;


                // recibe como parametros los datos anteriores para que carguen en la lista de cliente
                ClientModifyView clientModifyView = new ClientModifyView(clientId, clientName, clientLastName, clientAge, clientEmail, clientPhone, clientAddress);
                

                if (clientModifyView.ShowDialog() == DialogResult.OK)
                {
                    GetListClients();
                }
            }
            this.Hide();
        }

        // SELECT A REGISTER TO BE MODIFIED

        // si hay un registro seleccionado entonces activa los botones de modificar y eliminar
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnModifyClient.Enabled = true;
                btnDelete.Enabled = true;
            } else
            {
                btnModifyClient.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // similar a modificar este solo selecciona el id y posteriormente envia los datos para poder ser eliminados
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedClientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                bool isDeleted = false;

                try
                {
                    isDeleted = ClientBL.Instance.DeleteClient(selectedClientId);
                }
                 catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el cliente: " + ex.Message);

                }
                if (isDeleted)
                {
                    MessageBox.Show("Cliente eliminado con éxito.");
                    GetListClients();
                } else
                {
                    MessageBox.Show("No se pudo eliminar el cliente.");
                }

            }
        }
    }
}
