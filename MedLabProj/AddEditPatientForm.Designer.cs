namespace MedLabProj
{
    partial class AddEditPatientForm
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label insurancePolicyLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditPatientForm));
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.insurancePolicyMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            addressLabel = new System.Windows.Forms.Label();
            insurancePolicyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            addressLabel.Location = new System.Drawing.Point(12, 142);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 24);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адрес:";
            // 
            // insurancePolicyLabel
            // 
            insurancePolicyLabel.AutoSize = true;
            insurancePolicyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            insurancePolicyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            insurancePolicyLabel.Location = new System.Drawing.Point(12, 78);
            insurancePolicyLabel.Name = "insurancePolicyLabel";
            insurancePolicyLabel.Size = new System.Drawing.Size(142, 24);
            insurancePolicyLabel.TabIndex = 7;
            insurancePolicyLabel.Text = "Номер полиса:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            nameLabel.Location = new System.Drawing.Point(12, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(121, 24);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Полное имя:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            phoneLabel.Location = new System.Drawing.Point(12, 110);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(167, 24);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Номер телефона:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateOfBirthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            dateOfBirthLabel.Location = new System.Drawing.Point(12, 46);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(155, 24);
            dateOfBirthLabel.TabIndex = 12;
            dateOfBirthLabel.Text = "Дата рождения:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.ForeColor = System.Drawing.Color.White;
            this.addressTextBox.Location = new System.Drawing.Point(200, 140);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(291, 26);
            this.addressTextBox.TabIndex = 4;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(MedLabProj.ModelEF.Patient);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(200, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(291, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.phoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(200, 108);
            this.phoneMaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(291, 26);
            this.phoneMaskedTextBox.TabIndex = 3;
            // 
            // insurancePolicyMaskedTextBox
            // 
            this.insurancePolicyMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.insurancePolicyMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insurancePolicyMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "InsurancePolicy", true));
            this.insurancePolicyMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insurancePolicyMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.insurancePolicyMaskedTextBox.Location = new System.Drawing.Point(200, 76);
            this.insurancePolicyMaskedTextBox.Mask = "000-000-000 00";
            this.insurancePolicyMaskedTextBox.Name = "insurancePolicyMaskedTextBox";
            this.insurancePolicyMaskedTextBox.Size = new System.Drawing.Size(291, 26);
            this.insurancePolicyMaskedTextBox.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.closeBtn.Location = new System.Drawing.Point(357, 185);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(134, 39);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.saveBtn.Location = new System.Drawing.Point(16, 185);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 39);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.dateOfBirthMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOfBirthMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "DateOfBirth", true));
            this.dateOfBirthMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirthMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(200, 44);
            this.dateOfBirthMaskedTextBox.Mask = "00/00/0000";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(291, 26);
            this.dateOfBirthMaskedTextBox.TabIndex = 1;
            // 
            // AddEditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(511, 244);
            this.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.insurancePolicyMaskedTextBox);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(insurancePolicyLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый пациент";
            this.Load += new System.EventHandler(this.AddEditPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox insurancePolicyMaskedTextBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.MaskedTextBox dateOfBirthMaskedTextBox;
    }
}