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
    public partial class FormDepartments : Form
    {
        public FormDepartments()
        {
            InitializeComponent();
            ShowDepartments();
        }

        void ShowDepartments()
        {
            listViewDepartments.Items.Clear();
            foreach (DepartmentsSet departmentsSet in Program.varr.DepartmentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    departmentsSet.Id.ToString(), departmentsSet.NameDepartment, departmentsSet.Persons.ToString(),
                    departmentsSet.Director
                });
                item.Tag = departmentsSet;
                listViewDepartments.Items.Add(item);
            }
            listViewDepartments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void labelNameAutoparts_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPersons_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void listViewDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDepartments.SelectedItems.Count == 1)
            {
                DepartmentsSet departmentsSet = listViewDepartments.SelectedItems[0].Tag as DepartmentsSet;

                textBoxNameDepartments.Text = departmentsSet.NameDepartment;
                textBoxPersons.Text = departmentsSet.Persons.ToString();
                textBoxDirector.Text = departmentsSet.Director;
            }
            else
            {
                textBoxNameDepartments.Text = "";
                textBoxPersons.Text = "";
                textBoxDirector.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentsSet departmentsSet = new DepartmentsSet();

                if (textBoxNameDepartments.Text == "" || textBoxPersons.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    departmentsSet.NameDepartment = textBoxNameDepartments.Text;
                    departmentsSet.Persons = Convert.ToInt32(textBoxPersons.Text);
                }

                if (textBoxDirector != null)
                    departmentsSet.Director = textBoxDirector.Text;
                else departmentsSet.Director = "";

                Program.varr.DepartmentsSet.Add(departmentsSet);
                Program.varr.SaveChanges();
                ShowDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDepartments.SelectedItems.Count == 1)
                {
                    DepartmentsSet departmentsSet = listViewDepartments.SelectedItems[0].Tag as DepartmentsSet;

                    if (textBoxNameDepartments.Text == "" || textBoxPersons.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        departmentsSet.NameDepartment = textBoxNameDepartments.Text;
                        departmentsSet.Persons = Convert.ToInt32(textBoxPersons.Text);
                    }

                    if (textBoxDirector != null)
                        departmentsSet.Director = textBoxDirector.Text;
                    else departmentsSet.Director = "";

                    Program.varr.SaveChanges();
                    ShowDepartments();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDepartments.SelectedItems.Count == 1)
                {
                    DepartmentsSet departmentsSet = listViewDepartments.SelectedItems[0].Tag as DepartmentsSet;

                    Program.varr.DepartmentsSet.Remove(departmentsSet);
                    Program.varr.SaveChanges();
                    ShowDepartments();
                }
                textBoxNameDepartments.Text = "";
                textBoxPersons.Text = "";
                textBoxDirector.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void labelPersons_Click(object sender, EventArgs e)
        {

        }
    }
}
