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
    public partial class CurrentAppointmentsForm : Form
    {
        public CurrentAppointmentsForm()
        {
            InitializeComponent();
        }

        private void CurrentAppointmentsForm_Load(object sender, EventArgs e)
        {
            patientBindingSource.DataSource = Program.db.Patient.ToList();
            medicalWorkerBindingSource.DataSource = Program.db.MedicalWorker.ToList();
            priceListBindingSource.DataSource = Program.db.PriceList.ToList();
            appointmentsBindingSource.DataSource = Program.db.Appointments.ToList();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void appointmentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Appointments appointment = (Appointments)appointmentsBindingSource.Current;
            DateTime date = appointment.DateOf;
            TimeSpan time = appointment.TimeOf;
            DialogResult dr = MessageBox.Show($"Удалить данные о записи от {date.ToShortDateString()}/{time.Hours}:{time.Minutes}?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.db.Appointments.Remove(appointment);
                    Program.db.SaveChanges();
                    MessageBox.Show($"Данные о записи от {date.ToShortDateString()}/{time.Hours}:{time.Minutes} удалены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    appointmentsBindingSource.DataSource = Program.db.Appointments.ToList();
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
            AddEditAppointmentForm editAppointment = new AddEditAppointmentForm((Appointments)appointmentsBindingSource.Current);
            DialogResult dr = editAppointment.ShowDialog();
            if (dr == DialogResult.OK)
            {
                appointmentsBindingSource.DataSource = Program.db.Appointments.ToList();
            }
        }
    }
}
