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
    public partial class MedicalWorkesListForm : Form
    {
        public MedicalWorkesListForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void medicalWorkerDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void MedicalWorkesListForm_Load(object sender, EventArgs e)
        {
            if (Program.userType != 1)
            {
                editCurrentBtn.Visible = false;
                deleteBtn.Visible = false;
            }
            else
            {
                editCurrentBtn.Visible = true;
                deleteBtn.Visible = true;
            }

            specializationsBindingSource.DataSource = Program.db.Specializations.ToList();
            medicalWorkerBindingSource.DataSource = Program.db.MedicalWorker.ToList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MedicalWorker medicalWorker = (MedicalWorker)medicalWorkerBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Удалить данные о сотруднике \"{medicalWorker.Name}\"?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.db.MedicalWorker.Remove(medicalWorker);
                    Program.db.SaveChanges();
                    MessageBox.Show($"Данные о сотруднике \"{medicalWorker.Name}\" удалены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    medicalWorkerBindingSource.DataSource = Program.db.MedicalWorker.ToList();
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
            AddEditMedicalWorkerForm editPatientForm = new AddEditMedicalWorkerForm((MedicalWorker)medicalWorkerBindingSource.Current);
            DialogResult dr = editPatientForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                medicalWorkerBindingSource.DataSource = Program.db.MedicalWorker.ToList();
            }
        }
    }
}
