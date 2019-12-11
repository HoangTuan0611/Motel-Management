using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLPT_BUS;
using QLPT_DAL;
using QLPT_Entity;

namespace QLPT
{
    public partial class Frmkhachtro : Form
    {
        public Frmkhachtro()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_khachtro bus = new BUS_khachtro();
        E_khachtro ec = new E_khachtro();

        void KhoaDieuKien()
        {
            txtcmnd.Enabled = false;
            txthoten.Enabled = false;
            txtmakt.Enabled = false;
            txtnghenghiep.Enabled = false;
            txtsdt.Enabled = false;
            cbmapt.Enabled = false;
            rdnu.Enabled = false;
            rdnam.Enabled = false;
        }

        void MoDieuKien()
        {
            txtcmnd.Enabled = true;
            txthoten.Enabled = true;
            txtmakt.Enabled = false;
            txtnghenghiep.Enabled = true;
            txtsdt.Enabled = true;
            cbmapt.Enabled = true;
            rdnu.Enabled = true;
            rdnam.Enabled = true;
        }

        void setnull()
        {
            txtsdt.Text = "";
            txtnghenghiep.Text = "";
            txtmakt.Text = "";
            txthoten.Text = "";
            txtcmnd.Text = "";
            cbmapt.Text = "";
        }

        void HienThi(string where)
        {
            dgvkhachhang.DataSource = bus.TaoBang(where);
        }

        private void Frmkhachtro_Load(object sender, EventArgs e)
        {
            cbmapt.DataSource = bus.LayThongtinmapt("");
            cbmapt.ValueMember = "mapt";
            cbmapt.DisplayMember = "mapt";
            KhoaDieuKien();
            HienThi("");
        }

        private string GetGioiTinh()//Lấy giới tính của sinh viên
        {
            if (rdnam.Checked)
                return "Nam";
            else 
                return "Nữ";           
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (btnthem.Text == "Thêm")
            {

                MoDieuKien();
                setnull();
                txtmakt.Focus();
                btnthem.Text = "Lưu";
                MaTuTang();
            }
            else if(btnthem.Text == "Lưu")
            {
                if (txtmakt.Text == "" || txthoten.Text == "" || cbmapt.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.hoten = txthoten.Text;
                        ec.nghenghiep = txtnghenghiep.Text;
                        ec.sdt = txtsdt.Text;
                        ec.cmnd = txtcmnd.Text;
                        ec.mapt = cbmapt.Text;
                        ec.gioitinh = GetGioiTinh();
                        ec.makt = txtmakt.Text;                     
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
                txtmakt.Focus();
                btnsua.Text = "Lưu";
            }
            else if (btnsua.Text == "Lưu")
            {
                if (txtmakt.Text == "" || txthoten.Text == "" || cbmapt.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.hoten = txthoten.Text;
                        ec.nghenghiep = txtnghenghiep.Text;
                        ec.sdt = txtsdt.Text;
                        ec.cmnd = txtcmnd.Text;
                        ec.mapt = cbmapt.Text;
                        ec.gioitinh = GetGioiTinh();
                        ec.makt = txtmakt.Text;
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
                ec.makt = txtmakt.Text;
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
            DataTable dt = db.GetDataTable("Select * from khachtro");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "KT00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "KT";//ký tự mặc định của mã nhân viên
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
            txtmakt.Text = h;
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtmakt.Text = dgvkhachhang.Rows[dong].Cells[0].Value.ToString();
                cbmapt.Text = dgvkhachhang.Rows[dong].Cells[1].Value.ToString();
                txthoten.Text = dgvkhachhang.Rows[dong].Cells[2].Value.ToString();      
                txtcmnd.Text = dgvkhachhang.Rows[dong].Cells[3].Value.ToString();              
                txtnghenghiep.Text = dgvkhachhang.Rows[dong].Cells[5].Value.ToString();
                txtsdt.Text = dgvkhachhang.Rows[dong].Cells[6].Value.ToString();
                if (dgvkhachhang[4, dgvkhachhang.CurrentRow.Index].Value.ToString() == "Nam")
                {
                    rdnam.Checked = true;
                }
                if (dgvkhachhang[4, dgvkhachhang.CurrentRow.Index].Value.ToString() == "Nữ")
                {
                    rdnu.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {
            txthoten.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txthoten.Text);
            //cho con nháy đi về sau mỗi kí tự được nhập
            txthoten.SelectionStart = txthoten.Text.Length;
        }
    }







}
