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
using System.Configuration;
namespace StartUp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            TextPassword();
        }
        public void TextPassword()
        {
            textBox3.PasswordChar = '*';
            textBox3.CharacterCasing = CharacterCasing.Lower;
        }
        public void Config()
        {
            
            System.Configuration.Configuration config =
                   ConfigurationManager.OpenExeConfiguration(
                   ConfigurationUserLevel.None);
            int connStrCnt =
                ConfigurationManager.ConnectionStrings.Count;

            ConnectionStringSettings csSettings =
                   new ConnectionStringSettings("CRMSource",
                   $@"Data Source={comboBox1.Text}\SQLEXPRESS;" +
                   "Initial Catalog=InpitsuDataBase;user id=sa;Password=12345", "System.Data.SqlClient");
            ConnectionStringsSection csSection =
               config.ConnectionStrings;
            config.ConnectionStrings.ConnectionStrings.RemoveAt(ConfigurationManager.ConnectionStrings.Count-1);
            csSection.ConnectionStrings.Add(csSettings);
            config.Save(ConfigurationSaveMode.Modified);
        }
        public void initdate()
        {
            using (CRMContext context = new CRMContext())
            {
                var query = context.Employees.Select(p => new
                {
                    p.ID,
                    p.Login,
                    p.Password,
                    p.Number
                }).ToList();
                if (query.Count == 0) InsertUsersAndTickets();
            }
        }
        public void InsertUsersAndTickets()
        {
            GenericRepository<Employee> Userscompile = new GenericRepository<Employee>(new CRMContext());

            Employee employee1 = new Employee { Login = "admin", Password = "admin", Administrator = true, Number = "+998911234567" };

            Userscompile.Create(employee1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Config();
            initdate();
            try
            {
                using (CRMContext context = new CRMContext())
                {
                    Employee userlog = (from u in context.Employees
                                        where u.Login == textBox2.Text || u.Password == textBox3.Text
                                        select u)
                                     .FirstOrDefault();
                    if (userlog != null)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm(userlog);
                        mainForm.ShowDialog();
                    }

                    else throw new Exception("Неверное имя или пароль");
                }
            }
            catch (Exception er) { MessageBox.Show(er.Message); }
        }

        private void addIpBtn_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
        }
    }
}
