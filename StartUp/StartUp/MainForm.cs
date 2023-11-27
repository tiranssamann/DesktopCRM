using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StartUp.Модель_базы_данных;
using StartUp.Бронирование_и_продажи;
using StartUp.Клиентская_база_CRM;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
namespace StartUp
{
    public partial class MainForm : Form
    {
        Timer timer = new Timer();
        public MainForm(Employee employee)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            InitializeComponent();
            InitializeData();
            hideBar();
        }
        // вывод данных с бд
        public void InitializeData()
        {
            using(CRMContext context = new CRMContext())
            {
                var query2 = context.Drugs.ToList();
                foreach(Drugs drugs in query2)
                {
                    dataGridView1.Rows.Add(drugs.ID, drugs.NameOfDrug, drugs.Counts, drugs.FormCreations, drugs.DateOfExplotation, drugs.ComingPrice, drugs.ComingProcent,drugs.Price, drugs.Procent, drugs.Creator, drugs.SNumber);
                }
            }
        }
        // спрятать панель
        public void hideBar(){doppanel.Hide();}
        // закрытие формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e){System.Windows.Forms.Application.Exit();}
        // кнопка закрытия на панели
        private void ExitPanelBtn_Click(object sender, EventArgs e){hideBar();}
        // открытие панели
        private void DopBTN_Click_1(object sender, EventArgs e){doppanel.Show();}
        // форма прихода товаров
        private void NewComingbtn_Click(object sender, EventArgs e){ComingListForm comingListForm = new ComingListForm();comingListForm.Show();}
        // дата и время на панели
        private void timer1_Tick(object sender, EventArgs e){int h = DateTime.Now.Hour;int m = DateTime.Now.Minute;int s = DateTime.Now.Second;string time = "";if (h < 10){time += "0" + h;}else{time += h;}time += ":";if (m < 10){time += "0" + m;}else{ time += m;}time += ":";if (s < 10){time += "0" + s;}else{time += s;}label5.Text = time;string data = "";int day = DateTime.Now.Day;int month = DateTime.Now.Month;int year = DateTime.Now.Year;if (day < 10){data += "0" + day;}else{data += day;}data += ".";if (month < 10){data += "0" + month;}else{data += month;}data += ".";data += year;label4.Text = data;}
        // форма контрагента
        private void ContragentBtn_Click(object sender, EventArgs e){ContragentsForm contragentsForm = new ContragentsForm();contragentsForm.Show();}
        // excel файл
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // открытие окна куда загрузить файл
                SaveFileDialog saveFile = new SaveFileDialog();
                // формат файла
                saveFile.DefaultExt = ".xsl";
                // фильтр создания файла
                saveFile.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    // создание excel
                    Excel.Application exApp = new Excel.Application();
                    exApp.Workbooks.Add();
                    // создание листа excel
                    Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
                    // объединение ячеек
                    Excel.Range _excelCells1 = (Excel.Range)workSheet.get_Range("E1", "F1").Cells;
                    Excel.Range _excelCells2 = (Excel.Range)workSheet.get_Range("E2", "F2").Cells;
                    _excelCells2.Merge(Type.Missing);
                    _excelCells1.Merge(Type.Missing);
                    // что вписать в ячейки 
                    workSheet.Cells[1, 5] = "Остаток товара на складе";
                    workSheet.Cells[2, 5] = label4.Text;
                    workSheet.Cells[4, 1] = "Id";
                    workSheet.Cells[4, 2] = "Наименование";
                    workSheet.Cells[4, 3] = "Количество";
                    workSheet.Cells[4, 4] = "Форма выпуска";
                    workSheet.Cells[4, 5] = "Приходная цена";
                    workSheet.Cells[4, 6] = "Приходная наценка %";
                    workSheet.Cells[4, 7] = "Цена";
                    workSheet.Cells[4, 8] = "Наценка %";
                    workSheet.Cells[4, 9] = "Производитель";
                    workSheet.Cells[4, 10] = "Серийный номер";
                    // выровнить столбцы под надпись в них
                    Excel.Range _excelCells3 = (Excel.Range)workSheet.get_Range("A1", "J4").Cells;
                    _excelCells3.Columns.EntireColumn.AutoFit();
                    _excelCells3.HorizontalAlignment = Excel.Constants.xlCenter;
                    // с какой строки начать вывод данных таблицы
                    int rowExcel = 5;
                    // вывод данных в excel с datagridview
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        workSheet.Cells[rowExcel, "A"] = dataGridView1.Rows[i].Cells["Id"].Value;
                        workSheet.Cells[rowExcel, "B"] = dataGridView1.Rows[i].Cells["NameOf"].Value;
                        workSheet.Cells[rowExcel, "C"] = dataGridView1.Rows[i].Cells["Countss"].Value;
                        workSheet.Cells[rowExcel, "D"] = dataGridView1.Rows[i].Cells["FormCreations"].Value;
                        workSheet.Cells[rowExcel, "E"] = dataGridView1.Rows[i].Cells["ComingPrice"].Value;
                        workSheet.Cells[rowExcel, "F"] = dataGridView1.Rows[i].Cells["ComingProc"].Value;
                        workSheet.Cells[rowExcel, "G"] = dataGridView1.Rows[i].Cells["Prices"].Value;
                        workSheet.Cells[rowExcel, "H"] = dataGridView1.Rows[i].Cells["Procents"].Value;
                        workSheet.Cells[rowExcel, "I"] = dataGridView1.Rows[i].Cells["Creators"].Value;
                        workSheet.Cells[rowExcel, "J"] = dataGridView1.Rows[i].Cells["SerialNumber"].Value;
                        ++rowExcel;
                    }
                    // сделать из ячеек таблицу
                    int a = 3 + dataGridView1.Rows.Count;
                    Excel.Range s = workSheet.Range["A4:J" + a];
                    s.HorizontalAlignment = Excel.Constants.xlCenter;
                    s.Borders.LineStyle = XlLineStyle.xlContinuous;
                    s.Borders.Color = Color.Black;
                    // сохранить файл
                    workSheet.SaveAs(saveFile.FileName);
                    // убрать файл с использования ОЗУ
                    exApp.Quit();
                }
                else if (saveFile.FileName.Length < 0) { throw new Exception("Введите название файла"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
