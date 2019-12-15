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

namespace QLPT
{
    public partial class Frmtraphong : Form
    {
        BUS_traphong bus = new BUS_traphong();
        public Frmtraphong()
        {
            InitializeComponent();
        }

        private void Frmtraphong_Load(object sender, EventArgs e)
        {
            cbphong.DataSource = bus.LayThongtinmapt(" where trangthai ='Đang cho thuê'");
            cbphong.ValueMember = "mapt";
            cbphong.DisplayMember = "mapt";
            if (cbphong != null)
            {
                txttenphong.Text = bus.getvalue("tenphong","'"+cbphong.Text+"'");
                txtmaphong.Text = bus.getvalue("mapt","'"+cbphong.Text+"'");
                dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='"+txtmaphong.Text+"'");
            }
        }

        

        private void Cbphong_TextChanged(object sender, EventArgs e)
        {
            txttenphong.Text = bus.getvalue("tenphong", "'" + cbphong.Text + "'");
            txtmaphong.Text = bus.getvalue("mapt", "'" + cbphong.Text + "'");
            dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='" + txtmaphong.Text + "'");
        }

        private void Btnxacnhan_Click(object sender, EventArgs e)
        {
            bus.Xoa("'"+txtmaphong.Text+"'");
            bus.updatetrangthaiphongtro2("'" + txtmaphong.Text + "'");
            cbphong.DataSource = bus.LayThongtinmapt(" where trangthai ='Đang cho thuê'");
            cbphong.ValueMember = "mapt";
            cbphong.DisplayMember = "mapt";
            if (cbphong != null)
            {
                txttenphong.Text = bus.getvalue("tenphong", "'" + cbphong.Text + "'");
                txtmaphong.Text = bus.getvalue("mapt", "'" + cbphong.Text + "'");
                dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='" + txtmaphong.Text + "'");
            }
        }
    }
}
