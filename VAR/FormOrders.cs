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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            ShowManager();
            ShowAutoparts();
            ShowClient();
            ShowOrders();
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

        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (OrdersSet ordersSet in Program.varr.OrdersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ordersSet.Id.ToString(),
                    ordersSet.ManagerSet.IdUser.ToString()+". "+
                    ordersSet.ManagerSet.Users.Login,
                    ordersSet.AutopartsSet.Id.ToString()+". "+ordersSet.AutopartsSet.NameAutopart,
                    ordersSet.ClientsSet.Id.ToString()+". "+ordersSet.ClientsSet.LastName+" "+ordersSet.ClientsSet.FirstName
                });
                item.Tag = ordersSet;
                listViewOrders.Items.Add(item);
            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersSet ordersSet = new OrdersSet();

                if (comboBoxAutoparts.SelectedItem == null || comboBoxClient.SelectedItem == null || comboBoxManager.SelectedItem == null)
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
                ShowOrders();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;

                    if (comboBoxAutoparts.SelectedItem == null || comboBoxClient.SelectedItem == null || comboBoxManager.SelectedItem == null)
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        ordersSet.IdAutopart = Convert.ToInt32(comboBoxAutoparts.SelectedItem.ToString().Split('.')[0]);
                        ordersSet.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                        ordersSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    }
                    Program.varr.SaveChanges();
                    ShowOrders();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;

                    Program.varr.OrdersSet.Remove(ordersSet);
                    Program.varr.SaveChanges();
                    ShowOrders();
                }
                comboBoxManager.Text = null;
                comboBoxAutoparts.Text = null;
                comboBoxClient.Text = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;

                comboBoxManager.Text = ordersSet.IdManager.ToString()+". "+ordersSet.ManagerSet.IdUser.ToString()+
                    ". "+ordersSet.ManagerSet.Users.Login;
                comboBoxAutoparts.Text = ordersSet.IdAutopart.ToString() + ". " + ordersSet.AutopartsSet.NameAutopart;
                comboBoxClient.Text = ordersSet.IdClient.ToString() + ". " + ordersSet.ClientsSet.LastName +
                    " " + ordersSet.ClientsSet.FirstName;
            }
            else
            {
                comboBoxManager.SelectedItem = null;
                comboBoxAutoparts.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
            }
        }
    }
}
