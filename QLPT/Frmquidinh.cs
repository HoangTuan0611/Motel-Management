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
using QLPT_DAL;
using QLPT_Entity;

namespace QLPT
{
    public partial class Frmquidinh : Form
    {
        int Kiemtra;
        BUS_quidinh bus = new BUS_quidinh();
        E_quidinh ec = new E_quidinh();
        public Frmquidinh()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ec.tienphongnho = txtphongnho.Text;
                ec.tienphonglon = txtphonglon.Text;
                ec.tiendien = txttiendien.Text;
                ec.tiennuoc = txttiennuoc.Text;
                ec.tienxe = txttienxe.Text;
                ec.tienmang = txttienmang.Text;
                ec.tienrac = txttienrac.Text;
                ec.giamtienlenphong = txtgiamtien.Text;
                if (Kiemtra != 0)
                {
                    bus.SuaDuLieu(ec);
                    MessageBox.Show("Sữa dữ liệu thành công!", "Thông báo");
                }
                else
                {
                    bus.ThemDuLieu(ec);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi", "Thông báo");
                return;
            }
        }

        private void Frmquidinh_Load(object sender, EventArgs e)
        {
            Kiemtra = int.Parse(bus.kiemtra());
            if(Kiemtra!=0)
            {
                txtphongnho.Text = bus.getvalue("tienphongnho", "'1'");
                txtphonglon.Text = bus.getvalue("tienphonglon", "'1'");
                txttiendien.Text = bus.getvalue("tiendien", "'1'");
                txttiennuoc.Text = bus.getvalue("tiennuoc", "'1'");
                txttienxe.Text = bus.getvalue("tienxe", "'1'");
                txttienmang.Text = bus.getvalue("tienmang", "'1'");
                txttienrac.Text = bus.getvalue("tienrac", "'1'");
                txtgiamtien.Text = bus.getvalue("giamtienlenphong", "'1'");
            }
        }
    }
}
