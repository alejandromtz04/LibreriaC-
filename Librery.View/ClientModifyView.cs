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
        private int clientId;
        public ClientModifyView(int id, string name, string lastName, int age, string email, string phone, string address)
        {
            InitializeComponent();

            clientId = id;
            txtUpdateClientName.Text = name;
            txtUpdateClientLastName.Text = lastName;
            txtUpdateClientAge.Text = age.ToString();
            txtUpdateClientEmail.Text = email;
            txtUpdateClientPhone.Text = phone;
            txtUpdateClientAddress.Text = address;
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
           if (string.IsNullOrWhiteSpace(txtUpdateClientName.Text) || 
                string.IsNullOrWhiteSpace(txtUpdateClientLastName.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateClientAge.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateClientEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateClientPhone.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateClientAddress.Text))
            {
                MessageBox.Show("Por favor ingrese los datos faltantes del cliente.");
                return;
            }

            var updateClient = new Client
            {
                Id = clientId,
                ClientName = txtUpdateClientName.Text,
                ClientLastName = txtUpdateClientLastName.Text,
                ClientAge = int.Parse(txtUpdateClientAge.Text),
                ClientContact = new ClientContact
                {
                    ClientEmail = txtUpdateClientEmail.Text,
                    ClientPhone = txtUpdateClientPhone.Text,
                    ClientAddress = txtUpdateClientAddress.Text,
                }
            };

            ClientBL.Instance.UpdateClient(updateClient);
            
            ClientView clientView = new ClientView();
            clientView.Show();
            this.Hide();
        }
    }
}
