using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDepartment
{
    public partial class Form_PersonsEditor : Form
    {
        public Form_PersonsEditor()
        {
            InitializeComponent();

            //ширина столбца с именем физлица в списке слева
            listView_Persons.Columns[0].Width = 220;

            //загружаем данные в список
            RefreshListView();
        }

        /// <summary>
        /// событие при выборе жлемента (физлица) в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если ничего не выбрано
            if (listView_Persons.SelectedItems.Count == 0)
            {
                //панель с подробностями скрываем
                panel_Person.Visible = false;

                //прекращаем выполннение процедуры
                return;
            }

            //панель с подробностями отображаем
            panel_Person.Visible = true;

            //физлицо
            var personDataRow = listView_Persons.SelectedItems[0].Tag as DataRow;
            //отображаем данные
            textBox_FirstName.Text = $"{personDataRow["FirstName"]}";
            textBox_LastName.Text = $"{personDataRow["LastName"]}";
            textBox_MiddleName.Text = $"{personDataRow["MiddleName"]}";
            dateTimePicker_Birthday.Value = Convert.ToDateTime(personDataRow["Birthday"]);
            textBox_PassportSeries.Text = $"{personDataRow["PassportSeries"]}";
            textBox_PassportNumber.Text = $"{personDataRow["PassportNumber"]}";
            textBox_PassportIssuedBy.Text = $"{personDataRow["PassportIssuedBy"]}";
            dateTimePicker_PassportIssuedDate.Value = Convert.ToDateTime(personDataRow["PassportIssuedDate"]);
            textBox_PassportRegistrationAddress.Text = $"{personDataRow["PassportRegistrationAddress"]}";
            textBox_Address.Text = $"{personDataRow["Address"]}";
            textBox_PostIndex.Text = $"{personDataRow["PostIndex"]}";
            textBox_Phone.Text = $"{personDataRow["Phone"]}";
            textBox_INN.Text = $"{personDataRow["INN"]}";
            comboBox_FamilyStatus.Text = $"{personDataRow["FamilyStatus"]}";
            //и изображение
            var photoBytes = personDataRow["Photo"] as byte[];
            if (photoBytes != null && photoBytes.Length > 0)
            {
                button_DeletePhoto.Visible = true;

                MemoryStream mStream = new MemoryStream();
                mStream.Write(photoBytes, 0, Convert.ToInt32(photoBytes.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();

                pictureBox_Photo.Image = bm;
            }
            else
            {
                //если изображения нет, то прячем неактуальную кнопку Удалить фото
                button_DeletePhoto.Visible = false;
                pictureBox_Photo.Image = null;
            }
        }

        /// <summary>
        /// Нажатие Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Save_Click(object sender, EventArgs e)
        {
            //если новое физ лицо
            if (IsNewAdding)
            {
                var FirstName = textBox_FirstName.Text;
                var LastName = textBox_LastName.Text;
                var MiddleName = textBox_MiddleName.Text;
                var Birthday = dateTimePicker_Birthday.Value;
                var PassportSeries = textBox_PassportSeries.Text;
                var PassportNumber = textBox_PassportNumber.Text;
                var PassportIssuedBy = textBox_PassportIssuedBy.Text;
                var PassportIssuedDate = dateTimePicker_PassportIssuedDate.Value;
                var PassportRegistrationAddress = textBox_PassportRegistrationAddress.Text;
                var Address = textBox_Address.Text;
                var PostIndex = textBox_PostIndex.Text;
                var Phone = textBox_Phone.Text;
                var INN = textBox_INN.Text;
                var FamilyStatus = comboBox_FamilyStatus.Text;
                //если было фото, заполняем фото
                Byte[] imgBytes = null;
                if (pictureBox_Photo.Image != null)
                {
                    var bmp = new Bitmap(pictureBox_Photo.Image);
                    var stream = new MemoryStream();
                    bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    bmp.Dispose();
                    //ImageConverter imgConverter = new ImageConverter();
                    //imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox_Photo.Image, Type.GetType("System.Byte[]"));
                    imgBytes = stream.GetBuffer();
                }
                //сохраняем это в базу
                var ok = personsTableAdapter.Insert(LastName, FirstName, MiddleName,"", Birthday, PassportSeries, PassportNumber,
                    PassportIssuedBy, PassportIssuedDate, PassportRegistrationAddress, Address, PostIndex, INN, Phone, FamilyStatus, imgBytes);
                IsNewAdding = false;
            }
            else
            {
                //физлицо 
                var personDataRow = listView_Persons.SelectedItems[0].Tag as DataRow;
                //заполняем введенными данными
                personDataRow["FirstName"] = textBox_FirstName.Text;
                personDataRow["LastName"] = textBox_LastName.Text;
                personDataRow["MiddleName"] = textBox_MiddleName.Text;
                personDataRow["Birthday"] = dateTimePicker_Birthday.Value;
                personDataRow["PassportSeries"] = textBox_PassportSeries.Text;
                personDataRow["PassportNumber"] = textBox_PassportNumber.Text;
                personDataRow["PassportIssuedBy"] = textBox_PassportIssuedBy.Text;
                personDataRow["PassportIssuedDate"] = dateTimePicker_PassportIssuedDate.Value;
                personDataRow["PassportRegistrationAddress"] = textBox_PassportRegistrationAddress.Text;
                personDataRow["Address"] = textBox_Address.Text;
                personDataRow["PostIndex"] = textBox_PostIndex.Text;
                personDataRow["Phone"] = textBox_Phone.Text;
                personDataRow["INN"] = textBox_INN.Text;
                personDataRow["FamilyStatus"] = comboBox_FamilyStatus.Text;
                //если было фото, заолпняем фото
                if (pictureBox_Photo.Image != null)
                {
                    Byte[] imgBytes = null;
                    var bmp = new Bitmap(pictureBox_Photo.Image);
                    var stream = new MemoryStream();
                    bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    bmp.Dispose();
                    //ImageConverter imgConverter = new ImageConverter();
                    //imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox_Photo.Image, Type.GetType("System.Byte[]"));
                    personDataRow["Photo"] = stream.GetBuffer();
                }
                //сохраняем изменения
                var ok = personsTableAdapter.Update(personDataRow);
            }

            //обновляем список физлиц для отбржения изменений
            RefreshListView();
        }

        private void button_UploadFile_Click(object sender, EventArgs e)
        {
            //создаем диалог выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //настраиваем его параметры
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Изображения (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";

            //открываем этот диалог и если выбрали файл,
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //то отображаем выдранную картинку на форме
                pictureBox_Photo.Image = Image.FromFile(openFileDialog.FileName);
                //показываем кнопку Удалить фото
                button_DeletePhoto.Visible = true;
            }
        }
        /// <summary>
        /// Нажатие на Удалить фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DeletePhoto_Click(object sender, EventArgs e)
        {
            //физлицо
            var personDataRow = listView_Persons.SelectedItems[0].Tag as DataRow;
            //обнуляем фото
            personDataRow["Photo"] = null;
            //на форме тоже убираем фото
            pictureBox_Photo.Image = null;
            //прячем неактуальную кнопку Удалить фото
            button_DeletePhoto.Visible = false;
        }
        /// <summary>
        /// Клик по списку с фищлицами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Persons_MouseClick(object sender, MouseEventArgs e)
        {
            //если кликнули правой кнопкой мыши
            if (e.Button == MouseButtons.Right)
            {
                //берем эелемнт списка, по которому кликнули
                var focusedItem = listView_Persons.FocusedItem;
                //если клик был по элементу списка, то
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    //показываем контектсное меню в позиции курсора
                    contextMenuStrip_PersonsListview.Show(Cursor.Position);
                }
            }
        }

        /// <summary>
        /// Клик по удалить в контекстном меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //показываем сообщение пользователю (с предупреждением). Если нажали ОК
            if (MessageBox.Show("Вы уверены, что хотите удалить физическое лицо? Все связанные данные также будут удалены.", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //берем выбранное физлицо
                var personDataRow = listView_Persons.SelectedItems[0].Tag as DataRow;
                //удаляем из базы
                var ok = personsTableAdapter.Delete(Convert.ToInt32(personDataRow["Id"]));
                //обновляем список сфизлицами
                RefreshListView();
            }
        }

        /// <summary>
        /// обновляем список с физлицами
        /// </summary>
        private void RefreshListView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRDepartmentDatabaseDataSet.Persons". При необходимости она может быть перемещена или удалена.
            this.personsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Persons);
            listView_Persons.Items.Clear();
            foreach (DataRow row in this.hRDepartmentDatabaseDataSet.Persons.Rows)
            {
                var item = new ListViewItem($"{row["LastName"]} {row["FirstName"]} {row["MiddleName"]}");
                item.Tag = row;
                listView_Persons.Items.Add(item);
            }

            panel_Person.Visible = false;
        }
        /// <summary>
        /// Клик по кнопке Управление документами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_PersonDocuments_Click(object sender, EventArgs e)
        {
            var personDataRow = listView_Persons.SelectedItems[0].Tag as DataRow;
            //открываем форму управления документами и передаем туда ИД физлица
            new Form_PersonDocumentsEditor(Convert.ToInt32(personDataRow["Id"])).ShowDialog();
        }

        bool IsNewAdding;
        private void button_AddNew_Click(object sender, EventArgs e)
        {
            IsNewAdding = true;

            //панель с подробностями отображаем
            panel_Person.Visible = true;

            //отображаем данные
            textBox_FirstName.Text = "";
            textBox_LastName.Text = "";
            textBox_MiddleName.Text = "";
            dateTimePicker_Birthday.Value = DateTime.Now;
            textBox_PassportSeries.Text = "";
            textBox_PassportNumber.Text = "";
            textBox_PassportIssuedBy.Text = "";
            dateTimePicker_PassportIssuedDate.Value = DateTime.Now;
            textBox_PassportRegistrationAddress.Text = "";
            textBox_Address.Text = "";
            textBox_PostIndex.Text = "";
            textBox_Phone.Text = "";
            textBox_INN.Text = "";
            comboBox_FamilyStatus.SelectedIndex = 0;

            //изображения нет,  прячем неактуальную кнопку Удалить фото
            button_DeletePhoto.Visible = false;
            pictureBox_Photo.Image = null;
        }
    }
}
