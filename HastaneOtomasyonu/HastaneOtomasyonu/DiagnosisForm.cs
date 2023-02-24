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
using EntityLayer;
using BusinessLayer;

namespace HastaneOtomasyonu
{
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        void populate() //Hastalık ait veritabanındaki verileri çeker ve docGV adlı datagrive tablosunu oluşturur.
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "select * from Hastalık"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlDataAdapter adp = new SqlDataAdapter(query, Conn.Con); //adp ile verileri almak için kullanılır.

            SqlCommandBuilder builder = new SqlCommandBuilder(adp); // veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            var ds = new DataSet(); //yeni bir dataset nesnesi oluşturur.

            adp.Fill(ds); //veri kaynağındakilerle DataSet eşleşecek şekilde içindeki satırları ekler veya yeniler.

            diagGv.DataSource = ds.Tables[0]; //veritabanındaki tablo ile diaggv arasındaki bağlantıyı sağlar.
        }

        void populatecombo() //Veritabanındaki hasta tablosundan hastalara ait id numaralarını çeker ve combobox içine ekler.
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string sql = "select * from Hasta"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(sql, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            SqlDataReader rdr;
            try
            {
                DataTable dt = new DataTable(); //yeni bir datatable nesnesi oluşturur.

                dt.Columns.Add("hasta_id", typeof(int)); //dt nesnesine tablodaki idleri ekler.

                rdr = cmd.ExecuteReader(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.

                dt.Load(rdr); //veri kaynağındakilerle DataSet eşleşecek şekilde içindeki satırları yükler.

                patIdCb.ValueMember = "hasta_id"; //comboboxa id datalarını doldurur.

                patIdCb.DataSource = dt; //veritabanındaki tablo ile patIdCb arasındaki bağlantıyı sağlar.
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi " + hata.Message);
            }
        }

        string patientName, patientDoc, patientBolum;
        void fecthPatientName() //Seçilen hastanın belirlenmiş bilgilerini id ile kontrol ederek otomatik olarak veritabanından çekerek doldurur.
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string mysql = "select * from Hasta where hasta_id=" + patIdCb.SelectedValue.ToString() + ""; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(mysql, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            DataTable dt = new DataTable(); //yeni bir datatable nesnesi oluşturur.

            SqlDataAdapter da = new SqlDataAdapter(cmd); //cmd ile verileri almak için kullanılır.

            da.Fill(dt); //veri kaynağındakilerle DataSet eşleşecek şekilde içindeki satırları ekler veya yeniler.

            foreach (DataRow dr in dt.Rows) //tablo içindeki tüm değerleri yazdırana kadar çalışır.
            {
                //tablo içindeki tüm değerleri belirtilen textboxlara yazdırır.
                patientName = dr["hasta_ismi"].ToString();
                patName.Text = patientName;
                patientBolum = dr["hasta_gittiği_bölüm"].ToString();
                bolumTb.Text = patientBolum;
                patientDoc = dr["hasta_gittiği_doktor"].ToString();
                docTb.Text = patientDoc;
            }
        }

        private void patIdCb_SelectionChangeCommitted(object sender, EventArgs e) //Hastalığa ait belirli bilgileri id ile kontol ederek veri tabanından çekip içeriği otomatik doldurması için yazılan kodu çalıştırır.
        {
            fecthPatientName();
        }

        private void ekle_Click(object sender, EventArgs e) //ekleme işlemi
        {
            if (diagID.Text != "" && semptom.Text != "" && teshis.Text != "" && ilac.Text != "") //İf içinde belirtilen özellikler dışındaki kalanlar zaten otomatik olarak doldurulduğu için sadece bu değerlerin kontrol edilmesi yeterlidir.
            {
                ELDiagnosis diag = new ELDiagnosis() //yeni bir daig nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    hastalık_id = int.Parse(diagID.Text),
                    semptomlar = semptom.Text,
                    teşhis = teshis.Text,
                    ilaçlar = ilac.Text,
                    hasta_id = int.Parse(patIdCb.SelectedValue.ToString()),
                    hasta_email=patMail.Text,
                    hasta_gittiği_bölüm=bolumTb.Text,
                    hasta_gittiği_doktor=docTb.Text,
                    hasta_ismi=patName.Text,
                    eklenecekler=ekleTb.Text
                };

                BSDiagnosis.HastalıkEkle(diag); //doldurulan nesneyle businesslayerdaki hastalıkekle sınıfına gönder.

                MessageBox.Show("Hasta raporu başarılı bir şekilde eklenmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, yeni girdi eklenmiş şekliyle tabloyu datagrive ekler.
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerin girildiğine emin olun!");
            }
        }

        private void güncelle_Click(object sender, EventArgs e) //güncelleme işlemi
        {
            if (diagID.Text != "" && semptom.Text != "" && teshis.Text != "" && ilac.Text != "") //İf içinde belirtilen özellikler dışındaki kalanlar zaten otomatik olarak doldurulduğu için sadece bu değerlerin kontrol edilmesi yeterlidir.
            {
                ELDiagnosis diag = new ELDiagnosis() //yeni bir daig nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    hastalık_id = int.Parse(diagID.Text),
                    semptomlar = semptom.Text,
                    teşhis = teshis.Text,
                    ilaçlar = ilac.Text,
                    hasta_id = int.Parse(patIdCb.SelectedValue.ToString()),
                    hasta_email = patMail.Text,
                    hasta_gittiği_bölüm = bolumTb.Text,
                    hasta_gittiği_doktor = docTb.Text,
                    hasta_ismi = patName.Text,
                    eklenecekler=ekleTb.Text
                };

                BSDiagnosis.HastalıkGüncelle(diag); //doldurulan nesneyle businesslayerdaki hastalıkgüncelle sınıfına gönder.

                MessageBox.Show("Hasta raporu başarılı bir şekilde güncellenmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, değişiklik yapılmış şekliyle tabloya eklemiş olur.
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerin girildiğine emin olun!");
            }
        }

        private void sil_Click(object sender, EventArgs e) //silme işlemi
        {
            if (diagID.Text == "") //İf içinde belirtilen özellikler dışındaki kalanlar zaten otomatik olarak doldurulduğu için sadece bu değerlerin kontrol edilmesi yeterlidir.
            {
                MessageBox.Show("Lütfen kaydını silmek istediğiniz doktoru listeden seçiniz veya doktora ait id numarasını giriniz!");
            }
            else
            {
                ELDiagnosis diag = new ELDiagnosis() //yeni bir daig nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    hastalık_id = int.Parse(diagID.Text),
                };

                BSDiagnosis.HastalıkSil(diag); //doldurulan nesneyle businesslayerdaki hastalıksil sınıfına gönder.

                MessageBox.Show("Hasta raporu başarılı bir şekilde silinmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, silme işlemi yapılmış şekliyle tabloya eklemiş olur.
            }
        }

        private void anamenü_Click(object sender, EventArgs e) //doktor menüsüne gider
        {
            DoctorHomeForm docHome = new DoctorHomeForm();
            docHome.Show();
            this.Hide();
        }

        private void mail_Click(object sender, EventArgs e) //E posta gönderme formuna gider (MailForm formu)
        {
            MailForm mail = new MailForm();
            mail.txtAlici.Text = diagGv.SelectedRows[0].Cells[3].Value.ToString(); //Veritabanından 3. indexte yer alan bilgiyi MailForm içerisindeki txtAlici textbox'ına yazar.
            mail.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //Yazdırma sayfa düzeni ayarları
        {
            e.Graphics.DrawString("\n" + label3.Text, new Font("Century Gothic", 45, FontStyle.Regular), Brushes.Black, new Point(300));
            e.Graphics.DrawString("\n\n\n\n\n\n\n Hasta Adı :  " + patNamelbl.Text + "\n\n Teşhis :  " + teshislbl.Text + "\n\n Semptomlar :  " + semptomlbl.Text + "\n\n İlaçlar :  " + ilaclbl.Text + "\n\n" + " Eklenecekler : " + ekleTb.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(80));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + docNamelbl.Text + "\n\n" + label5.Text + "\n\n" + label6.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(600));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label7.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(300));
        }

        private void reçete_Click(object sender, EventArgs e) //Yazdırma işlemi
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void diagGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagrivde tıklanan satırdaki tüm bilgileri indexine göre otomatik olarak textboxlara ve comboboxa doldurur.
            patIdCb.SelectedValue = diagGv.SelectedRows[0].Cells[1].Value.ToString();
            diagID.Text = diagGv.SelectedRows[0].Cells[0].Value.ToString();
            bolumTb.Text = diagGv.SelectedRows[0].Cells[4].Value.ToString();
            patMail.Text = diagGv.SelectedRows[0].Cells[3].Value.ToString();
            docTb.Text = diagGv.SelectedRows[0].Cells[5].Value.ToString();
            patName.Text = diagGv.SelectedRows[0].Cells[2].Value.ToString();
            semptom.Text = diagGv.SelectedRows[0].Cells[6].Value.ToString();
            teshis.Text = diagGv.SelectedRows[0].Cells[7].Value.ToString();
            ilac.Text = diagGv.SelectedRows[0].Cells[8].Value.ToString();
            patNamelbl.Text = diagGv.SelectedRows[0].Cells[2].Value.ToString();
            semptomlbl.Text = diagGv.SelectedRows[0].Cells[6].Value.ToString();
            teshislbl.Text = diagGv.SelectedRows[0].Cells[7].Value.ToString();
            ilaclbl.Text = diagGv.SelectedRows[0].Cells[8].Value.ToString();
            docNamelbl.Text = diagGv.SelectedRows[0].Cells[5].Value.ToString();
            label5.Text = DateTime.Now.ToShortDateString();
            ekleTb.Text = diagGv.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void kapat_Click(object sender, EventArgs e) //Uygulamayı kapatma
        {
            Application.Exit();
        }
    }
}
