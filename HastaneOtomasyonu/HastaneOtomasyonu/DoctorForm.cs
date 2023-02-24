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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate() //Doktorlara ait veritabanındaki verileri çeker ve docGV adlı datagrive tablosunu oluşturur.
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "select * from Doktor"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlDataAdapter adp = new SqlDataAdapter(query, Conn.Con); //adp ile verileri almak için kullanılır.

            SqlCommandBuilder builder = new SqlCommandBuilder(adp); // veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            var ds = new DataSet(); //yeni bir dataset nesnesi oluşturur.

            adp.Fill(ds); //veri kaynağındakilerle DataSet eşleşecek şekilde içindeki satırları ekler veya yeniler.

            doctorGV.DataSource = ds.Tables[0]; //veritabanındaki tablo ile doctorgv arasındaki bağlantıyı sağlar.
        }

        private void docAdd_Click(object sender, EventArgs e) //ekleme işlemi
        {
            if (docID.Text != "" && docName.Text != "" && docBrans.Text != "" && docExp.Text != "" && docNumber.Text != "" && docPass.Text != "") //İf içinde belirtilen özellikler doğru ise
            {
                ELDoctor doc = new ELDoctor() //yeni bir doc nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    doktor_id = int.Parse(docID.Text),
                    doktor_ismi = docName.Text,
                    doktor_branş = docBrans.SelectedItem.ToString(),
                    doktor_deneyim = int.Parse(docExp.Text),
                    doktor_telefon = long.Parse(docNumber.Text),
                    doktor_şifre = docPass.Text,
                };

                BSDoctor.DoktorEkle(doc); //doldurulan nesneyle businesslayerdaki doktorekle sınıfına gönder.

                MessageBox.Show("Doktor başarılı bir şekilde eklenmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, yeni girdi eklenmiş şekliyle tabloyu datagrive ekler.
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerin girildiğine emin olun!");
            }
        }

        private void docUpdate_Click(object sender, EventArgs e) //güncelleme işlemi
        {
            if (docID.Text != "" && docName.Text != "" && docBrans.Text != "" && docExp.Text != "" && docNumber.Text != "" && docPass.Text != "") //İf içinde belirtilen özellikler doğru ise
            {
                ELDoctor doc = new ELDoctor() //yeni bir doc nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    doktor_id = int.Parse(docID.Text),
                    doktor_ismi = docName.Text,
                    doktor_branş = docBrans.SelectedItem.ToString(),
                    doktor_deneyim = int.Parse(docExp.Text),
                    doktor_telefon = long.Parse(docNumber.Text),
                    doktor_şifre = docPass.Text,
                };

                BSDoctor.DoktorGüncelle(doc); //doldurulan nesneyle businesslayerdaki doktorgüncelle sınıfına gönder.

                MessageBox.Show("Doktor başarılı bir şekilde güncellenmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, değişiklik yapılmış şekliyle tabloya eklemiş olur.
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerin girildiğine emin olun!");
            }
        }

        private void docDelete_Click(object sender, EventArgs e) //silme işlemi
        {
            if (docID.Text == "") //İf içinde belirtilen özellikler dışındaki kalanlar zaten otomatik olarak doldurulduğu için sadece bu değerlerin kontrol edilmesi yeterlidir.
            {
                MessageBox.Show("Lütfen kaydını silmek istediğiniz doktoru listeden seçiniz veya doktora ait id numarasını giriniz!");
            }
            else
            {
                ELDoctor doc = new ELDoctor() //yeni bir doc nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    doktor_id = int.Parse(docID.Text),
                };

                BSDoctor.DoktorSil(doc); //doldurulan nesneyle businesslayerdaki doktorsil sınıfına gönder.

                MessageBox.Show("Doktor başarılı bir şekilde silinmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, silme işlemi yapılmış şekliyle tabloya eklemiş olur.
            }
        }

        private void docHome_Click(object sender, EventArgs e) //sekreter menüsüne gider
        {
            SecretaryHomeForm secHome = new SecretaryHomeForm();
            secHome.Show();
            this.Hide();
        }

        private void doctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagrivde tıklanan satırdaki tüm bilgileri indexine göre otomatik olarak textboxlara ve comboboxa doldurur.
            docID.Text = doctorGV.SelectedRows[0].Cells[0].Value.ToString();
            docName.Text = doctorGV.SelectedRows[0].Cells[1].Value.ToString();
            docBrans.Text = doctorGV.SelectedRows[0].Cells[2].Value.ToString();
            docExp.Text = doctorGV.SelectedRows[0].Cells[3].Value.ToString();
            docNumber.Text = doctorGV.SelectedRows[0].Cells[4].Value.ToString();
            docPass.Text = doctorGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void kapat_Click(object sender, EventArgs e) //Uygulamayı kapatma
        {
            Application.Exit();
        }
    }
}
