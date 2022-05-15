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
    public partial class SpecializationsForm : Form
    {
        public SpecializationsForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Specializations specializations = (Specializations)specializationsBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Удалить данные о специализации \"{specializations.Title}\"?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.db.Specializations.Remove(specializations);
                    Program.db.SaveChanges();
                    MessageBox.Show($"Данные о специализации \"{specializations.Title}\" удалены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    specializationsBindingSource.DataSource = Program.db.Specializations.ToList();
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

        private void editCurrentBtn_Click(object sender, EventArgs e)
        {
            addEditSpecializationForm editSpecisalization = new addEditSpecializationForm((Specializations)specializationsBindingSource.Current);
            DialogResult dr = editSpecisalization.ShowDialog();
            if (dr == DialogResult.OK)
            {
                specializationsBindingSource.DataSource = Program.db.Specializations.ToList();
            }
        }

        private void SpecializationsForm_Load(object sender, EventArgs e)
        {
            specializationsBindingSource.DataSource = Program.db.Specializations.ToList();
        }
    }
}
