using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace HastaneOtomasyonu
{
    public partial class PatientListForm : Form
    {
        public PatientListForm()
        {
            InitializeComponent();
        }

        private void PatientListForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate() //Hastalara ait veritabanındaki verileri çeker ve docGV adlı datagrive tablosunu oluşturur.
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "select * from Hasta"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlDataAdapter adp = new SqlDataAdapter(query, Conn.Con); //adp ile verileri almak için kullanılır.

            SqlCommandBuilder builder = new SqlCommandBuilder(adp); // veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            var ds = new DataSet(); //yeni bir dataset nesnesi oluşturur.

            adp.Fill(ds); //veri kaynağındakilerle DataSet eşleşecek şekilde içindeki satırları ekler veya yeniler.

            hastaListGv.DataSource = ds.Tables[0];  //veritabanındaki tablo ile diaggv arasındaki bağlantıyı sağlar.
        }

        private void hastaListGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagrivde tıklanan satırdaki tüm bilgileri daiagnosisform'daki textboxlara ve comboboxlara indexine göre otomatik olarak doldurur ve diagnosis formu açar.
            DiagnosisForm diag = new DiagnosisForm();
            diag.patIdCb.SelectedValue = hastaListGv.SelectedRows[0].Cells[0].Value.ToString();
            diag.patName.Text = hastaListGv.SelectedRows[0].Cells[1].Value.ToString();
            diag.patMail.Text = hastaListGv.SelectedRows[0].Cells[4].Value.ToString();
            diag.bolumTb.Text = hastaListGv.SelectedRows[0].Cells[8].Value.ToString();
            diag.docTb.Text = hastaListGv.SelectedRows[0].Cells[9].Value.ToString();
            diag.Show();
            this.Hide();
        }

        private void patControl_Click(object sender, EventArgs e)
        {
            //Datagrivde tıklanan satırdaki tüm bilgileri daiagnosisform'daki textboxlara ve comboboxlara indexine göre otomatik olarak doldurur ve diagnosis formu açar.
            DiagnosisForm diag = new DiagnosisForm();
            diag.patIdCb.SelectedValue = hastaListGv.SelectedRows[0].Cells[0].Value.ToString();
            diag.patName.Text = hastaListGv.SelectedRows[0].Cells[1].Value.ToString();
            diag.patMail.Text = hastaListGv.SelectedRows[0].Cells[4].Value.ToString();
            diag.bolumTb.Text = hastaListGv.SelectedRows[0].Cells[8].Value.ToString();
            diag.docTb.Text = hastaListGv.SelectedRows[0].Cells[9].Value.ToString();
            diag.Show();
            this.Hide();
        }

        private void Home2_Click(object sender, EventArgs e) //doktor yönetim formuna gider.
        {
            DoctorHomeForm docHome = new DoctorHomeForm();
            docHome.Show();
            this.Hide();
        }

        private void kapat_Click(object sender, EventArgs e) //uygulamayı kapat
        {
            Application.Exit();
        }
    }
}
