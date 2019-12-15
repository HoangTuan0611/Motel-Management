
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_Entity;

namespace QLPT_DAL
{
    public class DAL_khachtro
    {
        KetNoiDB cn = new KetNoiDB();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_khachtro et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO khachtro (makt, mapt, hoten, cmnd, gioitinh, nghenghiep, sdt) VALUES  ('" + et.makt + "',N'" + et.mapt + "',N'" + et.hoten + "',N'" + et.cmnd + "',N'" + et.gioitinh + "',N'" + et.nghenghiep + "',N'" + et.sdt + "')");
        }
        //Sửa
        public void SuaDuLieu(E_khachtro et)
        {
            cn.ThucThiCauLenh(@"UPDATE khachtro SET mapt = N'" + et.mapt + "', hoten =N'" + et.hoten + "', cmnd ='" + et.cmnd + "', gioitinh ='" + et.gioitinh + "', nghenghiep ='" + et.nghenghiep + "', sdt ='" + et.sdt + "' Where makt='" + et.makt + "'");
        }
        //Xoá
        public void XoaDuLieu(E_khachtro et)
        {

            cn.ThucThiCauLenh(@"DELETE FROM khachtro  Where makt='" + et.makt + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from khachtro " + DieuKien);
        }
        public DataTable LayThongtinmapt(string DieuKien)
        {
            return cn.GetDataTable("Select mapt from phongtro " + DieuKien);
        }
        public void updatetrangthaiphongtro1(string DieuKien)
        {
            cn.ThucThiCauLenh("UPDATE phongtro SET trangthai ='Dang cho thue' where mapt = " + DieuKien);
        }
        public void updatetrangthaiphongtro2(string DieuKien)
        {
            cn.ThucThiCauLenh("UPDATE phongtro SET trangthai ='Trong' where mapt = " + DieuKien);
        }
        public string demsoluongnguoi(string DieuKien)
        {
           return cn.GetValue("Select COUNT(*) from khachtro where mapt = " + DieuKien);
        }
        public string songuoitoida(string DieuKien)
        {
           return cn.GetValue("Select sltoida from phongtro where mapt = " + DieuKien);
        }
    }
}
