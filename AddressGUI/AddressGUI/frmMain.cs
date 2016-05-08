// Written by Jacob Misirian
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressGUI
{
    public partial class frmMain : Form
    {
        public const string CONTACTS_PATH = "contacts.txt";
        public frmMain()
        {
            InitializeComponent();
        }

        private Contacts contacts = new Contacts();
        private void frmMain_Load(object sender, EventArgs e)
        {
            contacts.ReadFromFile(CONTACTS_PATH);

            foreach (string lastName in contacts.GetAllLastNames())
                cbContacts.Items.Add(lastName);
        }

        private void cbContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lastName = (string)cbContacts.Items[cbContacts.SelectedIndex];
            Contact contact = contacts.GetContactFromLastName(lastName);

            StringBuilder contactInfo = new StringBuilder();
            contactInfo.AppendLine("FirstName: " + contact.FirstName);
            contactInfo.AppendLine("LastName: " + contact.LastName);
            contactInfo.AppendLine("Address: " + contact.Address);
            contactInfo.AppendLine("City: " + contact.City);
            contactInfo.AppendLine("State: " + contact.State);
            contactInfo.AppendLine("ZipCode: " + contact.ZipCode);
            contactInfo.AppendLine("Phone: " + contact.PhoneNumber);
            contactInfo.AppendLine("Email: " + contact.Email);

            rtbInfo.Text = contactInfo.ToString();
        }
    }
}
