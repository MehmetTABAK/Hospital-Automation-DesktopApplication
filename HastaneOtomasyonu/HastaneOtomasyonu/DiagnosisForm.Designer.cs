
namespace HastaneOtomasyonu
{
    partial class DiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.label4 = new System.Windows.Forms.Label();
            this.ekleTb = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Button();
            this.diagGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.patIdCb = new System.Windows.Forms.ComboBox();
            this.kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reçete = new System.Windows.Forms.Button();
            this.anamenü = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diagID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.patName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.semptom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.patMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.teshis = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bolumTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ilac = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.docTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.teshisözeti = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.docNamelbl = new System.Windows.Forms.Label();
            this.patNamelbl = new System.Windows.Forms.Label();
            this.semptomlbl = new System.Windows.Forms.Label();
            this.ilaclbl = new System.Windows.Forms.Label();
            this.teshislbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.diagGv)).BeginInit();
            this.panel1.SuspendLayout();
            this.teshisözeti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(521, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 33);
            this.label4.TabIndex = 49;
            this.label4.Text = "EKLENECEKLER";
            // 
            // ekleTb
            // 
            this.ekleTb.Location = new System.Drawing.Point(399, 156);
            this.ekleTb.Multiline = true;
            this.ekleTb.Name = "ekleTb";
            this.ekleTb.Size = new System.Drawing.Size(491, 213);
            this.ekleTb.TabIndex = 48;
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.Color.DarkRed;
            this.mail.FlatAppearance.BorderSize = 0;
            this.mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mail.Location = new System.Drawing.Point(703, 385);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(184, 39);
            this.mail.TabIndex = 47;
            this.mail.Text = "E-POSTA";
            this.mail.UseVisualStyleBackColor = false;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // diagGv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.diagGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.diagGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.diagGv.ColumnHeadersHeight = 15;
            this.diagGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.diagGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.diagGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.diagGv.Location = new System.Drawing.Point(30, 515);
            this.diagGv.Name = "diagGv";
            this.diagGv.RowHeadersVisible = false;
            this.diagGv.Size = new System.Drawing.Size(857, 222);
            this.diagGv.TabIndex = 46;
            this.diagGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.diagGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.diagGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.diagGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.diagGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.diagGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.diagGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.diagGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.diagGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.diagGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diagGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.diagGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.diagGv.ThemeStyle.HeaderStyle.Height = 15;
            this.diagGv.ThemeStyle.ReadOnly = false;
            this.diagGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.diagGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.diagGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diagGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.diagGv.ThemeStyle.RowsStyle.Height = 22;
            this.diagGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.diagGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.diagGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diagGv_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(219, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 37);
            this.label2.TabIndex = 44;
            this.label2.Text = "Kontrolü Yapılan Hastalar Listesi";
            // 
            // patIdCb
            // 
            this.patIdCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.patIdCb.FormattingEnabled = true;
            this.patIdCb.Location = new System.Drawing.Point(29, 145);
            this.patIdCb.Name = "patIdCb";
            this.patIdCb.Size = new System.Drawing.Size(176, 28);
            this.patIdCb.TabIndex = 43;
            this.patIdCb.Text = "Hasta ID";
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
            this.kapat.TabIndex = 31;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
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
            // reçete
            // 
            this.reçete.BackColor = System.Drawing.Color.DarkRed;
            this.reçete.FlatAppearance.BorderSize = 0;
            this.reçete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reçete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reçete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reçete.Location = new System.Drawing.Point(399, 385);
            this.reçete.Name = "reçete";
            this.reçete.Size = new System.Drawing.Size(184, 39);
            this.reçete.TabIndex = 45;
            this.reçete.Text = "REÇETE YAZDIR";
            this.reçete.UseVisualStyleBackColor = false;
            this.reçete.Click += new System.EventHandler(this.reçete_Click);
            // 
            // anamenü
            // 
            this.anamenü.BackColor = System.Drawing.Color.Purple;
            this.anamenü.FlatAppearance.BorderSize = 0;
            this.anamenü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anamenü.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.anamenü.Location = new System.Drawing.Point(149, 423);
            this.anamenü.Name = "anamenü";
            this.anamenü.Size = new System.Drawing.Size(85, 52);
            this.anamenü.TabIndex = 42;
            this.anamenü.Text = "ANA MENÜ";
            this.anamenü.UseVisualStyleBackColor = false;
            this.anamenü.Click += new System.EventHandler(this.anamenü_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Purple;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sil.Location = new System.Drawing.Point(240, 365);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(85, 52);
            this.sil.TabIndex = 41;
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
            this.güncelle.Location = new System.Drawing.Point(149, 365);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(85, 52);
            this.güncelle.TabIndex = 40;
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
            this.ekle.Location = new System.Drawing.Point(58, 365);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(85, 52);
            this.ekle.TabIndex = 39;
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
            // diagID
            // 
            this.diagID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.diagID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.diagID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.diagID.HintForeColor = System.Drawing.Color.Empty;
            this.diagID.HintText = "Hastalık ID";
            this.diagID.isPassword = false;
            this.diagID.LineFocusedColor = System.Drawing.Color.Blue;
            this.diagID.LineIdleColor = System.Drawing.Color.Gray;
            this.diagID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.diagID.LineThickness = 3;
            this.diagID.Location = new System.Drawing.Point(212, 145);
            this.diagID.Margin = new System.Windows.Forms.Padding(4);
            this.diagID.Name = "diagID";
            this.diagID.Size = new System.Drawing.Size(176, 32);
            this.diagID.TabIndex = 50;
            this.diagID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // patName
            // 
            this.patName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patName.Enabled = false;
            this.patName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patName.HintForeColor = System.Drawing.Color.Empty;
            this.patName.HintText = "";
            this.patName.isPassword = false;
            this.patName.LineFocusedColor = System.Drawing.Color.Blue;
            this.patName.LineIdleColor = System.Drawing.Color.Gray;
            this.patName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.patName.LineThickness = 3;
            this.patName.Location = new System.Drawing.Point(28, 185);
            this.patName.Margin = new System.Windows.Forms.Padding(4);
            this.patName.Name = "patName";
            this.patName.Size = new System.Drawing.Size(176, 32);
            this.patName.TabIndex = 51;
            this.patName.Text = "Hasta İsim";
            this.patName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // semptom
            // 
            this.semptom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.semptom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.semptom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.semptom.HintForeColor = System.Drawing.Color.Empty;
            this.semptom.HintText = "Semptomlar";
            this.semptom.isPassword = false;
            this.semptom.LineFocusedColor = System.Drawing.Color.Blue;
            this.semptom.LineIdleColor = System.Drawing.Color.Gray;
            this.semptom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.semptom.LineThickness = 3;
            this.semptom.Location = new System.Drawing.Point(212, 185);
            this.semptom.Margin = new System.Windows.Forms.Padding(4);
            this.semptom.Name = "semptom";
            this.semptom.Size = new System.Drawing.Size(176, 32);
            this.semptom.TabIndex = 52;
            this.semptom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // patMail
            // 
            this.patMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patMail.Enabled = false;
            this.patMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patMail.HintForeColor = System.Drawing.Color.Empty;
            this.patMail.HintText = "";
            this.patMail.isPassword = false;
            this.patMail.LineFocusedColor = System.Drawing.Color.Blue;
            this.patMail.LineIdleColor = System.Drawing.Color.Gray;
            this.patMail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.patMail.LineThickness = 3;
            this.patMail.Location = new System.Drawing.Point(28, 225);
            this.patMail.Margin = new System.Windows.Forms.Padding(4);
            this.patMail.Name = "patMail";
            this.patMail.Size = new System.Drawing.Size(176, 32);
            this.patMail.TabIndex = 53;
            this.patMail.Text = "Hasta Mail";
            this.patMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // teshis
            // 
            this.teshis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.teshis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.teshis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teshis.HintForeColor = System.Drawing.Color.Empty;
            this.teshis.HintText = "Teşhis";
            this.teshis.isPassword = false;
            this.teshis.LineFocusedColor = System.Drawing.Color.Blue;
            this.teshis.LineIdleColor = System.Drawing.Color.Gray;
            this.teshis.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.teshis.LineThickness = 3;
            this.teshis.Location = new System.Drawing.Point(212, 225);
            this.teshis.Margin = new System.Windows.Forms.Padding(4);
            this.teshis.Name = "teshis";
            this.teshis.Size = new System.Drawing.Size(176, 32);
            this.teshis.TabIndex = 54;
            this.teshis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bolumTb
            // 
            this.bolumTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bolumTb.Enabled = false;
            this.bolumTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bolumTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bolumTb.HintForeColor = System.Drawing.Color.Empty;
            this.bolumTb.HintText = "";
            this.bolumTb.isPassword = false;
            this.bolumTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.bolumTb.LineIdleColor = System.Drawing.Color.Gray;
            this.bolumTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bolumTb.LineThickness = 3;
            this.bolumTb.Location = new System.Drawing.Point(29, 265);
            this.bolumTb.Margin = new System.Windows.Forms.Padding(4);
            this.bolumTb.Name = "bolumTb";
            this.bolumTb.Size = new System.Drawing.Size(176, 32);
            this.bolumTb.TabIndex = 55;
            this.bolumTb.Text = "Gittiği Bölüm";
            this.bolumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ilac
            // 
            this.ilac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ilac.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ilac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ilac.HintForeColor = System.Drawing.Color.Empty;
            this.ilac.HintText = "İlaçlar";
            this.ilac.isPassword = false;
            this.ilac.LineFocusedColor = System.Drawing.Color.Blue;
            this.ilac.LineIdleColor = System.Drawing.Color.Gray;
            this.ilac.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ilac.LineThickness = 3;
            this.ilac.Location = new System.Drawing.Point(212, 265);
            this.ilac.Margin = new System.Windows.Forms.Padding(4);
            this.ilac.Name = "ilac";
            this.ilac.Size = new System.Drawing.Size(176, 32);
            this.ilac.TabIndex = 56;
            this.ilac.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // docTb
            // 
            this.docTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docTb.Enabled = false;
            this.docTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.docTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docTb.HintForeColor = System.Drawing.Color.Empty;
            this.docTb.HintText = "";
            this.docTb.isPassword = false;
            this.docTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.docTb.LineIdleColor = System.Drawing.Color.Gray;
            this.docTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.docTb.LineThickness = 3;
            this.docTb.Location = new System.Drawing.Point(30, 305);
            this.docTb.Margin = new System.Windows.Forms.Padding(4);
            this.docTb.Name = "docTb";
            this.docTb.Size = new System.Drawing.Size(176, 32);
            this.docTb.TabIndex = 57;
            this.docTb.Text = "Gittiği Doktor";
            this.docTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // teshisözeti
            // 
            this.teshisözeti.Controls.Add(this.label7);
            this.teshisözeti.Controls.Add(this.label6);
            this.teshisözeti.Controls.Add(this.label5);
            this.teshisözeti.Controls.Add(this.docNamelbl);
            this.teshisözeti.Controls.Add(this.patNamelbl);
            this.teshisözeti.Controls.Add(this.semptomlbl);
            this.teshisözeti.Controls.Add(this.ilaclbl);
            this.teshisözeti.Controls.Add(this.teshislbl);
            this.teshisözeti.Controls.Add(this.label3);
            this.teshisözeti.Location = new System.Drawing.Point(904, 156);
            this.teshisözeti.Name = "teshisözeti";
            this.teshisözeti.Size = new System.Drawing.Size(10, 10);
            this.teshisözeti.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(135, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "MyHospital Hastanesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(362, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kaşe Ve İmza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(362, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 8;
            // 
            // docNamelbl
            // 
            this.docNamelbl.AutoSize = true;
            this.docNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.docNamelbl.ForeColor = System.Drawing.Color.Black;
            this.docNamelbl.Location = new System.Drawing.Point(362, 197);
            this.docNamelbl.Name = "docNamelbl";
            this.docNamelbl.Size = new System.Drawing.Size(0, 16);
            this.docNamelbl.TabIndex = 7;
            // 
            // patNamelbl
            // 
            this.patNamelbl.AutoSize = true;
            this.patNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.patNamelbl.ForeColor = System.Drawing.Color.Black;
            this.patNamelbl.Location = new System.Drawing.Point(70, 62);
            this.patNamelbl.Name = "patNamelbl";
            this.patNamelbl.Size = new System.Drawing.Size(0, 24);
            this.patNamelbl.TabIndex = 6;
            // 
            // semptomlbl
            // 
            this.semptomlbl.AutoSize = true;
            this.semptomlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.semptomlbl.ForeColor = System.Drawing.Color.Black;
            this.semptomlbl.Location = new System.Drawing.Point(272, 62);
            this.semptomlbl.Name = "semptomlbl";
            this.semptomlbl.Size = new System.Drawing.Size(0, 24);
            this.semptomlbl.TabIndex = 5;
            // 
            // ilaclbl
            // 
            this.ilaclbl.AutoSize = true;
            this.ilaclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilaclbl.ForeColor = System.Drawing.Color.Black;
            this.ilaclbl.Location = new System.Drawing.Point(272, 127);
            this.ilaclbl.Name = "ilaclbl";
            this.ilaclbl.Size = new System.Drawing.Size(0, 24);
            this.ilaclbl.TabIndex = 4;
            // 
            // teshislbl
            // 
            this.teshislbl.AutoSize = true;
            this.teshislbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teshislbl.ForeColor = System.Drawing.Color.Black;
            this.teshislbl.Location = new System.Drawing.Point(70, 127);
            this.teshislbl.Name = "teshislbl";
            this.teshislbl.Size = new System.Drawing.Size(0, 24);
            this.teshislbl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(188, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "REÇETE";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(914, 753);
            this.Controls.Add(this.teshisözeti);
            this.Controls.Add(this.docTb);
            this.Controls.Add(this.ilac);
            this.Controls.Add(this.bolumTb);
            this.Controls.Add(this.teshis);
            this.Controls.Add(this.patMail);
            this.Controls.Add(this.semptom);
            this.Controls.Add(this.patName);
            this.Controls.Add(this.diagID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ekleTb);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.diagGv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patIdCb);
            this.Controls.Add(this.reçete);
            this.Controls.Add(this.anamenü);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagGv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.teshisözeti.ResumeLayout(false);
            this.teshisözeti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ekleTb;
        private System.Windows.Forms.Button mail;
        private Guna.UI2.WinForms.Guna2DataGridView diagGv;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox patIdCb;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reçete;
        private System.Windows.Forms.Button anamenü;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox diagID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox semptom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox teshis;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ilac;
        private System.Windows.Forms.Panel teshisözeti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label docNamelbl;
        private System.Windows.Forms.Label patNamelbl;
        private System.Windows.Forms.Label semptomlbl;
        private System.Windows.Forms.Label ilaclbl;
        private System.Windows.Forms.Label teshislbl;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox patName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox patMail;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bolumTb;
        public Bunifu.Framework.UI.BunifuMaterialTextbox docTb;
    }
}