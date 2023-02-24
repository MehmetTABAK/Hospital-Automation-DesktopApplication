using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //Hasta tablosuna değerleri atar.
    public class ELPatient
    {
        public int hasta_id { get; set; }

        public string hasta_ismi { get; set; }

        public string hasta_adres { get; set; }

        public long hasta_telefon { get; set; }

        public string hasta_email { get; set; }

        public int hasta_yas { get; set; }

        public string hasta_cinsiyet { get; set; }

        public string hasta_kangrubu { get; set; }

        public string hasta_gittiği_bölüm { get; set; }

        public string hasta_gittiği_doktor { get; set; }

        public string hasta_hastalıkderecesi { get; set; }
    }
}
