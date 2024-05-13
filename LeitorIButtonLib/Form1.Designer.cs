namespace LeitorIButtonLib
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>


        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Abrir = new System.Windows.Forms.Button();
            this.comboBoxPortasCOM = new System.Windows.Forms.ComboBox();
            this.Fechar = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listViewDados = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ibutton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewSuntech = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Normal_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InicioNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GerarTeltonika = new System.Windows.Forms.Button();
            this.GerarSuntech = new System.Windows.Forms.Button();
            this.APIuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ListViewE2815 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.GerarE2815 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InicioNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Abrir
            // 
            this.Abrir.Location = new System.Drawing.Point(12, 51);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(175, 23);
            this.Abrir.TabIndex = 0;
            this.Abrir.Text = "Abrir USB";
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // comboBoxPortasCOM
            // 
            this.comboBoxPortasCOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPortasCOM.FormattingEnabled = true;
            this.comboBoxPortasCOM.Location = new System.Drawing.Point(12, 24);
            this.comboBoxPortasCOM.Name = "comboBoxPortasCOM";
            this.comboBoxPortasCOM.Size = new System.Drawing.Size(261, 21);
            this.comboBoxPortasCOM.TabIndex = 1;
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.Location = new System.Drawing.Point(193, 52);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(80, 22);
            this.Fechar.TabIndex = 2;
            this.Fechar.Text = "Fechar USB";
            this.Fechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // listViewDados
            // 
            this.listViewDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Ibutton});
            this.listViewDados.ForeColor = System.Drawing.Color.Black;
            this.listViewDados.FullRowSelect = true;
            this.listViewDados.GridLines = true;
            this.listViewDados.HideSelection = false;
            this.listViewDados.Location = new System.Drawing.Point(17, 147);
            this.listViewDados.Name = "listViewDados";
            this.listViewDados.Size = new System.Drawing.Size(256, 549);
            this.listViewDados.TabIndex = 5;
            this.listViewDados.UseCompatibleStateImageBehavior = false;
            this.listViewDados.View = System.Windows.Forms.View.Details;
            this.listViewDados.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listViewDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeltonikaCopy);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Ibutton
            // 
            this.Ibutton.Text = "Ibutton";
            this.Ibutton.Width = 155;
            // 
            // ListViewSuntech
            // 
            this.ListViewSuntech.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewSuntech.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewSuntech.ForeColor = System.Drawing.Color.Black;
            this.ListViewSuntech.FullRowSelect = true;
            this.ListViewSuntech.GridLines = true;
            this.ListViewSuntech.HideSelection = false;
            this.ListViewSuntech.Location = new System.Drawing.Point(326, 150);
            this.ListViewSuntech.Name = "ListViewSuntech";
            this.ListViewSuntech.Size = new System.Drawing.Size(257, 549);
            this.ListViewSuntech.TabIndex = 7;
            this.ListViewSuntech.UseCompatibleStateImageBehavior = false;
            this.ListViewSuntech.View = System.Windows.Forms.View.Details;
            this.ListViewSuntech.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.ListViewSuntech.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuntechCopy);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ibutton";
            this.columnHeader4.Width = 155;
            // 
            // Normal_text
            // 
            this.Normal_text.AutoSize = true;
            this.Normal_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Normal_text.Location = new System.Drawing.Point(14, 131);
            this.Normal_text.Name = "Normal_text";
            this.Normal_text.Size = new System.Drawing.Size(51, 16);
            this.Normal_text.TabIndex = 8;
            this.Normal_text.Text = "Normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(323, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Suntech";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackgroundImage = global::LeitorIButtonLib.Properties.Resources._7858251;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(279, 406);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 63);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::LeitorIButtonLib.Properties.Resources.Inviocar_marca_final_01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1036, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 104);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // InicioNum
            // 
            this.InicioNum.Location = new System.Drawing.Point(130, 110);
            this.InicioNum.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.InicioNum.Name = "InicioNum";
            this.InicioNum.Size = new System.Drawing.Size(143, 20);
            this.InicioNum.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Proximo Numero:";
            // 
            // GerarTeltonika
            // 
            this.GerarTeltonika.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GerarTeltonika.Enabled = false;
            this.GerarTeltonika.Location = new System.Drawing.Point(900, 224);
            this.GerarTeltonika.Name = "GerarTeltonika";
            this.GerarTeltonika.Size = new System.Drawing.Size(103, 32);
            this.GerarTeltonika.TabIndex = 29;
            this.GerarTeltonika.Text = "Teltonika";
            this.GerarTeltonika.UseVisualStyleBackColor = true;
            this.GerarTeltonika.Click += new System.EventHandler(this.GerarTeltonika_Click);
            // 
            // GerarSuntech
            // 
            this.GerarSuntech.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GerarSuntech.Enabled = false;
            this.GerarSuntech.Location = new System.Drawing.Point(1009, 225);
            this.GerarSuntech.Name = "GerarSuntech";
            this.GerarSuntech.Size = new System.Drawing.Size(107, 32);
            this.GerarSuntech.TabIndex = 30;
            this.GerarSuntech.Text = "Suntech";
            this.GerarSuntech.UseVisualStyleBackColor = true;
            this.GerarSuntech.Click += new System.EventHandler(this.GerarSuntech_Click);
            // 
            // APIuser
            // 
            this.APIuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.APIuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.APIuser.Location = new System.Drawing.Point(901, 199);
            this.APIuser.Name = "APIuser";
            this.APIuser.Size = new System.Drawing.Size(322, 20);
            this.APIuser.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(898, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "API User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(957, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Enviar Motoristas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackgroundImage = global::LeitorIButtonLib.Properties.Resources._7858251;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(589, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 63);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // ListViewE2815
            // 
            this.ListViewE2815.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewE2815.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListViewE2815.ForeColor = System.Drawing.Color.Black;
            this.ListViewE2815.FullRowSelect = true;
            this.ListViewE2815.GridLines = true;
            this.ListViewE2815.HideSelection = false;
            this.ListViewE2815.Location = new System.Drawing.Point(636, 150);
            this.ListViewE2815.Name = "ListViewE2815";
            this.ListViewE2815.Size = new System.Drawing.Size(257, 549);
            this.ListViewE2815.TabIndex = 36;
            this.ListViewE2815.UseCompatibleStateImageBehavior = false;
            this.ListViewE2815.View = System.Windows.Forms.View.Details;
            this.ListViewE2815.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.ListViewE2815.KeyDown += new System.Windows.Forms.KeyEventHandler(this.E2815Copy);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ibutton";
            this.columnHeader2.Width = 155;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(633, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "VT200";
            // 
            // GerarE2815
            // 
            this.GerarE2815.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GerarE2815.Enabled = false;
            this.GerarE2815.Location = new System.Drawing.Point(1122, 225);
            this.GerarE2815.Name = "GerarE2815";
            this.GerarE2815.Size = new System.Drawing.Size(99, 32);
            this.GerarE2815.TabIndex = 41;
            this.GerarE2815.Text = "E2815";
            this.GerarE2815.UseVisualStyleBackColor = true;
            this.GerarE2815.Click += new System.EventHandler(this.E2815_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1237, 704);
            this.Controls.Add(this.GerarE2815);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ListViewE2815);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.APIuser);
            this.Controls.Add(this.GerarSuntech);
            this.Controls.Add(this.GerarTeltonika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InicioNum);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Normal_text);
            this.Controls.Add(this.ListViewSuntech);
            this.Controls.Add(this.listViewDados);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.comboBoxPortasCOM);
            this.Controls.Add(this.Abrir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Leitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InicioNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Abrir;
        private System.Windows.Forms.ComboBox comboBoxPortasCOM;
        private System.Windows.Forms.Button Fechar;
        private System.Diagnostics.EventLog eventLog1;
        private System.Diagnostics.EventLog eventLog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView listViewDados;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Ibutton;
        private System.Windows.Forms.ListView ListViewSuntech;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Normal_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GerarSuntech;
        private System.Windows.Forms.Button GerarTeltonika;
        private System.Windows.Forms.TextBox APIuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown InicioNum;
        private System.Windows.Forms.Button GerarE2815;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView ListViewE2815;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

