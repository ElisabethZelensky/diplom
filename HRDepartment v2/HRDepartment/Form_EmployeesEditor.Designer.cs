using System;
using System.Windows.Forms;

namespace HRDepartment
{
    partial class Form_EmployeesEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EmployeesEditor));
            this.treeView_Departments = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new HRDepartment.CalendarColumn();
            this.calendarColumn1 = new HRDepartment.CalendarColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDepartmentDatabaseDataSet = new HRDepartment.HRDepartmentDatabaseDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depatmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depatmentsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.DepatmentsTableAdapter();
            this.divisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.divisionsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.DivisionsTableAdapter();
            this.employeesTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.personsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.PersonsTableAdapter();
            this.postsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.PostsTableAdapter();
            this.statusesTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.StatusesTableAdapter();
            this.tableAdapterManager1 = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.postIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDateDataGridViewTextBoxColumn = new HRDepartment.CalendarColumn();
            this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dismissalDateDataGridViewTextBoxColumn = new HRDepartment.CalendarColumn();
            this.dismissalReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Documents = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depatmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_Departments
            // 
            this.treeView_Departments.Location = new System.Drawing.Point(-1, 1);
            this.treeView_Departments.Name = "treeView_Departments";
            this.treeView_Departments.Size = new System.Drawing.Size(225, 449);
            this.treeView_Departments.TabIndex = 2;
            this.treeView_Departments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Departments_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.personIdDataGridViewTextBoxColumn,
            this.postIdDataGridViewTextBoxColumn,
            this.statusIdDataGridViewTextBoxColumn,
            this.contractNumberDataGridViewTextBoxColumn,
            this.employmentDateDataGridViewTextBoxColumn,
            this.SalaryColumn,
            this.dismissalDateDataGridViewTextBoxColumn,
            this.dismissalReasonDataGridViewTextBoxColumn,
            this.Column_Documents});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(226, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1009, 419);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.employeesBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton_Save});
            this.bindingNavigator1.Location = new System.Drawing.Point(227, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(286, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = global::HRDepartment.Properties.Resources.save;
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Save.Text = "toolStripButton1";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ContractNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер контракта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmploymentDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата назначения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "DismissalDate";
            this.calendarColumn1.HeaderText = "Дата увольнения";
            this.calendarColumn1.Name = "calendarColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DismissalReason";
            this.dataGridViewTextBoxColumn4.HeaderText = "Причина увольнения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
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
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "Statuses";
            this.statusesBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
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
            // divisionsBindingSource
            // 
            this.divisionsBindingSource.DataMember = "Divisions";
            this.divisionsBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // divisionsTableAdapter
            // 
            this.divisionsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // statusesTableAdapter
            // 
            this.statusesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DepatmentsTableAdapter = this.depatmentsTableAdapter;
            this.tableAdapterManager1.DivisionsTableAdapter = this.divisionsTableAdapter;
            this.tableAdapterManager1.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager1.PersonDocumentsTableAdapter = null;
            this.tableAdapterManager1.PersonsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager1.PostsTableAdapter = this.postsTableAdapter;
            this.tableAdapterManager1.StatusesTableAdapter = this.statusesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 40;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.DataSource = this.personsBindingSource;
            this.personIdDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "Физ лицо";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.personIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.personIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            this.postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            this.postIdDataGridViewTextBoxColumn.DataSource = this.postsBindingSource;
            this.postIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.postIdDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            this.postIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.postIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.postIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // statusIdDataGridViewTextBoxColumn
            // 
            this.statusIdDataGridViewTextBoxColumn.DataPropertyName = "StatusId";
            this.statusIdDataGridViewTextBoxColumn.DataSource = this.statusesBindingSource;
            this.statusIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.statusIdDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            this.statusIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // contractNumberDataGridViewTextBoxColumn
            // 
            this.contractNumberDataGridViewTextBoxColumn.DataPropertyName = "ContractNumber";
            this.contractNumberDataGridViewTextBoxColumn.HeaderText = "Номер контракта";
            this.contractNumberDataGridViewTextBoxColumn.Name = "contractNumberDataGridViewTextBoxColumn";
            // 
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.DataPropertyName = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.HeaderText = "Дата назначения";
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            // 
            // SalaryColumn
            // 
            this.SalaryColumn.DataPropertyName = "Salary";
            this.SalaryColumn.HeaderText = "Оклад";
            this.SalaryColumn.Name = "SalaryColumn";
            // 
            // dismissalDateDataGridViewTextBoxColumn
            // 
            this.dismissalDateDataGridViewTextBoxColumn.DataPropertyName = "DismissalDate";
            this.dismissalDateDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            this.dismissalDateDataGridViewTextBoxColumn.Name = "dismissalDateDataGridViewTextBoxColumn";
            // 
            // dismissalReasonDataGridViewTextBoxColumn
            // 
            this.dismissalReasonDataGridViewTextBoxColumn.DataPropertyName = "DismissalReason";
            this.dismissalReasonDataGridViewTextBoxColumn.HeaderText = "Причина увольнения";
            this.dismissalReasonDataGridViewTextBoxColumn.Name = "dismissalReasonDataGridViewTextBoxColumn";
            // 
            // Column_Documents
            // 
            this.Column_Documents.DataPropertyName = "Id";
            this.Column_Documents.HeaderText = "Документы";
            this.Column_Documents.Name = "Column_Documents";
            this.Column_Documents.ReadOnly = true;
            this.Column_Documents.Text = "Документы";
            this.Column_Documents.ToolTipText = "Документы";
            this.Column_Documents.UseColumnTextForButtonValue = true;
            this.Column_Documents.Width = 75;
            // 
            // Form_EmployeesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView_Departments);
            this.Name = "Form_EmployeesEditor";
            this.Text = "Редактор сотрудников";
            this.Load += new System.EventHandler(this.Form_EmployeesEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depatmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
        #endregion

        private System.Windows.Forms.TreeView treeView_Departments;
        private HRDepartmentDatabaseDataSet hRDepartmentDatabaseDataSet;
        private System.Windows.Forms.BindingSource depatmentsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.DepatmentsTableAdapter depatmentsTableAdapter;
        private System.Windows.Forms.BindingSource divisionsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.DivisionsTableAdapter divisionsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.StatusesTableAdapter statusesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private CalendarColumn dataGridViewTextBoxColumn3;
        private CalendarColumn calendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private HRDepartmentDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewComboBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn postIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn statusIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contractNumberDataGridViewTextBoxColumn;
        private CalendarColumn employmentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SalaryColumn;
        private CalendarColumn dismissalDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dismissalReasonDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Column_Documents;
    }
}