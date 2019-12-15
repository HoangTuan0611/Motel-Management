using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_Entity;
using System.Data;

namespace QLPT_DAL
{
    public class DAL_quidinh
    {
        KetNoiDB cn = new KetNoiDB();
        public void SuaDuLieu(E_quidinh et)
        {
            cn.ThucThiCauLenh(@"UPDATE thamso SET tienphongnho =N'" + et.tienphongnho + "', tienphonglon =N'" + et.tienphonglon + "', tiendien =N'" + et.tiendien + "', tiennuoc =N'" + et.tiennuoc + "', tienxe =N'" + et.tienxe + "', tienmang =N'" + et.tienmang + "', tienrac=N'" + et.tienrac +"', giamtienlenphong=N'" +et.giamtienlenphong +"'");
        }
        public string kiemtra()
        {
            return cn.GetValue("Select COUNT(*) from thamso");
        }
        public void ThemDuLieu(E_quidinh et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO thamso (tienphongnho, tienphonglon, tiendien, tiennuoc, tienxe, tienmang, tienrac, giamtienlenphong) VALUES  ('" + et.tienphongnho + "',N'" + et.tienphonglon + "',N'" + et.tiendien + "',N'" + et.tiennuoc + "',N'" + et.tienxe + "',N'" + et.tienmang + "',N'" + et.tienrac + "',N'" + et.giamtienlenphong +"')");
        }
        public string getvalue(string DieuKien1, string DieuKien2)
        {
            return cn.GetValue("Select " + DieuKien1 + " from thamso where id = " + DieuKien2);
        }
    }
}
