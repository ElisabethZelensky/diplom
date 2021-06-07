using HRDepartment.HRDepartmentDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRDepartment.HRDepartmentDatabaseDataSet;

namespace HRDepartment
{
    public partial class Form_PersonDocumentsEditor : Form
    {
        //идентификатор физ лица, для которого открыли форму
        int PersonId;
        public Form_PersonDocumentsEditor(int personId)
        {
            InitializeComponent();
            PersonId = personId;
            // берем текущее физлицо (для которого открыли форму)
            this.personsTableAdapter.FillGetPersonById(this.hRDepartmentDatabaseDataSet.Persons, PersonId);
            //загружаем список документов
            LoadListView();
        }

        private void LoadListView()
        {
            //берем из бд документы заданного физлица
            this.personDocumentsTableAdapter.FillGetDocumentsByPerson(this.hRDepartmentDatabaseDataSet.PersonDocuments, PersonId);
            var documentsCount = this.hRDepartmentDatabaseDataSet.PersonDocuments.Count;
            //очищаем список документов от старых значениц
            listView_Files.Items.Clear();

            // создаем лист, где будут хранится иконки, ассоциированные с раширением каждого документа
            var imageList = new ImageList();
            //говорим, что размер иконок будет 32*32
            imageList.ImageSize = new Size(32, 32);
            //идем по каждому документу пользователя
            for (int i = 0; i < documentsCount; i++)
            {
                //сохраняем в переменную i-ый документ
                var document = this.hRDepartmentDatabaseDataSet.PersonDocuments.Rows[i] as PersonDocumentsRow;
                //полное имя файла документа
                var fullName = document.FileFullName;
                //вытаскиваем расширение файла
                var extension = Path.GetExtension(fullName).ToLower();
                //создаем изображение для иконки 
                Bitmap extensionImage = new Bitmap(1, 1);
                //в зависимости от расширения документа подставляем нужную картинку
                switch (extension)
                {
                    case ".png":
                    case ".jpeg":
                    case ".jpg":
                        extensionImage = Properties.Resources.image;
                        break;
                    case ".doc":
                    case ".docx":
                        extensionImage = Properties.Resources.word;
                        break;
                    case ".xls":
                    case ".xlsx":
                        extensionImage = Properties.Resources.excel;
                        break;
                    case ".pdf":
                        extensionImage = Properties.Resources.pdf;
                        break;
                    default: break;
                }
                imageList.Images.Add(extensionImage);//добавляем изображения. ассоциированное с рширением документа

                //создаем элемент списка
                var item = new ListViewItem();
                item.Text = fullName;//даем ему текст, которыый бедет отобржаться рядом сэлементом списка
                item.ImageIndex = i;//даем идентификатор изображения
                item.Tag = document;//в Tag запоминаем весь объект Документ (чтобы далее, когда кликнут по элементу списка (документу) мы могли сразу открыть его без дополнительного обращения к БД) 
                listView_Files.Items.Add(item);//добавляем элемент списка в элемент управления listView_Files
            }
            //самому элементу управления даем список изображений
            listView_Files.LargeImageList = imageList;
        }

       
        private void Form_PersonDocumentsEditor_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// нажатие кнопки Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Upload_Click(object sender, EventArgs e)
        {
            //создаем диалог открытия файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Документы и изображения|*.docx;*.xlsx;*.pdf;*.png;*.jpeg;*.jpg;";

            //открываем диалог и если в результате нажали ок( выбрали файл)
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //текщее физлицо
                var person = this.hRDepartmentDatabaseDataSet.Persons[0];
                //идем по каждому выбранному в диалоге файлу
                foreach (string filePath in openFileDialog.FileNames)
                {
                    //берем его имя
                    var fileName = Path.GetFileName(filePath);
                    //берем его контент в виде массива байт
                    var bytes = File.ReadAllBytes(filePath);
                    //сохраняем это в базу как новый документ
                    var ok = personDocumentsTableAdapter.Insert(PersonId, fileName, bytes);
                }
                //заново грузим список с документами пользователя, чтобы отобразились сохраненые новые данные
                LoadListView();
            }
        }
        /// <summary>
        /// двойно клик по документу в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //если есть выделенный документ в списке
            if (listView_Files.SelectedItems.Count == 1)
            {
                //то достаем его
                var item = listView_Files.SelectedItems[0].Tag as PersonDocumentsRow;
                //и открываем в соответствующем приложении
                Utils.OpenInAnotherApp(item.FileBytes, item.FileFullName);
            }
        }
        /// <summary>
        /// клик по элементу списка с документами  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_MouseClick(object sender, MouseEventArgs e)
        {
            //если нажали правой кнопкой мыши
            if (e.Button == MouseButtons.Right)
            {
                //то рисуем контекстное меню на позиции курсора
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        /// <summary>
        /// клик по контекстному меню  документа Открыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //если есть выделенный документ в списке
            if (listView_Files.SelectedItems.Count == 1)
            {
                //то достаем его
                var item = listView_Files.SelectedItems[0].Tag as PersonDocumentsRow;
                //и открываем в соответствующем приложении
                Utils.OpenInAnotherApp(item["FileBytes"] as byte[], item["FileFullName"].ToString());
            }
        }
        /// <summary>
        /// клик по контекстному меню  документа Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //берем элемент - документ
            var item = listView_Files.SelectedItems[0].Tag as PersonDocumentsRow;
            //выполняем удаление
            var ok = personDocumentsTableAdapter.Delete(item.Id);
            //заново грузим список, чтобы отобразить изменения
            LoadListView();
        }
        /// <summary>
        /// нажатие на пункт контекстного меню выгрузитьНаКомпьютер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выгрузитьНаКомпьютерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //если есть выделенный документ в списке
            if (listView_Files.SelectedItems.Count == 1)
            {
                //то достаем его
                var item = listView_Files.SelectedItems[0].Tag as PersonDocumentsRow;
                //открываем диалог сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //достаем расширение файла
                var fileName = item["FileFullName"].ToString();
                var extension = Path.GetExtension(fileName);
                //задаем фильтр для диалога, чтобы можно было выбрать только файлы нужног расширения
                saveFileDialog.Filter = $"Файлы {extension} |*{extension};";
                //открываем диалог и если результатом работы диалогового окна по сохранению файла есть нажатие в нем кнопки ОК, то
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // получаем выбранный файл
                    string filename = saveFileDialog.FileName;
                    // сохраняем байты в файл
                    System.IO.File.WriteAllBytes(filename, item["FileBytes"] as byte[]);
                    MessageBox.Show("Файл сохранен");
                }
            }
        }
    }
}
