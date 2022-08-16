namespace HastaneProgramı
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastatcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastasoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastadogumyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastadogumtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaanneadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastababaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastacinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastailceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayittürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_programıDataSet7 = new HastaneProgramı.hastane_programıDataSet7();
            this.button2 = new System.Windows.Forms.Button();
            this.hastalarTableAdapter = new HastaneProgramı.hastane_programıDataSet7TableAdapters.hastalarTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_programıDataSet7)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(239, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastanın Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Ara";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(156, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Hasta Kaydı Oluştur";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaidDataGridViewTextBoxColumn,
            this.hastatcDataGridViewTextBoxColumn,
            this.hastaadDataGridViewTextBoxColumn,
            this.hastasoyadDataGridViewTextBoxColumn,
            this.hastadogumyDataGridViewTextBoxColumn,
            this.hastadogumtDataGridViewTextBoxColumn,
            this.hastaanneadiDataGridViewTextBoxColumn,
            this.hastababaadiDataGridViewTextBoxColumn,
            this.hastacinsiyetDataGridViewTextBoxColumn,
            this.hastailDataGridViewTextBoxColumn,
            this.hastailceDataGridViewTextBoxColumn,
            this.hastatelDataGridViewTextBoxColumn,
            this.hastaadresDataGridViewTextBoxColumn,
            this.kayittürüDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastalarBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(576, 197);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // hastaidDataGridViewTextBoxColumn
            // 
            this.hastaidDataGridViewTextBoxColumn.DataPropertyName = "hasta_id";
            this.hastaidDataGridViewTextBoxColumn.HeaderText = "HASTA NO";
            this.hastaidDataGridViewTextBoxColumn.Name = "hastaidDataGridViewTextBoxColumn";
            this.hastaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaidDataGridViewTextBoxColumn.Width = 73;
            // 
            // hastatcDataGridViewTextBoxColumn
            // 
            this.hastatcDataGridViewTextBoxColumn.DataPropertyName = "hasta_tc";
            this.hastatcDataGridViewTextBoxColumn.HeaderText = "KİMLİK NO";
            this.hastatcDataGridViewTextBoxColumn.Name = "hastatcDataGridViewTextBoxColumn";
            this.hastatcDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastatcDataGridViewTextBoxColumn.Width = 75;
            // 
            // hastaadDataGridViewTextBoxColumn
            // 
            this.hastaadDataGridViewTextBoxColumn.DataPropertyName = "hasta_ad";
            this.hastaadDataGridViewTextBoxColumn.HeaderText = "AD";
            this.hastaadDataGridViewTextBoxColumn.Name = "hastaadDataGridViewTextBoxColumn";
            this.hastaadDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaadDataGridViewTextBoxColumn.Width = 45;
            // 
            // hastasoyadDataGridViewTextBoxColumn
            // 
            this.hastasoyadDataGridViewTextBoxColumn.DataPropertyName = "hasta_soyad";
            this.hastasoyadDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.hastasoyadDataGridViewTextBoxColumn.Name = "hastasoyadDataGridViewTextBoxColumn";
            this.hastasoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastasoyadDataGridViewTextBoxColumn.Width = 75;
            // 
            // hastadogumyDataGridViewTextBoxColumn
            // 
            this.hastadogumyDataGridViewTextBoxColumn.DataPropertyName = "hasta_dogumy";
            this.hastadogumyDataGridViewTextBoxColumn.HeaderText = "DOĞUM YERİ";
            this.hastadogumyDataGridViewTextBoxColumn.Name = "hastadogumyDataGridViewTextBoxColumn";
            this.hastadogumyDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastadogumyDataGridViewTextBoxColumn.Width = 75;
            // 
            // hastadogumtDataGridViewTextBoxColumn
            // 
            this.hastadogumtDataGridViewTextBoxColumn.DataPropertyName = "hasta_dogumt";
            this.hastadogumtDataGridViewTextBoxColumn.HeaderText = "DOĞUM TARİHİ";
            this.hastadogumtDataGridViewTextBoxColumn.Name = "hastadogumtDataGridViewTextBoxColumn";
            this.hastadogumtDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastadogumtDataGridViewTextBoxColumn.Width = 75;
            // 
            // hastaanneadiDataGridViewTextBoxColumn
            // 
            this.hastaanneadiDataGridViewTextBoxColumn.DataPropertyName = "hasta_anneadi";
            this.hastaanneadiDataGridViewTextBoxColumn.HeaderText = "ANNE ADI";
            this.hastaanneadiDataGridViewTextBoxColumn.Name = "hastaanneadiDataGridViewTextBoxColumn";
            this.hastaanneadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaanneadiDataGridViewTextBoxColumn.Width = 75;
            // 
            // hastababaadiDataGridViewTextBoxColumn
            // 
            this.hastababaadiDataGridViewTextBoxColumn.DataPropertyName = "hasta_babaadi";
            this.hastababaadiDataGridViewTextBoxColumn.HeaderText = "BABA ADI";
            this.hastababaadiDataGridViewTextBoxColumn.Name = "hastababaadiDataGridViewTextBoxColumn";
            this.hastababaadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastababaadiDataGridViewTextBoxColumn.Width = 75;
            // 
            // hastacinsiyetDataGridViewTextBoxColumn
            // 
            this.hastacinsiyetDataGridViewTextBoxColumn.DataPropertyName = "hasta_cinsiyet";
            this.hastacinsiyetDataGridViewTextBoxColumn.HeaderText = "CİNSİYET";
            this.hastacinsiyetDataGridViewTextBoxColumn.Name = "hastacinsiyetDataGridViewTextBoxColumn";
            this.hastacinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastacinsiyetDataGridViewTextBoxColumn.Width = 45;
            // 
            // hastailDataGridViewTextBoxColumn
            // 
            this.hastailDataGridViewTextBoxColumn.DataPropertyName = "hasta_il";
            this.hastailDataGridViewTextBoxColumn.HeaderText = "İL";
            this.hastailDataGridViewTextBoxColumn.Name = "hastailDataGridViewTextBoxColumn";
            this.hastailDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastailDataGridViewTextBoxColumn.Width = 45;
            // 
            // hastailceDataGridViewTextBoxColumn
            // 
            this.hastailceDataGridViewTextBoxColumn.DataPropertyName = "hasta_ilce";
            this.hastailceDataGridViewTextBoxColumn.HeaderText = "İLÇE";
            this.hastailceDataGridViewTextBoxColumn.Name = "hastailceDataGridViewTextBoxColumn";
            this.hastailceDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastailceDataGridViewTextBoxColumn.Width = 45;
            // 
            // hastatelDataGridViewTextBoxColumn
            // 
            this.hastatelDataGridViewTextBoxColumn.DataPropertyName = "hasta_tel";
            this.hastatelDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.hastatelDataGridViewTextBoxColumn.Name = "hastatelDataGridViewTextBoxColumn";
            this.hastatelDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastatelDataGridViewTextBoxColumn.Width = 55;
            // 
            // hastaadresDataGridViewTextBoxColumn
            // 
            this.hastaadresDataGridViewTextBoxColumn.DataPropertyName = "hasta_adres";
            this.hastaadresDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.hastaadresDataGridViewTextBoxColumn.Name = "hastaadresDataGridViewTextBoxColumn";
            this.hastaadresDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaadresDataGridViewTextBoxColumn.Width = 55;
            // 
            // kayittürüDataGridViewTextBoxColumn
            // 
            this.kayittürüDataGridViewTextBoxColumn.DataPropertyName = "kayit_türü";
            this.kayittürüDataGridViewTextBoxColumn.HeaderText = "KAYIT TÜRÜ";
            this.kayittürüDataGridViewTextBoxColumn.Name = "kayittürüDataGridViewTextBoxColumn";
            this.kayittürüDataGridViewTextBoxColumn.ReadOnly = true;
            this.kayittürüDataGridViewTextBoxColumn.Width = 75;
            // 
            // hastalarBindingSource
            // 
            this.hastalarBindingSource.DataMember = "hastalar";
            this.hastalarBindingSource.DataSource = this.hastane_programıDataSet7;
            // 
            // hastane_programıDataSet7
            // 
            this.hastane_programıDataSet7.DataSetName = "hastane_programıDataSet7";
            this.hastane_programıDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(429, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 58);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hastalarTableAdapter
            // 
            this.hastalarTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 216);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Kaydı";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(264, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 59);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 409);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Doktor İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta No";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 14;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(595, 453);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_programıDataSet7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private hastane_programıDataSet7 hastane_programıDataSet7;
        private System.Windows.Forms.BindingSource hastalarBindingSource;
        private hastane_programıDataSet7TableAdapters.hastalarTableAdapter hastalarTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastatcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastasoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastadogumyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastadogumtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaanneadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastababaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastacinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastailceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastatelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayittürüDataGridViewTextBoxColumn;
    }
}