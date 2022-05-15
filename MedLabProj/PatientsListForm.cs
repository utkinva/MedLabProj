using MedLabProj.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedLabProj
{
    public partial class PatientsListForm : Form
    {
        public PatientsListForm()
        {
            InitializeComponent();
        }

        private void PatientsListForm_Load(object sender, EventArgs e)
        {
            patientBindingSource.DataSource = Program.db.Patient.ToList();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void editCurrentBtn_Click(object sender, EventArgs e)
        {
            AddEditPatientForm editPatientForm = new AddEditPatientForm((Patient)patientBindingSource.Current);
            DialogResult dr = editPatientForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                patientBindingSource.DataSource = Program.db.Patient.ToList();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Patient patient = (Patient)patientBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Удалить данные о пациенте \"{patient.Name}\"?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.db.Patient.Remove(patient);
                    Program.db.SaveChanges();
                    MessageBox.Show($"Данные о пациенте \"{patient.Name}\" удалены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    patientBindingSource.DataSource = Program.db.Patient.ToList();
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
    }
}
