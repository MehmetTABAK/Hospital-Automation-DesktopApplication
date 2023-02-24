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
    public class DALSecretary
    {
        public static int SekreterEkle(ELSecretary sec)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "insert into Sekreter(sekreter_id, sekreter_ismi, sekreter_şifre, sekreter_telefon) values(@secID, @secName, @secPass, @secNumber)"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneleri değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@secID", sec.sekreter_id);
            cmd.Parameters.AddWithValue("@secName", sec.sekreter_ismi);
            cmd.Parameters.AddWithValue("@secPass", sec.sekreter_şifre);
            cmd.Parameters.AddWithValue("@secNumber", sec.sekreter_telefon);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler
        }

        public static int SekreterGüncelle(ELSecretary sec)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "update Sekreter set sekreter_ismi= @secName, sekreter_şifre= @secPass, sekreter_telefon= @secNumber where sekreter_id = @secID"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneleri değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@secID", sec.sekreter_id);
            cmd.Parameters.AddWithValue("@secName", sec.sekreter_ismi);
            cmd.Parameters.AddWithValue("@secPass", sec.sekreter_şifre);
            cmd.Parameters.AddWithValue("@secNumber", sec.sekreter_telefon);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler
        }

        public static int SekreterSil(ELSecretary sec)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "delete from Sekreter where sekreter_id = @secID"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneyi değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@secID", sec.sekreter_id);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler
        }
    }
}
