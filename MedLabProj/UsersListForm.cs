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
    public partial class UsersListForm : Form
    {
        public UsersListForm()
        {
            InitializeComponent();
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            userTypesBindingSource.DataSource = Program.db.UserTypes.ToList();
            usersBindingSource.DataSource = Program.db.Users.ToList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Users user = (Users)usersBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Удалить данные о пользователе с логином \"{user.Login}\"?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.db.Users.Remove(user);
                    Program.db.SaveChanges();
                    MessageBox.Show($"Данные о пользователе с логином \"{user.Login}\" удалены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usersBindingSource.DataSource = Program.db.Users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            else
            {
                return;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
