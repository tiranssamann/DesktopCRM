namespace StartUp.Клиентская_база_CRM
{
    partial class ContragentADDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContragentADDForm));
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.inn = new System.Windows.Forms.TextBox();
            this.oked = new System.Windows.Forms.TextBox();
            this.okonh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CreateComingBtn = new System.Windows.Forms.Button();
            this.ExitPanelBtn = new System.Windows.Forms.Button();
            this.regExTextBox1 = new RegExControls.RegExTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(16, 15);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(328, 22);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(353, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование организации";
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(16, 64);
            this.adress.Margin = new System.Windows.Forms.Padding(4);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(523, 22);
            this.adress.TabIndex = 3;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(16, 119);
            this.number.Margin = new System.Windows.Forms.Padding(4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(328, 22);
            this.number.TabIndex = 4;
            this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // inn
            // 
            this.inn.Location = new System.Drawing.Point(449, 169);
            this.inn.Margin = new System.Windows.Forms.Padding(4);
            this.inn.MaxLength = 12;
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(128, 22);
            this.inn.TabIndex = 6;
            this.inn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inn_KeyPress);
            // 
            // oked
            // 
            this.oked.Location = new System.Drawing.Point(337, 215);
            this.oked.Margin = new System.Windows.Forms.Padding(4);
            this.oked.Name = "oked";
            this.oked.Size = new System.Drawing.Size(227, 22);
            this.oked.TabIndex = 7;
            this.oked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oked_KeyPress);
            // 
            // okonh
            // 
            this.okonh.Location = new System.Drawing.Point(16, 215);
            this.okonh.Margin = new System.Windows.Forms.Padding(4);
            this.okonh.Name = "okonh";
            this.okonh.Size = new System.Drawing.Size(227, 22);
            this.okonh.TabIndex = 8;
            this.okonh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.okonh_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(548, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(353, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Контактный номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(367, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(587, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "ИНН";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(573, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "ОКЭД";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(252, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "ОКОНХ";
            // 
            // bank
            // 
            this.bank.Location = new System.Drawing.Point(16, 263);
            this.bank.Margin = new System.Windows.Forms.Padding(4);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(328, 22);
            this.bank.TabIndex = 15;
            this.bank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bank_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(367, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Банковские реквизиты";
            // 
            // CreateComingBtn
            // 
            this.CreateComingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateComingBtn.BackColor = System.Drawing.Color.White;
            this.CreateComingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateComingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateComingBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateComingBtn.Image")));
            this.CreateComingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateComingBtn.Location = new System.Drawing.Point(16, 316);
            this.CreateComingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateComingBtn.Name = "CreateComingBtn";
            this.CreateComingBtn.Size = new System.Drawing.Size(329, 46);
            this.CreateComingBtn.TabIndex = 17;
            this.CreateComingBtn.Text = "Добавить контрагента";
            this.CreateComingBtn.UseVisualStyleBackColor = false;
            this.CreateComingBtn.Click += new System.EventHandler(this.CreateComingBtn_Click);
            // 
            // ExitPanelBtn
            // 
            this.ExitPanelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitPanelBtn.BackColor = System.Drawing.Color.White;
            this.ExitPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitPanelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitPanelBtn.Location = new System.Drawing.Point(357, 316);
            this.ExitPanelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitPanelBtn.Name = "ExitPanelBtn";
            this.ExitPanelBtn.Size = new System.Drawing.Size(269, 46);
            this.ExitPanelBtn.TabIndex = 18;
            this.ExitPanelBtn.Text = " Отмена операции";
            this.ExitPanelBtn.UseVisualStyleBackColor = false;
            // 
            // regExTextBox1
            // 
            this.regExTextBox1.Location = new System.Drawing.Point(16, 169);
            this.regExTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.regExTextBox1.Name = "regExTextBox1";
            this.regExTextBox1.Regular_Expression = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.regExTextBox1.Size = new System.Drawing.Size(328, 22);
            this.regExTextBox1.TabIndex = 19;
            this.regExTextBox1.TextChanged += new System.EventHandler(this.regExTextBox1_TextChanged);
            this.regExTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.regExTextBox1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ContragentADDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(643, 385);
            this.Controls.Add(this.regExTextBox1);
            this.Controls.Add(this.ExitPanelBtn);
            this.Controls.Add(this.CreateComingBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okonh);
            this.Controls.Add(this.oked);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.number);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContragentADDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить Контрагента";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox adress;
        public System.Windows.Forms.TextBox number;
        public System.Windows.Forms.TextBox inn;
        public System.Windows.Forms.TextBox oked;
        public System.Windows.Forms.TextBox okonh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox bank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CreateComingBtn;
        private System.Windows.Forms.Button ExitPanelBtn;
        private RegExControls.RegExTextBox regExTextBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}