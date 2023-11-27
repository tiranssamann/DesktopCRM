using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartUp.Бронирование_и_продажи
{
    public partial class NewComingForm : Form
    {
        public NewComingForm()
        {
            InitializeComponent();
        }

        private void CreateComingBtn_Click(object sender, EventArgs e)
        {
            ComingPage newComing = new ComingPage(comboBox1.Text,comboBox2.Text,textBox2.Text);
            newComing.ShowDialog();
        }
    }
}
