namespace MedLabProj
{
    partial class AdministratorPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorPanelForm));
            this.checkAppointmentsBtn = new System.Windows.Forms.Button();
            this.addNewAppointmentBtn = new System.Windows.Forms.Button();
            this.addNewPatientBtn = new System.Windows.Forms.Button();
            this.checkPatientsBtn = new System.Windows.Forms.Button();
            this.checkMedicalWorkersBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkAppointmentsBtn
            // 
            this.checkAppointmentsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkAppointmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAppointmentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAppointmentsBtn.Location = new System.Drawing.Point(12, 12);
            this.checkAppointmentsBtn.Name = "checkAppointmentsBtn";
            this.checkAppointmentsBtn.Size = new System.Drawing.Size(209, 59);
            this.checkAppointmentsBtn.TabIndex = 2;
            this.checkAppointmentsBtn.Text = "Просмотр текущих записей";
            this.checkAppointmentsBtn.UseVisualStyleBackColor = false;
            this.checkAppointmentsBtn.Click += new System.EventHandler(this.checkAppointmentsBtn_Click);
            // 
            // addNewAppointmentBtn
            // 
            this.addNewAppointmentBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewAppointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewAppointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewAppointmentBtn.Location = new System.Drawing.Point(12, 77);
            this.addNewAppointmentBtn.Name = "addNewAppointmentBtn";
            this.addNewAppointmentBtn.Size = new System.Drawing.Size(209, 59);
            this.addNewAppointmentBtn.TabIndex = 2;
            this.addNewAppointmentBtn.Text = "Создание записи";
            this.addNewAppointmentBtn.UseVisualStyleBackColor = false;
            this.addNewAppointmentBtn.Click += new System.EventHandler(this.addNewAppointmentBtn_Click);
            // 
            // addNewPatientBtn
            // 
            this.addNewPatientBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewPatientBtn.Location = new System.Drawing.Point(227, 77);
            this.addNewPatientBtn.Name = "addNewPatientBtn";
            this.addNewPatientBtn.Size = new System.Drawing.Size(209, 59);
            this.addNewPatientBtn.TabIndex = 2;
            this.addNewPatientBtn.Text = "Добавление пациента";
            this.addNewPatientBtn.UseVisualStyleBackColor = false;
            this.addNewPatientBtn.Click += new System.EventHandler(this.addNewPatientBtn_Click);
            // 
            // checkPatientsBtn
            // 
            this.checkPatientsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkPatientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPatientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPatientsBtn.Location = new System.Drawing.Point(227, 12);
            this.checkPatientsBtn.Name = "checkPatientsBtn";
            this.checkPatientsBtn.Size = new System.Drawing.Size(209, 59);
            this.checkPatientsBtn.TabIndex = 2;
            this.checkPatientsBtn.Text = "Просмотр списка пациентов";
            this.checkPatientsBtn.UseVisualStyleBackColor = false;
            this.checkPatientsBtn.Click += new System.EventHandler(this.checkPatientsBtn_Click);
            // 
            // checkMedicalWorkersBtn
            // 
            this.checkMedicalWorkersBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkMedicalWorkersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMedicalWorkersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkMedicalWorkersBtn.Location = new System.Drawing.Point(12, 142);
            this.checkMedicalWorkersBtn.Name = "checkMedicalWorkersBtn";
            this.checkMedicalWorkersBtn.Size = new System.Drawing.Size(424, 59);
            this.checkMedicalWorkersBtn.TabIndex = 2;
            this.checkMedicalWorkersBtn.Text = "Просмотр списка мед. работников";
            this.checkMedicalWorkersBtn.UseVisualStyleBackColor = false;
            this.checkMedicalWorkersBtn.Click += new System.EventHandler(this.checkMedicalWorkersBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutBtn.Location = new System.Drawing.Point(334, 229);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(102, 32);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Выйти";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AdministratorPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(452, 273);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.checkMedicalWorkersBtn);
            this.Controls.Add(this.checkPatientsBtn);
            this.Controls.Add(this.addNewPatientBtn);
            this.Controls.Add(this.addNewAppointmentBtn);
            this.Controls.Add(this.checkAppointmentsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministratorPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkAppointmentsBtn;
        private System.Windows.Forms.Button addNewAppointmentBtn;
        private System.Windows.Forms.Button addNewPatientBtn;
        private System.Windows.Forms.Button checkPatientsBtn;
        private System.Windows.Forms.Button checkMedicalWorkersBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}