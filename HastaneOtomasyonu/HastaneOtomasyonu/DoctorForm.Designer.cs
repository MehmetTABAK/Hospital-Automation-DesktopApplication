
namespace HastaneOtomasyonu
{
    partial class DoctorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapat = new System.Windows.Forms.Button();
            this.doctorGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.docBrans = new System.Windows.Forms.ComboBox();
            this.docNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.docHome = new System.Windows.Forms.Button();
            this.docDelete = new System.Windows.Forms.Button();
            this.docUpdate = new System.Windows.Forms.Button();
            this.docAdd = new System.Windows.Forms.Button();
            this.docPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.docExp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.docName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.docID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGV)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.kapat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 100);
            this.panel1.TabIndex = 34;
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
            // doctorGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.doctorGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.doctorGV.ColumnHeadersHeight = 15;
            this.doctorGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.doctorGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.doctorGV.Location = new System.Drawing.Point(339, 178);
            this.doctorGV.Name = "doctorGV";
            this.doctorGV.RowHeadersVisible = false;
            this.doctorGV.Size = new System.Drawing.Size(551, 423);
            this.doctorGV.TabIndex = 36;
            this.doctorGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.doctorGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.doctorGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.doctorGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.doctorGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.doctorGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.doctorGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.doctorGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.doctorGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.doctorGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doctorGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.doctorGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.doctorGV.ThemeStyle.HeaderStyle.Height = 15;
            this.doctorGV.ThemeStyle.ReadOnly = false;
            this.doctorGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.doctorGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.doctorGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doctorGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.doctorGV.ThemeStyle.RowsStyle.Height = 22;
            this.doctorGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.doctorGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.doctorGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(507, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 35;
            this.label2.Text = "Doktor Listesi";
            // 
            // docBrans
            // 
            this.docBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.docBrans.FormattingEnabled = true;
            this.docBrans.Items.AddRange(new object[] {
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
            this.docBrans.Location = new System.Drawing.Point(36, 261);
            this.docBrans.Name = "docBrans";
            this.docBrans.Size = new System.Drawing.Size(267, 28);
            this.docBrans.TabIndex = 46;
            this.docBrans.Text = "Branş";
            // 
            // docNumber
            // 
            this.docNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.docNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docNumber.HintForeColor = System.Drawing.Color.Empty;
            this.docNumber.HintText = "Telefon";
            this.docNumber.isPassword = false;
            this.docNumber.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.docNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.docNumber.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.docNumber.LineThickness = 3;
            this.docNumber.Location = new System.Drawing.Point(36, 348);
            this.docNumber.Margin = new System.Windows.Forms.Padding(4);
            this.docNumber.Name = "docNumber";
            this.docNumber.Size = new System.Drawing.Size(267, 44);
            this.docNumber.TabIndex = 45;
            this.docNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // docHome
            // 
            this.docHome.BackColor = System.Drawing.Color.Purple;
            this.docHome.FlatAppearance.BorderSize = 0;
            this.docHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.docHome.Location = new System.Drawing.Point(127, 550);
            this.docHome.Name = "docHome";
            this.docHome.Size = new System.Drawing.Size(85, 52);
            this.docHome.TabIndex = 44;
            this.docHome.Text = "ANA MENÜ";
            this.docHome.UseVisualStyleBackColor = false;
            this.docHome.Click += new System.EventHandler(this.docHome_Click);
            // 
            // docDelete
            // 
            this.docDelete.BackColor = System.Drawing.Color.Purple;
            this.docDelete.FlatAppearance.BorderSize = 0;
            this.docDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.docDelete.Location = new System.Drawing.Point(218, 476);
            this.docDelete.Name = "docDelete";
            this.docDelete.Size = new System.Drawing.Size(85, 52);
            this.docDelete.TabIndex = 43;
            this.docDelete.Text = "SİL";
            this.docDelete.UseVisualStyleBackColor = false;
            this.docDelete.Click += new System.EventHandler(this.docDelete_Click);
            // 
            // docUpdate
            // 
            this.docUpdate.BackColor = System.Drawing.Color.Purple;
            this.docUpdate.FlatAppearance.BorderSize = 0;
            this.docUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.docUpdate.Location = new System.Drawing.Point(127, 476);
            this.docUpdate.Name = "docUpdate";
            this.docUpdate.Size = new System.Drawing.Size(85, 52);
            this.docUpdate.TabIndex = 42;
            this.docUpdate.Text = "GÜNCELLE";
            this.docUpdate.UseVisualStyleBackColor = false;
            this.docUpdate.Click += new System.EventHandler(this.docUpdate_Click);
            // 
            // docAdd
            // 
            this.docAdd.BackColor = System.Drawing.Color.Purple;
            this.docAdd.FlatAppearance.BorderSize = 0;
            this.docAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.docAdd.Location = new System.Drawing.Point(36, 476);
            this.docAdd.Name = "docAdd";
            this.docAdd.Size = new System.Drawing.Size(85, 52);
            this.docAdd.TabIndex = 41;
            this.docAdd.Text = "EKLE";
            this.docAdd.UseVisualStyleBackColor = false;
            this.docAdd.Click += new System.EventHandler(this.docAdd_Click);
            // 
            // docPass
            // 
            this.docPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.docPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docPass.HintForeColor = System.Drawing.Color.Empty;
            this.docPass.HintText = "Şifre Belirle";
            this.docPass.isPassword = false;
            this.docPass.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.docPass.LineIdleColor = System.Drawing.Color.Gray;
            this.docPass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.docPass.LineThickness = 3;
            this.docPass.Location = new System.Drawing.Point(36, 400);
            this.docPass.Margin = new System.Windows.Forms.Padding(4);
            this.docPass.Name = "docPass";
            this.docPass.Size = new System.Drawing.Size(267, 44);
            this.docPass.TabIndex = 40;
            this.docPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // docExp
            // 
            this.docExp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docExp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.docExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docExp.HintForeColor = System.Drawing.Color.Empty;
            this.docExp.HintText = "Deneyim";
            this.docExp.isPassword = false;
            this.docExp.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.docExp.LineIdleColor = System.Drawing.Color.Gray;
            this.docExp.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.docExp.LineThickness = 3;
            this.docExp.Location = new System.Drawing.Point(36, 296);
            this.docExp.Margin = new System.Windows.Forms.Padding(4);
            this.docExp.Name = "docExp";
            this.docExp.Size = new System.Drawing.Size(267, 44);
            this.docExp.TabIndex = 39;
            this.docExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // docName
            // 
            this.docName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.docName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docName.HintForeColor = System.Drawing.Color.Empty;
            this.docName.HintText = "Doktor İsim";
            this.docName.isPassword = false;
            this.docName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.docName.LineIdleColor = System.Drawing.Color.Gray;
            this.docName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.docName.LineThickness = 3;
            this.docName.Location = new System.Drawing.Point(37, 192);
            this.docName.Margin = new System.Windows.Forms.Padding(4);
            this.docName.Name = "docName";
            this.docName.Size = new System.Drawing.Size(267, 44);
            this.docName.TabIndex = 38;
            this.docName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // docID
            // 
            this.docID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.docID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docID.HintForeColor = System.Drawing.Color.Empty;
            this.docID.HintText = "Doktor ID";
            this.docID.isPassword = false;
            this.docID.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.docID.LineIdleColor = System.Drawing.Color.Gray;
            this.docID.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.docID.LineThickness = 3;
            this.docID.Location = new System.Drawing.Point(37, 140);
            this.docID.Margin = new System.Windows.Forms.Padding(4);
            this.docID.Name = "docID";
            this.docID.Size = new System.Drawing.Size(267, 44);
            this.docID.TabIndex = 37;
            this.docID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(914, 615);
            this.Controls.Add(this.docBrans);
            this.Controls.Add(this.docNumber);
            this.Controls.Add(this.docHome);
            this.Controls.Add(this.docDelete);
            this.Controls.Add(this.docUpdate);
            this.Controls.Add(this.docAdd);
            this.Controls.Add(this.docPass);
            this.Controls.Add(this.docExp);
            this.Controls.Add(this.docName);
            this.Controls.Add(this.docID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doctorGV);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kapat;
        private Guna.UI2.WinForms.Guna2DataGridView doctorGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox docBrans;
        private Bunifu.Framework.UI.BunifuMaterialTextbox docNumber;
        private System.Windows.Forms.Button docHome;
        private System.Windows.Forms.Button docDelete;
        private System.Windows.Forms.Button docUpdate;
        private System.Windows.Forms.Button docAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox docPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox docExp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox docName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox docID;
        private System.Windows.Forms.ImageList ımageList1;
    }
}