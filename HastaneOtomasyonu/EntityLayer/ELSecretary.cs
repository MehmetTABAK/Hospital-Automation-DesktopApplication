using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //Sekreter tablosuna değerleri atar.
    public class ELSecretary
    {
        public int sekreter_id { get; set; }

        public string sekreter_ismi { get; set; }

        public long sekreter_telefon { get; set; }

        public string sekreter_şifre { get; set; }
    }
}
