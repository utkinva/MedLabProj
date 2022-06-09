namespace MedLabProj
{
    partial class AddEditAppointmentForm
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
            System.Windows.Forms.Label dateOfLabel;
            System.Windows.Forms.Label medicalWorkerIDLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label priceListIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label timeOfLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditAppointmentForm));
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.medicalWorkerIDComboBox = new System.Windows.Forms.ComboBox();
            this.medicalWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientIDComboBox = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceListIDComboBox = new System.Windows.Forms.ComboBox();
            this.priceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.timeOfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            dateOfLabel = new System.Windows.Forms.Label();
            medicalWorkerIDLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            priceListIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            timeOfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfLabel
            // 
            dateOfLabel.AutoSize = true;
            dateOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateOfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            dateOfLabel.Location = new System.Drawing.Point(12, 14);
            dateOfLabel.Name = "dateOfLabel";
            dateOfLabel.Size = new System.Drawing.Size(59, 24);
            dateOfLabel.TabIndex = 1;
            dateOfLabel.Text = "Дата:";
            // 
            // medicalWorkerIDLabel
            // 
            medicalWorkerIDLabel.AutoSize = true;
            medicalWorkerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            medicalWorkerIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            medicalWorkerIDLabel.Location = new System.Drawing.Point(12, 114);
            medicalWorkerIDLabel.Name = "medicalWorkerIDLabel";
            medicalWorkerIDLabel.Size = new System.Drawing.Size(149, 24);
            medicalWorkerIDLabel.TabIndex = 3;
            medicalWorkerIDLabel.Text = "Мед. Работник:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            patientIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            patientIDLabel.Location = new System.Drawing.Point(12, 148);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(92, 24);
            patientIDLabel.TabIndex = 5;
            patientIDLabel.Text = "Пациент:";
            // 
            // priceListIDLabel
            // 
            priceListIDLabel.AutoSize = true;
            priceListIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceListIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            priceListIDLabel.Location = new System.Drawing.Point(12, 80);
            priceListIDLabel.Name = "priceListIDLabel";
            priceListIDLabel.Size = new System.Drawing.Size(139, 24);
            priceListIDLabel.TabIndex = 7;
            priceListIDLabel.Text = "Вид анализов:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            label1.Location = new System.Drawing.Point(160, 180);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 24);
            label1.TabIndex = 7;
            label1.Text = "Стоимость:";
            // 
            // timeOfLabel
            // 
            timeOfLabel.AutoSize = true;
            timeOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            timeOfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            timeOfLabel.Location = new System.Drawing.Point(12, 46);
            timeOfLabel.Name = "timeOfLabel";
            timeOfLabel.Size = new System.Drawing.Size(72, 24);
            timeOfLabel.TabIndex = 18;
            timeOfLabel.Text = "Время:";
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataSource = typeof(MedLabProj.ModelEF.Appointments);
            // 
            // dateOfMaskedTextBox
            // 
            this.dateOfMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.dateOfMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "DateOf", true));
            this.dateOfMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.dateOfMaskedTextBox.Location = new System.Drawing.Point(182, 12);
            this.dateOfMaskedTextBox.Mask = "00/00/0000";
            this.dateOfMaskedTextBox.Name = "dateOfMaskedTextBox";
            this.dateOfMaskedTextBox.Size = new System.Drawing.Size(240, 26);
            this.dateOfMaskedTextBox.TabIndex = 0;
            this.dateOfMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // medicalWorkerIDComboBox
            // 
            this.medicalWorkerIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.medicalWorkerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.appointmentsBindingSource, "MedicalWorkerID", true));
            this.medicalWorkerIDComboBox.DataSource = this.medicalWorkerBindingSource;
            this.medicalWorkerIDComboBox.DisplayMember = "Name";
            this.medicalWorkerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicalWorkerIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.medicalWorkerIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicalWorkerIDComboBox.ForeColor = System.Drawing.Color.White;
            this.medicalWorkerIDComboBox.FormattingEnabled = true;
            this.medicalWorkerIDComboBox.Location = new System.Drawing.Point(182, 110);
            this.medicalWorkerIDComboBox.Name = "medicalWorkerIDComboBox";
            this.medicalWorkerIDComboBox.Size = new System.Drawing.Size(240, 28);
            this.medicalWorkerIDComboBox.TabIndex = 4;
            this.medicalWorkerIDComboBox.TabStop = false;
            this.medicalWorkerIDComboBox.ValueMember = "ID";
            // 
            // medicalWorkerBindingSource
            // 
            this.medicalWorkerBindingSource.DataSource = typeof(MedLabProj.ModelEF.MedicalWorker);
            // 
            // patientIDComboBox
            // 
            this.patientIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.patientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.appointmentsBindingSource, "PatientID", true));
            this.patientIDComboBox.DataSource = this.patientBindingSource;
            this.patientIDComboBox.DisplayMember = "Name";
            this.patientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patientIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientIDComboBox.ForeColor = System.Drawing.Color.White;
            this.patientIDComboBox.FormattingEnabled = true;
            this.patientIDComboBox.Location = new System.Drawing.Point(182, 144);
            this.patientIDComboBox.Name = "patientIDComboBox";
            this.patientIDComboBox.Size = new System.Drawing.Size(240, 28);
            this.patientIDComboBox.TabIndex = 6;
            this.patientIDComboBox.TabStop = false;
            this.patientIDComboBox.ValueMember = "ID";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(MedLabProj.ModelEF.Patient);
            // 
            // priceListIDComboBox
            // 
            this.priceListIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.priceListIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.appointmentsBindingSource, "PriceListID", true));
            this.priceListIDComboBox.DataSource = this.priceListBindingSource;
            this.priceListIDComboBox.DisplayMember = "Title";
            this.priceListIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceListIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.priceListIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceListIDComboBox.ForeColor = System.Drawing.Color.White;
            this.priceListIDComboBox.FormattingEnabled = true;
            this.priceListIDComboBox.Location = new System.Drawing.Point(182, 76);
            this.priceListIDComboBox.Name = "priceListIDComboBox";
            this.priceListIDComboBox.Size = new System.Drawing.Size(240, 28);
            this.priceListIDComboBox.TabIndex = 8;
            this.priceListIDComboBox.TabStop = false;
            this.priceListIDComboBox.ValueMember = "ID";
            this.priceListIDComboBox.SelectedIndexChanged += new System.EventHandler(this.priceListIDComboBox_SelectedIndexChanged);
            // 
            // priceListBindingSource
            // 
            this.priceListBindingSource.DataSource = typeof(MedLabProj.ModelEF.PriceList);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.totalCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCostTextBox.ForeColor = System.Drawing.Color.White;
            this.totalCostTextBox.Location = new System.Drawing.Point(281, 178);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(141, 26);
            this.totalCostTextBox.TabIndex = 9;
            this.totalCostTextBox.TabStop = false;
            this.totalCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.saveBtn.Location = new System.Drawing.Point(12, 224);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 39);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.closeBtn.Location = new System.Drawing.Point(288, 224);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(134, 39);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // timeOfMaskedTextBox
            // 
            this.timeOfMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.timeOfMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeOfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "TimeOf", true));
            this.timeOfMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeOfMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.timeOfMaskedTextBox.Location = new System.Drawing.Point(182, 44);
            this.timeOfMaskedTextBox.Mask = "00:00";
            this.timeOfMaskedTextBox.Name = "timeOfMaskedTextBox";
            this.timeOfMaskedTextBox.Size = new System.Drawing.Size(240, 26);
            this.timeOfMaskedTextBox.TabIndex = 1;
            this.timeOfMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // AddEditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(436, 272);
            this.Controls.Add(this.timeOfMaskedTextBox);
            this.Controls.Add(timeOfLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(dateOfLabel);
            this.Controls.Add(this.dateOfMaskedTextBox);
            this.Controls.Add(medicalWorkerIDLabel);
            this.Controls.Add(this.medicalWorkerIDComboBox);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(priceListIDLabel);
            this.Controls.Add(this.priceListIDComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая запись";
            this.Load += new System.EventHandler(this.AddEditAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.MaskedTextBox dateOfMaskedTextBox;
        private System.Windows.Forms.ComboBox medicalWorkerIDComboBox;
        private System.Windows.Forms.BindingSource medicalWorkerBindingSource;
        private System.Windows.Forms.ComboBox patientIDComboBox;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.ComboBox priceListIDComboBox;
        private System.Windows.Forms.BindingSource priceListBindingSource;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.MaskedTextBox timeOfMaskedTextBox;
    }
}