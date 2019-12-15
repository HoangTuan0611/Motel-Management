using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_DAL;
using System.Data;

namespace QLPT_BUS
{
    public class BUS_traphong
    {
        DAL_traphong sql = new DAL_traphong();
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable LayThongtinmapt(string DieuKien)
        {
            return sql.LayThongtinmapt(DieuKien);
        }
        public void updatetrangthaiphongtro2(string DieuKien)
        {
            sql.updatetrangthaiphongtro2(DieuKien);
        }
        public string getvalue(string DieuKien1, string DieuKien2)
        {
            return sql.getvalue(DieuKien1, DieuKien2);
        }
        public void Xoa(string DieuKien)
        {
            sql.Xoa(DieuKien);
        }
    }
}
