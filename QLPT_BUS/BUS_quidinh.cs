using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_DAL;
using QLPT_Entity;
using System.Data;

namespace QLPT_BUS
{
    public class BUS_quidinh
    {
        DAL_quidinh sql = new DAL_quidinh();
        public void SuaDuLieu(E_quidinh et)
        {
            sql.SuaDuLieu(et);
        }
        public string kiemtra()
        {
            return sql.kiemtra();
        }
        public void ThemDuLieu(E_quidinh et)
        {
            sql.ThemDuLieu(et);
        }
        public string getvalue(string DieuKien1,string DieuKien2)
        {
            return sql.getvalue(DieuKien1, DieuKien2);
        }
    }
}
