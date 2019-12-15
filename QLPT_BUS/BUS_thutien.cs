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
    public class BUS_thutien
    {
        DAL_thutien sql = new DAL_thutien();
        public DataTable LayThongtinmapt(string DieuKien)
        {
            return sql.LayThongtinmapt(DieuKien);
        }
        public string getvalue(string DieuKien1, string DieuKien2)
        {
            return sql.getvalue(DieuKien1, DieuKien2);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public string kiemtra()
        {
            return sql.kiemtra();
        }
        public string getvalue2(string DieuKien1, string DieuKien2)
        {
            return sql.getvalue2(DieuKien1, DieuKien2);
        }
        public string demsoluongnguoi(string DieuKien)
        {
            return sql.demsoluongnguoi(DieuKien);
        }
        public string kiemtra2(string DieuKien1,string DieuKien2,string DieuKien3)
        {
            return sql.kiemtra2(DieuKien1, DieuKien2, DieuKien3);
        }
        public void ThemDuLieu(E_thutien et)
        {
            sql.ThemDuLieu(et);
        }
    }
}
