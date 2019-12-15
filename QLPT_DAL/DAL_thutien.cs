using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPT_Entity;
namespace QLPT_DAL
{
    public class DAL_thutien
    {
        KetNoiDB cn = new KetNoiDB();
        public DataTable LayThongtinmapt(string DieuKien)
        {
            return cn.GetDataTable("Select mapt from phongtro " + DieuKien);
        }
        public string getvalue(string DieuKien1, string DieuKien2)
        {
            return cn.GetValue("Select " + DieuKien1 + " from phongtro where mapt = " + DieuKien2);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from khachtro " + DieuKien);
        }
        public string kiemtra()
        {
            return cn.GetValue("Select COUNT(*) from thamso");
        }
        public string getvalue2(string DieuKien1, string DieuKien2)
        {
            return cn.GetValue("Select " + DieuKien1 + " from thamso where id = " + DieuKien2);
        }
        public string demsoluongnguoi(string DieuKien)
        {
            return cn.GetValue("Select COUNT(*) from khachtro where mapt = " + DieuKien);
        }
        public string kiemtra2(string DieuKien1,string DieuKien2,string DieuKien3)
        {
            return cn.GetValue("Select COUNT(*) from thutien where mapt='" + DieuKien1 + "' and MONTH(ngaythu)='" + DieuKien2 + "' and YEAR(ngaythu)='" + DieuKien3 + "'");
        }
        public void ThemDuLieu(E_thutien et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO thutien (mapt, tiendien, tiennuoc, tienmang, tienxe, tienphong, ngaythu, tongtien) VALUES  ('" + et.mapt + "',N'" + et.tiendien + "',N'" + et.tiennuoc + "',N'" + et.tienmang + "',N'" + et.tienxe + "',N'" + et.tienphong + "',N'" + et.ngaythu + "',N'" + et.tongtien + "')");
        }
    }
}
