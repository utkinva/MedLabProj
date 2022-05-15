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
    public partial class AddEditMedicalWorkerForm : Form
    {
        MedicalWorker medicalWorker { get; set; } = null;
        public AddEditMedicalWorkerForm(MedicalWorker currentMedicalWorker)
        {
            InitializeComponent();

            if (currentMedicalWorker == null)
            {
                medicalWorker = new MedicalWorker();
                this.Text = "Новый мед. работник";
            }
            else
            {
                medicalWorker = currentMedicalWorker;
                this.Text = $"{medicalWorker.Name}";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddEditMedicalWorkerForm_Load(object sender, EventArgs e)
        {
            if (medicalWorker == null)
            {
                medicalWorkerBindingSource.AddNew();
            }
            else
            {
                medicalWorkerBindingSource.Add(medicalWorker);
            }

            specializationsBindingSource.DataSource = Program.db.Specializations.ToList();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Полное имя\"");
                return;
            }

            if (workingDaysTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Рабочие дни\"");
                return;
            }

            if (medicalWorker.ID == 0)
            {
                Program.db.MedicalWorker.Add(medicalWorker);
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
