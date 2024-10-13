using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.BussinessLogic;
using Libreria.Entity;

namespace Librery.view
{
    public partial class ClientModifyView : Form
    {

        // TO MODIFY
        private Client _client;
        private ClientContact _clientContact;
        public ClientModifyView(Client client, ClientContact clientContact)
        {
            InitializeComponent();
            _client = client;

            LoadClientData();
         }

        public void LoadClientData()
        {
            txtUpdateClientName.Text = _client.ClientName;
            txtUpdateClientLastName.Text = _client.ClientLastName;
            txtUpdateClientAge.Text = _client.ClientAge.ToString();

            txtUpdateClientEmail.Text = _clientContact.ClientEmail;
            txtUpdateClientPhone.Text = _clientContact.ClientPhone;
            txtUpdateClientAddress.Text = _clientContact.ClientAddress;
        }

        private void button1_Click(object sender, EventArgs e) // return
        {
            ClientView clientView = new ClientView();
            clientView.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientModifyView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // SAVE CHANGES
        {
            _client.ClientName = txtUpdateClientName.Text;
            _client.ClientLastName = txtUpdateClientLastName.Text;
            _client.ClientAge = int.Parse(txtUpdateClientAge.Text);

            _clientContact.ClientEmail = txtUpdateClientEmail.Text;
            _clientContact.ClientPhone = txtUpdateClientPhone.Text;
            _clientContact.ClientAddress = txtUpdateClientAddress.Text;

            bool result = ClientBL.Instance.UpdateClient(_client, _clientContact);

            if (result)
            {
                MessageBox.Show("Client actualizado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar cliente.");
            }
            this.Close();
            
        }
    }
}
