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
    public partial class Form_DivisionsEditor : Form
    {
        public Form_DivisionsEditor()
        {
            InitializeComponent();
        }

        private void Form_DivisionsEditor_Load(object sender, EventArgs e)
        {
            //  берем из базы все департаменты
            this.depatmentsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Depatments);
            //  берем из базы все отделы
            this.divisionsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Divisions);
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
            this.divisionsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.hRDepartmentDatabaseDataSet);
        }
    }
}
