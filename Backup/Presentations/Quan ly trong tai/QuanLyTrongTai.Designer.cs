﻿namespace Presentations
{
    partial class QuanLyTrongTai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTrongTai));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTrongTai = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datetimengaysinhtrongtai = new System.Windows.Forms.DateTimePicker();
            this.btxoatrongtai = new System.Windows.Forms.Button();
            this.btthemtrongtai = new System.Windows.Forms.Button();
            this.btcapnhattrongtai = new System.Windows.Forms.Button();
            this.btrefeshtrongtai = new System.Windows.Forms.Button();
            this.tbtentrongtai = new System.Windows.Forms.TextBox();
            this.tbmatrongtai = new System.Windows.Forms.TextBox();
            this.lbngaysinhtrongtai = new System.Windows.Forms.Label();
            this.lbtentrongtai = new System.Windows.Forms.Label();
            this.lbmatrongtai = new System.Windows.Forms.Label();
            this.tabDieuKhien = new System.Windows.Forms.TabPage();
            this.DK_MaTT_dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cbbmatrongtaidieukhien = new System.Windows.Forms.ComboBox();
            this.cbbmadieukhientrandau = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbbvaitrodieukhien = new System.Windows.Forms.ComboBox();
            this.lbvaitrondieukhien = new System.Windows.Forms.Label();
            this.lbmatrongtaidieukhien = new System.Windows.Forms.Label();
            this.lbmatrandaudieukhien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.quanLyBongDaDataSet = new Presentations.Data.QuanLyBongDaDataSet();
            this.dIEUKHIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEUKHIENTableAdapter = new Presentations.Data.QuanLyBongDaDataSetTableAdapters.DIEUKHIENTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabTrongTai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabDieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DK_MaTT_dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBongDaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEUKHIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabTrongTai);
            this.tabControl1.Controls.Add(this.tabDieuKhien);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 470);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.Select);
            // 
            // tabTrongTai
            // 
            this.tabTrongTai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabTrongTai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTrongTai.Controls.Add(this.dataGridView1);
            this.tabTrongTai.Controls.Add(this.datetimengaysinhtrongtai);
            this.tabTrongTai.Controls.Add(this.btxoatrongtai);
            this.tabTrongTai.Controls.Add(this.btthemtrongtai);
            this.tabTrongTai.Controls.Add(this.btcapnhattrongtai);
            this.tabTrongTai.Controls.Add(this.btrefeshtrongtai);
            this.tabTrongTai.Controls.Add(this.tbtentrongtai);
            this.tabTrongTai.Controls.Add(this.tbmatrongtai);
            this.tabTrongTai.Controls.Add(this.lbngaysinhtrongtai);
            this.tabTrongTai.Controls.Add(this.lbtentrongtai);
            this.tabTrongTai.Controls.Add(this.lbmatrongtai);
            this.tabTrongTai.ForeColor = System.Drawing.Color.Green;
            this.tabTrongTai.Location = new System.Drawing.Point(4, 33);
            this.tabTrongTai.Name = "tabTrongTai";
            this.tabTrongTai.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrongTai.Size = new System.Drawing.Size(648, 433);
            this.tabTrongTai.TabIndex = 0;
            this.tabTrongTai.Text = "Trọng Tài";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 252);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // datetimengaysinhtrongtai
            // 
            this.datetimengaysinhtrongtai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimengaysinhtrongtai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimengaysinhtrongtai.Location = new System.Drawing.Point(193, 118);
            this.datetimengaysinhtrongtai.MaxDate = new System.DateTime(1980, 12, 31, 0, 0, 0, 0);
            this.datetimengaysinhtrongtai.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.datetimengaysinhtrongtai.Name = "datetimengaysinhtrongtai";
            this.datetimengaysinhtrongtai.Size = new System.Drawing.Size(201, 29);
            this.datetimengaysinhtrongtai.TabIndex = 2;
            this.datetimengaysinhtrongtai.Value = new System.DateTime(1980, 12, 31, 0, 0, 0, 0);
            // 
            // btxoatrongtai
            // 
            this.btxoatrongtai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btxoatrongtai.BackgroundImage")));
            this.btxoatrongtai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btxoatrongtai.Location = new System.Drawing.Point(455, 50);
            this.btxoatrongtai.Name = "btxoatrongtai";
            this.btxoatrongtai.Size = new System.Drawing.Size(90, 29);
            this.btxoatrongtai.TabIndex = 4;
            this.btxoatrongtai.Text = "Xoá";
            this.btxoatrongtai.UseVisualStyleBackColor = true;
            this.btxoatrongtai.Click += new System.EventHandler(this.btxoatrongtai_Click);
            // 
            // btthemtrongtai
            // 
            this.btthemtrongtai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthemtrongtai.BackgroundImage")));
            this.btthemtrongtai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btthemtrongtai.Location = new System.Drawing.Point(455, 15);
            this.btthemtrongtai.Name = "btthemtrongtai";
            this.btthemtrongtai.Size = new System.Drawing.Size(90, 29);
            this.btthemtrongtai.TabIndex = 3;
            this.btthemtrongtai.Text = "Thêm";
            this.btthemtrongtai.UseVisualStyleBackColor = true;
            this.btthemtrongtai.Click += new System.EventHandler(this.btthemtrongtai_Click);
            // 
            // btcapnhattrongtai
            // 
            this.btcapnhattrongtai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcapnhattrongtai.BackgroundImage")));
            this.btcapnhattrongtai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btcapnhattrongtai.Location = new System.Drawing.Point(455, 85);
            this.btcapnhattrongtai.Name = "btcapnhattrongtai";
            this.btcapnhattrongtai.Size = new System.Drawing.Size(90, 29);
            this.btcapnhattrongtai.TabIndex = 5;
            this.btcapnhattrongtai.Text = "Câp nhật";
            this.btcapnhattrongtai.UseVisualStyleBackColor = true;
            this.btcapnhattrongtai.Click += new System.EventHandler(this.btcapnhattrongtai_Click);
            // 
            // btrefeshtrongtai
            // 
            this.btrefeshtrongtai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btrefeshtrongtai.BackgroundImage")));
            this.btrefeshtrongtai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btrefeshtrongtai.Location = new System.Drawing.Point(455, 130);
            this.btrefeshtrongtai.Name = "btrefeshtrongtai";
            this.btrefeshtrongtai.Size = new System.Drawing.Size(90, 29);
            this.btrefeshtrongtai.TabIndex = 6;
            this.btrefeshtrongtai.Text = "Refresh";
            this.btrefeshtrongtai.UseVisualStyleBackColor = true;
            this.btrefeshtrongtai.Click += new System.EventHandler(this.btrefeshtrongtai_Click);
            // 
            // tbtentrongtai
            // 
            this.tbtentrongtai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtentrongtai.Location = new System.Drawing.Point(193, 22);
            this.tbtentrongtai.Name = "tbtentrongtai";
            this.tbtentrongtai.Size = new System.Drawing.Size(201, 29);
            this.tbtentrongtai.TabIndex = 0;
            this.tbtentrongtai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtentrongtai_KeyPress);
            // 
            // tbmatrongtai
            // 
            this.tbmatrongtai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmatrongtai.Location = new System.Drawing.Point(193, 70);
            this.tbmatrongtai.Name = "tbmatrongtai";
            this.tbmatrongtai.Size = new System.Drawing.Size(201, 29);
            this.tbmatrongtai.TabIndex = 1;
            // 
            // lbngaysinhtrongtai
            // 
            this.lbngaysinhtrongtai.AutoSize = true;
            this.lbngaysinhtrongtai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaysinhtrongtai.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbngaysinhtrongtai.Location = new System.Drawing.Point(82, 124);
            this.lbngaysinhtrongtai.Name = "lbngaysinhtrongtai";
            this.lbngaysinhtrongtai.Size = new System.Drawing.Size(84, 21);
            this.lbngaysinhtrongtai.TabIndex = 0;
            this.lbngaysinhtrongtai.Text = "Ngày sinh";
            // 
            // lbtentrongtai
            // 
            this.lbtentrongtai.AutoSize = true;
            this.lbtentrongtai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtentrongtai.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbtentrongtai.Location = new System.Drawing.Point(82, 30);
            this.lbtentrongtai.Name = "lbtentrongtai";
            this.lbtentrongtai.Size = new System.Drawing.Size(105, 21);
            this.lbtentrongtai.TabIndex = 0;
            this.lbtentrongtai.Text = "Tên trọng tài";
            // 
            // lbmatrongtai
            // 
            this.lbmatrongtai.AutoSize = true;
            this.lbmatrongtai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatrongtai.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbmatrongtai.Location = new System.Drawing.Point(82, 73);
            this.lbmatrongtai.Name = "lbmatrongtai";
            this.lbmatrongtai.Size = new System.Drawing.Size(100, 21);
            this.lbmatrongtai.TabIndex = 0;
            this.lbmatrongtai.Text = "Mã trọng tài";
            // 
            // tabDieuKhien
            // 
            this.tabDieuKhien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabDieuKhien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDieuKhien.Controls.Add(this.DK_MaTT_dataGridView3);
            this.tabDieuKhien.Controls.Add(this.cbbmatrongtaidieukhien);
            this.tabDieuKhien.Controls.Add(this.cbbmadieukhientrandau);
            this.tabDieuKhien.Controls.Add(this.dataGridView2);
            this.tabDieuKhien.Controls.Add(this.cbbvaitrodieukhien);
            this.tabDieuKhien.Controls.Add(this.lbvaitrondieukhien);
            this.tabDieuKhien.Controls.Add(this.lbmatrongtaidieukhien);
            this.tabDieuKhien.Controls.Add(this.lbmatrandaudieukhien);
            this.tabDieuKhien.Controls.Add(this.button1);
            this.tabDieuKhien.Controls.Add(this.button2);
            this.tabDieuKhien.Controls.Add(this.button3);
            this.tabDieuKhien.Controls.Add(this.button4);
            this.tabDieuKhien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDieuKhien.ForeColor = System.Drawing.Color.Green;
            this.tabDieuKhien.Location = new System.Drawing.Point(4, 33);
            this.tabDieuKhien.Name = "tabDieuKhien";
            this.tabDieuKhien.Padding = new System.Windows.Forms.Padding(3);
            this.tabDieuKhien.Size = new System.Drawing.Size(648, 433);
            this.tabDieuKhien.TabIndex = 1;
            this.tabDieuKhien.Text = "Điều Khiển";
            // 
            // DK_MaTT_dataGridView3
            // 
            this.DK_MaTT_dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.DK_MaTT_dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DK_MaTT_dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DK_MaTT_dataGridView3.Location = new System.Drawing.Point(626, 412);
            this.DK_MaTT_dataGridView3.Name = "DK_MaTT_dataGridView3";
            this.DK_MaTT_dataGridView3.Size = new System.Drawing.Size(10, 11);
            this.DK_MaTT_dataGridView3.TabIndex = 13;
            this.DK_MaTT_dataGridView3.Visible = false;
            // 
            // cbbmatrongtaidieukhien
            // 
            this.cbbmatrongtaidieukhien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmatrongtaidieukhien.FormattingEnabled = true;
            this.cbbmatrongtaidieukhien.Location = new System.Drawing.Point(204, 105);
            this.cbbmatrongtaidieukhien.Name = "cbbmatrongtaidieukhien";
            this.cbbmatrongtaidieukhien.Size = new System.Drawing.Size(189, 29);
            this.cbbmatrongtaidieukhien.TabIndex = 2;
            this.cbbmatrongtaidieukhien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbmadieukhientrandau_KeyPress);
            // 
            // cbbmadieukhientrandau
            // 
            this.cbbmadieukhientrandau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmadieukhientrandau.FormattingEnabled = true;
            this.cbbmadieukhientrandau.Location = new System.Drawing.Point(204, 17);
            this.cbbmadieukhientrandau.Name = "cbbmadieukhientrandau";
            this.cbbmadieukhientrandau.Size = new System.Drawing.Size(189, 29);
            this.cbbmadieukhientrandau.TabIndex = 0;
            this.cbbmadieukhientrandau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbmadieukhientrandau_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 163);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(630, 262);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // cbbvaitrodieukhien
            // 
            this.cbbvaitrodieukhien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbvaitrodieukhien.FormattingEnabled = true;
            this.cbbvaitrodieukhien.Items.AddRange(new object[] {
            "Bắt chính",
            "Trợ lý trọng tài",
            "Giám sát",
            "Trọng tài thời gian"});
            this.cbbvaitrodieukhien.Location = new System.Drawing.Point(204, 59);
            this.cbbvaitrodieukhien.Name = "cbbvaitrodieukhien";
            this.cbbvaitrodieukhien.Size = new System.Drawing.Size(189, 29);
            this.cbbvaitrodieukhien.TabIndex = 1;
            this.cbbvaitrodieukhien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbmadieukhientrandau_KeyPress);
            // 
            // lbvaitrondieukhien
            // 
            this.lbvaitrondieukhien.AutoSize = true;
            this.lbvaitrondieukhien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvaitrondieukhien.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbvaitrondieukhien.Location = new System.Drawing.Point(91, 62);
            this.lbvaitrondieukhien.Name = "lbvaitrondieukhien";
            this.lbvaitrondieukhien.Size = new System.Drawing.Size(61, 21);
            this.lbvaitrondieukhien.TabIndex = 8;
            this.lbvaitrondieukhien.Text = "Vai trò";
            // 
            // lbmatrongtaidieukhien
            // 
            this.lbmatrongtaidieukhien.AutoSize = true;
            this.lbmatrongtaidieukhien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatrongtaidieukhien.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbmatrongtaidieukhien.Location = new System.Drawing.Point(92, 109);
            this.lbmatrongtaidieukhien.Name = "lbmatrongtaidieukhien";
            this.lbmatrongtaidieukhien.Size = new System.Drawing.Size(78, 21);
            this.lbmatrongtaidieukhien.TabIndex = 8;
            this.lbmatrongtaidieukhien.Text = "Trọng tài";
            // 
            // lbmatrandaudieukhien
            // 
            this.lbmatrandaudieukhien.AutoSize = true;
            this.lbmatrandaudieukhien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatrandaudieukhien.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbmatrandaudieukhien.Location = new System.Drawing.Point(91, 21);
            this.lbmatrandaudieukhien.Name = "lbmatrandaudieukhien";
            this.lbmatrandaudieukhien.Size = new System.Drawing.Size(99, 21);
            this.lbmatrandaudieukhien.TabIndex = 8;
            this.lbmatrandaudieukhien.Text = "Mã trận đấu";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(427, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btXoadk_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(427, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btThemdk_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(427, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Câp nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btCapNhatDK_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(427, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btRefreshDK_Click);
            // 
            // quanLyBongDaDataSet
            // 
            this.quanLyBongDaDataSet.DataSetName = "QuanLyBongDaDataSet";
            this.quanLyBongDaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIEUKHIENBindingSource
            // 
            this.dIEUKHIENBindingSource.DataMember = "DIEUKHIEN";
            this.dIEUKHIENBindingSource.DataSource = this.quanLyBongDaDataSet;
            // 
            // dIEUKHIENTableAdapter
            // 
            this.dIEUKHIENTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyTrongTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyTrongTai";
            this.Size = new System.Drawing.Size(656, 470);
            this.tabControl1.ResumeLayout(false);
            this.tabTrongTai.ResumeLayout(false);
            this.tabTrongTai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabDieuKhien.ResumeLayout(false);
            this.tabDieuKhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DK_MaTT_dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBongDaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEUKHIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTrongTai;
        private System.Windows.Forms.TabPage tabDieuKhien;
        private System.Windows.Forms.Button btrefeshtrongtai;
        private System.Windows.Forms.TextBox tbmatrongtai;
        private System.Windows.Forms.Label lbngaysinhtrongtai;
        private System.Windows.Forms.Label lbtentrongtai;
        private System.Windows.Forms.Label lbmatrongtai;
        private System.Windows.Forms.DateTimePicker datetimengaysinhtrongtai;
        private System.Windows.Forms.Button btxoatrongtai;
        private System.Windows.Forms.Button btthemtrongtai;
        private System.Windows.Forms.Button btcapnhattrongtai;
        private System.Windows.Forms.TextBox tbtentrongtai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbbvaitrodieukhien;
        private System.Windows.Forms.Label lbvaitrondieukhien;
        private System.Windows.Forms.Label lbmatrongtaidieukhien;
        private System.Windows.Forms.Label lbmatrandaudieukhien;
        private System.Windows.Forms.ComboBox cbbmadieukhientrandau;
        private System.Windows.Forms.ComboBox cbbmatrongtaidieukhien;
        private Presentations.Data.QuanLyBongDaDataSet quanLyBongDaDataSet;
        private System.Windows.Forms.BindingSource dIEUKHIENBindingSource;
        private Presentations.Data.QuanLyBongDaDataSetTableAdapters.DIEUKHIENTableAdapter dIEUKHIENTableAdapter;
        private System.Windows.Forms.DataGridView DK_MaTT_dataGridView3;

    }
}
