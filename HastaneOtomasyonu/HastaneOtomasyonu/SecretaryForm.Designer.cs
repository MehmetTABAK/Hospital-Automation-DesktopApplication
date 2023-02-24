
namespace HastaneOtomasyonu
{
    partial class SecretaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapat = new System.Windows.Forms.Button();
            this.secGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.secHome = new System.Windows.Forms.Button();
            this.secDelete = new System.Windows.Forms.Button();
            this.secUpdate = new System.Windows.Forms.Button();
            this.secAdd = new System.Windows.Forms.Button();
            this.secPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.secNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.secName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.secID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secGV)).BeginInit();
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
            this.panel1.TabIndex = 45;
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
            // secGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.secGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.secGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.secGV.ColumnHeadersHeight = 15;
            this.secGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.secGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.secGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.secGV.Location = new System.Drawing.Point(337, 186);
            this.secGV.Name = "secGV";
            this.secGV.RowHeadersVisible = false;
            this.secGV.Size = new System.Drawing.Size(551, 313);
            this.secGV.TabIndex = 55;
            this.secGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.secGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.secGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.secGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.secGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.secGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.secGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.secGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.secGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.secGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.secGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.secGV.ThemeStyle.HeaderStyle.Height = 15;
            this.secGV.ThemeStyle.ReadOnly = false;
            this.secGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.secGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.secGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.secGV.ThemeStyle.RowsStyle.Height = 22;
            this.secGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.secGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.secGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.secGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(505, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 37);
            this.label2.TabIndex = 54;
            this.label2.Text = "Sekreter Listesi";
            // 
            // secHome
            // 
            this.secHome.BackColor = System.Drawing.Color.Purple;
            this.secHome.FlatAppearance.BorderSize = 0;
            this.secHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secHome.Location = new System.Drawing.Point(137, 447);
            this.secHome.Name = "secHome";
            this.secHome.Size = new System.Drawing.Size(85, 52);
            this.secHome.TabIndex = 53;
            this.secHome.Text = "ANA MENÜ";
            this.secHome.UseVisualStyleBackColor = false;
            this.secHome.Click += new System.EventHandler(this.secHome_Click);
            // 
            // secDelete
            // 
            this.secDelete.BackColor = System.Drawing.Color.Purple;
            this.secDelete.FlatAppearance.BorderSize = 0;
            this.secDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secDelete.Location = new System.Drawing.Point(228, 373);
            this.secDelete.Name = "secDelete";
            this.secDelete.Size = new System.Drawing.Size(85, 52);
            this.secDelete.TabIndex = 52;
            this.secDelete.Text = "SİL";
            this.secDelete.UseVisualStyleBackColor = false;
            this.secDelete.Click += new System.EventHandler(this.secDelete_Click);
            // 
            // secUpdate
            // 
            this.secUpdate.BackColor = System.Drawing.Color.Purple;
            this.secUpdate.FlatAppearance.BorderSize = 0;
            this.secUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secUpdate.Location = new System.Drawing.Point(137, 373);
            this.secUpdate.Name = "secUpdate";
            this.secUpdate.Size = new System.Drawing.Size(85, 52);
            this.secUpdate.TabIndex = 51;
            this.secUpdate.Text = "GÜNCELLE";
            this.secUpdate.UseVisualStyleBackColor = false;
            this.secUpdate.Click += new System.EventHandler(this.secUpdate_Click);
            // 
            // secAdd
            // 
            this.secAdd.BackColor = System.Drawing.Color.Purple;
            this.secAdd.FlatAppearance.BorderSize = 0;
            this.secAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secAdd.Location = new System.Drawing.Point(46, 373);
            this.secAdd.Name = "secAdd";
            this.secAdd.Size = new System.Drawing.Size(85, 52);
            this.secAdd.TabIndex = 50;
            this.secAdd.Text = "EKLE";
            this.secAdd.UseVisualStyleBackColor = false;
            this.secAdd.Click += new System.EventHandler(this.secAdd_Click);
            // 
            // secPass
            // 
            this.secPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.secPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secPass.HintForeColor = System.Drawing.Color.Empty;
            this.secPass.HintText = "Şifre Belirle";
            this.secPass.isPassword = false;
            this.secPass.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.secPass.LineIdleColor = System.Drawing.Color.Gray;
            this.secPass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.secPass.LineThickness = 3;
            this.secPass.Location = new System.Drawing.Point(46, 302);
            this.secPass.Margin = new System.Windows.Forms.Padding(4);
            this.secPass.Name = "secPass";
            this.secPass.Size = new System.Drawing.Size(267, 44);
            this.secPass.TabIndex = 49;
            this.secPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // secNumber
            // 
            this.secNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.secNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secNumber.HintForeColor = System.Drawing.Color.Empty;
            this.secNumber.HintText = "Telefon";
            this.secNumber.isPassword = false;
            this.secNumber.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.secNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.secNumber.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.secNumber.LineThickness = 3;
            this.secNumber.Location = new System.Drawing.Point(46, 250);
            this.secNumber.Margin = new System.Windows.Forms.Padding(4);
            this.secNumber.Name = "secNumber";
            this.secNumber.Size = new System.Drawing.Size(267, 44);
            this.secNumber.TabIndex = 48;
            this.secNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // secName
            // 
            this.secName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.secName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secName.HintForeColor = System.Drawing.Color.Empty;
            this.secName.HintText = "Sekreter İsim";
            this.secName.isPassword = false;
            this.secName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.secName.LineIdleColor = System.Drawing.Color.Gray;
            this.secName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.secName.LineThickness = 3;
            this.secName.Location = new System.Drawing.Point(46, 198);
            this.secName.Margin = new System.Windows.Forms.Padding(4);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(267, 44);
            this.secName.TabIndex = 47;
            this.secName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // secID
            // 
            this.secID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.secID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secID.HintForeColor = System.Drawing.Color.Empty;
            this.secID.HintText = "Sekreter ID";
            this.secID.isPassword = false;
            this.secID.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.secID.LineIdleColor = System.Drawing.Color.Gray;
            this.secID.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.secID.LineThickness = 3;
            this.secID.Location = new System.Drawing.Point(46, 146);
            this.secID.Margin = new System.Windows.Forms.Padding(4);
            this.secID.Name = "secID";
            this.secID.Size = new System.Drawing.Size(267, 44);
            this.secID.TabIndex = 46;
            this.secID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SecretaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(914, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.secGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secHome);
            this.Controls.Add(this.secDelete);
            this.Controls.Add(this.secUpdate);
            this.Controls.Add(this.secAdd);
            this.Controls.Add(this.secPass);
            this.Controls.Add(this.secNumber);
            this.Controls.Add(this.secName);
            this.Controls.Add(this.secID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecretaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretaryForm";
            this.Load += new System.EventHandler(this.SecretaryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kapat;
        private Guna.UI2.WinForms.Guna2DataGridView secGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button secHome;
        private System.Windows.Forms.Button secDelete;
        private System.Windows.Forms.Button secUpdate;
        private System.Windows.Forms.Button secAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox secPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox secNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox secName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox secID;
    }
}