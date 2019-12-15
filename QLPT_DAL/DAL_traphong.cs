using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_DAL
{
    public class DAL_traphong
    {
        KetNoiDB cn = new KetNoiDB();
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from khachtro " + DieuKien);
        }
        public DataTable LayThongtinmapt(string DieuKien)
        {
            return cn.GetDataTable("Select mapt from phongtro " + DieuKien);
        }
        public void updatetrangthaiphongtro2(string DieuKien)
        {
            cn.ThucThiCauLenh("UPDATE phongtro SET trangthai ='Trống' where mapt = " + DieuKien);
        }
        public string getvalue(string DieuKien1,string DieuKien2)
        {
            return cn.GetValue("Select "+ DieuKien1+" from phongtro where mapt = " + DieuKien2);
        }
        public void Xoa(string DieuKien)
        {
            cn.ThucThiCauLenh("Delete from khachtro where mapt=" + DieuKien);
        }
    }
}
