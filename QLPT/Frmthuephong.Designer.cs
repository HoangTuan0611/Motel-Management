namespace QLPT
{
    partial class Frmkhachtro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbphongtrong = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtslhientai = new System.Windows.Forms.TextBox();
            this.txtsltoida = new System.Windows.Forms.TextBox();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.cbmapt = new System.Windows.Forms.ComboBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtnghenghiep = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmakt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbphongtrong);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtslhientai);
            this.panel1.Controls.Add(this.txtsltoida);
            this.panel1.Controls.Add(this.rdnu);
            this.panel1.Controls.Add(this.rdnam);
            this.panel1.Controls.Add(this.cbmapt);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.txtnghenghiep);
            this.panel1.Controls.Add(this.txtcmnd);
            this.panel1.Controls.Add(this.txthoten);
            this.panel1.Controls.Add(this.txtmakt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 122);
            this.panel1.TabIndex = 7;
            // 
            // ckbphongtrong
            // 
            this.ckbphongtrong.AutoSize = true;
            this.ckbphongtrong.Location = new System.Drawing.Point(206, 56);
            this.ckbphongtrong.Name = "ckbphongtrong";
            this.ckbphongtrong.Size = new System.Drawing.Size(88, 17);
            this.ckbphongtrong.TabIndex = 19;
            this.ckbphongtrong.Text = "Phòng Trống";
            this.ckbphongtrong.UseVisualStyleBackColor = true;
            this.ckbphongtrong.CheckedChanged += new System.EventHandler(this.Ckbphongtrong_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "SL Hiện Tại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "SL Tối Đa";
            // 
            // txtslhientai
            // 
            this.txtslhientai.Enabled = false;
            this.txtslhientai.Location = new System.Drawing.Point(659, 84);
            this.txtslhientai.Name = "txtslhientai";
            this.txtslhientai.Size = new System.Drawing.Size(100, 20);
            this.txtslhientai.TabIndex = 16;
            // 
            // txtsltoida
            // 
            this.txtsltoida.Enabled = false;
            this.txtsltoida.Location = new System.Drawing.Point(390, 84);
            this.txtsltoida.Name = "txtsltoida";
            this.txtsltoida.Size = new System.Drawing.Size(100, 20);
            this.txtsltoida.TabIndex = 15;
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(455, 51);
            this.rdnu.Margin = new System.Windows.Forms.Padding(2);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(39, 17);
            this.rdnu.TabIndex = 14;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(388, 51);
            this.rdnam.Margin = new System.Windows.Forms.Padding(2);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 13;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // cbmapt
            // 
            this.cbmapt.FormattingEnabled = true;
            this.cbmapt.Location = new System.Drawing.Point(109, 52);
            this.cbmapt.Margin = new System.Windows.Forms.Padding(2);
            this.cbmapt.Name = "cbmapt";
            this.cbmapt.Size = new System.Drawing.Size(92, 21);
            this.cbmapt.TabIndex = 12;
            this.cbmapt.TextChanged += new System.EventHandler(this.Cbmapt_TextChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(659, 52);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(162, 20);
            this.txtsdt.TabIndex = 11;
            // 
            // txtnghenghiep
            // 
            this.txtnghenghiep.Location = new System.Drawing.Point(659, 20);
            this.txtnghenghiep.Margin = new System.Windows.Forms.Padding(2);
            this.txtnghenghiep.Name = "txtnghenghiep";
            this.txtnghenghiep.Size = new System.Drawing.Size(162, 20);
            this.txtnghenghiep.TabIndex = 10;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(388, 20);
            this.txtcmnd.Margin = new System.Windows.Forms.Padding(2);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(128, 20);
            this.txtcmnd.TabIndex = 9;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(109, 87);
            this.txthoten.Margin = new System.Windows.Forms.Padding(2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(182, 20);
            this.txthoten.TabIndex = 8;
            this.txthoten.TextChanged += new System.EventHandler(this.txthoten_TextChanged);
            // 
            // txtmakt
            // 
            this.txtmakt.Location = new System.Drawing.Point(109, 20);
            this.txtmakt.Margin = new System.Windows.Forms.Padding(2);
            this.txtmakt.Name = "txtmakt";
            this.txtmakt.Size = new System.Drawing.Size(93, 20);
            this.txtmakt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nghề nghiệp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng trọ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách trọ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Location = new System.Drawing.Point(4, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 37);
            this.panel2.TabIndex = 8;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(313, 12);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 19);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(540, 12);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(56, 19);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(432, 12);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(56, 19);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvkhachhang);
            this.groupBox1.Location = new System.Drawing.Point(2, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(937, 272);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makt,
            this.mapt,
            this.hoten,
            this.cmnd,
            this.gioitinh,
            this.nghenghiep,
            this.sdt});
            this.dgvkhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkhachhang.Location = new System.Drawing.Point(2, 15);
            this.dgvkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.Size = new System.Drawing.Size(933, 255);
            this.dgvkhachhang.TabIndex = 0;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // makt
            // 
            this.makt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makt.DataPropertyName = "makt";
            this.makt.HeaderText = "Mã khách trọ";
            this.makt.Name = "makt";
            // 
            // mapt
            // 
            this.mapt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Mã phòng trọ";
            this.mapt.Name = "mapt";
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            // 
            // cmnd
            // 
            this.cmnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // nghenghiep
            // 
            this.nghenghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nghenghiep.DataPropertyName = "nghenghiep";
            this.nghenghiep.HeaderText = "Nghề nghiệp";
            this.nghenghiep.Name = "nghenghiep";
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            // 
            // Frmkhachtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frmkhachtro";
            this.Text = "Thuê phòng";
            this.Load += new System.EventHandler(this.Frmkhachtro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.ComboBox cbmapt;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtnghenghiep;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmakt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtslhientai;
        private System.Windows.Forms.TextBox txtsltoida;
        private System.Windows.Forms.CheckBox ckbphongtrong;
    }
}