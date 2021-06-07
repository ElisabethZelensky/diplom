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
    public partial class Form_UsersEditor : Form
    {
        public Form_UsersEditor()
        {
            InitializeComponent();
        }

        private void Form_UsersEditor_Load(object sender, EventArgs e)
        {
            //берем из бд всех пользователей
            this.usersTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Users);
        }

        /// <summary>
        /// Нажатие Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            //Сохраняем внесенные изменения в БД
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.hRDepartmentDatabaseDataSet);
        }
    }
}
