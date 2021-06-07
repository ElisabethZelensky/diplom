namespace HRDepartment
{
    partial class Form_Login
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
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hRDepartmentDatabaseDataSet = new HRDepartment.HRDepartmentDatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRolesTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.UserRolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(129, 84);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(136, 23);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Вход";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(129, 32);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(136, 20);
            this.textBox_Login.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(33, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Логин";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(129, 58);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(136, 20);
            this.textBox_Password.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hRDepartmentDatabaseDataSet
            // 
            this.hRDepartmentDatabaseDataSet.DataSetName = "HRDepartmentDatabaseDataSet";
            this.hRDepartmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "UserRoles";
            this.userRolesBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // userRolesTableAdapter
            // 
            this.userRolesTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 132);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_Login);
            this.Name = "Form_Login";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label1;
        private HRDepartmentDatabaseDataSet hRDepartmentDatabaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.UserRolesTableAdapter userRolesTableAdapter;
    }
}