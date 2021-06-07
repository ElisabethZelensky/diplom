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
    public partial class Form_EmployeesEditor : Form
    {
        public Form_EmployeesEditor()
        {
            InitializeComponent();

            //  берем из базы все департаменты
            this.depatmentsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Depatments);
            //идем по департаментам
            foreach (DataRow row in this.hRDepartmentDatabaseDataSet.Depatments.Rows)
            {
                //создаем новый узел для дерева
                TreeNode node = new TreeNode(row["Name"].ToString());
                int id = Convert.ToInt32(row["Id"]);
                node.Tag = row;
                //берем все отделы данного депаратмента
                this.divisionsTableAdapter.FillGetDivisionsByDepartment(this.hRDepartmentDatabaseDataSet.Divisions, id);
                //идем по каждому из них
                foreach (DataRow child in this.hRDepartmentDatabaseDataSet.Divisions.Rows)
                {
                    //и создаем дочерний узел для депарамента
                    int departmentId = Convert.ToInt32(child["DepartmentId"]);
                    var childNode = new TreeNode(child["Name"].ToString());
                    int childId = Convert.ToInt32(child["Id"]);
                    childNode.Tag = childId;
                    node.Nodes.Add(childNode);
                }
                //в само дерево добавляем узел депаратамента
                treeView_Departments.Nodes.Add(node);
            }
            //открываем все узлы дерева
            treeView_Departments.ExpandAll();
        }

        private void Form_EmployeesEditor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRDepartmentDatabaseDataSet.Statuses". При необходимости она может быть перемещена или удалена.
            this.statusesTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Statuses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRDepartmentDatabaseDataSet.Persons". При необходимости она может быть перемещена или удалена.
            this.personsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Persons);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRDepartmentDatabaseDataSet.Divisions". При необходимости она может быть перемещена или удалена.
            this.divisionsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Divisions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRDepartmentDatabaseDataSet.Depatments". При необходимости она может быть перемещена или удалена.
            this.depatmentsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Depatments);
        }

        /// <summary>
        /// Клик по узлу дерева
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_Departments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //если в таг узла дерева сохранено число, то это отдел
            if (e.Node.Tag is int)
            {
                //вытаскиваем ИД отдела
                var divisionId = Convert.ToInt32(e.Node.Tag);
                //берем всех сотрудников отдела
                this.employeesTableAdapter.FillGetEmployeesByDivision(this.hRDepartmentDatabaseDataSet.Employees, divisionId);
                //берем все должности отдела
                this.postsTableAdapter.FillGetPostsByDivision(this.hRDepartmentDatabaseDataSet.Posts, divisionId);
            }
        }

        /// <summary>
        /// если в гриде возникают ошибки, то мы не выдаем окно  с ошибкой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        /// <summary>
        /// Нажатие сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            //сохраняем изменения в БД
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.hRDepartmentDatabaseDataSet);
        }
        //клик по ячейке таблицы
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //если кликнули по ячейке, в которой кнопка (а это кнопка "Документы")
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // то открываем форму управления документами сотрудника
                var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["personIdDataGridViewTextBoxColumn"].Value);
                new Form_PersonDocumentsEditor(id).ShowDialog();
            }
        }
    }
}
