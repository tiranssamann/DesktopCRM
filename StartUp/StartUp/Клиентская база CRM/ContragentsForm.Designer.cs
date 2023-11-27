namespace StartUp.Клиентская_база_CRM
{
    partial class ContragentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContragentsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreateComingBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Acceptbtn = new System.Windows.Forms.Button();
            this.Canceltbtn = new System.Windows.Forms.Button();
            this.excelbtn = new System.Windows.Forms.Button();
            this.settingsSearchBtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKONH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NAMES,
            this.Act,
            this.Adress,
            this.Number,
            this.Email,
            this.INN,
            this.OKED,
            this.OKONH,
            this.BANK});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1560, 650);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // CreateComingBtn
            // 
            this.CreateComingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateComingBtn.BackColor = System.Drawing.Color.White;
            this.CreateComingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateComingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateComingBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateComingBtn.Image")));
            this.CreateComingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateComingBtn.Location = new System.Drawing.Point(1231, 52);
            this.CreateComingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateComingBtn.Name = "CreateComingBtn";
            this.CreateComingBtn.Size = new System.Drawing.Size(305, 46);
            this.CreateComingBtn.TabIndex = 14;
            this.CreateComingBtn.Text = "Создать контрагента";
            this.CreateComingBtn.UseVisualStyleBackColor = false;
            this.CreateComingBtn.Click += new System.EventHandler(this.CreateComingBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(28, 59);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(372, 30);
            this.textBox3.TabIndex = 16;
            // 
            // Acceptbtn
            // 
            this.Acceptbtn.BackColor = System.Drawing.Color.White;
            this.Acceptbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Acceptbtn.BackgroundImage")));
            this.Acceptbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Acceptbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Acceptbtn.ForeColor = System.Drawing.Color.Green;
            this.Acceptbtn.Location = new System.Drawing.Point(420, 54);
            this.Acceptbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Acceptbtn.Name = "Acceptbtn";
            this.Acceptbtn.Size = new System.Drawing.Size(47, 43);
            this.Acceptbtn.TabIndex = 17;
            this.Acceptbtn.UseVisualStyleBackColor = false;
            this.Acceptbtn.Click += new System.EventHandler(this.Acceptbtn_Click);
            // 
            // Canceltbtn
            // 
            this.Canceltbtn.BackColor = System.Drawing.Color.White;
            this.Canceltbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Canceltbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Canceltbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Canceltbtn.Location = new System.Drawing.Point(475, 54);
            this.Canceltbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Canceltbtn.Name = "Canceltbtn";
            this.Canceltbtn.Size = new System.Drawing.Size(47, 43);
            this.Canceltbtn.TabIndex = 18;
            this.Canceltbtn.Text = "X";
            this.Canceltbtn.UseVisualStyleBackColor = false;
            this.Canceltbtn.Click += new System.EventHandler(this.Canceltbtn_Click);
            // 
            // excelbtn
            // 
            this.excelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excelbtn.BackColor = System.Drawing.Color.White;
            this.excelbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("excelbtn.BackgroundImage")));
            this.excelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.excelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelbtn.Location = new System.Drawing.Point(1172, 52);
            this.excelbtn.Margin = new System.Windows.Forms.Padding(4);
            this.excelbtn.Name = "excelbtn";
            this.excelbtn.Size = new System.Drawing.Size(50, 46);
            this.excelbtn.TabIndex = 19;
            this.excelbtn.UseVisualStyleBackColor = false;
            this.excelbtn.Click += new System.EventHandler(this.excelbtn_Click);
            // 
            // settingsSearchBtn
            // 
            this.settingsSearchBtn.BackColor = System.Drawing.Color.White;
            this.settingsSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsSearchBtn.Location = new System.Drawing.Point(529, 54);
            this.settingsSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.settingsSearchBtn.Name = "settingsSearchBtn";
            this.settingsSearchBtn.Size = new System.Drawing.Size(241, 46);
            this.settingsSearchBtn.TabIndex = 20;
            this.settingsSearchBtn.Text = "Параметры поиска";
            this.settingsSearchBtn.UseVisualStyleBackColor = false;
            this.settingsSearchBtn.Click += new System.EventHandler(this.settingsSearchBtn_Click);
            // 
            // Id
            // 
            this.Id.FillWeight = 19.9071F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // NAMES
            // 
            this.NAMES.FillWeight = 234.1104F;
            this.NAMES.HeaderText = "Наименование";
            this.NAMES.MinimumWidth = 6;
            this.NAMES.Name = "NAMES";
            this.NAMES.ReadOnly = true;
            this.NAMES.Width = 353;
            // 
            // Act
            // 
            this.Act.FillWeight = 114.9608F;
            this.Act.HeaderText = "Договор";
            this.Act.MinimumWidth = 6;
            this.Act.Name = "Act";
            this.Act.ReadOnly = true;
            this.Act.Width = 173;
            // 
            // Adress
            // 
            this.Adress.FillWeight = 108.7806F;
            this.Adress.HeaderText = "Адрес";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 164;
            // 
            // Number
            // 
            this.Number.FillWeight = 71.89773F;
            this.Number.HeaderText = "Контакт";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 108;
            // 
            // Email
            // 
            this.Email.FillWeight = 88.40926F;
            this.Email.HeaderText = "Почта";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 134;
            // 
            // INN
            // 
            this.INN.FillWeight = 76.69469F;
            this.INN.HeaderText = "ИНН";
            this.INN.MinimumWidth = 6;
            this.INN.Name = "INN";
            this.INN.ReadOnly = true;
            this.INN.Width = 115;
            // 
            // OKED
            // 
            this.OKED.FillWeight = 75.964F;
            this.OKED.HeaderText = "ОКЭД";
            this.OKED.MinimumWidth = 6;
            this.OKED.Name = "OKED";
            this.OKED.ReadOnly = true;
            this.OKED.Width = 115;
            // 
            // OKONH
            // 
            this.OKONH.FillWeight = 76.90921F;
            this.OKONH.HeaderText = "ОКОНХ";
            this.OKONH.MinimumWidth = 6;
            this.OKONH.Name = "OKONH";
            this.OKONH.ReadOnly = true;
            this.OKONH.Width = 116;
            // 
            // BANK
            // 
            this.BANK.FillWeight = 132.3662F;
            this.BANK.HeaderText = "Банковские реквизиты";
            this.BANK.MinimumWidth = 6;
            this.BANK.Name = "BANK";
            this.BANK.ReadOnly = true;
            this.BANK.Width = 199;
            // 
            // ContragentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1555, 750);
            this.Controls.Add(this.settingsSearchBtn);
            this.Controls.Add(this.excelbtn);
            this.Controls.Add(this.Canceltbtn);
            this.Controls.Add(this.Acceptbtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CreateComingBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContragentsForm";
            this.Text = "ContragentsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CreateComingBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Acceptbtn;
        private System.Windows.Forms.Button Canceltbtn;
        private System.Windows.Forms.Button excelbtn;
        private System.Windows.Forms.Button settingsSearchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMES;
        private System.Windows.Forms.DataGridViewTextBoxColumn Act;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn INN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OKED;
        private System.Windows.Forms.DataGridViewTextBoxColumn OKONH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANK;
    }
}