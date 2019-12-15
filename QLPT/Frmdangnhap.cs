using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using QLPT_DAL;


namespace QLPT
{
    public partial class Frmdangnhap : Form
    {
        public Frmdangnhap()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();

   

        private void txtmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btndn_Click(sender, e);
            }

        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            string strcon = @"Server=.; Database=DataQLPT ;Integrated Security=SSPI;";
            string user = txttnd.Text.Trim();
            string pass = txtmk.Text.Trim();
            DataTable dt = SqlHelper.ExecuteDataset(strcon, "DangNhap_Login", user, pass).Tables[0];

            if (dt.Rows.Count > 0)

            {
                FrmMain.TaiKhoan = txttnd.Text;
                MessageBox.Show("Chào mừng bạn đến chương trình Quản lý nhà trọ");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry! Bạn sai tài khoản hoặc mật khẩu mất rồi", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txttnd.Focus();

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            FrmMain.TaiKhoan = txttnd.Text = "";
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn huỷ đăng nhập?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                //MessageBox.Show("Tạm Biệt! Hẹn Gặp Lại", "Thông Báo");
                //Application.Exit();
                this.Hide();

            }
        }

        private void btndn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btndn_Click(sender, e);
            }
        }

    }
}
