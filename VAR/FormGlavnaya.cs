using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAR
{
    public partial class FormGlavnaya : Form
    {
        public FormGlavnaya()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "manager") { buttonManager.Enabled = false; }
            labelHello.Text = "Здравствуйте, " + FormAuthorization.users.login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGlavnaya_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.Show();
            this.Hide();
        }

        private void buttonAutoparts_Click(object sender, EventArgs e)
        {
            FormAutoparts formAutoparts = new FormAutoparts();
            formAutoparts.Show();
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            FormSuppliers formSuppliers = new FormSuppliers();
            formSuppliers.Show();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            FormManager formManager = new FormManager();
            formManager.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients();
            formClients.Show();
        }

        private void buttonOrderBy_Click(object sender, EventArgs e)
        {
            FormOrderClient formOrderClient = new FormOrderClient();
            formOrderClient.Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
        }
    }
}
