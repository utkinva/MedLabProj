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
    public partial class AddEditAppointmentForm : Form
    {
        Appointments appointment { get; set; } = null;
        public AddEditAppointmentForm(Appointments currentAppointment)
        {
            InitializeComponent();
            if (currentAppointment == null)
            {
                appointment = new Appointments();
                this.Text = "Новый пациент";
            }
            else
            {
                appointment = currentAppointment;
                DateTime date = appointment.DateOf;
                TimeSpan time = appointment.TimeOf;
                this.Text = $"Запись от {date.ToShortDateString()}/{time.Hours}:{time.Minutes}";
            }
        }

        private void AddEditAppointmentForm_Load(object sender, EventArgs e)
        {
            medicalWorkerBindingSource.DataSource = Program.db.MedicalWorker.ToList();
            patientBindingSource.DataSource = Program.db.Patient.ToList();
            priceListBindingSource.DataSource = Program.db.PriceList.ToList();

            if (appointment == null)
            {
                appointmentsBindingSource.AddNew();
            }
            else
            {
                appointmentsBindingSource.Add(appointment);
            }

            PriceList currentPriceList = (PriceList)priceListIDComboBox.SelectedItem;
            if (currentPriceList != null)
            {
                totalCostTextBox.Text = $"{currentPriceList.Cost:000.00} руб.";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (dateOfMaskedTextBox.Text.Length != 10)
            {
                MessageBox.Show("Заполните поле \"Дата\"");
            }

            if (appointment.ID == 0)
            {
                Program.db.Appointments.Add(appointment);
                foreach (var item in Program.db.Appointments.ToList())
                {
                    if (item.PatientID == int.Parse(patientIDComboBox.SelectedValue.ToString()) &&
                        item.PriceListID == int.Parse(priceListIDComboBox.SelectedValue.ToString()) &&
                        DateTime.Parse(item.DateOf.ToString()) == DateTime.Parse(dateOfMaskedTextBox.Text) &&
                        TimeSpan.Parse(item.TimeOf.ToString()) == TimeSpan.Parse(timeOfMaskedTextBox.Text))
                    {
                        MessageBox.Show($"Пациент уже записан на услугу {priceListIDComboBox.Text} с датой {dateOfMaskedTextBox.Text} в {timeOfMaskedTextBox.Text}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void priceListIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceList currentPriceList = (PriceList)priceListIDComboBox.SelectedItem;
            if (currentPriceList != null)
            {
                totalCostTextBox.Text = $"{currentPriceList.Cost:000.00} руб.";
            }
        }
    }
}
