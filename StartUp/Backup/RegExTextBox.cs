using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegExControls
{
    public partial class RegExTextBox : TextBox 
    {

#region "Declarations"

        private string mRegularExpression;

#endregion


#region "Properties"

        public string Regular_Expression
        {
            get
            {
                return mRegularExpression;
            }
            set
            {
                mRegularExpression = value;
            }
        }

#endregion


#region "Constructor"

        public RegExTextBox()
        {
            InitializeComponent();
        }

#endregion


#region "Methods"

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }

        public bool ValidateControl()
        {
            string TextToValidate;
            Regex expression;

            try
            {
                TextToValidate = this.Text;
                expression = new Regex(Regular_Expression);
            }
            catch
            {
                return false;
            }

            // test text with expression
            if (expression.IsMatch(TextToValidate))
            {
                return true;
            }
            else
            {
                // no match
                return false;
            }
        }

#endregion


    }
}
