using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDepartment
{
    public partial class Form_DepartmentsEditor : Form
    {
        public Form_DepartmentsEditor()
        {
            InitializeComponent();
        }

        private void Form_DepartmentsEditor_Load(object sender, EventArgs e)
        {
            //  берем из базы все департаменты
            this.depatmentsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Depatments);
        }

        /// <summary>
        /// нажатие Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            //сохраняем данные в БД
            this.Validate();
            this.depatmentsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.hRDepartmentDatabaseDataSet);
        }
    }
}
