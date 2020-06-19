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
    public partial class FormAuthorization : Form
    {
        public static User users = new User();

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users user in Program.varr.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login= user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    FormGlavnaya formGlavnaya = new FormGlavnaya();
                    formGlavnaya.Show();
                    this.Hide();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
