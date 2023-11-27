using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StartUp.Модель_базы_данных;
namespace StartUp.Клиентская_база_CRM
{
    public partial class ContragentADDForm : Form
    {
        public ContragentADDForm()
        {
            InitializeComponent();
            CreateComingBtn.DialogResult = DialogResult.OK;
            ExitPanelBtn.DialogResult = DialogResult.Cancel;
        }
        private void CreateComingBtn_Click(object sender, EventArgs e)
        {
            try{
                GenericRepository<Contragent> genericContragent = new GenericRepository<Contragent>(new CRMContext());
                Contragent contragent = new Contragent(){Name = name.Text,Number = string.Format("{0}", number.Text),Address = adress.Text,Email = regExTextBox1.Text,Inn = string.Format("{0}", inn.Text),OKED = string.Format("{0}", oked.Text),OKONH = string.Format("{0}", okonh.Text),BankScope = string.Format("{0}", bank.Text)};
                genericContragent.Create(contragent);
            }
            catch (Exception ex){MessageBox.Show(ex.Message);}
        }
        #region Проверка текстбоксов
        private void number_KeyPress(object sender, KeyPressEventArgs e){char number = e.KeyChar;if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61){e.Handled = true;}}
        private void inn_KeyPress(object sender, KeyPressEventArgs e){char number = e.KeyChar;if (!Char.IsDigit(number)){e.Handled = true;}}
        private void okonh_KeyPress(object sender, KeyPressEventArgs e){char number = e.KeyChar;if (!Char.IsDigit(number)){e.Handled = true;}}
        private void oked_KeyPress(object sender, KeyPressEventArgs e){char number = e.KeyChar;if (!Char.IsDigit(number)){e.Handled = true;}}
        private void bank_KeyPress(object sender, KeyPressEventArgs e){char number = e.KeyChar;if (!Char.IsDigit(number)){e.Handled = true;}}
        private void regExTextBox1_Validating(object sender, CancelEventArgs e){if (regExTextBox1.ValidateControl() == false){errorProvider1.SetError(regExTextBox1, "Неправильный формат почты(e.g., pres@whitehouse.gov)");}else{errorProvider1.SetError(regExTextBox1, "");}}
        private bool PerformFormValidation(){if (regExTextBox1.ValidateControl() == false){return false;}return true;}
        private void regExTextBox1_TextChanged(object sender, EventArgs e){bool valResult = PerformFormValidation();if (valResult == true){CreateComingBtn.Enabled = true;}else if (regExTextBox1.Text.Length == 0 ) { CreateComingBtn.Enabled = true; } else if(valResult == false) { CreateComingBtn.Enabled = false;  }}
        private void name_TextChanged(object sender, EventArgs e){ if (name.Text.Length == 0) { CreateComingBtn.Enabled = false; } else if (name.Text.Length > 0) { CreateComingBtn.Enabled = true; } }

        private void name_Leave(object sender, EventArgs e){if (name.Text.Length == 0) { CreateComingBtn.Enabled = false; } else if (name.Text.Length > 0) { CreateComingBtn.Enabled = true; }}
        private void name_Enter(object sender, EventArgs e){if (name.Text.Length == 0) { CreateComingBtn.Enabled = false; } else if (name.Text.Length > 0) { CreateComingBtn.Enabled = true; }}
#endregion
    }
}
