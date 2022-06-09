namespace MedLabProj
{
    partial class AddNewUserForm
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userTypeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUserForm));
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.userTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.userTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userTypeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            loginLabel.Location = new System.Drawing.Point(12, 14);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(69, 24);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            passwordLabel.Location = new System.Drawing.Point(12, 46);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(81, 24);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль:";
            // 
            // userTypeIDLabel
            // 
            userTypeIDLabel.AutoSize = true;
            userTypeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            userTypeIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            userTypeIDLabel.Location = new System.Drawing.Point(12, 82);
            userTypeIDLabel.Name = "userTypeIDLabel";
            userTypeIDLabel.Size = new System.Drawing.Size(180, 24);
            userTypeIDLabel.TabIndex = 8;
            userTypeIDLabel.Text = "Тип пользователя:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Login", true));
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.ForeColor = System.Drawing.Color.White;
            this.loginTextBox.Location = new System.Drawing.Point(233, 14);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(182, 26);
            this.loginTextBox.TabIndex = 2;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(MedLabProj.ModelEF.Users);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(233, 46);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(182, 26);
            this.passwordTextBox.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.saveBtn.Location = new System.Drawing.Point(16, 117);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 39);
            this.saveBtn.TabIndex = 7;
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
            this.closeBtn.Location = new System.Drawing.Point(304, 117);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(111, 39);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // userTypeIDComboBox
            // 
            this.userTypeIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.userTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "UserTypeID", true));
            this.userTypeIDComboBox.DataSource = this.userTypesBindingSource;
            this.userTypeIDComboBox.DisplayMember = "Title";
            this.userTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userTypeIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTypeIDComboBox.ForeColor = System.Drawing.Color.White;
            this.userTypeIDComboBox.FormattingEnabled = true;
            this.userTypeIDComboBox.Location = new System.Drawing.Point(233, 78);
            this.userTypeIDComboBox.Name = "userTypeIDComboBox";
            this.userTypeIDComboBox.Size = new System.Drawing.Size(182, 28);
            this.userTypeIDComboBox.TabIndex = 9;
            this.userTypeIDComboBox.ValueMember = "ID";
            // 
            // userTypesBindingSource
            // 
            this.userTypesBindingSource.DataSource = typeof(MedLabProj.ModelEF.UserTypes);
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(427, 164);
            this.Controls.Add(userTypeIDLabel);
            this.Controls.Add(this.userTypeIDComboBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый пользователь";
            this.Load += new System.EventHandler(this.AddEditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox userTypeIDComboBox;
        private System.Windows.Forms.BindingSource userTypesBindingSource;
    }
}