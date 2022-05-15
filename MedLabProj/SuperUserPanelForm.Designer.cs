namespace MedLabProj
{
    partial class SuperUserPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperUserPanelForm));
            this.checkWorkersBtn = new System.Windows.Forms.Button();
            this.addNewWorkerBtn = new System.Windows.Forms.Button();
            this.addNewSpecializationBtn = new System.Windows.Forms.Button();
            this.checkSpecializationsBtn = new System.Windows.Forms.Button();
            this.checkPatientsBtn = new System.Windows.Forms.Button();
            this.addNewPatientBtn = new System.Windows.Forms.Button();
            this.addNewAppointmentBtn = new System.Windows.Forms.Button();
            this.checkAppointmentsBtn = new System.Windows.Forms.Button();
            this.checkAllUsersBtn = new System.Windows.Forms.Button();
            this.addNewUserBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkWorkersBtn
            // 
            this.checkWorkersBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkWorkersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkWorkersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkWorkersBtn.Location = new System.Drawing.Point(227, 12);
            this.checkWorkersBtn.Name = "checkWorkersBtn";
            this.checkWorkersBtn.Size = new System.Drawing.Size(209, 59);
            this.checkWorkersBtn.TabIndex = 1;
            this.checkWorkersBtn.Text = "Просмотр списка мед. работников";
            this.checkWorkersBtn.UseVisualStyleBackColor = false;
            this.checkWorkersBtn.Click += new System.EventHandler(this.checkMedicalWorkersBtn_Click);
            // 
            // addNewWorkerBtn
            // 
            this.addNewWorkerBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewWorkerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewWorkerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewWorkerBtn.Location = new System.Drawing.Point(227, 77);
            this.addNewWorkerBtn.Name = "addNewWorkerBtn";
            this.addNewWorkerBtn.Size = new System.Drawing.Size(209, 59);
            this.addNewWorkerBtn.TabIndex = 3;
            this.addNewWorkerBtn.Text = "Добавить мед. работника";
            this.addNewWorkerBtn.UseVisualStyleBackColor = false;
            this.addNewWorkerBtn.Click += new System.EventHandler(this.addNewWorkerBtn_Click);
            // 
            // addNewSpecializationBtn
            // 
            this.addNewSpecializationBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewSpecializationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewSpecializationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewSpecializationBtn.Location = new System.Drawing.Point(12, 77);
            this.addNewSpecializationBtn.Name = "addNewSpecializationBtn";
            this.addNewSpecializationBtn.Size = new System.Drawing.Size(209, 59);
            this.addNewSpecializationBtn.TabIndex = 2;
            this.addNewSpecializationBtn.Text = "Создать специализацию";
            this.addNewSpecializationBtn.UseVisualStyleBackColor = false;
            this.addNewSpecializationBtn.Click += new System.EventHandler(this.addNewSpecializationBtn_Click);
            // 
            // checkSpecializationsBtn
            // 
            this.checkSpecializationsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkSpecializationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSpecializationsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSpecializationsBtn.Location = new System.Drawing.Point(12, 12);
            this.checkSpecializationsBtn.Name = "checkSpecializationsBtn";
            this.checkSpecializationsBtn.Size = new System.Drawing.Size(209, 59);
            this.checkSpecializationsBtn.TabIndex = 0;
            this.checkSpecializationsBtn.Text = "Просмотр специализации";
            this.checkSpecializationsBtn.UseVisualStyleBackColor = false;
            this.checkSpecializationsBtn.Click += new System.EventHandler(this.checkSpecializationsBtn_Click);
            // 
            // checkPatientsBtn
            // 
            this.checkPatientsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkPatientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPatientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPatientsBtn.Location = new System.Drawing.Point(227, 242);
            this.checkPatientsBtn.Name = "checkPatientsBtn";
            this.checkPatientsBtn.Size = new System.Drawing.Size(209, 59);
            this.checkPatientsBtn.TabIndex = 7;
            this.checkPatientsBtn.Text = "Просмотр списка пациентов";
            this.checkPatientsBtn.UseVisualStyleBackColor = false;
            this.checkPatientsBtn.Click += new System.EventHandler(this.checkPatientsBtn_Click);
            // 
            // addNewPatientBtn
            // 
            this.addNewPatientBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewPatientBtn.Location = new System.Drawing.Point(227, 307);
            this.addNewPatientBtn.Name = "addNewPatientBtn";
            this.addNewPatientBtn.Size = new System.Drawing.Size(209, 59);
            this.addNewPatientBtn.TabIndex = 9;
            this.addNewPatientBtn.Text = "Добавление пациента";
            this.addNewPatientBtn.UseVisualStyleBackColor = false;
            this.addNewPatientBtn.Click += new System.EventHandler(this.addNewPatientBtn_Click);
            // 
            // addNewAppointmentBtn
            // 
            this.addNewAppointmentBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewAppointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewAppointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewAppointmentBtn.Location = new System.Drawing.Point(12, 307);
            this.addNewAppointmentBtn.Name = "addNewAppointmentBtn";
            this.addNewAppointmentBtn.Size = new System.Drawing.Size(209, 59);
            this.addNewAppointmentBtn.TabIndex = 8;
            this.addNewAppointmentBtn.Text = "Создание записи";
            this.addNewAppointmentBtn.UseVisualStyleBackColor = false;
            this.addNewAppointmentBtn.Click += new System.EventHandler(this.addNewAppointmentBtn_Click);
            // 
            // checkAppointmentsBtn
            // 
            this.checkAppointmentsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkAppointmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAppointmentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAppointmentsBtn.Location = new System.Drawing.Point(12, 242);
            this.checkAppointmentsBtn.Name = "checkAppointmentsBtn";
            this.checkAppointmentsBtn.Size = new System.Drawing.Size(209, 59);
            this.checkAppointmentsBtn.TabIndex = 6;
            this.checkAppointmentsBtn.Text = "Просмотр текущих записей";
            this.checkAppointmentsBtn.UseVisualStyleBackColor = false;
            this.checkAppointmentsBtn.Click += new System.EventHandler(this.checkAppointmentsBtn_Click);
            // 
            // checkAllUsersBtn
            // 
            this.checkAllUsersBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkAllUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAllUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAllUsersBtn.Location = new System.Drawing.Point(12, 142);
            this.checkAllUsersBtn.Name = "checkAllUsersBtn";
            this.checkAllUsersBtn.Size = new System.Drawing.Size(209, 59);
            this.checkAllUsersBtn.TabIndex = 4;
            this.checkAllUsersBtn.Text = "Просмотр всех пользователей";
            this.checkAllUsersBtn.UseVisualStyleBackColor = false;
            this.checkAllUsersBtn.Click += new System.EventHandler(this.checkAllUsersBtn_Click);
            // 
            // addNewUserBtn
            // 
            this.addNewUserBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewUserBtn.Location = new System.Drawing.Point(227, 142);
            this.addNewUserBtn.Name = "addNewUserBtn";
            this.addNewUserBtn.Size = new System.Drawing.Size(209, 59);
            this.addNewUserBtn.TabIndex = 5;
            this.addNewUserBtn.Text = "Добавление нового пользователя";
            this.addNewUserBtn.UseVisualStyleBackColor = false;
            this.addNewUserBtn.Click += new System.EventHandler(this.addNewUserBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutBtn.Location = new System.Drawing.Point(335, 398);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(102, 32);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Text = "Выйти";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // SuperUserPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(449, 438);
            this.Controls.Add(this.addNewUserBtn);
            this.Controls.Add(this.checkPatientsBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.addNewPatientBtn);
            this.Controls.Add(this.checkAllUsersBtn);
            this.Controls.Add(this.addNewAppointmentBtn);
            this.Controls.Add(this.checkAppointmentsBtn);
            this.Controls.Add(this.checkWorkersBtn);
            this.Controls.Add(this.addNewWorkerBtn);
            this.Controls.Add(this.addNewSpecializationBtn);
            this.Controls.Add(this.checkSpecializationsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SuperUserPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления SU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkWorkersBtn;
        private System.Windows.Forms.Button addNewWorkerBtn;
        private System.Windows.Forms.Button addNewSpecializationBtn;
        private System.Windows.Forms.Button checkSpecializationsBtn;
        private System.Windows.Forms.Button checkPatientsBtn;
        private System.Windows.Forms.Button addNewPatientBtn;
        private System.Windows.Forms.Button addNewAppointmentBtn;
        private System.Windows.Forms.Button checkAppointmentsBtn;
        private System.Windows.Forms.Button checkAllUsersBtn;
        private System.Windows.Forms.Button addNewUserBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}