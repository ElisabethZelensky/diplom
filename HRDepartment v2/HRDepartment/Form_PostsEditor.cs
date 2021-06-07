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
    public partial class Form_PostsEditor : Form
    {
        public Form_PostsEditor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// событие прии  загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_PostsEditor_Load(object sender, EventArgs e)
        {
            //берем из БД все отделы
            this.depatmentsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Depatments);
            //автоматом вызывем событие (чтобы не дублирвоать код)
            comboBox_Departments_SelectedIndexChanged(null, null);
            comboBox_Divisions_SelectedIndexChanged(null, null);
        }
        /// <summary>
        /// Нажатие Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            //Сохраняем изменения в БД
            this.Validate();
            this.postsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.hRDepartmentDatabaseDataSet);
        }
        /// <summary>
        /// событие при изменении выбранного элемента в комобоксе с депаратментами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Departments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //проверка, что точно выбан какой-нибудь депаратмент
            var selectedId = Convert.ToInt32(comboBox_Departments.SelectedValue);
            if (selectedId == 0)
            {
                return;
            }
            //берем из базы все отделы выбранного департамента
            this.divisionsTableAdapter.FillGetDivisionsByDepartment(this.hRDepartmentDatabaseDataSet.Divisions, selectedId);

            comboBox_Divisions_SelectedIndexChanged(null, null);
        }

        /// <summary>
        /// событие при выборе элемента в комобоксе с отделами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Divisions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //проверка, что точно выбан какой-нибудь отдел
            var selectedId = Convert.ToInt32(comboBox_Divisions.SelectedValue);
            if (selectedId == 0)
            {
                return;
            }
            //берем все должности отдела из БД
            this.postsTableAdapter.FillGetPostsByDivision(this.hRDepartmentDatabaseDataSet.Posts, selectedId);
        }
        /// <summary>
        /// Событие при добавлении строк в грид с должностями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //проверка, что точно выбан какой-нибудь отдел
            var selectedId = Convert.ToInt32(comboBox_Divisions.SelectedValue);
            if (selectedId == 0)
            {
                return;
            }
            //добавляенной должности автоматически назначаем выбранный в комобобоксе отдел
            e.Row.Cells["DivisionId"].Value = selectedId;
        }
        /// <summary>
        /// при изменении источника данных в гриде
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void postsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //если изменилась какая-то должность, а именно добавлена новая
            if (postsBindingSource.Current != null && (postsBindingSource.Current as DataRowView).IsNew)
            {
                //проверка, что точно выбан какой-нибудь отдел
                var selectedId = Convert.ToInt32(comboBox_Divisions.SelectedValue);
                if (selectedId == 0)
                {
                    return;
                }
                //новой должности автоматически задаем выбранный в комобоксе отдел
                (postsBindingSource.Current as DataRowView)["DivisionId"] = selectedId;
            }
        }
    }
}
