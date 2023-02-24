using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALPatient
    {
        public static int HastaEkle(ELPatient pat)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "insert into Hasta(hasta_id, hasta_ismi, hasta_adres, hasta_telefon, hasta_yas, hasta_hastalıkderecesi, hasta_cinsiyet, hasta_kangrubu, hasta_email, hasta_gittiği_bölüm, hasta_gittiği_doktor) values(@patID, @patName, @patAdrs, @patPhone, @patAge, @patMajor, @patGender, @patBlood, @patEmail, @patBolum, @patDoc)"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneleri değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@patID", pat.hasta_id);
            cmd.Parameters.AddWithValue("@patName", pat.hasta_ismi);
            cmd.Parameters.AddWithValue("@patAdrs", pat.hasta_adres);
            cmd.Parameters.AddWithValue("@patPhone", pat.hasta_telefon);
            cmd.Parameters.AddWithValue("@patAge", pat.hasta_yas);
            cmd.Parameters.AddWithValue("@patMajor", pat.hasta_hastalıkderecesi);
            cmd.Parameters.AddWithValue("@patGender", pat.hasta_cinsiyet);
            cmd.Parameters.AddWithValue("@patBlood", pat.hasta_kangrubu);
            cmd.Parameters.AddWithValue("@patEmail", pat.hasta_email);
            cmd.Parameters.AddWithValue("@patBolum", pat.hasta_gittiği_bölüm);
            cmd.Parameters.AddWithValue("@patDoc", pat.hasta_gittiği_doktor);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }

        public static int HastaGüncelle(ELPatient pat)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "update Hasta set hasta_ismi= @patName, hasta_adres= @patAdrs, hasta_telefon= @patPhone, hasta_yas= @patAge, hasta_hastalıkderecesi= @patMajor, hasta_cinsiyet= @patGender, hasta_kangrubu= @patBlood,hasta_gittiği_bölüm= @patBolum, hasta_gittiği_doktor= @patDoc,hasta_email= @patEmail where hasta_id = @patID"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneleri değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@patID", pat.hasta_id);
            cmd.Parameters.AddWithValue("@patName", pat.hasta_ismi);
            cmd.Parameters.AddWithValue("@patAdrs", pat.hasta_adres);
            cmd.Parameters.AddWithValue("@patPhone", pat.hasta_telefon);
            cmd.Parameters.AddWithValue("@patAge", pat.hasta_yas);
            cmd.Parameters.AddWithValue("@patMajor", pat.hasta_hastalıkderecesi);
            cmd.Parameters.AddWithValue("@patGender", pat.hasta_cinsiyet);
            cmd.Parameters.AddWithValue("@patBlood", pat.hasta_kangrubu);
            cmd.Parameters.AddWithValue("@patEmail", pat.hasta_email);
            cmd.Parameters.AddWithValue("@patBolum", pat.hasta_gittiği_bölüm);
            cmd.Parameters.AddWithValue("@patDoc", pat.hasta_gittiği_doktor);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }

        public static int HastaSil(ELPatient pat)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "delete from Hasta where hasta_id = @patID"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            //belirlediğimiz nesneyi değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            cmd.Parameters.AddWithValue("@patID", pat.hasta_id);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }
    }
}
