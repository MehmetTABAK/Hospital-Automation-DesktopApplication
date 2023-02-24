using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class SecretaryHomeForm : Form
    {
        public SecretaryHomeForm()
        {
            InitializeComponent();
        }

        private void docAdd_Click(object sender, EventArgs e) //doktor ekleme formunu açar.
        {
            DoctorForm doc = new DoctorForm();
            doc.Show();
            this.Hide();
        }

        private void secAdd_Click(object sender, EventArgs e) //secreter ekleme formunu açar.
        {
            SecretaryForm sec = new SecretaryForm();
            sec.Show();
            this.Hide();
        }

        private void patAdd_Click(object sender, EventArgs e) //hasta ekleme formunu açar.
        {
            PatientForm pat = new PatientForm();
            pat.Show();
            this.Hide();
        }

        private void cikis_Click(object sender, EventArgs e) //giriş yöntemi seçme formunu açar.
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void kapat_Click(object sender, EventArgs e) //uygulamayı kapat
        {
            Application.Exit();
        }
    }
}
