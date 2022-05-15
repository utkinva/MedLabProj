namespace MedLabProj
{
    partial class MedicalWorkesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalWorkesListForm));
            this.medicalWorkerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.specializationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            this.editCurrentBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalWorkerDataGridView
            // 
            this.medicalWorkerDataGridView.AllowUserToAddRows = false;
            this.medicalWorkerDataGridView.AllowUserToDeleteRows = false;
            this.medicalWorkerDataGridView.AllowUserToResizeColumns = false;
            this.medicalWorkerDataGridView.AllowUserToResizeRows = false;
            this.medicalWorkerDataGridView.AutoGenerateColumns = false;
            this.medicalWorkerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicalWorkerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.medicalWorkerDataGridView.DataSource = this.medicalWorkerBindingSource;
            this.medicalWorkerDataGridView.Location = new System.Drawing.Point(12, 12);
            this.medicalWorkerDataGridView.MultiSelect = false;
            this.medicalWorkerDataGridView.Name = "medicalWorkerDataGridView";
            this.medicalWorkerDataGridView.ReadOnly = true;
            this.medicalWorkerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicalWorkerDataGridView.Size = new System.Drawing.Size(776, 355);
            this.medicalWorkerDataGridView.TabIndex = 1;
            this.medicalWorkerDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.medicalWorkerDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Полное имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SpecializationID";
            this.dataGridViewTextBoxColumn3.DataSource = this.specializationsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Title";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Специализация";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // specializationsBindingSource
            // 
            this.specializationsBindingSource.DataSource = typeof(MedLabProj.ModelEF.Specializations);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WorkingDays";
            this.dataGridViewTextBoxColumn4.HeaderText = "Рабочие дни";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 320;
            // 
            // medicalWorkerBindingSource
            // 
            this.medicalWorkerBindingSource.DataSource = typeof(MedLabProj.ModelEF.MedicalWorker);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(654, 373);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(134, 39);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // editCurrentBtn
            // 
            this.editCurrentBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editCurrentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCurrentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCurrentBtn.Location = new System.Drawing.Point(489, 373);
            this.editCurrentBtn.Name = "editCurrentBtn";
            this.editCurrentBtn.Size = new System.Drawing.Size(159, 39);
            this.editCurrentBtn.TabIndex = 7;
            this.editCurrentBtn.Text = "Редактировать";
            this.editCurrentBtn.UseVisualStyleBackColor = false;
            this.editCurrentBtn.Click += new System.EventHandler(this.editCurrentBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(12, 373);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(134, 39);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // MedicalWorkesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.editCurrentBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.medicalWorkerDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MedicalWorkesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список мед. работников";
            this.Load += new System.EventHandler(this.MedicalWorkesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalWorkerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource medicalWorkerBindingSource;
        private System.Windows.Forms.DataGridView medicalWorkerDataGridView;
        private System.Windows.Forms.BindingSource specializationsBindingSource;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button editCurrentBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}