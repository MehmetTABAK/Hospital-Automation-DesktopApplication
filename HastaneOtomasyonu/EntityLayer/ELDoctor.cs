using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //Doktor tablosuna değerleri atar.
    public class ELDoctor
    {
        public int doktor_id { get; set; }

        public string doktor_ismi { get; set; }

        public string doktor_branş { get; set; }

        public int doktor_deneyim { get; set; }

        public long doktor_telefon { get; set; }

        public string doktor_şifre { get; set; }
    }
}
