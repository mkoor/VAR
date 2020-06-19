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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            ShowStaff();
            ShowDepartments();
        }

        void ShowStaff()
        {
            listViewStaff.Items.Clear();
            foreach (StaffSet staffSet in Program.varr.StaffSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    staffSet.Id.ToString(), staffSet.LastName+" "+staffSet.FirstName, staffSet.Telephone,
                    staffSet.Email, staffSet.DepartmentsSet.Id.ToString()+". "+staffSet.DepartmentsSet.NameDepartment
                });
                item.Tag = staffSet;
                listViewStaff.Items.Add(item);
            }
            listViewStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void ShowDepartments()
        {
            comboBoxDepartments.Items.Clear();
            foreach (DepartmentsSet departmentsSet in Program.varr.DepartmentsSet)
            {
                string[] item = {departmentsSet.Id.ToString()+". ", departmentsSet.NameDepartment};
                comboBoxDepartments.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StaffSet staffSet = new StaffSet();

                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" ||
                       textBoxTelephone.Text == "" || comboBoxDepartments.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    staffSet.LastName = textBoxLastName.Text;
                    staffSet.FirstName = textBoxFirstName.Text;
                    staffSet.Telephone = textBoxTelephone.Text;
                    staffSet.IdDepartment = Convert.ToInt32(comboBoxDepartments.SelectedItem.ToString().Split('.')[0]);
                }

                if (textBoxEmail.Text != null)
                    staffSet.Email = textBoxEmail.Text;
                else staffSet.Email = "";

                Program.varr.StaffSet.Add(staffSet);
                Program.varr.SaveChanges();
                ShowStaff();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedItems.Count == 1)
            {
                StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;

                textBoxFirstName.Text = staffSet.FirstName;
                textBoxLastName.Text = staffSet.LastName;
                textBoxTelephone.Text = staffSet.Telephone;
                textBoxEmail.Text = staffSet.Email;
                comboBoxDepartments.Text = staffSet.IdDepartment.ToString() + ". " + staffSet.DepartmentsSet.NameDepartment;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxTelephone.Text = "";
                textBoxEmail.Text = "";
                comboBoxDepartments.Text = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStaff.SelectedItems.Count == 1)
                {
                    StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;

                    if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" ||
                      textBoxTelephone.Text == "" || comboBoxDepartments.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        staffSet.LastName = textBoxLastName.Text;
                        staffSet.FirstName = textBoxFirstName.Text;
                        staffSet.Telephone = textBoxTelephone.Text;
                        staffSet.IdDepartment = Convert.ToInt32(comboBoxDepartments.SelectedItem.ToString().Split('.')[0]);
                    }

                    if (textBoxEmail.Text != null)
                        staffSet.Email = textBoxEmail.Text;
                    else staffSet.Email = "";

                    Program.varr.SaveChanges();
                    ShowStaff();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStaff.SelectedItems.Count == 1)
                {
                    StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;

                    Program.varr.StaffSet.Remove(staffSet);
                    Program.varr.SaveChanges();
                    ShowStaff();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxTelephone.Text = "";
                textBoxEmail.Text = "";
                comboBoxDepartments.Text = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
