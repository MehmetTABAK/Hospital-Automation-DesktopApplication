using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BSSecretary
    {
        public static int SekreterEkle(ELSecretary sec)
        {
            if (sec.sekreter_id >= 0 && sec.sekreter_ismi != null && sec.sekreter_telefon >= 0 && sec.sekreter_şifre != null) //İf içinde belirtilen özellikler doğru ise
            {
                return DALSecretary.SekreterEkle(sec); //DataAccessLayer ın secreterekle sınıfına sec ile git.
            }
            else
            {
                return -1;
            }
        }

        public static int SekreterGüncelle(ELSecretary sec)
        {
            if (sec.sekreter_id >= 0 && sec.sekreter_ismi != null && sec.sekreter_telefon >= 0 && sec.sekreter_şifre != null) //İf içinde belirtilen özellikler doğru ise
            {
                return DALSecretary.SekreterGüncelle(sec); //DataAccessLayer ın sekretergüncelle sınıfına sec ile git.
            }
            else
            {
                return -1;
            }
        }

        public static int SekreterSil(ELSecretary sec)
        {
            if (sec.sekreter_id >= 0) //İf içinde belirtilen özellik doğru ise
            {
                return DALSecretary.SekreterSil(sec); //DataAccessLayer ın sekretersil sınıfına sec ile git.
            }
            else
            {
                return -1;
            }
        }
    }
}
