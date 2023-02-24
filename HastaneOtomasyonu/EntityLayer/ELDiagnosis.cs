using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //Hastalık tablosuna değerleri atar.
    public class ELDiagnosis
    {
        public int hastalık_id { get; set; }

        public int hasta_id { get; set; }

        public string hasta_ismi { get; set; }

        public string hasta_email { get; set; }

        public string hasta_gittiği_bölüm { get; set; }

        public string hasta_gittiği_doktor { get; set; }

        public string semptomlar { get; set; }

        public string teşhis { get; set; }

        public string ilaçlar { get; set; }

        public string eklenecekler { get; set; }
    }
}
