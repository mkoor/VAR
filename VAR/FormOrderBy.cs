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
    public partial class FormOrderBy : Form
    {
        public FormOrderBy()
        {
            InitializeComponent();
            ShowManager();
            ShowAutoparts();
            ShowClient();
        }

        void ShowManager()
        {
            comboBoxManager.Items.Clear();
            foreach (Users users in Program.varr.Users)
            {
                string[] item = { users.Id.ToString()+". ", users.Login };
                comboBoxManager.Items.Add(string.Join(" ", item));
            }
        }

        void ShowAutoparts()
        {
            comboBoxAutoparts.Items.Clear();
            foreach (AutopartsSet autopartsSet in Program.varr.AutopartsSet)
            {
                string[] item = { autopartsSet.Id.ToString() + ". ", autopartsSet.NameAutopart };
                comboBoxAutoparts.Items.Add(string.Join(" ", item));
            }
        }

        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.varr.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString()+". ", clientsSet.LastName+" ",
                clientsSet.FirstName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersSet ordersSet = new OrdersSet();

                if (comboBoxAutoparts.Text == " " || comboBoxClient.Text == " " || comboBoxManager.Text == " ")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    ordersSet.IdAutopart = Convert.ToInt32(comboBoxAutoparts.SelectedItem.ToString().Split('.')[0]);
                    ordersSet.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                    ordersSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                }

                Program.varr.OrdersSet.Add(ordersSet);
                Program.varr.SaveChanges();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            MessageBox.Show("Заказ успешно оформлен!", "Заказ оформлен",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void labelManager_Click(object sender, EventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {

        }
    }
}
