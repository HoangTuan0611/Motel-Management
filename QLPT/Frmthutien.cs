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
using QLPT_Entity;

namespace QLPT
{
    public partial class Frmthutien : Form
    {
        int tienphongnho;
        int tienphonglon;
        int tiendien;
        int tiennuoc;
        int tienmang;
        int tienrac;
        int tienxe;
        int giamtien;
        int Kiemtra;
        string year;
        string month;
        int soluongnguoi;
        BUS_thutien bus = new BUS_thutien();
        E_thutien ec = new E_thutien();
        public Frmthutien()
        {
            InitializeComponent();
        }

        private void Frmthutien_Load(object sender, EventArgs e)
        {
            Kiemtra = int.Parse(bus.kiemtra());
            
                if (Kiemtra != 0)
                {
                    tienphongnho = int.Parse(bus.getvalue2("tienphongnho", "'1'"));
                    tienphonglon = int.Parse(bus.getvalue2("tienphonglon", "'1'"));
                    tiendien = int.Parse(bus.getvalue2("tiendien", "'1'"));
                    tiennuoc = int.Parse(bus.getvalue2("tiennuoc", "'1'"));
                    tienxe = int.Parse(bus.getvalue2("tienxe", "'1'"));
                    tienmang = int.Parse(bus.getvalue2("tienmang", "'1'"));
                    tienrac = int.Parse(bus.getvalue2("tienrac", "'1'"));
                    giamtien = int.Parse(bus.getvalue2("giamtienlenphong", "'1'"));
                }
                cbphong.DataSource = bus.LayThongtinmapt(" where trangthai != 'Trong' and trangthai != 'Bao Tri'");
                cbphong.ValueMember = "mapt";
                cbphong.DisplayMember = "mapt";
                if (cbphong != null)
                {
                    soluongnguoi = int.Parse(bus.demsoluongnguoi("'" + cbphong.Text + "'"));
                    txttenphong.Text = bus.getvalue("tenphong", "'" + cbphong.Text + "'");
                    txtmaphong.Text = bus.getvalue("mapt", "'" + cbphong.Text + "'");
                    txtTang.Text = bus.getvalue("tang", "'" + cbphong.Text + "'");
                    txtloaiphong.Text = bus.getvalue("loai", "'" + cbphong.Text + "'");
                    dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='" + txtmaphong.Text + "'");
                    txttiennuoc.Text = (soluongnguoi * tiennuoc).ToString();
                    txttienmang.Text = tienmang.ToString();
                    if (txtloaiphong.Text == "A")
                    {
                        txttienphong.Text = tienphongnho.ToString();
                    }
                    else { txttienphong.Text = tienphonglon.ToString(); }

                }
            
            string time = dtngaythu.Text;
            year = time.Substring(6, 4);
            month = time.Substring(3, 2);
        }

        private void Cbphong_TextChanged(object sender, EventArgs e)
        {
            if (cbphong != null)
            {
                soluongnguoi = int.Parse(bus.demsoluongnguoi("'" + cbphong.Text + "'"));
                txttenphong.Text = bus.getvalue("tenphong", "'" + cbphong.Text + "'");
                txtmaphong.Text = bus.getvalue("mapt", "'" + cbphong.Text + "'");
                txtTang.Text = bus.getvalue("tang", "'" + cbphong.Text + "'");
                txtloaiphong.Text = bus.getvalue("loai", "'" + cbphong.Text + "'");
                dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='" + txtmaphong.Text + "'");
                txttiennuoc.Text = (soluongnguoi * tiennuoc).ToString();
                txttienmang.Text = tienmang.ToString();
                if (txtloaiphong.Text == "A")
                {
                    txttienphong.Text = tienphongnho.ToString();
                }             
                else { txttienphong.Text = tienphonglon.ToString(); }
                try
                {
                    if (txtsokidien.Text != "" && txtsoxe.Text != "")
                    {
                        txttongtien.Text = (tienrac + int.Parse(txttienphong.Text) + int.Parse(txttiendien.Text)
                                       + int.Parse(txttiennuoc.Text) + int.Parse(txttienmang.Text)
                                       + int.Parse(txttienxe.Text) - ((int.Parse(txtTang.Text) - 1) * giamtien)).ToString();
                    }
                }
                catch { MessageBox.Show("Vui lòng kiểm tra lại tham số ở form qui định","Thông báo"); }
            }
        }

        private void Txtsokidien_TextChanged(object sender, EventArgs e)
        {

            try
            {
                txttiendien.Text = (tiendien * (int.Parse(txtsokidien.Text))).ToString();
                if (txtsoxe.Text != "")
                {
                    txttongtien.Text = (tienrac + int.Parse(txttienphong.Text) + int.Parse(txttiendien.Text)
                                       + int.Parse(txttiennuoc.Text) + int.Parse(txttienmang.Text)
                                       + int.Parse(txttienxe.Text) - ((int.Parse(txtTang.Text) - 1) * giamtien)).ToString();
                }
            }
            catch { MessageBox.Show("Vui lòng kiểm tra lại tham số ở form qui định", "Thông báo"); }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttienxe.Text = (tienxe * (int.Parse(txtsoxe.Text))).ToString();
                if (txtsokidien.Text != "")
                {
                    txttongtien.Text = (tienrac + int.Parse(txttienphong.Text) + int.Parse(txttiendien.Text)
                                   + int.Parse(txttiennuoc.Text) + int.Parse(txttienmang.Text)
                                   + int.Parse(txttienxe.Text) - ((int.Parse(txtTang.Text) - 1) * giamtien)).ToString();
                }
            }
            catch { MessageBox.Show("Vui lòng kiểm tra lại tham số ở form qui định", "Thông báo"); }
        }

        private void Btntinhtien_Click(object sender, EventArgs e)
        {
            if (txtsokidien.Text == "")
            {
                MessageBox.Show("Vui lòng điền số kí điện", "Thông báo");
                return;
            }
            if (txtsoxe.Text == "")
            {
                MessageBox.Show("Vui lòng điền số lượng xe", "Thông báo");
                return;
            }
            string a = bus.kiemtra2(cbphong.Text, month, year);
            if(a!="0")
            {
                MessageBox.Show("Bạn đã tính tiền phòng này tháng này rồi", "Thông báo");
                return;
            }
            else
            {
                try
                {
                    
                    ec.mapt = cbphong.Text;
                    ec.tiendien = txttiendien.Text;
                    ec.tiennuoc = txttiennuoc.Text;
                    ec.tienxe = txttienxe.Text;
                    ec.tienmang = txttienmang.Text;
                    ec.tongtien = txttongtien.Text;
                    ec.tienphong = txttienphong.Text;
                    ec.ngaythu = dtngaythu.Value;
                    if (txtsokidien.Text != "" && txtsoxe.Text != "")
                    {
                        if (Kiemtra != 0)
                        {
                            bus.ThemDuLieu(ec);
                            MessageBox.Show("Tính tiền thành công nếu kết quả sai vui lòng kiểm tra tham số form qui định!", "Thông báo");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ tham số trong form qui định");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tính tiền thất bại", "Thông Báo");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Báo lỗi", "Thông báo");
                    return;
                }
            }
        }

        private void Dtngaythu_ValueChanged(object sender, EventArgs e)
        {
            string time = dtngaythu.Text;
            year = time.Substring(6, 4);
            month = time.Substring(3, 2);
        }

       
    }
}
