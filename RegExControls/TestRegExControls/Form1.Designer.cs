namespace TestRegExControls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regExTextBox5 = new RegExControls.RegExTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regExTextBox4 = new RegExControls.RegExTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regExTextBox3 = new RegExControls.RegExTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regExTextBox2 = new RegExControls.RegExTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regExTextBox1 = new RegExControls.RegExTextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.regExTextBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.regExTextBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.regExTextBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.regExTextBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.regExTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regular Expression Test Cases";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter US State Abbrev";
            // 
            // regExTextBox5
            // 
            this.regExTextBox5.Location = new System.Drawing.Point(156, 131);
            this.regExTextBox5.MaxLength = 2;
            this.regExTextBox5.Name = "regExTextBox5";
            this.regExTextBox5.Regular_Expression = "(?:(A[KLRZ]|C[AOT]|D[CE]|FL|GA|HI|I[ADLN]|K[SY]|LA|M[ADEINOST]|N[CDEHJMVY]|O[HKR]" +
                "|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY]))";
            this.regExTextBox5.Size = new System.Drawing.Size(156, 20);
            this.regExTextBox5.TabIndex = 7;
            this.regExTextBox5.Validating += new System.ComponentModel.CancelEventHandler(this.regExTextBox5_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter IP Address";
            // 
            // regExTextBox4
            // 
            this.regExTextBox4.Location = new System.Drawing.Point(156, 105);
            this.regExTextBox4.MaxLength = 15;
            this.regExTextBox4.Name = "regExTextBox4";
            this.regExTextBox4.Regular_Expression = resources.GetString("regExTextBox4.Regular_Expression");
            this.regExTextBox4.Size = new System.Drawing.Size(156, 20);
            this.regExTextBox4.TabIndex = 5;
            this.regExTextBox4.Validating += new System.ComponentModel.CancelEventHandler(this.regExTextBox4_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Email Address";
            // 
            // regExTextBox3
            // 
            this.regExTextBox3.Location = new System.Drawing.Point(156, 79);
            this.regExTextBox3.MaxLength = 50;
            this.regExTextBox3.Name = "regExTextBox3";
            this.regExTextBox3.Regular_Expression = "\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}";
            this.regExTextBox3.Size = new System.Drawing.Size(156, 20);
            this.regExTextBox3.TabIndex = 3;
            this.regExTextBox3.Validating += new System.ComponentModel.CancelEventHandler(this.regExTextBox3_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Phone Number";
            // 
            // regExTextBox2
            // 
            this.regExTextBox2.Location = new System.Drawing.Point(156, 53);
            this.regExTextBox2.MaxLength = 12;
            this.regExTextBox2.Name = "regExTextBox2";
            this.regExTextBox2.Regular_Expression = "[2-9]\\d{2}-\\d{3}-\\d{4}";
            this.regExTextBox2.Size = new System.Drawing.Size(156, 20);
            this.regExTextBox2.TabIndex = 1;
            this.regExTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.regExTextBox2_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Social Security Number";
            // 
            // regExTextBox1
            // 
            this.regExTextBox1.Location = new System.Drawing.Point(156, 27);
            this.regExTextBox1.MaxLength = 11;
            this.regExTextBox1.Name = "regExTextBox1";
            this.regExTextBox1.Regular_Expression = "\\d{3}-\\d{2}-\\d{4}";
            this.regExTextBox1.Size = new System.Drawing.Size(156, 20);
            this.regExTextBox1.TabIndex = 0;
            this.regExTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.regExTextBox1_Validating);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(169, 193);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Submit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 228);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Test RegExControls";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RegExControls.RegExTextBox regExTextBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RegExControls.RegExTextBox regExTextBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label5;
        private RegExControls.RegExTextBox regExTextBox5;
        private System.Windows.Forms.Label label4;
        private RegExControls.RegExTextBox regExTextBox4;
        private System.Windows.Forms.Label label3;
        private RegExControls.RegExTextBox regExTextBox3;

    }
}

