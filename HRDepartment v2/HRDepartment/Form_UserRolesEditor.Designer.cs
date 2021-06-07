namespace HRDepartment
{
    partial class Form_UserRolesEditor
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
            this.listBox_Users = new System.Windows.Forms.ListBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDepartmentDatabaseDataSet = new HRDepartment.HRDepartmentDatabaseDataSet();
            this.usersTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.checkBox_IsAdmin = new System.Windows.Forms.CheckBox();
            this.checkBox_IsHR = new System.Windows.Forms.CheckBox();
            this.checkBox_IsDirector = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRolesTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.UserRolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Users
            // 
            this.listBox_Users.DataSource = this.usersBindingSource;
            this.listBox_Users.DisplayMember = "Username";
            this.listBox_Users.FormattingEnabled = true;
            this.listBox_Users.Location = new System.Drawing.Point(0, 0);
            this.listBox_Users.Name = "listBox_Users";
            this.listBox_Users.Size = new System.Drawing.Size(198, 173);
            this.listBox_Users.TabIndex = 0;
            this.listBox_Users.ValueMember = "Id";
            this.listBox_Users.SelectedIndexChanged += new System.EventHandler(this.listBox_Users_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // hRDepartmentDatabaseDataSet
            // 
            this.hRDepartmentDatabaseDataSet.DataSetName = "HRDepartmentDatabaseDataSet";
            this.hRDepartmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox_IsAdmin
            // 
            this.checkBox_IsAdmin.AutoSize = true;
            this.checkBox_IsAdmin.Location = new System.Drawing.Point(206, 23);
            this.checkBox_IsAdmin.Name = "checkBox_IsAdmin";
            this.checkBox_IsAdmin.Size = new System.Drawing.Size(165, 17);
            this.checkBox_IsAdmin.TabIndex = 1;
            this.checkBox_IsAdmin.Text = "Системный администратор";
            this.checkBox_IsAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBox_IsHR
            // 
            this.checkBox_IsHR.AutoSize = true;
            this.checkBox_IsHR.Location = new System.Drawing.Point(206, 55);
            this.checkBox_IsHR.Name = "checkBox_IsHR";
            this.checkBox_IsHR.Size = new System.Drawing.Size(97, 17);
            this.checkBox_IsHR.TabIndex = 2;
            this.checkBox_IsHR.Text = "HR-менеджер";
            this.checkBox_IsHR.UseVisualStyleBackColor = true;
            // 
            // checkBox_IsDirector
            // 
            this.checkBox_IsDirector.AutoSize = true;
            this.checkBox_IsDirector.Location = new System.Drawing.Point(206, 89);
            this.checkBox_IsDirector.Name = "checkBox_IsDirector";
            this.checkBox_IsDirector.Size = new System.Drawing.Size(277, 17);
            this.checkBox_IsDirector.TabIndex = 3;
            this.checkBox_IsDirector.Text = "Зам. директора по административным вопросам";
            this.checkBox_IsDirector.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(206, 138);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(167, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
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
            // Form_UserRolesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 173);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.checkBox_IsDirector);
            this.Controls.Add(this.checkBox_IsHR);
            this.Controls.Add(this.checkBox_IsAdmin);
            this.Controls.Add(this.listBox_Users);
            this.Name = "Form_UserRolesEditor";
            this.Text = "Управление ролями пользователей";
            this.Load += new System.EventHandler(this.Form_UserRolesEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Users;
        private HRDepartmentDatabaseDataSet hRDepartmentDatabaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.CheckBox checkBox_IsAdmin;
        private System.Windows.Forms.CheckBox checkBox_IsHR;
        private System.Windows.Forms.CheckBox checkBox_IsDirector;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.UserRolesTableAdapter userRolesTableAdapter;
    }
}