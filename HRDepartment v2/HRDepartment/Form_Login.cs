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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку Вход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Login_Click(object sender, EventArgs e)
        {
            //считываем введенные данные
            var login = textBox_Login.Text;
            var password = textBox_Password.Text;


            //пробуем достать из базы юзера с таким логином и паролем
            this.usersTableAdapter.FillGetUserByLoginPassword(this.hRDepartmentDatabaseDataSet.Users, login, password);

            //если есть такой пользователь
            bool success = false;
            if (this.hRDepartmentDatabaseDataSet.Users.Count != 0)
            {
                //достаем его в переменную user
                var user = this.hRDepartmentDatabaseDataSet.Users.Rows[0] as UsersRow;
                //во флаг записываем, что авторизация прошла успешно
                success = true;
                //берем роли этого пользователя
                this.userRolesTableAdapter.FillGetUserRolesByUser(this.hRDepartmentDatabaseDataSet.UserRoles, user.Id);
                var userRoles = this.hRDepartmentDatabaseDataSet.UserRoles;
                //и записываем в переменные, которые будут доступны из любого места программы (чтобы каждый раз не лезть в базу и првоерять права)
                Utils.IsAdmin = userRoles.Any(x => x.Role == "admin");
                Utils.IsHR = userRoles.Any(x => x.Role == "hr");
                Utils.IsDirector = userRoles.Any(x => x.Role == "director");
            }

            //если авторизация прошла успешно
            if (success)
            {
                //создаем экземпляр главной формы
                var form = new Form_Main();
                //помечаем флаг, что форму входа надо будет закрыть
                close = true;
                //вешаем событие на закрытие главной формы тоже самое, что и на закрытие текущей формы
                form.FormClosed += new FormClosedEventHandler(Auth_FormClosed);
                //показываем главную форму
                form.Show();
                //прячем форму входа
                this.Hide();
            }
            //инча отображаем соответсвующее сообщение
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем не существует");
            }
        }

        //флаг, чтобы понимать, надо закрывать форму входа или нет
        private bool close = false;

        /// <summary>
        /// событие закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            //если ранее отметили флаг, что форму надо закрыть,
            if (close)
            {
                close = false;
                //закрываем форму, а вместе с ней и приложение
                this.Close();
            }
        }
    }
}
