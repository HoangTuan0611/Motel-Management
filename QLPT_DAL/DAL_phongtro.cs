using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_Entity;

namespace QLPT_DAL
{
    public class DAL_phongtro
    {
        KetNoiDB cn = new KetNoiDB();

        
        // Thêm Dữ Liệu
        public void ThemDuLieu(E_phongtro et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO phongtro (mapt, tang, tenphong, loai, sltoida, trangthai) VALUES  ('" + et.mapt + "',N'" + et.tang + "',N'" + et.tenphong + "',N'" + et.loai + "',N'" + et.sltoida + "',N'" + et.trangthai + "')");
        }
        //Sửa
        public void SuaDuLieu(E_phongtro et)
        {
            cn.ThucThiCauLenh(@"UPDATE phongtro SET tang = N'" + et.tang + "', tenphong =N'" + et.tenphong + "', loai ='" + et.loai + "', sltoida ='" + et.sltoida + "', trangthai ='" + et.trangthai + "' Where mapt='" + et.mapt + "'");
        }
        //Xoá
        public void XoaDuLieu(E_phongtro et)
        {

            cn.ThucThiCauLenh(@"DELETE FROM phongtro  Where mapt='" + et.mapt + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from phongtro" + DieuKien);
        }
        public DataTable LayThongtintang(string DieuKien)
        {
            return cn.GetDataTable("Select tang from tangphong " + DieuKien);
        }
        public DataTable LayThongtinloaiphong(string DieuKien)
        {
            return cn.GetDataTable("Select loai from loaiphong " + DieuKien);
        }
    }
}
