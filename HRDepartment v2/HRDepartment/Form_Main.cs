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
using static HRDepartment.HRDepartmentDatabaseDataSet;

namespace HRDepartment
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            //отображаем или пряем пункты меню в зависимости от ролей текущего пользователя
            menu_administration.Visible = Utils.IsAdmin;
            menu_reports.Visible = Utils.IsDirector;
            menu_employees.Visible = Utils.IsHR;
            menu_lists.Visible = Utils.IsHR;

            //ниже рисуем структуру предприятия  в treeview
            RefreshTreeview();
        }
        // рисуем структуру предприятия  в treeview
        private void RefreshTreeview()
        {
            treeView_Departments.Nodes.Clear();//очищаем от старых данных

            //прячем панель с карточкой сотрудника (так как сейчас никакой сотрудник еще не выбран)
            panel_Person.Visible = false;


            //считываем все департаменты из БД
            this.depatmentsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Depatments);
            //идем по каждому департаменту
            foreach (DataRow departamentRow in this.hRDepartmentDatabaseDataSet.Depatments.Rows)
            {
                //создаем новый узел дерева
                TreeNode departmentNode = new TreeNode(departamentRow["Name"].ToString());
                //запоминаем ИД департамента 
                int departmentId = Convert.ToInt32(departamentRow["Id"]);
                departmentNode.Tag = departmentId;
                //считываем из базы все отделы заданного департамента (departmentId)
                this.divisionsTableAdapter.FillGetDivisionsByDepartment(this.hRDepartmentDatabaseDataSet.Divisions, departmentId);
                //ижем по каждому отделу
                foreach (DataRow divisionRow in this.hRDepartmentDatabaseDataSet.Divisions.Rows)
                {
                    //создаем новый узел дерева
                    var divisionNode = new TreeNode(divisionRow["Name"].ToString());
                    //запоминаем ИД отдела 
                    int divisionId = Convert.ToInt32(divisionRow["Id"]);
                    divisionNode.Tag = divisionId;
                    // считываем из базы все должности в этом отделе 
                    this.postsTableAdapter.FillGetPostsByDivision(this.hRDepartmentDatabaseDataSet.Posts, divisionId);
                    //идем по каждой должности
                    foreach (DataRow postRow in this.hRDepartmentDatabaseDataSet.Posts.Rows)
                    {
                        //создаем новый узел дерева
                        var postNode = new TreeNode(postRow["Name"].ToString());
                        //запоминаем ИД должности 
                        int postId = Convert.ToInt32(postRow["Id"]);
                        postNode.Tag = postRow;
                        //если текущий пользователь зам директора или HR,
                        if (Utils.IsHR || Utils.IsDirector)
                        {
                            //то они могут смотреть карточки сотрудников, поэтому римуем ниже сотрудников
                            //вытаскиваем всех сотрудников текущей должности
                            this.employeesTableAdapter.FillGetEmployeesByPost(this.hRDepartmentDatabaseDataSet.Employees, postId);
                            //идем по каждому сотруднику
                            foreach (DataRow employeeRow in this.hRDepartmentDatabaseDataSet.Employees.Rows)
                            {
                                //создаем для него свой узел дерева
                                var emploNode = new TreeNode(employeeRow["PersonFullName"].ToString());
                                //запоминаем его ИД
                                int emplId = Convert.ToInt32(employeeRow["Id"]);
                                emploNode.Tag = $"EMPLOYEE {emplId}";
                                //в узел дерева для Должности добавляем Узел сотрудника
                                postNode.Nodes.Add(emploNode);
                            }
                        }
                        //в узел дерева для Отдела добавляем Узел Должности
                        divisionNode.Nodes.Add(postNode);
                    }
                    //в узел дерева для Департамента добавляем Узел Отдела
                    departmentNode.Nodes.Add(divisionNode);
                }
                //добавляем узел Департамента (со всеми его подузлами) в дерево treeView_Departments
                treeView_Departments.Nodes.Add(departmentNode);
            }
            //автоматически раскрываем все узлы дерева
            treeView_Departments.ExpandAll();
        }

        /// <summary>
        /// Клик по пункту меню редакторДепартаментов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void редакторДепартаментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем соответствующую форму
            new Form_DepartmentsEditor().ShowDialog();
        }

        /// <summary>
        /// Клик по пункту меню редакторОтделов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void редакторОтделовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем соответствующую форму
            new Form_DivisionsEditor().ShowDialog();
        }

        /// <summary>
        /// Событие по клику на узел дерева
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_Departments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //если узел, по которому кликнули содержит EMPLOYEE, то значит кликнули по какому-то сотруднику
            if (e.Node.Tag.ToString().Contains("EMPLOYEE"))
            {
                //следовательно панель с карточкой сотрудника делаем видимой
                panel_Person.Visible = true;

                //вытаскиваем ИД сотрудника
                var employeeId = Convert.ToInt32(e.Node.Tag.ToString().Split(' ')[1]);
                //берем из базы сотрудника с заданным ИД
                this.employeesTableAdapter.FillGetEmployeeById(this.hRDepartmentDatabaseDataSet.Employees, employeeId);
                //запоминаем этого сотрудника в employeeRow
                var employeeRow = this.hRDepartmentDatabaseDataSet.Employees.Rows[0];

                //вытаскиваем ИД физ лица (этого сотрудника)
                var personId = Convert.ToInt32(employeeRow["PersonId"]);
                //из базы берем физлица  с заданным ИД
                this.personsTableAdapter.FillGetPersonById(this.hRDepartmentDatabaseDataSet.Persons, personId);
                //запоминаем физлицо в personRow
                var personRow = this.hRDepartmentDatabaseDataSet.Persons.Rows[0];

                //выводим данные сотрудника
                label_FullName.Text = $"{personRow["FullName"]}";
                label_Post.Text = $"{employeeRow["PostName"]}";
                label_Division.Text = $"{employeeRow["DivisionName"]}";
                label_Department.Text = $"{employeeRow["DepartmentName"]}";
                label_Status.Text = $"{employeeRow["StatusName"]}";
                label_ContractNumber.Text = $"{employeeRow["ContractNumber"]}";
                label_EmploymentDate.Text = $"{ Convert.ToDateTime(employeeRow["EmploymentDate"]).ToShortDateString()}";
                label_INN.Text = $"{personRow["INN"]}";
                label_Salary.Text = $"{employeeRow["Salary"]}";
                //выводим фото
                var photoBytes = personRow["Photo"] as byte[];
                if (photoBytes != null && photoBytes.Length > 0)
                {
                    MemoryStream mStream = new MemoryStream();
                    mStream.Write(photoBytes, 0, Convert.ToInt32(photoBytes.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    mStream.Dispose();

                    pictureBox_Photo.Image = bm;
                }
                //если фото нет, то выводим станлартную картинку
                else
                {
                    pictureBox_Photo.Image = Properties.Resources.person;
                }

                //выполняем запрос, который вытаскивает все документы физлица по его ИД
                this.personDocumentsTableAdapter.FillGetDocumentsByPerson(this.hRDepartmentDatabaseDataSet.PersonDocuments, personId);
                //считываем количество вытащенных документов
                var documentsCount = this.hRDepartmentDatabaseDataSet.PersonDocuments.Count;
                //очищаем листвью с документами от старых данных
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
                listView_Files.SmallImageList = imageList;
            }
            //если любой другой узел дерева (не сотрудник)
            else
            {
                //следовательно панель с карточкой сотрудника делаем невидимой
                panel_Person.Visible = false;
            }
        }

        /// <summary>
        /// клик по меню редакторДолжностей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void редакторДолжностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем соответствующую форму
            new Form_PostsEditor().ShowDialog();
        }
        /// <summary>
        /// клик по меню управлениеПользователями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void управлениеПользователямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем соответствующую форму
            new Form_UsersEditor().ShowDialog();
        }
        /// <summary>
        /// клик по меню физическиеЛица
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void физическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем соответствующую форму
            new Form_PersonsEditor().ShowDialog();
        }
        /// <summary>
        /// клик по меню управлениеСотрудниками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void управлениеСотрудникамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем соответствующую форму
            new Form_EmployeesEditor().ShowDialog();
        }
        /// <summary>
        /// двойной клик по элементу списка с документами сотрудника 
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
        /// клик по элементу списка с документами сотрудника 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Files_MouseClick(object sender, MouseEventArgs e)
        {
            //если нажали правой кнопкой мыши
            if (e.Button == MouseButtons.Right)
            {
                //то рисуем контекстное меню на позиции курсора
                contextMenuStrip2.Show(Cursor.Position);
            }
        }
        /// <summary>
        /// клик по пункту контекстого меню с документами сотрудника выгрузитьНаКомпьютер
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
        /// <summary>
        /// клик по отчетПоВакансиям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void отчетПоВакансиямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем Эексель
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Workbooks.Open(Application.StartupPath.ToString() + "\\blank.xlsx", Type.Missing, true);
            Microsoft.Office.Interop.Excel.Workbook book = app.ActiveWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.Worksheets[1];
            app.Visible = true;

            //задаем стиль шрифта
            worksheet.Rows[1].Style.Font.Bold = true;
            //рисуем заголовок отчета
            worksheet.get_Range("A1", "D1").Merge();
            worksheet.get_Range("A1", "D1").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.get_Range("A1", "D1").Font.Size = 22;
            worksheet.get_Range("A1", "D1").Value = "Отчет по вакансиям";

            //рисуем заголовок таблицы
            worksheet.get_Range("A2", "D2").Font.Bold = true;
            worksheet.Cells[2, 1].Value = "Департамент";
            worksheet.Cells[2, 2].Value = "Отдел";
            worksheet.Cells[2, 3].Value = "Открыто вакансий";
            worksheet.Cells[2, 4].Value = "Всего вакансий";
            //задаем ширину столбцам таблицы
            worksheet.Columns[1].ColumnWidth = 30;
            worksheet.Columns[2].ColumnWidth = 40;
            worksheet.Columns[3].ColumnWidth = 20;
            worksheet.Columns[4].ColumnWidth = 20;

            //заполняем таблицу данными
            //берем из базы все депаратменты
            this.depatmentsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Depatments);
            var departments = this.hRDepartmentDatabaseDataSet.Depatments.Rows;

            int rowNumber = 3;//текущий номер строки 3, так как в 1 строке - заголовок отчета, во 2 - заголовок таблицы, а начиначя  с 3 мы будем  рисовать само тело таблицы
            //идем по каждому депараменту
            for (int i = 0; i < departments.Count; i++)
            {
                //берем из базы все отделы данного департамента
                var departament = departments[i] as DepatmentsRow;
                this.divisionsTableAdapter.FillGetDivisionsByDepartment(this.hRDepartmentDatabaseDataSet.Divisions, departament.Id);
                var divisions = this.hRDepartmentDatabaseDataSet.Divisions.Rows;

                //пустой департамент не берем в отчет
                if (divisions.Count == 0)
                {
                    continue;
                }

                //опять стили - шрифт - обычный
                worksheet.Rows[i + 3].Style.Font.Bold = false;


                //объединяем строки в столбце Департамент (для красоты)
                worksheet.get_Range($"A{rowNumber}", $"A{rowNumber + divisions.Count - 1}").Merge();

                //идем по каждому отделу
                for (int j = 0; j < divisions.Count; j++)
                {
                    var division = divisions[j] as DivisionsRow;
                    //и заполняем ячейки соотвтетствующими данными
                    //Департамент
                    worksheet.get_Range($"A{rowNumber}").Value = departament.Name;
                    //Отдел
                    worksheet.get_Range($"B{rowNumber}").Value = division.Name;
                    //Открыто вакансий
                    this.postsTableAdapter.FillGetOpenedPostsByDivision(this.hRDepartmentDatabaseDataSet.Posts, division.Id);
                    worksheet.get_Range($"C{rowNumber}").Value = this.hRDepartmentDatabaseDataSet.Posts.Count;
                    //Всего вакансий
                    this.postsTableAdapter.FillGetPostsByDivision(this.hRDepartmentDatabaseDataSet.Posts, division.Id);
                    worksheet.get_Range($"D{rowNumber}").Value = this.hRDepartmentDatabaseDataSet.Posts.Count;
                    //счтечик текущей строки увелиичваем
                    rowNumber++;
                }
            }
            //здесь заполняем итоговую строку с итоговыми данными
            worksheet.get_Range($"A{rowNumber}", $"B{rowNumber}").Merge();
            worksheet.get_Range($"A{rowNumber}", $"B{rowNumber}").Value = "Итого";
            worksheet.get_Range($"C{rowNumber}").Formula = $"=SUM(C3:C{rowNumber - 1})";
            worksheet.get_Range($"D{rowNumber}").Formula = $"=SUM(D3:D{rowNumber - 1})";
            //задаем стили границ таблицы
            worksheet.get_Range("A2", $"D{rowNumber}").Borders.LineStyle = BorderStyle.FixedSingle;
        }
        /// <summary>
        /// клик по отчетПоСотрудникам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void отчетПоСотрудникамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем Эексель
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Workbooks.Open(Application.StartupPath.ToString() + "\\blank.xlsx", Type.Missing, true);
            Microsoft.Office.Interop.Excel.Workbook book = app.ActiveWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.Worksheets[1];
            app.Visible = true;
            //задаем стиль шрифта
            worksheet.Rows[1].Style.Font.Bold = true;
            //рисуем заголовок отчета
            worksheet.get_Range("A1", "D1").Merge();
            worksheet.get_Range("A1", "D1").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.get_Range("A1", "D1").Font.Size = 22;
            worksheet.get_Range("A1", "D1").Value = "Отчет по сотрудникам";

            //рисуем заголовок таблицы
            worksheet.get_Range("A2", "D2").Font.Bold = true;
            worksheet.Cells[2, 1].Value = "Департамент";
            worksheet.Cells[2, 2].Value = "Отдел";
            worksheet.Cells[2, 3].Value = "Всего сотрудников";
            worksheet.Cells[2, 4].Value = "Средний оклад";

            worksheet.Columns[1].ColumnWidth = 30;
            worksheet.Columns[2].ColumnWidth = 40;
            worksheet.Columns[3].ColumnWidth = 20;
            worksheet.Columns[4].ColumnWidth = 20;
            //заполняем таблицу данными

            //берем из базы все депаратменты
            this.depatmentsTableAdapter.Fill(this.hRDepartmentDatabaseDataSet.Depatments);
            var departments = this.hRDepartmentDatabaseDataSet.Depatments.Rows;

            int rowNumber = 3;//текущий номер строки 3, так как в 1 строке - заголовок отчета, во 2 - заголовок таблицы, а начиначя  с 3 мы будем  рисовать само тело таблицы
            //идем по каждому депараменту
            for (int i = 0; i < departments.Count; i++)
            {
                //берем из базы все отделы данного департамента
                var departament = departments[i] as DepatmentsRow;
                this.divisionsTableAdapter.FillGetDivisionsByDepartment(this.hRDepartmentDatabaseDataSet.Divisions, departament.Id);
                var divisions = this.hRDepartmentDatabaseDataSet.Divisions.Rows;

                //пустой департамент не берем в отчет
                if (divisions.Count == 0)
                {
                    continue;
                }

                //опять стили - шрифт - обычный
                worksheet.Rows[i + 3].Style.Font.Bold = false;
     
                //объединяем строки в столбце Департамент (для красоты)
                worksheet.get_Range($"A{rowNumber}", $"A{rowNumber + divisions.Count - 1}").Merge();
                //идем по каждому отделу
                for (int j = 0; j < divisions.Count; j++)
                {
                    var division = divisions[j] as DivisionsRow;
                    //Департамент
                    worksheet.get_Range($"A{rowNumber}").Value = departament.Name;
                    //Отдел
                    worksheet.get_Range($"B{rowNumber}").Value = division.Name;
                    //Всего сотрудников
                    this.employeesTableAdapter.FillGetEmployeesByDivision(this.hRDepartmentDatabaseDataSet.Employees, division.Id);
                    worksheet.get_Range($"C{rowNumber}").Value = this.hRDepartmentDatabaseDataSet.Employees.Count;
                    //Средний оклад
                    var avgSalary = 0.0;
                    if (this.hRDepartmentDatabaseDataSet.Employees.Count > 0)
                    {
                        avgSalary = this.hRDepartmentDatabaseDataSet.Employees.Average(x => x.Salary);
                    }
                    worksheet.get_Range($"D{rowNumber}").Value = avgSalary;
                    rowNumber++;
                }
            }
            //здесь заполняем итоговую строку с итоговыми данными
            worksheet.get_Range($"A{rowNumber}", $"B{rowNumber}").Merge();
            worksheet.get_Range($"A{rowNumber}", $"B{rowNumber}").Value = "Итого";
            worksheet.get_Range($"C{rowNumber}").Formula = $"=SUM(C3:C{rowNumber - 1})";
            worksheet.get_Range($"D{rowNumber}").Formula = $"=AVERAGE(D3:D{rowNumber - 1})";
            //задаем стили границ таблицы
            worksheet.get_Range("A2", $"D{rowNumber}").Borders.LineStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// клик по управлениеРолямиПользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void управлениеРолямиПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем соответствующую форму
            new Form_UserRolesEditor().ShowDialog();
        }

        /// <summary>
        /// клик по Обновить структуру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_RefreshTreeview_Click(object sender, EventArgs e)
        {
            //ниже рисуем структуру предприятия  в treeview
            RefreshTreeview();
        }
    }
}
