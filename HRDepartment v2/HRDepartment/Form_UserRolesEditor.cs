using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRDepartment.HRDepartmentDatabaseDataSet;

namespace HRDepartment
{
    public partial class Form_UserRolesEditor : Form
    {
        public Form_UserRolesEditor()
        {
            InitializeComponent();
        }

        private void Form_UserRolesEditor_Load(object sender, EventArgs e)
        {
            //берем всех пользовтелей из БД
            this.usersTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Users);

            //вызываем событие
            listBox_Users_SelectedIndexChanged(null, null);
        }

        /// <summary>
        /// Нажатие сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Save_Click(object sender, EventArgs e)
        {
            //берем выбранного в списке слева пользователя 
            var user = (listBox_Users.SelectedItem as DataRowView).Row as UsersRow;
            //считываем данные из чекбоксов
            var isAdmin = checkBox_IsAdmin.Checked;
            var isHR = checkBox_IsHR.Checked;
            var isDirector = checkBox_IsDirector.Checked;

            //добавляем недостающие роли
            var roles = this.hRDepartmentDatabaseDataSet.UserRoles;
            if (isAdmin && !roles.Any(x => x.Role == "admin"))
            {
                userRolesTableAdapter.Insert(user.Id, "admin");
            }
            if (isHR && !roles.Any(x => x.Role == "hr"))
            {
                userRolesTableAdapter.Insert(user.Id, "hr");
            }
            if (isDirector && !roles.Any(x => x.Role == "director"))
            {
                userRolesTableAdapter.Insert(user.Id, "director");
            }

            //удаляем устаревшие
            if (!isAdmin && roles.Any(x => x.Role == "admin"))
            {
                userRolesTableAdapter.Delete(user.Id, "admin");
            }
            if (!isHR && roles.Any(x => x.Role == "hr"))
            {
                userRolesTableAdapter.Delete(user.Id, "hr");
            }
            if (!isDirector && roles.Any(x => x.Role == "director"))
            {
                userRolesTableAdapter.Delete(user.Id, "director");
            }
        }
        /// <summary>
        /// Событие при выборе пользователя в списке слева
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            //берем выбранного в списке слева пользователя 
            var user = (listBox_Users.SelectedItem as DataRowView).Row as UsersRow;
            // берем из БД все его роли
            this.userRolesTableAdapter.FillGetUserRolesByUser(this.hRDepartmentDatabaseDataSet.UserRoles, user.Id);
            var roles = this.hRDepartmentDatabaseDataSet.UserRoles;
            var isAdmin = roles.Any(x => x.Role == "admin");
            var isHR = roles.Any(x => x.Role == "hr");
            var isDirector = roles.Any(x => x.Role == "director");

            //отображаем эти роли
            checkBox_IsAdmin.Checked = isAdmin;
            checkBox_IsHR.Checked = isHR;
            checkBox_IsDirector.Checked = isDirector;
        }
    }
}
