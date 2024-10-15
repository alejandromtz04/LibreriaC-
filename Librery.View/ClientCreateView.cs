using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.Entity;
using Libreria.BussinessLogic;

namespace Librery.view
{
    public partial class ClientCreateView : Form
    {
        public ClientCreateView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClientCreateView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //create button
        {
            if (string.IsNullOrEmpty(txtClientName.Text) ||
                string.IsNullOrEmpty(txtClientLastName.Text) ||
                string.IsNullOrWhiteSpace(txtClientLastName.Text) ||
                string.IsNullOrWhiteSpace(txtClientAge.Text) ||
                string.IsNullOrWhiteSpace(txtClientEmail.Text))
            {
                MessageBox.Show("Complete los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client client = new Client
            {
                ClientName = txtClientName.Text,
                ClientLastName = txtClientLastName.Text,
                ClientAge = int.Parse(txtClientAge.Text),
                State = true
            };

            ClientContact clientContact = new ClientContact
            {
                ClientEmail = txtClientEmail.Text,
                ClientPhone = txtClientPhone.Text,
                ClientAddress = txtClientAddress.Text,
                State = true
            };

            var result = ClientBL.Instance.CreateClient(client, clientContact);

            if (result != null)
            {
                MessageBox.Show("Cliente creado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearFields()
        {
            txtClientName.Clear();
            txtClientLastName.Clear();
            txtClientAge.Clear();
            txtClientPhone.Clear();
            txtClientEmail.Clear();
            txtClientAddress.Clear();
        }

        private void button1_Click(object sender, EventArgs e) // return to view button
        {
            ClientView clientView = new ClientView();
            clientView.Show();
            this.Hide();
        }
    }
}
