using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_DAL;
using QLPT_Entity;

namespace QLPT_BUS
{
    public class BUS_khachtro
    {
        DAL_khachtro sql = new DAL_khachtro();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_khachtro et)
        {
            sql.ThemDuLieu(et);
        }
        //Sửa
        public void SuaDuLieu(E_khachtro et)
        {
            sql.SuaDuLieu(et);
        }
        //Xoá
        public void XoaDuLieu(E_khachtro et)
        {
            sql.XoaDuLieu(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable LayThongtinmapt(string DieuKien)
        {
            return sql.LayThongtinmapt(DieuKien);
        }
        public void updatetrangthaiphongtro1(string DieuKien)
        {
            sql.updatetrangthaiphongtro1(DieuKien);
        }
        public void updatetrangthaiphongtro2(string DieuKien)
        {
            sql.updatetrangthaiphongtro2(DieuKien);
        }
        public string demsoluongnguoi(string DieuKien)
        {
            return sql.demsoluongnguoi(DieuKien);
        }
        public string songuoitoida(string DieuKien)
        {
            return sql.songuoitoida(DieuKien);
        }
    } 
}
