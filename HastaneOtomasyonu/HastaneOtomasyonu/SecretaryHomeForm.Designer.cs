
namespace HastaneOtomasyonu
{
    partial class SecretaryHomeForm
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
            this.secName = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.secAdd = new System.Windows.Forms.PictureBox();
            this.kapat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patAdd = new System.Windows.Forms.PictureBox();
            this.docAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // secName
            // 
            this.secName.AutoSize = true;
            this.secName.BackColor = System.Drawing.Color.Transparent;
            this.secName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secName.Location = new System.Drawing.Point(11, 267);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(70, 20);
            this.secName.TabIndex = 46;
            this.secName.Text = "Sekreter";
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Red;
            this.cikis.Location = new System.Drawing.Point(-4, 290);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(119, 40);
            this.cikis.TabIndex = 45;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(465, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "SEKRETER EKLE";
            // 
            // secAdd
            // 
            this.secAdd.BackColor = System.Drawing.Color.Transparent;
            this.secAdd.Image = global::HastaneOtomasyonu.Properties.Resources.Hemşiree;
            this.secAdd.Location = new System.Drawing.Point(468, 96);
            this.secAdd.Name = "secAdd";
            this.secAdd.Size = new System.Drawing.Size(103, 83);
            this.secAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secAdd.TabIndex = 43;
            this.secAdd.TabStop = false;
            this.secAdd.Click += new System.EventHandler(this.secAdd_Click);
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.Transparent;
            this.kapat.FlatAppearance.BorderSize = 0;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.ForeColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(589, -2);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(38, 32);
            this.kapat.TabIndex = 42;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(378, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "HASTA EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(295, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "DOKTOR EKLE";
            // 
            // patAdd
            // 
            this.patAdd.BackColor = System.Drawing.Color.Transparent;
            this.patAdd.Image = global::HastaneOtomasyonu.Properties.Resources.Patient;
            this.patAdd.Location = new System.Drawing.Point(376, 235);
            this.patAdd.Name = "patAdd";
            this.patAdd.Size = new System.Drawing.Size(103, 81);
            this.patAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patAdd.TabIndex = 39;
            this.patAdd.TabStop = false;
            this.patAdd.Click += new System.EventHandler(this.patAdd_Click);
            // 
            // docAdd
            // 
            this.docAdd.BackColor = System.Drawing.Color.Transparent;
            this.docAdd.Image = global::HastaneOtomasyonu.Properties.Resources.Doctor;
            this.docAdd.Location = new System.Drawing.Point(293, 98);
            this.docAdd.Name = "docAdd";
            this.docAdd.Size = new System.Drawing.Size(103, 81);
            this.docAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.docAdd.TabIndex = 38;
            this.docAdd.TabStop = false;
            this.docAdd.Click += new System.EventHandler(this.docAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // SecretaryHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.HastaneArkaPlan;
            this.ClientSize = new System.Drawing.Size(622, 328);
            this.Controls.Add(this.secName);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secAdd);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patAdd);
            this.Controls.Add(this.docAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecretaryHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecreterHomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.secAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secName;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox secAdd;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox patAdd;
        private System.Windows.Forms.PictureBox docAdd;
        private System.Windows.Forms.Label label1;
    }
}