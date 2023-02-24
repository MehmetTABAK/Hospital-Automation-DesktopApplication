using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BSDoctor
    {
        public static int DoktorEkle(ELDoctor doc)
        {
            if (doc.doktor_id >= 0 && doc.doktor_ismi != null && doc.doktor_deneyim >= 0 && doc.doktor_şifre != null && doc.doktor_telefon >= 0 && doc.doktor_branş != null) //İf içinde belirtilen özellikler doğru ise
            {
                return DALDoctor.DoktorEkle(doc); //DataAccessLayer ın doktorekle sınıfına doc ile git.
            }
            else
            {
                return -1;
            }
        }

        public static int DoktorGüncelle(ELDoctor doc)
        {
            if (doc.doktor_id >= 0 && doc.doktor_ismi != null && doc.doktor_deneyim >= 0 && doc.doktor_şifre != null && doc.doktor_telefon >= 0 && doc.doktor_branş != null) //İf içinde belirtilen özellikler doğru ise
            {
                return DALDoctor.DoktorGüncelle(doc); //DataAccessLayer ın doktorgüncelle sınıfına doc ile git.
            }
            else
            {
                return -1;
            }
        }

        public static int DoktorSil(ELDoctor doc)
        {
            if (doc.doktor_id >= 0) //İf içinde belirtilen özellik doğru ise
            {
                return DALDoctor.DoktorSil(doc); //DataAccessLayer ın doktorsil sınıfına doc ile git.
            }
            else
            {
                return -1;
            }
        }
    }
}
