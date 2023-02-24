
namespace HastaneOtomasyonu
{
    partial class DoctorLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.docPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.docName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.giris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Purple;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cikis.Location = new System.Drawing.Point(59, 329);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(198, 45);
            this.cikis.TabIndex = 19;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(125, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(125, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Doktor";
            // 
            // docPass
            // 
            this.docPass.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.docPass.BorderColorIdle = System.Drawing.Color.Purple;
            this.docPass.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.docPass.BorderThickness = 3;
            this.docPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.docPass.ForeColor = System.Drawing.Color.Purple;
            this.docPass.isPassword = true;
            this.docPass.Location = new System.Drawing.Point(59, 217);
            this.docPass.Margin = new System.Windows.Forms.Padding(4);
            this.docPass.Name = "docPass";
            this.docPass.Size = new System.Drawing.Size(198, 42);
            this.docPass.TabIndex = 16;
            this.docPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // docName
            // 
            this.docName.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.docName.BorderColorIdle = System.Drawing.Color.Purple;
            this.docName.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.docName.BorderThickness = 3;
            this.docName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.docName.ForeColor = System.Drawing.Color.Purple;
            this.docName.isPassword = false;
            this.docName.Location = new System.Drawing.Point(59, 143);
            this.docName.Margin = new System.Windows.Forms.Padding(4);
            this.docName.Name = "docName";
            this.docName.Size = new System.Drawing.Size(198, 42);
            this.docName.TabIndex = 15;
            this.docName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.Purple;
            this.giris.FlatAppearance.BorderSize = 0;
            this.giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.giris.Location = new System.Drawing.Point(59, 277);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(198, 45);
            this.giris.TabIndex = 14;
            this.giris.Text = "Giriş Yap";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
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
            this.panel1.TabIndex = 13;
            // 
            // DoctorLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(327, 380);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.docPass);
            this.Controls.Add(this.docName);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorLoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox docPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox docName;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Panel panel1;
    }
}