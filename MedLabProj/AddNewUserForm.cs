using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedLabProj.ModelEF;

namespace MedLabProj
{
    public partial class AddNewUserForm : Form
    {
        Users user = new Users();
        public AddNewUserForm()
        {
            InitializeComponent();
            usersBindingSource.Add(user);
        }
        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            userTypeIDComboBox.DataSource = Program.db.UserTypes.ToList();
            userTypeIDComboBox.SelectedIndex = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (loginTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Логин\"");
                return;
            }
            if (passwordTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Пароль\"");
                return;
            }

            Users checkUser = Program.db.Users.Find(loginTextBox.Text);
            if (checkUser != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Program.db.Users.Add(user);
                Program.db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


    }
}
