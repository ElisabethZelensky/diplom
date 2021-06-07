namespace HRDepartment
{
    partial class Form_PersonDocumentsEditor
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
            this.listView_Files = new System.Windows.Forms.ListView();
            this.button_Upload = new System.Windows.Forms.Button();
            this.hRDepartmentDatabaseDataSet = new HRDepartment.HRDepartmentDatabaseDataSet();
            this.personDocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personDocumentsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.PersonDocumentsTableAdapter();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new HRDepartment.HRDepartmentDatabaseDataSetTableAdapters.PersonsTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьНаКомпьютерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDocumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Files
            // 
            this.listView_Files.HideSelection = false;
            this.listView_Files.Location = new System.Drawing.Point(12, 37);
            this.listView_Files.Name = "listView_Files";
            this.listView_Files.Size = new System.Drawing.Size(776, 401);
            this.listView_Files.TabIndex = 0;
            this.listView_Files.UseCompatibleStateImageBehavior = false;
            this.listView_Files.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Files_MouseClick);
            this.listView_Files.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Files_MouseDoubleClick);
            // 
            // button_Upload
            // 
            this.button_Upload.Location = new System.Drawing.Point(570, 8);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(218, 23);
            this.button_Upload.TabIndex = 1;
            this.button_Upload.Text = "Добавить";
            this.button_Upload.UseVisualStyleBackColor = true;
            this.button_Upload.Click += new System.EventHandler(this.button_Upload_Click);
            // 
            // hRDepartmentDatabaseDataSet
            // 
            this.hRDepartmentDatabaseDataSet.DataSetName = "HRDepartmentDatabaseDataSet";
            this.hRDepartmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.hRDepartmentDatabaseDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выгрузитьНаКомпьютерToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 92);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выгрузитьНаКомпьютерToolStripMenuItem
            // 
            this.выгрузитьНаКомпьютерToolStripMenuItem.Name = "выгрузитьНаКомпьютерToolStripMenuItem";
            this.выгрузитьНаКомпьютерToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.выгрузитьНаКомпьютерToolStripMenuItem.Text = "Выгрузить на компьютер";
            this.выгрузитьНаКомпьютерToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьНаКомпьютерToolStripMenuItem_Click);
            // 
            // Form_PersonDocumentsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Upload);
            this.Controls.Add(this.listView_Files);
            this.Name = "Form_PersonDocumentsEditor";
            this.Text = "Редактор документов";
            this.Load += new System.EventHandler(this.Form_PersonDocumentsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRDepartmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDocumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private HRDepartmentDatabaseDataSet hRDepartmentDatabaseDataSet;
        private System.Windows.Forms.BindingSource personDocumentsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.PersonDocumentsTableAdapter personDocumentsTableAdapter;
        private System.Windows.Forms.ListView listView_Files;
        private System.Windows.Forms.Button button_Upload;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private HRDepartmentDatabaseDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьНаКомпьютерToolStripMenuItem;
    }
}