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
    public partial class addEditSpecializationForm : Form
    {
        Specializations specialization;
        public addEditSpecializationForm(Specializations currentSpecialization)
        {
            InitializeComponent();

            if (currentSpecialization == null)
            {
                specialization = new Specializations();
                this.Text = "Новая специализация";
            }
            else
            {
                specialization = currentSpecialization;
                this.Text = $"{specialization.Title}";
            }
        }

        private void addEditSpecializationForm_Load(object sender, EventArgs e)
        {
            if (specialization == null)
            {
                specializationsBindingSource.AddNew();
            }
            else
            {
                specializationsBindingSource.Add(specialization);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (titleTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Наименование\"");
                return;
            }


            if (specialization.ID == 0)
            {
                Program.db.Specializations.Add(specialization);
            }

            try
            {

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
