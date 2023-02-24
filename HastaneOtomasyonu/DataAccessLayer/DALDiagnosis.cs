using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALDiagnosis
    {
        public static int HastalıkEkle(ELDiagnosis diag)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "insert into Hastalık(hastalık_id, hasta_ismi, semptomlar, teşhis, ilaçlar, hasta_id, hasta_gittiği_bölüm, hasta_gittiği_doktor, eklenecekler, hasta_email) values(@diagID, @patName, @semptom, @teshis, @ilac, @patId, @patBolum, @patDoc, @ekle, @patMail)"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneleri değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@diagID", diag.hastalık_id);
            cmd.Parameters.AddWithValue("@patName", diag.hasta_ismi);
            cmd.Parameters.AddWithValue("@semptom", diag.semptomlar);
            cmd.Parameters.AddWithValue("@teshis", diag.teşhis);
            cmd.Parameters.AddWithValue("@ilac", diag.ilaçlar);
            cmd.Parameters.AddWithValue("@patBolum", diag.hasta_gittiği_bölüm);
            cmd.Parameters.AddWithValue("@patDoc", diag.hasta_gittiği_doktor);
            cmd.Parameters.AddWithValue("@patId", diag.hasta_id);
            cmd.Parameters.AddWithValue("@ekle", diag.eklenecekler);
            cmd.Parameters.AddWithValue("@patMail", diag.hasta_email);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }

        public static int HastalıkGüncelle(ELDiagnosis diag)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "update Hastalık set hasta_ismi= @patName, hasta_id= @patId, semptomlar= @semptom, teşhis= @teshis, ilaçlar= @ilac, hasta_gittiği_bölüm= @patBolum, hasta_gittiği_doktor= @patDoc, eklenecekler= @ekle, hasta_email= @patMail where hastalık_id= @diagID"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneleri değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@diagID", diag.hastalık_id);
            cmd.Parameters.AddWithValue("@patName", diag.hasta_ismi);
            cmd.Parameters.AddWithValue("@semptom", diag.semptomlar);
            cmd.Parameters.AddWithValue("@teshis", diag.teşhis);
            cmd.Parameters.AddWithValue("@ilac", diag.ilaçlar);
            cmd.Parameters.AddWithValue("@patBolum", diag.hasta_gittiği_bölüm);
            cmd.Parameters.AddWithValue("@patDoc", diag.hasta_gittiği_doktor);
            cmd.Parameters.AddWithValue("@patId", diag.hasta_id);
            cmd.Parameters.AddWithValue("@ekle", diag.eklenecekler);
            cmd.Parameters.AddWithValue("@patMail", diag.hasta_email);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }

        public static int HastalıkSil(ELDiagnosis diag)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "delete from Hastalık where hastalık_id = @diagID"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneyi değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@diagID", diag.hastalık_id);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }
    }
}
