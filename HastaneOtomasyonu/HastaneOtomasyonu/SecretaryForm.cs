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
using BusinessLayer;
using EntityLayer;
using DataAccessLayer;

namespace HastaneOtomasyonu
{
    public partial class SecretaryForm : Form
    {
        public SecretaryForm()
        {
            InitializeComponent();
        }

        private void SecretaryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate() //Secretere ait veritabanındaki verileri çeker ve docGV adlı datagrive tablosunu oluşturur.
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "select * from Sekreter";//veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlDataAdapter adp = new SqlDataAdapter(query, Conn.Con); //adp ile verileri almak için kullanılır.

            SqlCommandBuilder builder = new SqlCommandBuilder(adp); // veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            var ds = new DataSet(); //yeni bir dataset nesnesi oluşturur.

            adp.Fill(ds); //veri kaynağındakilerle DataSet eşleşecek şekilde içindeki satırları ekler veya yeniler.

            secGV.DataSource = ds.Tables[0]; //veritabanındaki tablo ile doctorgv arasındaki bağlantıyı sağlar.
        }

        private void secAdd_Click(object sender, EventArgs e) //ekleme işlemi
        {
            if (secID.Text != "" && secName.Text != "" && secNumber.Text != "" && secPass.Text != "")//İf içinde belirtilen özellikler doğru ise
            {
                ELSecretary sec = new ELSecretary() //yeni bir sec nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    sekreter_id = int.Parse(secID.Text),
                    sekreter_ismi = secName.Text,
                    sekreter_telefon = long.Parse(secNumber.Text),
                    sekreter_şifre = secPass.Text,
                };

                BSSecretary.SekreterEkle(sec); //doldurulan nesneyle businesslayerdaki sekreterekle sınıfına gönder.

                MessageBox.Show("Sekreter başarılı bir şekilde eklenmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, yeni girdi eklenmiş şekliyle tabloyu datagrive ekler.
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerin girildiğine emin olun!");
            }
        }

        private void secUpdate_Click(object sender, EventArgs e) //güncelleme işlemi
        {
            if (secID.Text != "" && secName.Text != "" && secNumber.Text != "" && secPass.Text != "") //İf içinde belirtilen özellikler doğru ise
            {
                ELSecretary sec = new ELSecretary() //yeni bir sec nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    sekreter_id = int.Parse(secID.Text),
                    sekreter_ismi = secName.Text,
                    sekreter_telefon = long.Parse(secNumber.Text),
                    sekreter_şifre = secPass.Text,
                };

                BSSecretary.SekreterGüncelle(sec); //doldurulan nesneyle businesslayerdaki sekretergüncelle sınıfına gönder.

                MessageBox.Show("Sekreter başarılı bir şekilde güncellenmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, değişiklik yapılmış şekliyle tabloya eklemiş olur.
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerin girildiğine emin olun!");
            }
        }

        private void secDelete_Click(object sender, EventArgs e)
        {
            if (secID.Text == "") //İf içinde belirtilen özellikler dışındaki kalanlar zaten otomatik olarak doldurulduğu için sadece bu değerlerin kontrol edilmesi yeterlidir.
            {
                MessageBox.Show("Lütfen kaydını silmek istediğiniz doktoru listeden seçiniz veya doktora ait id numarasını giriniz!");
            }
            else
            {
                ELSecretary sec = new ELSecretary() //yeni bir sec nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    sekreter_id = int.Parse(secID.Text),
                };

                BSSecretary.SekreterSil(sec); //doldurulan nesneyle businesslayerdaki sekretersil sınıfına gönder.

                MessageBox.Show("Sekreter başarılı bir şekilde silinmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, silme işlemi yapılmış şekliyle tabloya eklemiş olur.
            }
        }

        private void secHome_Click(object sender, EventArgs e) //sekreter menüsüne gider
        {
            SecretaryHomeForm secHome = new SecretaryHomeForm();
            secHome.Show();
            this.Hide();
        }

        private void secGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagrivde tıklanan satırdaki tüm bilgileri indexine göre otomatik olarak textboxlara ve comboboxa doldurur.
            secID.Text = secGV.SelectedRows[0].Cells[0].Value.ToString();
            secName.Text = secGV.SelectedRows[0].Cells[1].Value.ToString();
            secNumber.Text = secGV.SelectedRows[0].Cells[2].Value.ToString();
            secPass.Text = secGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void kapat_Click(object sender, EventArgs e) //Uygulamayı kapatma
        {
            Application.Exit();
        }
    }
}
