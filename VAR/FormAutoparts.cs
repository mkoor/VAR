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
    public partial class FormAutoparts : Form
    {
        public FormAutoparts()
        {
            InitializeComponent();
            ShowAutoparts();
            ShowSuppliers();
        }

        private void labelOrder_Click(object sender, EventArgs e)
        {

        }

        void ShowSuppliers()
        {
            comboBoxSuppliers.Items.Clear();
            foreach (SuppliersSet suppliersSet in Program.varr.SuppliersSet)
            {
                string[] item = {suppliersSet.Id.ToString()+". ",
                   suppliersSet.NameSupplier};
                comboBoxSuppliers.Items.Add(string.Join(" ", item));
            }
        }

        void ShowAutoparts()
        {
            listViewAutoparts.Items.Clear();
            foreach (AutopartsSet autopartsSet in Program.varr.AutopartsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    autopartsSet.Id.ToString(), autopartsSet.CategoryAutopart, autopartsSet.NameAutopart, 
                    autopartsSet.AutoBrand, autopartsSet.Manufacturer, autopartsSet.SuppliersSet.Id.ToString()+". "+
                    autopartsSet.SuppliersSet.NameSupplier
                });
                item.Tag = autopartsSet;
                listViewAutoparts.Items.Add(item);
            }
            listViewAutoparts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AutopartsSet autopartsSet = new AutopartsSet();

                if (textBoxCategory.Text == "" || textBoxNameAutoparts.Text == "" ||
                       textBoxManufacturer.Text == "" || comboBoxSuppliers.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    autopartsSet.CategoryAutopart = textBoxCategory.Text;
                    autopartsSet.NameAutopart = textBoxNameAutoparts.Text;
                    autopartsSet.Manufacturer = textBoxManufacturer.Text;
                    autopartsSet.IdSupplier = Convert.ToInt32(comboBoxSuppliers.SelectedItem.ToString().Split('.')[0]);
                }

                if (textBoxAutoBrand.Text != null)
                    autopartsSet.AutoBrand = textBoxAutoBrand.Text;
                else autopartsSet.AutoBrand = "";

                Program.varr.AutopartsSet.Add(autopartsSet);
                Program.varr.SaveChanges();
                ShowAutoparts();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewAutoparts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAutoparts.SelectedItems.Count == 1)
            {
                AutopartsSet autopartsSet = listViewAutoparts.SelectedItems[0].Tag as AutopartsSet;

                textBoxCategory.Text = autopartsSet.CategoryAutopart;
                textBoxNameAutoparts.Text = autopartsSet.NameAutopart;
                textBoxAutoBrand.Text = autopartsSet.AutoBrand;
                textBoxManufacturer.Text = autopartsSet.Manufacturer;
                comboBoxSuppliers.Text = autopartsSet.IdSupplier.ToString() + ". " + autopartsSet.SuppliersSet.NameSupplier;
            }
            else
            {
                textBoxCategory.Text = "";
                textBoxNameAutoparts.Text = "";
                textBoxAutoBrand.Text = "";
                textBoxManufacturer.Text = "";
                comboBoxSuppliers.Text = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAutoparts.SelectedItems.Count == 1)
                {
                    AutopartsSet autopartsSet = listViewAutoparts.SelectedItems[0].Tag as AutopartsSet;

                    if (textBoxCategory.Text == "" || textBoxNameAutoparts.Text == "" ||
                        textBoxManufacturer.Text == "" || comboBoxSuppliers.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        autopartsSet.CategoryAutopart = textBoxCategory.Text;
                        autopartsSet.NameAutopart = textBoxNameAutoparts.Text;
                        autopartsSet.Manufacturer = textBoxManufacturer.Text;
                        autopartsSet.IdSupplier = Convert.ToInt32(comboBoxSuppliers.SelectedItem.ToString().Split('.')[0]);
                    }

                    if (textBoxAutoBrand.Text != null)
                        autopartsSet.AutoBrand = textBoxAutoBrand.Text;
                    else autopartsSet.AutoBrand = "";

                    Program.varr.SaveChanges();
                    ShowAutoparts();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAutoparts.SelectedItems.Count == 1)
                {
                    AutopartsSet autopartsSet = listViewAutoparts.SelectedItems[0].Tag as AutopartsSet;

                    Program.varr.AutopartsSet.Remove(autopartsSet);
                    Program.varr.SaveChanges();
                    ShowAutoparts();
                }
                textBoxAutoBrand.Text = "";
                textBoxManufacturer.Text = "";
                textBoxNameAutoparts.Text = "";
                textBoxCategory.Text = "";
                comboBoxSuppliers.Text = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
