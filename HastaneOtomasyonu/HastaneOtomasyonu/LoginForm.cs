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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void docLogin_Click(object sender, EventArgs e) //doktor giriş ekranına gider.
        {
            DoctorLoginForm form2 = new DoctorLoginForm();
            form2.Show();
            this.Hide();
        }

        private void secLogin_Click(object sender, EventArgs e) //sekreter giriş ekranına gider.
        {
            SecretaryLoginForm form = new SecretaryLoginForm();
            form.Show();
            this.Hide();
        }

        private void kapat_Click(object sender, EventArgs e) //uygulamayı kapat
        {
            Application.Exit();
        }
    }
}
