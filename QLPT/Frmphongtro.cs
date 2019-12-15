using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPT_BUS;
using System.Text.RegularExpressions;
using QLPT_DAL;
using QLPT_Entity;

namespace QLPT
{
    public partial class Frmphongtro : Form
    {
        string kiemtratrangthai;
        public Frmphongtro()
        {
            InitializeComponent();
        }

        KetNoiDB db = new KetNoiDB();
        BUS_phongtro bus = new BUS_phongtro();
        E_phongtro ec = new E_phongtro();

        void KhoaDieuKien()
        {
            txtmapt.Enabled = false;
           
            
            txttenphong.Enabled = false;
            cmbtrangthai.Enabled = false;
            cbloaiphong.Enabled = false;
            cbtang.Enabled = false;
           
        }

        void MoDieuKien()
        {
            txtmapt.Enabled = false;
            
            
            txttenphong.Enabled = true;         
            cbloaiphong.Enabled = true;
            cbtang.Enabled = true;
            cmbtrangthai.Enabled = true;
        }

        void setnull()
        {
            txtmapt.Text = "";
            
    
            txttenphong.Text = "";
            cbtang.Text = "";
            cbloaiphong.Text = "";
        }

        void HienThi(string where)
        {
            dgvphongtro.DataSource = bus.TaoBang(where);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frmphongtro_Load(object sender, EventArgs e)
        {
            cbloaiphong.DataSource = bus.LayThongtinloaiphong("");
            cbloaiphong.ValueMember = "loai";
            cbloaiphong.DisplayMember = "loai";
            cbtang.DataSource = bus.LayThongtintang("");
            cbtang.ValueMember = "tang";
            cbtang.DisplayMember = "tang";
            KhoaDieuKien();
            HienThi("");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (btnthem.Text == "Thêm")
            {               
                MoDieuKien();
                cmbtrangthai.Text = "Trong";
                cmbtrangthai.Enabled = false;
                setnull();
                txtmapt.Focus();
                btnthem.Text = "Lưu";
                MaTuTang();
            }
            else if (btnthem.Text == "Lưu")
            {
                if (txtmapt.Text == "" || txttenphong.Text == "" || cbtang.Text == "" || cbloaiphong.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.mapt = txtmapt.Text;
                        ec.loai = cbloaiphong.Text;
                        ec.tang = cbtang.Text;
                        if (cbloaiphong.Text == "A")
                        {
                            ec.sltoida = "2";
                        }
                        else { ec.sltoida = "3"; }
                        ec.trangthai = cmbtrangthai.Text;
                        ec.tenphong = txttenphong.Text;
                        bus.ThemDuLieu(ec);
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Báo lỗi", "Thông báo");
                        return;
                    }
                }
                btnthem.Text = "Thêm";
                KhoaDieuKien();
                HienThi("");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "Sửa")
            {
                MoDieuKien();
                if (kiemtratrangthai != "Dang cho thue")
                {
                    cmbtrangthai.Enabled = true;
                }
                else cmbtrangthai.Enabled = false;
                txtmapt.Focus();
                btnsua.Text = "Lưu";
            }
            else if (btnsua.Text == "Lưu")
            {
                if (txtmapt.Text == "" || txttenphong.Text == "" || cbloaiphong.Text == "" || cbtang.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.mapt = txtmapt.Text;
                        ec.loai = cbloaiphong.Text;
                        ec.tang = cbtang.Text;
                        if (cbloaiphong.Text == "A")
                        {
                            ec.sltoida = "2";
                        }
                        else { ec.sltoida = "3"; }
                        ec.trangthai = cmbtrangthai.Text;
                        ec.tenphong = txttenphong.Text;
                        bus.SuaDuLieu(ec);
                        MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Báo lỗi", "Thông báo");
                        return;
                    }
                }
                KhoaDieuKien();
                HienThi("");
                btnsua.Text = "Sửa";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.mapt = txtmapt.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Xóa thành công");
                KhoaDieuKien();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Không thể xóa!");
            }
        }
        private void MaTuTang()
        {

            DataTable dt = db.GetDataTable("Select * from phongtro");
            string h = "";
            if (dt == null) { h = "PT00001"; goto here; }
            if (dt.Rows.Count <= 0)
            {
                h = "PT00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "PT";//ký tự mặc định của mã nhân viên
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 5));
                k = k + 1;
                if (k < 10)

                    h = h + "0000";
                else if (k < 100)
                    h = h + "000";
                else if (k < 1000)
                    h = h + "00";
                else if (k < 10000)
                    h = h + "0";
                h = h + k.ToString();

            }
            here:
            txtmapt.Text = h;
        }

        private void dgvphongtro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtmapt.Text = dgvphongtro.Rows[dong].Cells[0].Value.ToString();                               
                txttenphong.Text = dgvphongtro.Rows[dong].Cells[2].Value.ToString();
                cmbtrangthai.Text = dgvphongtro.Rows[dong].Cells[5].Value.ToString();
                kiemtratrangthai = cmbtrangthai.Text;
                cbloaiphong.Text = dgvphongtro.Rows[dong].Cells[3].Value.ToString();
                cbtang.Text = dgvphongtro.Rows[dong].Cells[1].Value.ToString();

            }
            catch
            {

            }
        }

        private void txttenphong_TextChanged(object sender, EventArgs e)
        {
            txttenphong.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txttenphong.Text);
            //cho con nháy đi về sau mỗi kí tự được nhập
            txttenphong.SelectionStart = txttenphong.Text.Length;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setnull();
            txtmapt.Focus();
            btnthem.Text = "Thêm";
        }
    }
}
