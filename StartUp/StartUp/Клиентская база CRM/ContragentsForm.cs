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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;

namespace StartUp.Клиентская_база_CRM
{
    public partial class ContragentsForm : Form
    {
        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
        public ContragentsForm()
        {
            InitializeComponent();
            InitializeData();
            menu();
            dataGridView1.Columns["Id"].Visible = false;
        }
        // вывод данных в datagridview1 с базы данных
        public void InitializeData()
        {
            //test
            using (CRMContext context = new CRMContext())
            {
                var query2 = context.Contragents.ToList();
                foreach (Contragent contragent in query2)
                {
                    string contract = "";
                    if (contragent != null && contragent.Contract != null)
                    {
                        foreach (Contracts contracts in contragent.Contract)
                        {
                            contract += " ," + contracts.NameContract;
                            
                        }
                        dataGridView1.Rows.Add(contragent.ID, contragent.Name, contract,
                                contragent.Address, contragent.Number,
                                contragent.Email, contragent.Inn, contragent.OKED, contragent.OKONH,
                                contragent.BankScope);
                        contract = "";
                    }
                    else
                    {
                        dataGridView1.Rows.Add(contragent.ID, contragent.Name, "",
                                contragent.Address, contragent.Number,
                                contragent.Email, contragent.Inn, contragent.OKED, contragent.OKONH,
                                contragent.BankScope);
                    }
                }
            }
        }

        // добавление контрагента
        private void CreateComingBtn_Click(object sender, EventArgs e)
        {
            ContragentADDForm f = new ContragentADDForm();
            f.Show();
            if(f.DialogResult == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                f.Dispose();
                InitializeData();
            }
        }
        // выбор строки и активация допменю
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.dataGridView1.CurrentCell = clickedCell;
                    var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);
                    this.contextMenuStrip1.Show(dataGridView1, relativeMousePosition);
                }
            }
        }
        // инициализация интерфейса меню
        public void menu()
        {
            // инициация подменю
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Внести изменения");
            ToolStripMenuItem addactMenuItem = new ToolStripMenuItem("Добавить договор");
            ToolStripMenuItem DeleteMenuItem = new ToolStripMenuItem("Удалить контагента");
            ToolStripMenuItem actMenuItem = new ToolStripMenuItem("Акт сверки");
            // добавление иконок
            editMenuItem.Image = Properties.Resources.edit;
            addactMenuItem.Image = Properties.Resources.Act;
            DeleteMenuItem.Image = Properties.Resources.delete;
            actMenuItem.Image = Properties.Resources.Otchet;
            // добавление подменю в меню
            contextMenuStrip1.Items.AddRange(new[] { editMenuItem, addactMenuItem, DeleteMenuItem, actMenuItem });
            // добавление логики при клике на подменю
            editMenuItem.Click += editMenuItem_Click;
            addactMenuItem.Click += addactMenuItem_Click;
            DeleteMenuItem.Click += DeleteMenuItem_Click;
            actMenuItem.Click += actMenuItem_Click;
        }
        // редактирование
        void editMenuItem_Click(object sender, EventArgs e)
        {

        }
        // добавить договор контрагенту
        void addactMenuItem_Click(object sender, EventArgs e)
        {

        }
        // удаление
        void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            int delId;
            Contragent delete;
            GenericRepository<Contragent> Contragentcompile = new GenericRepository<Contragent>(new CRMContext());
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                delId = int.Parse(string.Format("{0}", item.Cells[0].Value));
                delete = Contragentcompile.FindById(delId);
                Contragentcompile.Remove(delete);
            }
            dataGridView1.Rows.Clear();
            InitializeData();

        }
        // вызов акта сверки
        void actMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        // поиск
        private void Acceptbtn_Click(object sender, EventArgs e)
        {

        }
        // параметры поиска
        private void settingsSearchBtn_Click(object sender, EventArgs e)
        {

        }
        // отмена поиска и очищение поисковой строки
        private void Canceltbtn_Click(object sender, EventArgs e){textBox3.Text = "";dataGridView1.Rows.Clear();InitializeData();}
        // сохранение в файл excel
        private void excelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".xsl";
                saveFile.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    Excel.Application exApp = new Excel.Application();
                    exApp.Workbooks.Add();
                    Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
                    workSheet.Cells[1, 1] = "Id";
                    workSheet.Cells[1, 2] = "Наименование";
                    workSheet.Cells[1, 3] = "Договор";
                    workSheet.Cells[1, 4] = "Адрес";
                    workSheet.Cells[1, 5] = "Контакт";
                    workSheet.Cells[1, 6] = "Почта";
                    workSheet.Cells[1, 7] = "ИНН";
                    workSheet.Cells[1, 8] = "ОКЭД";
                    workSheet.Cells[1, 9] = "ОКОНХ";
                    workSheet.Cells[1, 10] = "Банковские реквизиты";
                    int rowExcel = 2;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        workSheet.Cells[rowExcel, "A"] = dataGridView1.Rows[i].Cells["Id"].Value;
                        workSheet.Cells[rowExcel, "B"] = dataGridView1.Rows[i].Cells["NAMES"].Value;
                        workSheet.Cells[rowExcel, "C"] = dataGridView1.Rows[i].Cells["Act"].Value;
                        workSheet.Cells[rowExcel, "D"] = dataGridView1.Rows[i].Cells["Adress"].Value;
                        workSheet.Cells[rowExcel, "E"] = dataGridView1.Rows[i].Cells["Number"].Value;
                        workSheet.Cells[rowExcel, "F"] = dataGridView1.Rows[i].Cells["Email"].Value;
                        workSheet.Cells[rowExcel, "G"] = dataGridView1.Rows[i].Cells["INN"].Value;
                        workSheet.Cells[rowExcel, "H"] = dataGridView1.Rows[i].Cells["OKED"].Value;
                        workSheet.Cells[rowExcel, "I"] = dataGridView1.Rows[i].Cells["OKONH"].Value;
                        workSheet.Cells[rowExcel, "J"] = dataGridView1.Rows[i].Cells["BANK"].Value;
                        ++rowExcel;
                    }
                    Excel.Range s = workSheet.Range["A1:J" + dataGridView1.Rows.Count];
                    workSheet.get_Range("A1", "J1");
                    workSheet.Columns.EntireColumn.AutoFit();
                    s.HorizontalAlignment = Excel.Constants.xlCenter;
                    s.Borders.LineStyle = XlLineStyle.xlContinuous;
                    s.Borders.Color = Color.Black;
                    workSheet.SaveAs(saveFile.FileName);
                    exApp.Quit();
                }
                else if(saveFile.FileName.Length < 0){ throw new Exception("Введите название файла"); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
