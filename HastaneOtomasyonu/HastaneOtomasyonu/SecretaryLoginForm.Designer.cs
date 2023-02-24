
namespace HastaneOtomasyonu
{
    partial class SecretaryLoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.secName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapat = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.secPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.giris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sekreter";
            // 
            // secName
            // 
            this.secName.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.secName.BorderColorIdle = System.Drawing.Color.Purple;
            this.secName.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.secName.BorderThickness = 3;
            this.secName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.secName.ForeColor = System.Drawing.Color.Purple;
            this.secName.isPassword = false;
            this.secName.Location = new System.Drawing.Point(59, 135);
            this.secName.Margin = new System.Windows.Forms.Padding(4);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(198, 42);
            this.secName.TabIndex = 9;
            this.secName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(107, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "HYS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.kapat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 76);
            this.panel1.TabIndex = 7;
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.Transparent;
            this.kapat.FlatAppearance.BorderSize = 0;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.ForeColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(289, 0);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(38, 32);
            this.kapat.TabIndex = 32;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Purple;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cikis.Location = new System.Drawing.Point(59, 324);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(198, 50);
            this.cikis.TabIndex = 13;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(125, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şifre";
            // 
            // secPass
            // 
            this.secPass.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.secPass.BorderColorIdle = System.Drawing.Color.Purple;
            this.secPass.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.secPass.BorderThickness = 3;
            this.secPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.secPass.ForeColor = System.Drawing.Color.Purple;
            this.secPass.isPassword = true;
            this.secPass.Location = new System.Drawing.Point(59, 209);
            this.secPass.Margin = new System.Windows.Forms.Padding(4);
            this.secPass.Name = "secPass";
            this.secPass.Size = new System.Drawing.Size(198, 42);
            this.secPass.TabIndex = 10;
            this.secPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.Purple;
            this.giris.FlatAppearance.BorderSize = 0;
            this.giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.giris.Location = new System.Drawing.Point(59, 268);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(198, 50);
            this.giris.TabIndex = 8;
            this.giris.Text = "Giriş Yap";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // SecretaryLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(327, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secPass);
            this.Controls.Add(this.giris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecretaryLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox secName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox secPass;
        private System.Windows.Forms.Button giris;
    }
}

