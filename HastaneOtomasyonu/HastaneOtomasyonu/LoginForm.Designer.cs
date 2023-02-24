
namespace HastaneOtomasyonu
{
    partial class LoginForm
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
            this.kapat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.secLogin = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.docLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.Transparent;
            this.kapat.FlatAppearance.BorderSize = 0;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.ForeColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(589, -1);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(38, 32);
            this.kapat.TabIndex = 46;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(449, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "SEKRETER GİRİŞİ";
            // 
            // secLogin
            // 
            this.secLogin.BackColor = System.Drawing.Color.Transparent;
            this.secLogin.Image = global::HastaneOtomasyonu.Properties.Resources.Hemşiree;
            this.secLogin.Location = new System.Drawing.Point(452, 178);
            this.secLogin.Name = "secLogin";
            this.secLogin.Size = new System.Drawing.Size(103, 83);
            this.secLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secLogin.TabIndex = 44;
            this.secLogin.TabStop = false;
            this.secLogin.Click += new System.EventHandler(this.secLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(274, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "DOKTOR GİRİŞİ";
            // 
            // docLogin
            // 
            this.docLogin.BackColor = System.Drawing.Color.Transparent;
            this.docLogin.Image = global::HastaneOtomasyonu.Properties.Resources.Doctor;
            this.docLogin.Location = new System.Drawing.Point(277, 117);
            this.docLogin.Name = "docLogin";
            this.docLogin.Size = new System.Drawing.Size(103, 81);
            this.docLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.docLogin.TabIndex = 42;
            this.docLogin.TabStop = false;
            this.docLogin.Click += new System.EventHandler(this.docLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(238, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.HastaneArkaPlan;
            this.ClientSize = new System.Drawing.Size(626, 324);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.docLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.secLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox secLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox docLogin;
        private System.Windows.Forms.Label label1;
    }
}