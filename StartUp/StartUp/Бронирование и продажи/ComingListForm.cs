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
    public partial class ComingListForm : Form
    {
        public ComingListForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            NewComingForm newComingForm = new NewComingForm();
            newComingForm.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void xbtn_Click(object sender, EventArgs e)
        {

        }

        private void Acceptbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
