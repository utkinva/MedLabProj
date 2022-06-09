using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedLabProj.ModelEF;

namespace MedLabProj
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Users currentUser = Program.db.Users.Find(loginTextBox.Text);
            if (currentUser != null)
            {
                if (currentUser.Password == passwordTextBox.Text)
                {
                    MessageBox.Show("Вход выполнен успешно", "Успешно",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    switch (currentUser.UserTypeID)
                    {
                        case 1:
                            Program.userType = currentUser.UserTypeID;
                            SuperUserPanelForm su = new SuperUserPanelForm();
                            su.Show();
                            this.Hide();
                            break;
                        case 2:
                            Program.userType = currentUser.UserTypeID;
                            AdministratorPanelForm admin = new AdministratorPanelForm();
                            admin.Show();
                            this.Hide();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process process = Process.GetCurrentProcess();
            process.Kill();
        }
    }
}
