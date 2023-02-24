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
    public partial class GraficForm : Form
    {
        public GraficForm()
        {
            InitializeComponent();
        }

        private void GraficForm_Load(object sender, EventArgs e)
        {
            //grafikteki bölümleri ve hasta sayısını belirler.
            chart1.Series["Bölümler"].Points.AddXY("Aile Hekimliği", 15);
            chart1.Series["Bölümler"].Points.AddXY("Çocuk Hastalıkları", 8);
            chart1.Series["Bölümler"].Points.AddXY("Dahiliye", 11);
            chart1.Series["Bölümler"].Points.AddXY("Kadın Doğum", 4);
            chart1.Series["Bölümler"].Points.AddXY("Kadın Hastalıkları", 7);
            chart1.Series["Bölümler"].Points.AddXY("Kardiyoloji", 3);
            chart1.Series["Bölümler"].Points.AddXY("Kulak-Burun-Boğaz", 10);
            chart1.Series["Bölümler"].Points.AddXY("Psikiyatri", 6);
            chart1.Series["Bölümler"].Points.AddXY("Üroloji", 1);
        }

        private void kapat_Click(object sender, EventArgs e) //doktorhomeform a gönder.
        {
            DoctorHomeForm docHome = new DoctorHomeForm();
            docHome.Show();
            this.Hide();
        }
    }
}
