
namespace HastaneOtomasyonu
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.docCb = new System.Windows.Forms.ComboBox();
            this.bolumCb = new System.Windows.Forms.ComboBox();
            this.patEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.hastaGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bloodCb = new System.Windows.Forms.ComboBox();
            this.genderCb = new System.Windows.Forms.ComboBox();
            this.majorTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.patAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.patPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.patAdrss = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.patName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.anamenü = new System.Windows.Forms.Button();
            this.patId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kapat = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hastaGv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // docCb
            // 
            this.docCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.docCb.FormattingEnabled = true;
            this.docCb.Location = new System.Drawing.Point(40, 483);
            this.docCb.Name = "docCb";
            this.docCb.Size = new System.Drawing.Size(267, 28);
            this.docCb.TabIndex = 55;
            this.docCb.Text = "Gidilecek Doktor";
            // 
            // bolumCb
            // 
            this.bolumCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolumCb.FormattingEnabled = true;
            this.bolumCb.Items.AddRange(new object[] {
            "Aile Hekimi",
            "Çocuk Hastalıkları",
            "Dahiliye",
            "Genel Cerrahi",
            "Kadın Doğum",
            "Kadın Hastalıkları",
            "Kardiyoloji",
            "Kulak-Burun-Boğaz",
            "Psikiyatri",
            "Üroloji"});
            this.bolumCb.Location = new System.Drawing.Point(40, 449);
            this.bolumCb.Name = "bolumCb";
            this.bolumCb.Size = new System.Drawing.Size(267, 28);
            this.bolumCb.TabIndex = 54;
            this.bolumCb.Text = "Gidilecek Bölüm";
            this.bolumCb.SelectedIndexChanged += new System.EventHandler(this.bolumCb_SelectedIndexChanged);
            // 
            // patEmail
            // 
            this.patEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patEmail.HintForeColor = System.Drawing.Color.Empty;
            this.patEmail.HintText = "Hasta Email";
            this.patEmail.isPassword = false;
            this.patEmail.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.patEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.patEmail.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.patEmail.LineThickness = 3;
            this.patEmail.Location = new System.Drawing.Point(40, 302);
            this.patEmail.Margin = new System.Windows.Forms.Padding(4);
            this.patEmail.Name = "patEmail";
            this.patEmail.Size = new System.Drawing.Size(267, 32);
            this.patEmail.TabIndex = 53;
            this.patEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // hastaGv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.hastaGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hastaGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.hastaGv.ColumnHeadersHeight = 15;
            this.hastaGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hastaGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.hastaGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.hastaGv.Location = new System.Drawing.Point(328, 169);
            this.hastaGv.Name = "hastaGv";
            this.hastaGv.RowHeadersVisible = false;
            this.hastaGv.Size = new System.Drawing.Size(574, 553);
            this.hastaGv.TabIndex = 52;
            this.hastaGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.hastaGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.hastaGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.hastaGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.hastaGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.hastaGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.hastaGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.hastaGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.hastaGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.hastaGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.hastaGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.hastaGv.ThemeStyle.HeaderStyle.Height = 15;
            this.hastaGv.ThemeStyle.ReadOnly = false;
            this.hastaGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.hastaGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.hastaGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.hastaGv.ThemeStyle.RowsStyle.Height = 22;
            this.hastaGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.hastaGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.hastaGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hastaGv_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(525, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 51;
            this.label2.Text = "Hasta Listesi";
            // 
            // bloodCb
            // 
            this.bloodCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bloodCb.FormattingEnabled = true;
            this.bloodCb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.bloodCb.Location = new System.Drawing.Point(40, 415);
            this.bloodCb.Name = "bloodCb";
            this.bloodCb.Size = new System.Drawing.Size(267, 28);
            this.bloodCb.TabIndex = 50;
            this.bloodCb.Text = "Kan Grubu";
            // 
            // genderCb
            // 
            this.genderCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genderCb.FormattingEnabled = true;
            this.genderCb.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.genderCb.Location = new System.Drawing.Point(40, 381);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(267, 28);
            this.genderCb.TabIndex = 49;
            this.genderCb.Text = "Cinsiyet";
            // 
            // majorTb
            // 
            this.majorTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.majorTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.majorTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.majorTb.HintForeColor = System.Drawing.Color.Empty;
            this.majorTb.HintText = "Hastalık Derecesi";
            this.majorTb.isPassword = false;
            this.majorTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.majorTb.LineIdleColor = System.Drawing.Color.Gray;
            this.majorTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.majorTb.LineThickness = 3;
            this.majorTb.Location = new System.Drawing.Point(40, 518);
            this.majorTb.Margin = new System.Windows.Forms.Padding(4);
            this.majorTb.Name = "majorTb";
            this.majorTb.Size = new System.Drawing.Size(267, 32);
            this.majorTb.TabIndex = 48;
            this.majorTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // patAge
            // 
            this.patAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patAge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patAge.HintForeColor = System.Drawing.Color.Empty;
            this.patAge.HintText = "Hasta Yaş";
            this.patAge.isPassword = false;
            this.patAge.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.patAge.LineIdleColor = System.Drawing.Color.Gray;
            this.patAge.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.patAge.LineThickness = 3;
            this.patAge.Location = new System.Drawing.Point(42, 342);
            this.patAge.Margin = new System.Windows.Forms.Padding(4);
            this.patAge.Name = "patAge";
            this.patAge.Size = new System.Drawing.Size(267, 32);
            this.patAge.TabIndex = 47;
            this.patAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // patPhone
            // 
            this.patPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patPhone.HintForeColor = System.Drawing.Color.Empty;
            this.patPhone.HintText = "Hasta Telefon";
            this.patPhone.isPassword = false;
            this.patPhone.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.patPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.patPhone.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.patPhone.LineThickness = 3;
            this.patPhone.Location = new System.Drawing.Point(40, 262);
            this.patPhone.Margin = new System.Windows.Forms.Padding(4);
            this.patPhone.Name = "patPhone";
            this.patPhone.Size = new System.Drawing.Size(267, 32);
            this.patPhone.TabIndex = 46;
            this.patPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // patAdrss
            // 
            this.patAdrss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patAdrss.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patAdrss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patAdrss.HintForeColor = System.Drawing.Color.Empty;
            this.patAdrss.HintText = "Hasta Adres";
            this.patAdrss.isPassword = false;
            this.patAdrss.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.patAdrss.LineIdleColor = System.Drawing.Color.Gray;
            this.patAdrss.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.patAdrss.LineThickness = 3;
            this.patAdrss.Location = new System.Drawing.Point(40, 222);
            this.patAdrss.Margin = new System.Windows.Forms.Padding(4);
            this.patAdrss.Name = "patAdrss";
            this.patAdrss.Size = new System.Drawing.Size(267, 32);
            this.patAdrss.TabIndex = 45;
            this.patAdrss.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // patName
            // 
            this.patName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patName.HintForeColor = System.Drawing.Color.Empty;
            this.patName.HintText = "Hasta İsim";
            this.patName.isPassword = false;
            this.patName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.patName.LineIdleColor = System.Drawing.Color.Gray;
            this.patName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.patName.LineThickness = 3;
            this.patName.Location = new System.Drawing.Point(41, 182);
            this.patName.Margin = new System.Windows.Forms.Padding(4);
            this.patName.Name = "patName";
            this.patName.Size = new System.Drawing.Size(267, 32);
            this.patName.TabIndex = 44;
            this.patName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // anamenü
            // 
            this.anamenü.BackColor = System.Drawing.Color.Purple;
            this.anamenü.FlatAppearance.BorderSize = 0;
            this.anamenü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anamenü.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.anamenü.Location = new System.Drawing.Point(132, 670);
            this.anamenü.Name = "anamenü";
            this.anamenü.Size = new System.Drawing.Size(85, 52);
            this.anamenü.TabIndex = 43;
            this.anamenü.Text = "ANA MENÜ";
            this.anamenü.UseVisualStyleBackColor = false;
            this.anamenü.Click += new System.EventHandler(this.anamenü_Click);
            // 
            // patId
            // 
            this.patId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patId.HintForeColor = System.Drawing.Color.Empty;
            this.patId.HintText = "Hasta ID";
            this.patId.isPassword = false;
            this.patId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.patId.LineIdleColor = System.Drawing.Color.Gray;
            this.patId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.patId.LineThickness = 3;
            this.patId.Location = new System.Drawing.Point(41, 142);
            this.patId.Margin = new System.Windows.Forms.Padding(4);
            this.patId.Name = "patId";
            this.patId.Size = new System.Drawing.Size(267, 32);
            this.patId.TabIndex = 39;
            this.patId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.Transparent;
            this.kapat.FlatAppearance.BorderSize = 0;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.ForeColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(876, 0);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(38, 32);
            this.kapat.TabIndex = 32;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Purple;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sil.Location = new System.Drawing.Point(223, 596);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(85, 52);
            this.sil.TabIndex = 42;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // güncelle
            // 
            this.güncelle.BackColor = System.Drawing.Color.Purple;
            this.güncelle.FlatAppearance.BorderSize = 0;
            this.güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.güncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.güncelle.Location = new System.Drawing.Point(132, 596);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(85, 52);
            this.güncelle.TabIndex = 41;
            this.güncelle.Text = "GÜNCELLE";
            this.güncelle.UseVisualStyleBackColor = false;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.Purple;
            this.ekle.FlatAppearance.BorderSize = 0;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ekle.Location = new System.Drawing.Point(41, 596);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(85, 52);
            this.ekle.TabIndex = 40;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.kapat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 100);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(233, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(914, 736);
            this.Controls.Add(this.docCb);
            this.Controls.Add(this.bolumCb);
            this.Controls.Add(this.patEmail);
            this.Controls.Add(this.hastaGv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bloodCb);
            this.Controls.Add(this.genderCb);
            this.Controls.Add(this.majorTb);
            this.Controls.Add(this.patAge);
            this.Controls.Add(this.patPhone);
            this.Controls.Add(this.patAdrss);
            this.Controls.Add(this.patName);
            this.Controls.Add(this.anamenü);
            this.Controls.Add(this.patId);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaGv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox docCb;
        private System.Windows.Forms.ComboBox bolumCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox patEmail;
        public Guna.UI2.WinForms.Guna2DataGridView hastaGv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bloodCb;
        private System.Windows.Forms.ComboBox genderCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox majorTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox patAge;
        private Bunifu.Framework.UI.BunifuMaterialTextbox patPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox patAdrss;
        private Bunifu.Framework.UI.BunifuMaterialTextbox patName;
        private System.Windows.Forms.Button anamenü;
        private Bunifu.Framework.UI.BunifuMaterialTextbox patId;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}