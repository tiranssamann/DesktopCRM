using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestRegExControls
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


#region "Handle Validations"

        private void regExTextBox1_Validating(object sender, CancelEventArgs e)
        {
            // test the control for invalid input
            if (regExTextBox1.ValidateControl() == false)
            {
                // display error if user input is invalid
                errorProvider1.SetError(regExTextBox1, "Invalid SSN (e.g., 123-22-3344)");
            }
            else
            {
                // set error message to nothing if control
                // passes validation
                errorProvider1.SetError(regExTextBox1, "");
            }
        }

        private void regExTextBox2_Validating(object sender, CancelEventArgs e)
        {
            // test the control for invalid input
            if (regExTextBox2.ValidateControl() == false)
            {
                // display error if user input is invalid
                errorProvider1.SetError(regExTextBox2, "Invalid Phone Number (e.g., 818-720-1234)");
            }
            else
            {
                // set error message to nothing if control
                // passes validation
                errorProvider1.SetError(regExTextBox2, "");
            }
        }

        private void regExTextBox3_Validating(object sender, CancelEventArgs e)
        {
            // test the control for invalid input
            if (regExTextBox3.ValidateControl() == false)
            {
                // display error if user input is invalid
                errorProvider1.SetError(regExTextBox3, "Invalid Email Address (e.g., pres@whitehouse.gov)");
            }
            else
            {
                // set error message to nothing if control
                // passes validation
                errorProvider1.SetError(regExTextBox3, "");
            }
        }

        private void regExTextBox4_Validating(object sender, CancelEventArgs e)
        {
            // test the control for invalid input
            if (regExTextBox4.ValidateControl() == false)
            {
                // display error if user input is invalid
                errorProvider1.SetError(regExTextBox4, "Invalid IP Address (e.g., 127.0.0.1)");
            }
            else
            {
                // set error message to nothing if control
                // passes validation
                errorProvider1.SetError(regExTextBox4, "");
            }
        }

        private void regExTextBox5_Validating(object sender, CancelEventArgs e)
        {
            // test the control for invalid input
            if (regExTextBox5.ValidateControl() == false)
            {
                // display error if user input is invalid
                errorProvider1.SetError(regExTextBox5, "Invalid State Abbreviation (e.g., AZ or GA)");
            }
            else
            {
                // set error message to nothing if control
                // passes validation
                errorProvider1.SetError(regExTextBox5, "");
            }
        }

        private bool PerformFormValidation()
        {

            // check for errors to set return value
            if (regExTextBox1.ValidateControl() == false)
            {
                return false;
            }

            if (regExTextBox2.ValidateControl() == false)
            {
                return false;
            }

            if (regExTextBox3.ValidateControl() == false)
            {
                return false;
            }

            if (regExTextBox4.ValidateControl() == false)
            {
                return false;
            }

            if (regExTextBox5.ValidateControl() == false)
            {
                return false;
            }

            // if it has not found an invalid control, return with true
            return true;
        }

#endregion


        private void btnExit_Click(object sender, EventArgs e)
        {
            // test the form before allowing the user to close it
            bool valResult = PerformFormValidation();

            if (valResult == true)
                Application.Exit();
            else
                MessageBox.Show("Fix errors on this page prior to closing form");
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            // test the form
            bool valResult = PerformFormValidation();

            if (valResult == true)
                MessageBox.Show("All form fields are valid");
            else
                MessageBox.Show("This form contains errors");
        }
    }
}