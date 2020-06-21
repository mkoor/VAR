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
    public partial class FormOrderClient : Form
    {
        public FormOrderClient()
        {
            InitializeComponent();
        }

        private void FormOrderClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonThen_Click(object sender, EventArgs e)
        {
            FormOrderBy formOrderBy = new FormOrderBy();
            formOrderBy.Show();
            this.Hide();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                ClientsSet clientsSet = new ClientsSet();

                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" || textBoxTelephone.Text == "")
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
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            MessageBox.Show("Клиент успешно добавлен!", "Клиент добавлен",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormOrderBy formOrderBy = new FormOrderBy();
            formOrderBy.Show();
            this.Hide();
        }
    }
}
