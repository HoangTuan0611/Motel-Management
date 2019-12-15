using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string TaiKhoan = string.Empty;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            tbtndangNhap_Click(sender, e);
        }
        void KhoaDieuKien()
        {
            tbtndangnhap.Enabled = true;
            tbtnphongtro.Enabled = false;
            tbtnthongke.Enabled = false;
            tbtnthuephong.Enabled = false;
        }
        void MoDieuKien()
        {
            tbtndangnhap.Enabled = true;
            tbtnphongtro.Enabled = true;
            tbtnthongke.Enabled = true;
            tbtnthuephong.Enabled = true;
        }
        private void tbtndangNhap_Click(object sender, EventArgs e)
        {
            if (tbtndangnhap.Text == "Đăng nhập" && this.lbltaikhoan.Text == "")
            {
                Frmdangnhap dn = new Frmdangnhap();
                // chỉ 1 cửa sổ được mở ra!
                dn.ShowDialog();

                // nếu chuỗi có giá trị!
                if (!string.IsNullOrEmpty(TaiKhoan))
                {
                    this.lbltaikhoan.Text = TaiKhoan;
                    MoDieuKien();
                    tbtndangnhap.Text = "Đăng xuất";
                }
            }
            else
            {

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    KhoaDieuKien();
                    this.lbltaikhoan.Text = "";
                    tbtndangnhap.Text = "Đăng nhập";
                }

                if (this.lbltaikhoan.Text == "")
                {
                    KhoaDieuKien();
                    tbtndangnhap.Text = "Đăng nhập";
                }

            }
        }

        private void tbtnthuephong_Click(object sender, EventArgs e)
        {
            Frmkhachtro kt = new Frmkhachtro();
            kt.ShowDialog();
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmphongtro pt = new Frmphongtro();
            pt.ShowDialog();
        }

        private void TrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmtraphong tp = new Frmtraphong();
            tp.ShowDialog();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Frmquidinh qd = new Frmquidinh();
            qd.ShowDialog();
        }

        private void ThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmthutien tt = new Frmthutien();
            tt.ShowDialog();
        }

        private void Tbtnthongke_Click(object sender, EventArgs e)
        {
            Frmthongke tk = new Frmthongke();
            tk.ShowDialog();
        }
    }
}
