namespace HRDepartment
{
    partial class Form_PersonsEditor
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
            this.listView_Persons = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Person = new System.Windows.Forms.Panel();
            this.button_DeletePhoto = new System.Windows.Forms.Button();
            this.pictureBox_Photo = new System.Windows.Forms.PictureBox();
            this.button_PersonDocuments = new System.Windows.Forms.Button();
            this.button_UploadFile = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_FamilyStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_PassportIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Birthday = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_INN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_PostIndex = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_PassportRegistrationAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_PassportIssuedBy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_PassportNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_PassportSeries = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MiddleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip_PersonsListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hRDepartmentDatabaseDataSet = new HRDepartment.HRDepartmentDatabaseDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.PersonsTableAdapter();
            this.tableAdapterManager1 = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager();
            this.button_AddNew = new System.Windows.Forms.Button();
            this.panel_Person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).BeginInit();
            this.contextMenuStrip_PersonsListview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Persons
            // 
            this.listView_Persons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Persons.FullRowSelect = true;
            this.listView_Persons.HideSelection = false;
            this.listView_Persons.Location = new System.Drawing.Point(0, 1);
            this.listView_Persons.MultiSelect = false;
            this.listView_Persons.Name = "listView_Persons";
            this.listView_Persons.Size = new System.Drawing.Size(225, 424);
            this.listView_Persons.TabIndex = 0;
            this.listView_Persons.UseCompatibleStateImageBehavior = false;
            this.listView_Persons.View = System.Windows.Forms.View.Details;
            this.listView_Persons.SelectedIndexChanged += new System.EventHandler(this.listView_Persons_SelectedIndexChanged);
            this.listView_Persons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Persons_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО";
            this.columnHeader1.Width = 219;
            // 
            // panel_Person
            // 
            this.panel_Person.Controls.Add(this.button_DeletePhoto);
            this.panel_Person.Controls.Add(this.pictureBox_Photo);
            this.panel_Person.Controls.Add(this.button_PersonDocuments);
            this.panel_Person.Controls.Add(this.button_UploadFile);
            this.panel_Person.Controls.Add(this.button_Save);
            this.panel_Person.Controls.Add(this.comboBox_FamilyStatus);
            this.panel_Person.Controls.Add(this.dateTimePicker_PassportIssuedDate);
            this.panel_Person.Controls.Add(this.dateTimePicker_Birthday);
            this.panel_Person.Controls.Add(this.label14);
            this.panel_Person.Controls.Add(this.textBox_INN);
            this.panel_Person.Controls.Add(this.label13);
            this.panel_Person.Controls.Add(this.textBox_Phone);
            this.panel_Person.Controls.Add(this.label12);
            this.panel_Person.Controls.Add(this.textBox_PostIndex);
            this.panel_Person.Controls.Add(this.label11);
            this.panel_Person.Controls.Add(this.textBox_Address);
            this.panel_Person.Controls.Add(this.label9);
            this.panel_Person.Controls.Add(this.textBox_PassportRegistrationAddress);
            this.panel_Person.Controls.Add(this.label10);
            this.panel_Person.Controls.Add(this.label7);
            this.panel_Person.Controls.Add(this.textBox_PassportIssuedBy);
            this.panel_Person.Controls.Add(this.label8);
            this.panel_Person.Controls.Add(this.textBox_PassportNumber);
            this.panel_Person.Controls.Add(this.label5);
            this.panel_Person.Controls.Add(this.textBox_PassportSeries);
            this.panel_Person.Controls.Add(this.label6);
            this.panel_Person.Controls.Add(this.label3);
            this.panel_Person.Controls.Add(this.textBox_MiddleName);
            this.panel_Person.Controls.Add(this.label4);
            this.panel_Person.Controls.Add(this.textBox_FirstName);
            this.panel_Person.Controls.Add(this.label2);
            this.panel_Person.Controls.Add(this.textBox_LastName);
            this.panel_Person.Controls.Add(this.label1);
            this.panel_Person.Location = new System.Drawing.Point(231, 1);
            this.panel_Person.Name = "panel_Person";
            this.panel_Person.Size = new System.Drawing.Size(557, 449);
            this.panel_Person.TabIndex = 3;
            // 
            // button_DeletePhoto
            // 
            this.button_DeletePhoto.Location = new System.Drawing.Point(14, 144);
            this.button_DeletePhoto.Name = "button_DeletePhoto";
            this.button_DeletePhoto.Size = new System.Drawing.Size(111, 23);
            this.button_DeletePhoto.TabIndex = 34;
            this.button_DeletePhoto.Text = "Удалить фото";
            this.button_DeletePhoto.UseVisualStyleBackColor = true;
            this.button_DeletePhoto.Click += new System.EventHandler(this.button_DeletePhoto_Click);
            // 
            // pictureBox_Photo
            // 
            this.pictureBox_Photo.Location = new System.Drawing.Point(14, 19);
            this.pictureBox_Photo.Name = "pictureBox_Photo";
            this.pictureBox_Photo.Size = new System.Drawing.Size(111, 90);
            this.pictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Photo.TabIndex = 34;
            this.pictureBox_Photo.TabStop = false;
            // 
            // button_PersonDocuments
            // 
            this.button_PersonDocuments.Location = new System.Drawing.Point(310, 385);
            this.button_PersonDocuments.Name = "button_PersonDocuments";
            this.button_PersonDocuments.Size = new System.Drawing.Size(244, 23);
            this.button_PersonDocuments.TabIndex = 33;
            this.button_PersonDocuments.Text = "Управление документами";
            this.button_PersonDocuments.UseVisualStyleBackColor = true;
            this.button_PersonDocuments.Click += new System.EventHandler(this.button_PersonDocuments_Click);
            // 
            // button_UploadFile
            // 
            this.button_UploadFile.Location = new System.Drawing.Point(14, 115);
            this.button_UploadFile.Name = "button_UploadFile";
            this.button_UploadFile.Size = new System.Drawing.Size(111, 23);
            this.button_UploadFile.TabIndex = 32;
            this.button_UploadFile.Text = "Загрузить фото";
            this.button_UploadFile.UseVisualStyleBackColor = true;
            this.button_UploadFile.Click += new System.EventHandler(this.button_UploadFile_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(310, 414);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(244, 23);
            this.button_Save.TabIndex = 31;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_FamilyStatus
            // 
            this.comboBox_FamilyStatus.FormattingEnabled = true;
            this.comboBox_FamilyStatus.Items.AddRange(new object[] {
            "женат (замужем)",
            "не женат (не замужем)",
            "разведен (разведена)"});
            this.comboBox_FamilyStatus.Location = new System.Drawing.Point(310, 358);
            this.comboBox_FamilyStatus.Name = "comboBox_FamilyStatus";
            this.comboBox_FamilyStatus.Size = new System.Drawing.Size(244, 21);
            this.comboBox_FamilyStatus.TabIndex = 30;
            // 
            // dateTimePicker_PassportIssuedDate
            // 
            this.dateTimePicker_PassportIssuedDate.Location = new System.Drawing.Point(310, 201);
            this.dateTimePicker_PassportIssuedDate.Name = "dateTimePicker_PassportIssuedDate";
            this.dateTimePicker_PassportIssuedDate.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker_PassportIssuedDate.TabIndex = 29;
            // 
            // dateTimePicker_Birthday
            // 
            this.dateTimePicker_Birthday.Location = new System.Drawing.Point(310, 98);
            this.dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            this.dateTimePicker_Birthday.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker_Birthday.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(126, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Семейное положение";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_INN
            // 
            this.textBox_INN.Location = new System.Drawing.Point(310, 331);
            this.textBox_INN.Name = "textBox_INN";
            this.textBox_INN.Size = new System.Drawing.Size(244, 20);
            this.textBox_INN.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(126, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "ИНН";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(310, 305);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(244, 20);
            this.textBox_Phone.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(126, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Номер телефона";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_PostIndex
            // 
            this.textBox_PostIndex.Location = new System.Drawing.Point(310, 279);
            this.textBox_PostIndex.Name = "textBox_PostIndex";
            this.textBox_PostIndex.Size = new System.Drawing.Size(244, 20);
            this.textBox_PostIndex.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(126, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Почтовый индекс";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(310, 253);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(244, 20);
            this.textBox_Address.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(126, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Адрес проживания";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_PassportRegistrationAddress
            // 
            this.textBox_PassportRegistrationAddress.Location = new System.Drawing.Point(310, 227);
            this.textBox_PassportRegistrationAddress.Name = "textBox_PassportRegistrationAddress";
            this.textBox_PassportRegistrationAddress.Size = new System.Drawing.Size(244, 20);
            this.textBox_PassportRegistrationAddress.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(126, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Адрес прописки";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(126, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата выдачи";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_PassportIssuedBy
            // 
            this.textBox_PassportIssuedBy.Location = new System.Drawing.Point(310, 175);
            this.textBox_PassportIssuedBy.Name = "textBox_PassportIssuedBy";
            this.textBox_PassportIssuedBy.Size = new System.Drawing.Size(244, 20);
            this.textBox_PassportIssuedBy.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(126, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Кем выдан";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_PassportNumber
            // 
            this.textBox_PassportNumber.Location = new System.Drawing.Point(310, 149);
            this.textBox_PassportNumber.Name = "textBox_PassportNumber";
            this.textBox_PassportNumber.Size = new System.Drawing.Size(244, 20);
            this.textBox_PassportNumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(126, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_PassportSeries
            // 
            this.textBox_PassportSeries.Location = new System.Drawing.Point(310, 123);
            this.textBox_PassportSeries.Name = "textBox_PassportSeries";
            this.textBox_PassportSeries.Size = new System.Drawing.Size(244, 20);
            this.textBox_PassportSeries.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(126, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Серия";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(126, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MiddleName
            // 
            this.textBox_MiddleName.Location = new System.Drawing.Point(310, 71);
            this.textBox_MiddleName.Name = "textBox_MiddleName";
            this.textBox_MiddleName.Size = new System.Drawing.Size(244, 20);
            this.textBox_MiddleName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(126, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Отчество";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(310, 45);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(244, 20);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(126, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(310, 19);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(244, 20);
            this.textBox_LastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip_PersonsListview
            // 
            this.contextMenuStrip_PersonsListview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip_PersonsListview.Name = "contextMenuStrip_PersonsListview";
            this.contextMenuStrip_PersonsListview.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // hRDepartmentDatabaseDataSet
            // 
            this.hRDepartmentDatabaseDataSet.DataSetName = "HRDepartmentDatabaseDataSet";
            this.hRDepartmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DepatmentsTableAdapter = null;
            this.tableAdapterManager1.DivisionsTableAdapter = null;
            this.tableAdapterManager1.EmployeesTableAdapter = null;
            this.tableAdapterManager1.PersonDocumentsTableAdapter = null;
            this.tableAdapterManager1.PersonsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager1.PostsTableAdapter = null;
            this.tableAdapterManager1.StatusesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserRolesTableAdapter = null;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // button_AddNew
            // 
            this.button_AddNew.Location = new System.Drawing.Point(0, 424);
            this.button_AddNew.Name = "button_AddNew";
            this.button_AddNew.Size = new System.Drawing.Size(225, 23);
            this.button_AddNew.TabIndex = 35;
            this.button_AddNew.Text = "Добавить";
            this.button_AddNew.UseVisualStyleBackColor = true;
            this.button_AddNew.Click += new System.EventHandler(this.button_AddNew_Click);
            // 
            // Form_PersonsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_AddNew);
            this.Controls.Add(this.panel_Person);
            this.Controls.Add(this.listView_Persons);
            this.Name = "Form_PersonsEditor";
            this.Text = "Редактор физических лиц";
            this.panel_Person.ResumeLayout(false);
            this.panel_Person.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).EndInit();
            this.contextMenuStrip_PersonsListview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Persons;
        private System.Windows.Forms.Panel panel_Person;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ComboBox comboBox_FamilyStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PassportIssuedDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthday;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_INN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_PostIndex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_PassportRegistrationAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_PassportIssuedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_PassportNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_PassportSeries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MiddleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label1;
        private HRDepartmentDatabaseDataSet hRDepartmentDatabaseDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button_UploadFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_PersonsListview;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button button_PersonDocuments;
        private System.Windows.Forms.PictureBox pictureBox_Photo;
        private System.Windows.Forms.Button button_DeletePhoto;
        private System.Windows.Forms.Button button_AddNew;
    }
}