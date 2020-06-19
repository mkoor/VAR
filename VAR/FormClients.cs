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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ShowClients();
        }

        void ShowClients()
        {
            listViewClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.varr.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.Id.ToString(), clientsSet.LastName+" "+clientsSet.FirstName, clientsSet.Phone,
                });
                item.Tag = clientsSet;
                listViewClients.Items.Add(item);
            }
            listViewClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClientsSet clientsSet = new ClientsSet();

                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" ||
                       textBoxTelephone.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    clientsSet.LastName = textBoxLastName.Text;
                    clientsSet.FirstName = textBoxFirstName.Text;
                    clientsSet.Phone = textBoxTelephone.Text;
                }

                Program.varr.ClientsSet.Add(clientsSet);
                Program.varr.SaveChanges();
                ShowClients();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
               ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;

                textBoxFirstName.Text = clientsSet.FirstName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxTelephone.Text = clientsSet.Phone;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxTelephone.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClients.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;

                    if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" ||
                        textBoxTelephone.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        clientsSet.LastName = textBoxLastName.Text;
                        clientsSet.FirstName = textBoxFirstName.Text;
                        clientsSet.Phone = textBoxTelephone.Text;
                    }

                    Program.varr.SaveChanges();
                    ShowClients();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClients.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;

                    Program.varr.ClientsSet.Remove(clientsSet);
                    Program.varr.SaveChanges();
                    ShowClients();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxTelephone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

