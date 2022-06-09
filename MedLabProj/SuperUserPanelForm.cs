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
    public partial class SuperUserPanelForm : Form
    {
        public SuperUserPanelForm()
        {
            InitializeComponent();
        }
        private void checkAppointmentsBtn_Click(object sender, EventArgs e)
        {
            CurrentAppointmentsForm currentAppointments = new CurrentAppointmentsForm();
            currentAppointments.ShowDialog();
        }

        private void checkPatientsBtn_Click(object sender, EventArgs e)
        {
            PatientsListForm patientsListForm = new PatientsListForm();
            patientsListForm.ShowDialog();
        }

        private void addNewPatientBtn_Click(object sender, EventArgs e)
        {
            AddEditPatientForm addEditPatientForm = new AddEditPatientForm(null);
            addEditPatientForm.ShowDialog();
        }

        private void addNewAppointmentBtn_Click(object sender, EventArgs e)
        {
            AddEditAppointmentForm addAppointment = new AddEditAppointmentForm(null);
            addAppointment.ShowDialog();
        }
        private void checkMedicalWorkersBtn_Click(object sender, EventArgs e)
        {
            MedicalWorkesListForm medicalWorkers = new MedicalWorkesListForm();
            medicalWorkers.ShowDialog();
        }

        private void addNewWorkerBtn_Click(object sender, EventArgs e)
        {
            AddEditMedicalWorkerForm addMedicalWorker = new AddEditMedicalWorkerForm(null);
            addMedicalWorker.ShowDialog();
        }

        private void addNewSpecializationBtn_Click(object sender, EventArgs e)
        {
            addEditSpecializationForm addEditSpecialization = new addEditSpecializationForm(null);
            addEditSpecialization.ShowDialog();
        }

        private void checkSpecializationsBtn_Click(object sender, EventArgs e)
        {
            SpecializationsForm specializations = new SpecializationsForm();
            specializations.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Выйти из учетной записи?", "Выход из учетной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                AuthorizationForm authorizationForm = new AuthorizationForm();
                authorizationForm.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void addNewUserBtn_Click(object sender, EventArgs e)
        {
            AddNewUserForm addUser = new AddNewUserForm();
            addUser.ShowDialog();
        }

        private void checkAllUsersBtn_Click(object sender, EventArgs e)
        {
            UsersListForm usersList = new UsersListForm();
            usersList.ShowDialog();
        }

        private void addNewPriceListBtn_Click(object sender, EventArgs e)
        {
            AddEditPriceListForm addEditPriceListForm = new AddEditPriceListForm();
            addEditPriceListForm.ShowDialog();
        }

        private void priceListBtn_Click(object sender, EventArgs e)
        {
            PriceListForm priceListForm = new PriceListForm();
            priceListForm.ShowDialog();
        }
    }
}
