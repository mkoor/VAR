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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            ShowManager();
            ShowLogin();
        }

        void ShowManager()
        {
            listViewManager.Items.Clear();
            foreach (ManagerSet managerSet in Program.varr.ManagerSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    managerSet.Id.ToString(), managerSet.LastName+" "+managerSet.FirstName, managerSet.Telephone,
                    managerSet.Email, managerSet.Users.Id.ToString()+". "+managerSet.Users.Login,
                    managerSet.Type
                });
                item.Tag = managerSet;
                listViewManager.Items.Add(item);
            }
            listViewManager.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void ShowLogin()
        {
            comboBoxLogin.Items.Clear();
            foreach (Users users in Program.varr.Users)
            {
                string[] item = { users.Id.ToString()+". ", users.Login };
                comboBoxLogin.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerSet managerSet = new ManagerSet();

                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" ||
                       textBoxTelephone.Text == "" || comboBoxLogin.Text == "" || 
                       textBoxType.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    managerSet.LastName = textBoxLastName.Text;
                    managerSet.FirstName = textBoxFirstName.Text;
                    managerSet.Telephone = textBoxTelephone.Text;
                    managerSet.IdUser = Convert.ToInt32(comboBoxLogin.SelectedItem.ToString().Split('.')[0]);
                    managerSet.Type = textBoxType.Text;
                }

                if (textBoxEmail.Text != null)
                    managerSet.Email = textBoxEmail.Text;
                else managerSet.Email = "";

                Program.varr.ManagerSet.Add(managerSet);
                Program.varr.SaveChanges();
                ShowManager();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;

                textBoxFirstName.Text = managerSet.FirstName;
                textBoxLastName.Text = managerSet.LastName;
                textBoxTelephone.Text = managerSet.Telephone;
                textBoxEmail.Text = managerSet.Email;
                comboBoxLogin.Text = managerSet.IdUser.ToString() + ". " + managerSet.Users.Login;
                textBoxType.Text = managerSet.Type;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxTelephone.Text = "";
                textBoxEmail.Text = "";
                comboBoxLogin.Text = null;
                textBoxType.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewManager.SelectedItems.Count == 1)
                {
                    ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;

                    if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" ||
                           textBoxTelephone.Text == "" || comboBoxLogin.Text == "" ||
                           textBoxType.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        managerSet.LastName = textBoxLastName.Text;
                        managerSet.FirstName = textBoxFirstName.Text;
                        managerSet.Telephone = textBoxTelephone.Text;
                        managerSet.IdUser = Convert.ToInt32(comboBoxLogin.SelectedItem.ToString().Split('.')[0]);
                        managerSet.Type = textBoxType.Text;
                    }

                    if (textBoxEmail.Text != null)
                        managerSet.Email = textBoxEmail.Text;
                    else managerSet.Email = "";

                    Program.varr.SaveChanges();
                    ShowManager();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewManager.SelectedItems.Count == 1)
                {
                    ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;

                    Program.varr.ManagerSet.Remove(managerSet);
                    Program.varr.SaveChanges();
                    ShowManager();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxTelephone.Text = "";
                textBoxEmail.Text = "";
                comboBoxLogin.Text = null;
                textBoxType.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
