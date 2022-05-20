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
    public partial class AddEditPatientForm : Form
    {
        Patient patient { get; set; } = null;
        public AddEditPatientForm(Patient currentPatient)
        {
            InitializeComponent();

            if (currentPatient == null)
            {
                patient = new Patient();
                this.Text = "Новый пациент";
            }
            else
            {
                patient = currentPatient;
                this.Text = $"{patient.Name}";
            }
        }
        private void AddEditPatientForm_Load(object sender, EventArgs e)
        {
            if (patient == null)
            {
                patientBindingSource.AddNew();
            }
            else
            {
                patientBindingSource.Add(patient);
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Полное имя\"");
                return;
            }
            if (addressTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Адрес\"");
                return;
            }
            if (insurancePolicyMaskedTextBox.Text.Length != 14)
            {
                MessageBox.Show("Заполните поле \"Номер полиса\"");
                return;
            }
            if (phoneMaskedTextBox.Text.Length != 18)
            {
                MessageBox.Show("Заполните поле \"Номер телефона\"");
                return;
            }
            if (dateOfBirthMaskedTextBox.Text.Length != 10)
            {
                MessageBox.Show("Заполните поле \"Номер телефона\"");
                return;
            }

            if (patient.ID == 0)
            {
                Program.db.Patient.Add(patient);

                foreach (var item in Program.db.Patient.ToList())
                {
                    if (item.InsurancePolicy == insurancePolicyMaskedTextBox.Text)
                    {
                        MessageBox.Show("Такой пациент уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
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
