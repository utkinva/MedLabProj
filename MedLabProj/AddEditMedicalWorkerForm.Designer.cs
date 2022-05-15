namespace MedLabProj
{
    partial class AddEditMedicalWorkerForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label specializationIDLabel;
            System.Windows.Forms.Label workingDaysLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditMedicalWorkerForm));
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.medicalWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializationIDComboBox = new System.Windows.Forms.ComboBox();
            this.specializationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workingDaysTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            specializationIDLabel = new System.Windows.Forms.Label();
            workingDaysLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(12, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(104, 20);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Полное имя:";
            // 
            // specializationIDLabel
            // 
            specializationIDLabel.AutoSize = true;
            specializationIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            specializationIDLabel.Location = new System.Drawing.Point(12, 52);
            specializationIDLabel.Name = "specializationIDLabel";
            specializationIDLabel.Size = new System.Drawing.Size(132, 20);
            specializationIDLabel.TabIndex = 11;
            specializationIDLabel.Text = "Специализация:";
            // 
            // workingDaysLabel
            // 
            workingDaysLabel.AutoSize = true;
            workingDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            workingDaysLabel.Location = new System.Drawing.Point(12, 84);
            workingDaysLabel.Name = "workingDaysLabel";
            workingDaysLabel.Size = new System.Drawing.Size(110, 20);
            workingDaysLabel.TabIndex = 13;
            workingDaysLabel.Text = "Рабочие дни:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(16, 127);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 39);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(262, 127);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(134, 39);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicalWorkerBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(178, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // medicalWorkerBindingSource
            // 
            this.medicalWorkerBindingSource.DataSource = typeof(MedLabProj.ModelEF.MedicalWorker);
            // 
            // specializationIDComboBox
            // 
            this.specializationIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicalWorkerBindingSource, "SpecializationID", true));
            this.specializationIDComboBox.DataSource = this.specializationsBindingSource;
            this.specializationIDComboBox.DisplayMember = "Title";
            this.specializationIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specializationIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.specializationIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializationIDComboBox.FormattingEnabled = true;
            this.specializationIDComboBox.Location = new System.Drawing.Point(178, 44);
            this.specializationIDComboBox.Name = "specializationIDComboBox";
            this.specializationIDComboBox.Size = new System.Drawing.Size(218, 28);
            this.specializationIDComboBox.TabIndex = 12;
            this.specializationIDComboBox.TabStop = false;
            this.specializationIDComboBox.ValueMember = "ID";
            // 
            // specializationsBindingSource
            // 
            this.specializationsBindingSource.DataSource = typeof(MedLabProj.ModelEF.Specializations);
            // 
            // workingDaysTextBox
            // 
            this.workingDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicalWorkerBindingSource, "WorkingDays", true));
            this.workingDaysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workingDaysTextBox.Location = new System.Drawing.Point(178, 78);
            this.workingDaysTextBox.Name = "workingDaysTextBox";
            this.workingDaysTextBox.Size = new System.Drawing.Size(218, 26);
            this.workingDaysTextBox.TabIndex = 1;
            // 
            // AddEditMedicalWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(412, 175);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(specializationIDLabel);
            this.Controls.Add(this.specializationIDComboBox);
            this.Controls.Add(workingDaysLabel);
            this.Controls.Add(this.workingDaysTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditMedicalWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый мед. работник";
            this.Load += new System.EventHandler(this.AddEditMedicalWorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.BindingSource medicalWorkerBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox specializationIDComboBox;
        private System.Windows.Forms.TextBox workingDaysTextBox;
        private System.Windows.Forms.BindingSource specializationsBindingSource;
    }
}