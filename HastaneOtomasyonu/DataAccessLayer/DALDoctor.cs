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
    public class DALDoctor
    {
        public static int DoktorEkle(ELDoctor doc)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "insert into Doktor(doktor_id, doktor_ismi, doktor_deneyim, doktor_şifre, doktor_branş, doktor_telefon) values(@docID, @docName, @docExp, @docPass, @docBrans, @docNumber)"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneleri değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@docID", doc.doktor_id);
            cmd.Parameters.AddWithValue("@docName", doc.doktor_ismi);
            cmd.Parameters.AddWithValue("@docExp", doc.doktor_deneyim);
            cmd.Parameters.AddWithValue("@docPass", doc.doktor_şifre);
            cmd.Parameters.AddWithValue("@docBrans", doc.doktor_branş);
            cmd.Parameters.AddWithValue("@docNumber", doc.doktor_telefon);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }

        public static int DoktorGüncelle(ELDoctor doc)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "update Doktor set doktor_ismi= @docName , doktor_deneyim= @docExp , doktor_şifre= @docPass, doktor_branş= @docBrans, doktor_telefon=@docNumber where doktor_id = @docID"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneleri değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@docID", doc.doktor_id);
            cmd.Parameters.AddWithValue("@docName", doc.doktor_ismi);
            cmd.Parameters.AddWithValue("@docExp", doc.doktor_deneyim);
            cmd.Parameters.AddWithValue("@docPass", doc.doktor_şifre);
            cmd.Parameters.AddWithValue("@docBrans", doc.doktor_branş);
            cmd.Parameters.AddWithValue("@docNumber", doc.doktor_telefon);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }

        public static int DoktorSil(ELDoctor doc)
        {
            if (Conn.Con.State == ConnectionState.Closed) //veritabanı bağlantısı kapalı ise
            {
                Conn.Con.Open(); //veritabanı bağlantısını aç.
            }

            string query = "delete from Doktor where doktor_id = @docID"; //veritabanındaki ulaşmak istediğimiz tablo ve o tablonun içeriğine erişmemizi sağlar.

            SqlCommand cmd = new SqlCommand(query, Conn.Con); //veritabanı üzerinde yapmak istediğimiz işlemlerimizi yapabilmemiz için string olarak komut dizesi yazdırma imkanı sağlar.

            //belirlediğimiz nesneyi değer olarak alır ve veritabanındaki tip türüne uyup uymadığını kontrol eder.eğer uygunsa addwithvalue ile sql kodunun içine işler.
            cmd.Parameters.AddWithValue("@docID", doc.doktor_id);

            return cmd.ExecuteNonQuery(); //veritabanını direk olarak kullanmadan verileri değiştirmek için kullanılır.belirttiğimiz değerleri işler.
        }
    }
}
