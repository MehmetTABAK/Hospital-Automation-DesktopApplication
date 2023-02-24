using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonu.Models;

namespace HastaneOtomasyonu
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void ek_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Gönderi İçin Ek Dosya Seçebilirsiniz.";
            ofd.ShowDialog();
            txtDosya.Text = ofd.FileName;
        }

        private void gönder_Click(object sender, EventArgs e)
        {
            SendMail sm = new SendMail();
            sm.Microsoft(txtAd.Text, txtGöndericiMail.Text, txtGondericiPass.Text, txtAlici.Text, txtBaslik.Text, txticerik.Text, txtDosya.Text);
            MessageBox.Show("Mail Gönderildi.");
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            DiagnosisForm diag = new DiagnosisForm();
            diag.Show();
            this.Hide();
        }
    }
}
