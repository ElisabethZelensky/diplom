namespace HRDepartment
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_lists = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторДепартаментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторОтделовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторДолжностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_employees = new System.Windows.Forms.ToolStripMenuItem();
            this.физическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеСотрудникамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоВакансиямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоСотрудникамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_administration = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеРолямиПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView_Departments = new System.Windows.Forms.TreeView();
            this.panel_Person = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Salary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_EmploymentDate = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_Files = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_INN = new System.Windows.Forms.Label();
            this.label_ContractNumber = new System.Windows.Forms.Label();
            this.pictureBox_Photo = new System.Windows.Forms.PictureBox();
            this.label_Department = new System.Windows.Forms.Label();
            this.label_Division = new System.Windows.Forms.Label();
            this.label_Post = new System.Windows.Forms.Label();
            this.label_FullName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hRDepartmentDatabaseDataSet = new HRDepartment.HRDepartmentDatabaseDataSet();
            this.depatmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depatmentsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.DepatmentsTableAdapter();
            this.tableAdapterManager1 = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager();
            this.divisionsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.DivisionsTableAdapter();
            this.divisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.PostsTableAdapter();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.PersonsTableAdapter();
            this.personDocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personDocumentsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.PersonDocumentsTableAdapter();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выгрузитьНаКомпьютерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_RefreshTreeview = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_Person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depatmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDocumentsBindingSource)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_lists,
            this.menu_employees,
            this.menu_reports,
            this.menu_administration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_lists
            // 
            this.menu_lists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторДепартаментовToolStripMenuItem,
            this.редакторОтделовToolStripMenuItem,
            this.редакторДолжностейToolStripMenuItem});
            this.menu_lists.Name = "menu_lists";
            this.menu_lists.Size = new System.Drawing.Size(94, 20);
            this.menu_lists.Text = "Справочники";
            // 
            // редакторДепартаментовToolStripMenuItem
            // 
            this.редакторДепартаментовToolStripMenuItem.Name = "редакторДепартаментовToolStripMenuItem";
            this.редакторДепартаментовToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.редакторДепартаментовToolStripMenuItem.Text = "Редактор департаментов";
            this.редакторДепартаментовToolStripMenuItem.Click += new System.EventHandler(this.редакторДепартаментовToolStripMenuItem_Click);
            // 
            // редакторОтделовToolStripMenuItem
            // 
            this.редакторОтделовToolStripMenuItem.Name = "редакторОтделовToolStripMenuItem";
            this.редакторОтделовToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.редакторОтделовToolStripMenuItem.Text = "Редактор отделов";
            this.редакторОтделовToolStripMenuItem.Click += new System.EventHandler(this.редакторОтделовToolStripMenuItem_Click);
            // 
            // редакторДолжностейToolStripMenuItem
            // 
            this.редакторДолжностейToolStripMenuItem.Name = "редакторДолжностейToolStripMenuItem";
            this.редакторДолжностейToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.редакторДолжностейToolStripMenuItem.Text = "Редактор должностей";
            this.редакторДолжностейToolStripMenuItem.Click += new System.EventHandler(this.редакторДолжностейToolStripMenuItem_Click);
            // 
            // menu_employees
            // 
            this.menu_employees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.физическиеЛицаToolStripMenuItem,
            this.управлениеСотрудникамиToolStripMenuItem});
            this.menu_employees.Name = "menu_employees";
            this.menu_employees.Size = new System.Drawing.Size(85, 20);
            this.menu_employees.Text = "Сотрудники";
            // 
            // физическиеЛицаToolStripMenuItem
            // 
            this.физическиеЛицаToolStripMenuItem.Name = "физическиеЛицаToolStripMenuItem";
            this.физическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.физическиеЛицаToolStripMenuItem.Text = "Физические лица";
            this.физическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.физическиеЛицаToolStripMenuItem_Click);
            // 
            // управлениеСотрудникамиToolStripMenuItem
            // 
            this.управлениеСотрудникамиToolStripMenuItem.Name = "управлениеСотрудникамиToolStripMenuItem";
            this.управлениеСотрудникамиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.управлениеСотрудникамиToolStripMenuItem.Text = "Управление сотрудниками";
            this.управлениеСотрудникамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеСотрудникамиToolStripMenuItem_Click);
            // 
            // menu_reports
            // 
            this.menu_reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетПоВакансиямToolStripMenuItem,
            this.отчетПоСотрудникамToolStripMenuItem});
            this.menu_reports.Name = "menu_reports";
            this.menu_reports.Size = new System.Drawing.Size(60, 20);
            this.menu_reports.Text = "Отчеты";
            // 
            // отчетПоВакансиямToolStripMenuItem
            // 
            this.отчетПоВакансиямToolStripMenuItem.Name = "отчетПоВакансиямToolStripMenuItem";
            this.отчетПоВакансиямToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.отчетПоВакансиямToolStripMenuItem.Text = "Отчет по вакансиям";
            this.отчетПоВакансиямToolStripMenuItem.Click += new System.EventHandler(this.отчетПоВакансиямToolStripMenuItem_Click);
            // 
            // отчетПоСотрудникамToolStripMenuItem
            // 
            this.отчетПоСотрудникамToolStripMenuItem.Name = "отчетПоСотрудникамToolStripMenuItem";
            this.отчетПоСотрудникамToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.отчетПоСотрудникамToolStripMenuItem.Text = "Отчет по сотрудникам";
            this.отчетПоСотрудникамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоСотрудникамToolStripMenuItem_Click);
            // 
            // menu_administration
            // 
            this.menu_administration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеПользователямиToolStripMenuItem,
            this.управлениеРолямиПользователейToolStripMenuItem});
            this.menu_administration.Name = "menu_administration";
            this.menu_administration.Size = new System.Drawing.Size(134, 20);
            this.menu_administration.Text = "Администрирование";
            // 
            // управлениеПользователямиToolStripMenuItem
            // 
            this.управлениеПользователямиToolStripMenuItem.Name = "управлениеПользователямиToolStripMenuItem";
            this.управлениеПользователямиToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.управлениеПользователямиToolStripMenuItem.Text = "Управление пользователями";
            this.управлениеПользователямиToolStripMenuItem.Click += new System.EventHandler(this.управлениеПользователямиToolStripMenuItem_Click);
            // 
            // управлениеРолямиПользователейToolStripMenuItem
            // 
            this.управлениеРолямиПользователейToolStripMenuItem.Name = "управлениеРолямиПользователейToolStripMenuItem";
            this.управлениеРолямиПользователейToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.управлениеРолямиПользователейToolStripMenuItem.Text = "Управление ролями пользователей";
            this.управлениеРолямиПользователейToolStripMenuItem.Click += new System.EventHandler(this.управлениеРолямиПользователейToolStripMenuItem_Click);
            // 
            // treeView_Departments
            // 
            this.treeView_Departments.Location = new System.Drawing.Point(0, 27);
            this.treeView_Departments.Name = "treeView_Departments";
            this.treeView_Departments.Size = new System.Drawing.Size(225, 401);
            this.treeView_Departments.TabIndex = 1;
            this.treeView_Departments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Departments_AfterSelect);
            // 
            // panel_Person
            // 
            this.panel_Person.Controls.Add(this.label6);
            this.panel_Person.Controls.Add(this.label_Salary);
            this.panel_Person.Controls.Add(this.label5);
            this.panel_Person.Controls.Add(this.label4);
            this.panel_Person.Controls.Add(this.label_EmploymentDate);
            this.panel_Person.Controls.Add(this.label_Status);
            this.panel_Person.Controls.Add(this.label3);
            this.panel_Person.Controls.Add(this.listView_Files);
            this.panel_Person.Controls.Add(this.label2);
            this.panel_Person.Controls.Add(this.label1);
            this.panel_Person.Controls.Add(this.label_INN);
            this.panel_Person.Controls.Add(this.label_ContractNumber);
            this.panel_Person.Controls.Add(this.pictureBox_Photo);
            this.panel_Person.Controls.Add(this.label_Department);
            this.panel_Person.Controls.Add(this.label_Division);
            this.panel_Person.Controls.Add(this.label_Post);
            this.panel_Person.Controls.Add(this.label_FullName);
            this.panel_Person.Location = new System.Drawing.Point(231, 27);
            this.panel_Person.Name = "panel_Person";
            this.panel_Person.Size = new System.Drawing.Size(557, 423);
            this.panel_Person.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Оклад";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Salary
            // 
            this.label_Salary.Location = new System.Drawing.Point(145, 252);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(114, 17);
            this.label_Salary.TabIndex = 25;
            this.label_Salary.Text = "Оклад";
            this.label_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Детали";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Дата принятия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_EmploymentDate
            // 
            this.label_EmploymentDate.Location = new System.Drawing.Point(145, 226);
            this.label_EmploymentDate.Name = "label_EmploymentDate";
            this.label_EmploymentDate.Size = new System.Drawing.Size(114, 17);
            this.label_EmploymentDate.TabIndex = 22;
            this.label_EmploymentDate.Text = "Дата принятия";
            this.label_EmploymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Status
            // 
            this.label_Status.Location = new System.Drawing.Point(173, 127);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(361, 17);
            this.label_Status.TabIndex = 21;
            this.label_Status.Text = "Статус";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(296, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Документы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView_Files
            // 
            this.listView_Files.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_Files.BackColor = System.Drawing.SystemColors.Control;
            this.listView_Files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Files.FullRowSelect = true;
            this.listView_Files.HideSelection = false;
            this.listView_Files.Location = new System.Drawing.Point(299, 199);
            this.listView_Files.MultiSelect = false;
            this.listView_Files.Name = "listView_Files";
            this.listView_Files.Size = new System.Drawing.Size(255, 163);
            this.listView_Files.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_Files.TabIndex = 3;
            this.listView_Files.UseCompatibleStateImageBehavior = false;
            this.listView_Files.View = System.Windows.Forms.View.List;
            this.listView_Files.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Files_MouseClick);
            this.listView_Files.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Files_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "ИНН";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "№ договора";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_INN
            // 
            this.label_INN.Location = new System.Drawing.Point(145, 280);
            this.label_INN.Name = "label_INN";
            this.label_INN.Size = new System.Drawing.Size(114, 17);
            this.label_INN.TabIndex = 15;
            this.label_INN.Text = "ИНН";
            this.label_INN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ContractNumber
            // 
            this.label_ContractNumber.Location = new System.Drawing.Point(145, 199);
            this.label_ContractNumber.Name = "label_ContractNumber";
            this.label_ContractNumber.Size = new System.Drawing.Size(114, 17);
            this.label_ContractNumber.TabIndex = 14;
            this.label_ContractNumber.Text = "№ договора";
            this.label_ContractNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_Photo
            // 
            this.pictureBox_Photo.Image = global::HRDepartment.Properties.Resources.person;
            this.pictureBox_Photo.Location = new System.Drawing.Point(28, 22);
            this.pictureBox_Photo.Name = "pictureBox_Photo";
            this.pictureBox_Photo.Size = new System.Drawing.Size(138, 122);
            this.pictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Photo.TabIndex = 13;
            this.pictureBox_Photo.TabStop = false;
            // 
            // label_Department
            // 
            this.label_Department.Location = new System.Drawing.Point(173, 103);
            this.label_Department.Name = "label_Department";
            this.label_Department.Size = new System.Drawing.Size(361, 17);
            this.label_Department.TabIndex = 12;
            this.label_Department.Text = "Департамент";
            this.label_Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Division
            // 
            this.label_Division.Location = new System.Drawing.Point(173, 78);
            this.label_Division.Name = "label_Division";
            this.label_Division.Size = new System.Drawing.Size(361, 17);
            this.label_Division.TabIndex = 11;
            this.label_Division.Text = "Отдел";
            this.label_Division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Post
            // 
            this.label_Post.Location = new System.Drawing.Point(173, 54);
            this.label_Post.Name = "label_Post";
            this.label_Post.Size = new System.Drawing.Size(361, 17);
            this.label_Post.TabIndex = 10;
            this.label_Post.Text = "Должность";
            this.label_Post.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FullName
            // 
            this.label_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FullName.Location = new System.Drawing.Point(172, 20);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(361, 24);
            this.label_FullName.TabIndex = 9;
            this.label_FullName.Text = "ФИО";
            this.label_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // hRDepartmentDatabaseDataSet
            // 
            this.hRDepartmentDatabaseDataSet.DataSetName = "HRDepartmentDatabaseDataSet";
            this.hRDepartmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depatmentsBindingSource
            // 
            this.depatmentsBindingSource.DataMember = "Depatments";
            this.depatmentsBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // depatmentsTableAdapter
            // 
            this.depatmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DepatmentsTableAdapter = this.depatmentsTableAdapter;
            this.tableAdapterManager1.DivisionsTableAdapter = this.divisionsTableAdapter;
            this.tableAdapterManager1.EmployeesTableAdapter = null;
            this.tableAdapterManager1.PersonDocumentsTableAdapter = null;
            this.tableAdapterManager1.PersonsTableAdapter = null;
            this.tableAdapterManager1.PostsTableAdapter = null;
            this.tableAdapterManager1.StatusesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserRolesTableAdapter = null;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // divisionsTableAdapter
            // 
            this.divisionsTableAdapter.ClearBeforeFill = true;
            // 
            // divisionsBindingSource
            // 
            this.divisionsBindingSource.DataMember = "Divisions";
            this.divisionsBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
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
            // personDocumentsBindingSource
            // 
            this.personDocumentsBindingSource.DataMember = "PersonDocuments";
            this.personDocumentsBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // personDocumentsTableAdapter
            // 
            this.personDocumentsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузитьНаКомпьютерToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(214, 26);
            // 
            // выгрузитьНаКомпьютерToolStripMenuItem
            // 
            this.выгрузитьНаКомпьютерToolStripMenuItem.Name = "выгрузитьНаКомпьютерToolStripMenuItem";
            this.выгрузитьНаКомпьютерToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.выгрузитьНаКомпьютерToolStripMenuItem.Text = "Выгрузить на компьютер";
            this.выгрузитьНаКомпьютерToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьНаКомпьютерToolStripMenuItem_Click);
            // 
            // button_RefreshTreeview
            // 
            this.button_RefreshTreeview.Location = new System.Drawing.Point(0, 427);
            this.button_RefreshTreeview.Name = "button_RefreshTreeview";
            this.button_RefreshTreeview.Size = new System.Drawing.Size(225, 23);
            this.button_RefreshTreeview.TabIndex = 3;
            this.button_RefreshTreeview.Text = "Обновить структуру";
            this.button_RefreshTreeview.UseVisualStyleBackColor = true;
            this.button_RefreshTreeview.Click += new System.EventHandler(this.button_RefreshTreeview_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_RefreshTreeview);
            this.Controls.Add(this.panel_Person);
            this.Controls.Add(this.treeView_Departments);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "АИС отдела кадров";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Person.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depatmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDocumentsBindingSource)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_lists;
        private System.Windows.Forms.ToolStripMenuItem редакторДепартаментовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторОтделовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторДолжностейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_employees;
        private System.Windows.Forms.ToolStripMenuItem физическиеЛицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеСотрудникамиToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView_Departments;
        private HRDepartmentDatabaseDataSet hRDepartmentDatabaseDataSet;
        private System.Windows.Forms.BindingSource depatmentsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.DepatmentsTableAdapter depatmentsTableAdapter;
        private HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HRDepartmentDatabaseDataSetTableAdapters.DivisionsTableAdapter divisionsTableAdapter;
        private System.Windows.Forms.BindingSource divisionsBindingSource;
        private System.Windows.Forms.Panel panel_Person;
        private System.Windows.Forms.ToolStripMenuItem menu_reports;
        private System.Windows.Forms.ToolStripMenuItem отчетПоВакансиямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоСотрудникамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_administration;
        private System.Windows.Forms.ToolStripMenuItem управлениеПользователямиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.PictureBox pictureBox_Photo;
        private System.Windows.Forms.Label label_Department;
        private System.Windows.Forms.Label label_Division;
        private System.Windows.Forms.Label label_Post;
        private System.Windows.Forms.Label label_INN;
        private System.Windows.Forms.Label label_ContractNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_Files;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.BindingSource personDocumentsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.PersonDocumentsTableAdapter personDocumentsTableAdapter;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_EmploymentDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьНаКомпьютерToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Salary;
        private System.Windows.Forms.ToolStripMenuItem управлениеРолямиПользователейToolStripMenuItem;
        private System.Windows.Forms.Button button_RefreshTreeview;
    }
}

