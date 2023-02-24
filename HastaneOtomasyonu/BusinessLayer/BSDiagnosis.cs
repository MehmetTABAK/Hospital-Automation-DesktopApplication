using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BSDiagnosis
    {
        public static int HastalıkEkle(ELDiagnosis diag)
        {
            if (diag.hastalık_id >= 0 && diag.hasta_ismi != null && diag.semptomlar != null && diag.teşhis != null && diag.ilaçlar != null) //İf içinde belirtilen özellikler doğru ise
            {
                return DALDiagnosis.HastalıkEkle(diag); //DataAccessLayer ın hastalıkekle sınıfına diag ile git.
            }
            else
            {
                return -1;
            }
        }

        public static int HastalıkGüncelle(ELDiagnosis diag)
        {
            if (diag.hastalık_id >= 0 && diag.hasta_ismi != null && diag.semptomlar != null && diag.teşhis != null && diag.ilaçlar != null) //İf içinde belirtilen özellikler doğru ise
            {
                return DALDiagnosis.HastalıkGüncelle(diag);//DataAccessLayer ın hastalıkgüncelle sınıfına diag ile git.
            }
            else
            {
                return -1;
            }
        }

        public static int HastalıkSil(ELDiagnosis diag)
        {
            if (diag.hastalık_id >= 0) //İf içinde belirtilen özellik doğru ise
            {
                return DALDiagnosis.HastalıkSil(diag); //DataAccessLayer ın hastalıksil sınıfına diag ile git.
            }
            else
            {
                return -1;
            }
        }
    }
}
