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
    public partial class DoctorHomeForm : Form
    {
        public DoctorHomeForm()
        {
            InitializeComponent();
        }

        private void patList_Click(object sender, EventArgs e) //hasta listesinin olduğu forma gönderir.
        {
            PatientListForm pali = new PatientListForm();
            pali.Show();
            this.Hide();
        }

        private void patControl_Click(object sender, EventArgs e) //hasta control formuna gönderir.
        {
            DiagnosisForm diag = new DiagnosisForm();
            diag.Show();
            this.Hide();
        }

        private void grafic_Click(object sender, EventArgs e) //grafik formuna gönderir.
        {
            GraficForm gra = new GraficForm();
            gra.Show();
            this.Hide();
        }

        private void cikis_Click(object sender, EventArgs e) //giriş yapma formuna gönderir.
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void kapat_Click(object sender, EventArgs e) //uygulama kapatma
        {
            Application.Exit();
        }
    }
}
