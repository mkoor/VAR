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
    public partial class FormSuppliers : Form
    {
        public FormSuppliers()
        {
            InitializeComponent();
            ShowSuppliers();
        }

        void ShowSuppliers()
        {
            listViewSuppliers.Items.Clear();
            foreach (SuppliersSet suppliersSet in Program.varr.SuppliersSet)
            {

                ListViewItem item = new ListViewItem(new string[]
                {
                    suppliersSet.Id.ToString(), suppliersSet.NameSupplier, suppliersSet.INN,
                    suppliersSet.Address, suppliersSet.Telephone
                });
                item.Tag = suppliersSet;
                listViewSuppliers.Items.Add(item);
            }
            listViewSuppliers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SuppliersSet suppliersSet = new SuppliersSet();

                if (textBoxNameSupplier.Text == "" || textBoxINN.Text == "" ||
                       textBoxAddress.Text == "" || textBoxTelephone.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    suppliersSet.NameSupplier = textBoxNameSupplier.Text;
                    suppliersSet.INN = textBoxINN.Text;
                    suppliersSet.Address = textBoxAddress.Text;
                    suppliersSet.Telephone = textBoxTelephone.Text;
                }

                Program.varr.SuppliersSet.Add(suppliersSet);
                Program.varr.SaveChanges();
                ShowSuppliers();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSuppliers.SelectedItems.Count == 1)
                {
                    SuppliersSet suppliersSet = listViewSuppliers.SelectedItems[0].Tag as SuppliersSet;

                    if (textBoxNameSupplier.Text == "" || textBoxINN.Text == "" ||
                      textBoxAddress.Text == "" || textBoxTelephone.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        suppliersSet.NameSupplier = textBoxNameSupplier.Text;
                        suppliersSet.INN = textBoxINN.Text;
                        suppliersSet.Address = textBoxAddress.Text;
                        suppliersSet.Telephone = textBoxTelephone.Text;
                    }

                    Program.varr.SaveChanges();
                    ShowSuppliers();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSuppliers.SelectedItems.Count == 1)
            {
                SuppliersSet suppliersSet = listViewSuppliers.SelectedItems[0].Tag as SuppliersSet;

                textBoxNameSupplier.Text = suppliersSet.NameSupplier;
                textBoxINN.Text = suppliersSet.INN;
                textBoxAddress.Text = suppliersSet.Address;
                textBoxTelephone.Text = suppliersSet.Telephone;

            }
            else
            {
                textBoxNameSupplier.Text = "";
                textBoxINN.Text = "";
                textBoxAddress.Text = "";
                textBoxTelephone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSuppliers.SelectedItems.Count == 1)
                {
                    SuppliersSet suppliersSet = listViewSuppliers.SelectedItems[0].Tag as SuppliersSet;

                    Program.varr.SuppliersSet.Remove(suppliersSet);
                    Program.varr.SaveChanges();
                    ShowSuppliers();
                }
                textBoxNameSupplier.Text = "";
                textBoxINN.Text = "";
                textBoxAddress.Text = "";
                textBoxTelephone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
