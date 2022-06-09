namespace MedLabProj
{
    partial class CurrentAppointmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentAppointmentsForm));
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.medicalWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PriceListIDCost = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editCurrentBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.AllowUserToAddRows = false;
            this.appointmentsDataGridView.AllowUserToDeleteRows = false;
            this.appointmentsDataGridView.AllowUserToResizeColumns = false;
            this.appointmentsDataGridView.AllowUserToResizeRows = false;
            this.appointmentsDataGridView.AutoGenerateColumns = false;
            this.appointmentsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.TimeOf,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.PriceListIDCost});
            this.appointmentsDataGridView.DataSource = this.appointmentsBindingSource;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(12, 89);
            this.appointmentsDataGridView.MultiSelect = false;
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(776, 358);
            this.appointmentsDataGridView.TabIndex = 1;
            this.appointmentsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.appointmentsDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateOf";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TimeOf
            // 
            this.TimeOf.DataPropertyName = "TimeOf";
            this.TimeOf.HeaderText = "Время";
            this.TimeOf.Name = "TimeOf";
            this.TimeOf.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn4.DataSource = this.patientBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Пациент";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(MedLabProj.ModelEF.Patient);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PriceListID";
            this.dataGridViewTextBoxColumn2.DataSource = this.priceListBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Title";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Услуга";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // priceListBindingSource
            // 
            this.priceListBindingSource.DataSource = typeof(MedLabProj.ModelEF.PriceList);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MedicalWorkerID";
            this.dataGridViewTextBoxColumn5.DataSource = this.medicalWorkerBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "Мед. работник";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID";
            // 
            // medicalWorkerBindingSource
            // 
            this.medicalWorkerBindingSource.DataSource = typeof(MedLabProj.ModelEF.MedicalWorker);
            // 
            // PriceListIDCost
            // 
            this.PriceListIDCost.DataPropertyName = "PriceListID";
            this.PriceListIDCost.DataSource = this.priceListBindingSource;
            this.PriceListIDCost.DisplayMember = "Cost";
            this.PriceListIDCost.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PriceListIDCost.HeaderText = "Стоимость, руб.";
            this.PriceListIDCost.Name = "PriceListIDCost";
            this.PriceListIDCost.ReadOnly = true;
            this.PriceListIDCost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceListIDCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PriceListIDCost.ValueMember = "ID";
            this.PriceListIDCost.Width = 80;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataSource = typeof(MedLabProj.ModelEF.Appointments);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.closeBtn.Location = new System.Drawing.Point(654, 453);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(134, 39);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.deleteBtn.Location = new System.Drawing.Point(12, 453);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(134, 39);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editCurrentBtn
            // 
            this.editCurrentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.editCurrentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCurrentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCurrentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.editCurrentBtn.Location = new System.Drawing.Point(489, 453);
            this.editCurrentBtn.Name = "editCurrentBtn";
            this.editCurrentBtn.Size = new System.Drawing.Size(159, 39);
            this.editCurrentBtn.TabIndex = 5;
            this.editCurrentBtn.Text = "Редактировать";
            this.editCurrentBtn.UseVisualStyleBackColor = false;
            this.editCurrentBtn.Click += new System.EventHandler(this.editCurrentBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-7, -4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1165, 10);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(-7, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1165, 10);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 61);
            this.label4.TabIndex = 18;
            this.label4.Text = "Текущие записи";
            // 
            // CurrentAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editCurrentBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.appointmentsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CurrentAppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Текущие записи";
            this.Load += new System.EventHandler(this.CurrentAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.BindingSource priceListBindingSource;
        private System.Windows.Forms.BindingSource medicalWorkerBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOf;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn PriceListIDCost;
        private System.Windows.Forms.Button editCurrentBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}