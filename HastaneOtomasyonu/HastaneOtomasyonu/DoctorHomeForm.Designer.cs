
namespace HastaneOtomasyonu
{
    partial class DoctorHomeForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.grafic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patList = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patControl = new System.Windows.Forms.PictureBox();
            this.kapat = new System.Windows.Forms.Button();
            this.secName = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(373, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "YOĞUNLUK";
            // 
            // grafic
            // 
            this.grafic.BackColor = System.Drawing.Color.Transparent;
            this.grafic.Image = global::HastaneOtomasyonu.Properties.Resources.grafik;
            this.grafic.Location = new System.Drawing.Point(363, 237);
            this.grafic.Name = "grafic";
            this.grafic.Size = new System.Drawing.Size(103, 81);
            this.grafic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grafic.TabIndex = 55;
            this.grafic.TabStop = false;
            this.grafic.Click += new System.EventHandler(this.grafic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(277, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "HASTA LİSTESİ";
            // 
            // patList
            // 
            this.patList.BackColor = System.Drawing.Color.Transparent;
            this.patList.Image = global::HastaneOtomasyonu.Properties.Resources.Hastalık;
            this.patList.Location = new System.Drawing.Point(280, 111);
            this.patList.Name = "patList";
            this.patList.Size = new System.Drawing.Size(103, 81);
            this.patList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patList.TabIndex = 53;
            this.patList.TabStop = false;
            this.patList.Click += new System.EventHandler(this.patList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(456, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "HASTA KONTROL";
            // 
            // patControl
            // 
            this.patControl.BackColor = System.Drawing.Color.Transparent;
            this.patControl.Image = global::HastaneOtomasyonu.Properties.Resources.Patient;
            this.patControl.Location = new System.Drawing.Point(459, 111);
            this.patControl.Name = "patControl";
            this.patControl.Size = new System.Drawing.Size(103, 81);
            this.patControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patControl.TabIndex = 51;
            this.patControl.TabStop = false;
            this.patControl.Click += new System.EventHandler(this.patControl_Click);
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.Transparent;
            this.kapat.FlatAppearance.BorderSize = 0;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.ForeColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(590, -2);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(38, 32);
            this.kapat.TabIndex = 50;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // secName
            // 
            this.secName.AutoSize = true;
            this.secName.BackColor = System.Drawing.Color.Transparent;
            this.secName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secName.Location = new System.Drawing.Point(19, 268);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(57, 20);
            this.secName.TabIndex = 49;
            this.secName.Text = "Doktor";
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Red;
            this.cikis.Location = new System.Drawing.Point(-5, 291);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(119, 40);
            this.cikis.TabIndex = 48;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(239, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // DoctorHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.HastaneArkaPlan;
            this.ClientSize = new System.Drawing.Size(622, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grafic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patControl);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.secName);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorHomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox grafic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox patList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox patControl;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label secName;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label1;
    }
}