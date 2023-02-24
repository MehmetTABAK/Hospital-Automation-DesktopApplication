using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BSPatient
    {
        public static int HastaEkle(ELPatient pat)
        {
            if (pat.hasta_id >= 0 && pat.hasta_ismi != null && pat.hasta_adres != null && pat.hasta_telefon >= 0 && pat.hasta_yas >= 0 && pat.hasta_hastalıkderecesi != null && pat.hasta_cinsiyet != null && pat.hasta_kangrubu != null && pat.hasta_email != null && pat.hasta_gittiği_bölüm != null && pat.hasta_gittiği_doktor != null) //İf içinde belirtilen özellikler doğru ise
            {
                return DALPatient.HastaEkle(pat); //DataAccessLayer ın hastaekle sınıfına pat ile git.
            }
            else
            {
                return -1;
            }
        }

        public static int HastaGüncelle(ELPatient pat)
        {
            if (pat.hasta_id >= 0 && pat.hasta_ismi != null && pat.hasta_adres != null && pat.hasta_telefon >= 0 && pat.hasta_yas >= 0 && pat.hasta_hastalıkderecesi != null && pat.hasta_cinsiyet != null && pat.hasta_kangrubu != null && pat.hasta_email != null && pat.hasta_gittiği_bölüm != null && pat.hasta_gittiği_doktor != null) //İf içinde belirtilen özellikler doğru ise
            {
                return DALPatient.HastaGüncelle(pat); //DataAccessLayer ın hastagüncelle sınıfına pat ile git.
            }
            else
            {
                return -1;
            }
        }

        public static int HastaSil(ELPatient pat)
        {
            if (pat.hasta_id >= 0) //İf içinde belirtilen özellik doğru ise
            {
                return DALPatient.HastaSil(pat); //DataAccessLayer ın hastasil sınıfına pat ile git.
            }
            else
            {
                return -1;
            }
        }
    }
}
