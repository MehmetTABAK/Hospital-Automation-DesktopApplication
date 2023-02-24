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
using BusinessLayer;
using EntityLayer;

namespace HastaneOtomasyonu
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate() //Doktorlara ait veritabanındaki verileri çeker ve docGV adlı datagrive tablosunu oluşturur.
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "select * from Hasta"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlDataAdapter adp = new SqlDataAdapter(query, Conn.Con); //adp ile verileri almak için kullanılır.

            SqlCommandBuilder builder = new SqlCommandBuilder(adp);// veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            var ds = new DataSet();//yeni bir dataset nesnesi oluşturur.

            adp.Fill(ds); //veri kaynağındakilerle DataSet eşleşecek şekilde içindeki satırları ekler veya yeniler.

            hastaGv.DataSource = ds.Tables[0]; //veritabanındaki tablo ile hastagv arasındaki bağlantıyı sağlar.
        }

        private void ekle_Click(object sender, EventArgs e) //ekleme işlemi
        {
            if (patId.Text != "" && patName.Text != "" && patAdrss.Text != "" && patPhone.Text != "" && patAge.Text != "" && majorTb.Text != "" && genderCb.Text != "" && bloodCb.Text != "" && patEmail.Text != "" && bolumCb.Text != "" && docCb.Text != "") //İf içinde belirtilen özellikler doğru ise
            {
                ELPatient pat = new ELPatient() //yeni bir pat nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    hasta_id = int.Parse(patId.Text),
                    hasta_ismi = patName.Text,
                    hasta_adres = patAdrss.Text,
                    hasta_telefon = long.Parse(patPhone.Text),
                    hasta_yas = int.Parse(patAge.Text),
                    hasta_hastalıkderecesi = majorTb.Text,
                    hasta_cinsiyet = genderCb.SelectedItem.ToString(),
                    hasta_kangrubu = bloodCb.SelectedItem.ToString(),
                    hasta_email = patEmail.Text,
                    hasta_gittiği_bölüm = bolumCb.SelectedItem.ToString(),
                    hasta_gittiği_doktor = docCb.SelectedItem.ToString(),
                };

                BSPatient.HastaEkle(pat); //doldurulan nesneyle businesslayerdaki hastaekle sınıfına gönder.

                MessageBox.Show("Hasta başarılı bir şekilde eklenmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, yeni girdi eklenmiş şekliyle tabloyu datagrive ekler.
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerin girildiğine emin olun!");
            }
        }

        private void güncelle_Click(object sender, EventArgs e) //güncelleme işlemi
        {
            if (patId.Text != "" && patName.Text != "" && patAdrss.Text != "" && patPhone.Text != "" && patAge.Text != "" && majorTb.Text != "" && genderCb.Text != "" && bloodCb.Text != "" && patEmail.Text != "" && bolumCb.Text != "" && docCb.Text != "") //İf içinde belirtilen özellikler doğru ise
            {
                ELPatient pat = new ELPatient() //yeni bir pat nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    hasta_id = int.Parse(patId.Text),
                    hasta_ismi = patName.Text,
                    hasta_adres = patAdrss.Text,
                    hasta_telefon = long.Parse(patPhone.Text),
                    hasta_yas = int.Parse(patAge.Text),
                    hasta_hastalıkderecesi = majorTb.Text,
                    hasta_cinsiyet = genderCb.SelectedItem.ToString(),
                    hasta_kangrubu = bloodCb.SelectedItem.ToString(),
                    hasta_email = patEmail.Text,
                    hasta_gittiği_bölüm = bolumCb.SelectedItem.ToString(),
                    hasta_gittiği_doktor = docCb.SelectedItem.ToString(),
                };

                BSPatient.HastaGüncelle(pat); //doldurulan nesneyle businesslayerdaki hastagüncelle sınıfına gönder.

                MessageBox.Show("Hasta başarılı bir şekilde güncellenmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, değişiklik yapılmış şekliyle tabloya eklemiş olur.
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerin girildiğine emin olun!");
            }
        }

        private void sil_Click(object sender, EventArgs e) //silme işlemi
        {
            if (patId.Text == "") //İf içinde belirtilen özellikler dışındaki kalanlar zaten otomatik olarak doldurulduğu için sadece bu değerlerin kontrol edilmesi yeterlidir.
            {
                MessageBox.Show("Lütfen kaydını silmek istediğiniz doktoru listeden seçiniz veya doktora ait id numarasını giriniz!");
            }
            else
            {
                ELPatient pat = new ELPatient() //yeni bir pat nesnesi oluştur.
                {
                    //formda bulunana textbox ve combobox değerlerini ata.
                    hasta_id = int.Parse(patId.Text),
                };

                BSPatient.HastaSil(pat); //doldurulan nesneyle businesslayerdaki hastasil sınıfına gönder.

                MessageBox.Show("Hasta başarılı bir şekilde silinmiştir.");

                populate(); //Tabloyu datagrive ekleyen kodu çalıştırır, silme işlemi yapılmış şekliyle tabloya eklemiş olur.
            }
        }

        private void anamenü_Click(object sender, EventArgs e) //sekreter menüsüne gider
        {
            SecretaryHomeForm secHome = new SecretaryHomeForm();
            secHome.Show();
            this.Hide();
        }

        private void hastaGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagrivde tıklanan satırdaki tüm bilgileri indexine göre otomatik olarak textboxlara ve comboboxa doldurur.
            patId.Text = hastaGv.SelectedRows[0].Cells[0].Value.ToString();
            patName.Text = hastaGv.SelectedRows[0].Cells[1].Value.ToString();
            patAdrss.Text = hastaGv.SelectedRows[0].Cells[2].Value.ToString();
            patPhone.Text = hastaGv.SelectedRows[0].Cells[3].Value.ToString();
            patEmail.Text = hastaGv.SelectedRows[0].Cells[4].Value.ToString();
            patAge.Text = hastaGv.SelectedRows[0].Cells[5].Value.ToString();
            genderCb.Text = hastaGv.SelectedRows[0].Cells[6].Value.ToString();
            bloodCb.Text = hastaGv.SelectedRows[0].Cells[7].Value.ToString();
            bolumCb.Text = hastaGv.SelectedRows[0].Cells[8].Value.ToString();
            docCb.Text = hastaGv.SelectedRows[0].Cells[9].Value.ToString();
            majorTb.Text = hastaGv.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void kapat_Click(object sender, EventArgs e) //Uygulamayı kapatma
        {
            Application.Exit();
        }

        private void bolumCb_SelectedIndexChanged(object sender, EventArgs e) //seçilen bölüme göre o bölümün doktorlarını comboboxa ekler.
        {
            if (bolumCb.Text == "Aile Hekimi")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Ahmet KILINÇ");
                docCb.Items.Add("Yüksel AKSAKAL");
                docCb.Items.Add("Çiğdem PARLAK");
                docCb.Items.Add("Kemal KÜÇÜK");
            }
            else if (bolumCb.Text == "Çocuk Hastalıkları")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Serhat ACAR");
                docCb.Items.Add("Esra ERDOĞAN");
                docCb.Items.Add("Yağmur KURT");
            }
            else if (bolumCb.Text == "Dahiliye")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Tarık UZUN");
                docCb.Items.Add("Kazım KARA");
            }
            else if (bolumCb.Text == "Genel Cerrahi")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Mehmet TABAK");
                docCb.Items.Add("Burak KAYA");
            }
            else if (bolumCb.Text == "Kadın Doğum")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Hatice AKSU");
                docCb.Items.Add("Osman Nuri CANDEĞER");
            }
            else if (bolumCb.Text == "Kadın Hastalıkları")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Serkan YILMAZ");
            }
            else if (bolumCb.Text == "Kardiyoloji")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Zeynep ARSLAN");
            }
            else if (bolumCb.Text == "Kulak-Burun-Boğaz")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Berk AYDIN");
                docCb.Items.Add("Kübra OYMAK");
            }
            else if (bolumCb.Text == "Psikiyatri")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Cenk KAHRAMAN");
                docCb.Items.Add("Ayşe PEKYOL");
            }
            else if (bolumCb.Text == "Üroloji")
            {
                docCb.Items.Clear();
                docCb.Items.Add("Mustafa AKKAVAK");
            }
        }
    }
} 
