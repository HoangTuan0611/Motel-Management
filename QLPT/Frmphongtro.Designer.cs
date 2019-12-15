namespace QLPT
{
    partial class Frmphongtro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmphongtro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbtrangthai = new System.Windows.Forms.ComboBox();
            this.cbloaiphong = new System.Windows.Forms.ComboBox();
            this.cbtang = new System.Windows.Forms.ComboBox();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txtmapt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvphongtro = new System.Windows.Forms.DataGridView();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sltoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnhuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphongtro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbtrangthai);
            this.panel1.Controls.Add(this.cbloaiphong);
            this.panel1.Controls.Add(this.cbtang);
            this.panel1.Controls.Add(this.txttenphong);
            this.panel1.Controls.Add(this.txtmapt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 178);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbtrangthai
            // 
            this.cmbtrangthai.FormattingEnabled = true;
            this.cmbtrangthai.Items.AddRange(new object[] {
            "Trong",
            "Bao Tri"});
            this.cmbtrangthai.Location = new System.Drawing.Point(831, 36);
            this.cmbtrangthai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbtrangthai.Name = "cmbtrangthai";
            this.cmbtrangthai.Size = new System.Drawing.Size(203, 24);
            this.cmbtrangthai.TabIndex = 14;
            // 
            // cbloaiphong
            // 
            this.cbloaiphong.FormattingEnabled = true;
            this.cbloaiphong.Location = new System.Drawing.Point(544, 39);
            this.cbloaiphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbloaiphong.Name = "cbloaiphong";
            this.cbloaiphong.Size = new System.Drawing.Size(118, 24);
            this.cbloaiphong.TabIndex = 13;
            // 
            // cbtang
            // 
            this.cbtang.FormattingEnabled = true;
            this.cbtang.Location = new System.Drawing.Point(544, 86);
            this.cbtang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbtang.Name = "cbtang";
            this.cbtang.Size = new System.Drawing.Size(121, 24);
            this.cbtang.TabIndex = 12;
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(176, 78);
            this.txttenphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(152, 22);
            this.txttenphong.TabIndex = 8;
            this.txttenphong.TextChanged += new System.EventHandler(this.txttenphong_TextChanged);
            // 
            // txtmapt
            // 
            this.txtmapt.Location = new System.Drawing.Point(176, 31);
            this.txtmapt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmapt.Name = "txtmapt";
            this.txtmapt.Size = new System.Drawing.Size(152, 22);
            this.txtmapt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tầng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng trọ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng trọ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Location = new System.Drawing.Point(12, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 60);
            this.panel2.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(427, 18);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(749, 18);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(587, 18);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(12, 254);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1183, 302);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvphongtro);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1177, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng trọ";
            // 
            // dgvphongtro
            // 
            this.dgvphongtro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphongtro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapt,
            this.tenphong,
            this.tang,
            this.loaiphong,
            this.sltoida,
            this.trangthai});
            this.dgvphongtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvphongtro.Location = new System.Drawing.Point(3, 17);
            this.dgvphongtro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvphongtro.Name = "dgvphongtro";
            this.dgvphongtro.Size = new System.Drawing.Size(1171, 276);
            this.dgvphongtro.TabIndex = 0;
            this.dgvphongtro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphongtro_CellClick);
            // 
            // mapt
            // 
            this.mapt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Mã phòng trọ";
            this.mapt.Name = "mapt";
            // 
            // tenphong
            // 
            this.tenphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.Name = "tenphong";
            // 
            // tang
            // 
            this.tang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tang.DataPropertyName = "tang";
            this.tang.HeaderText = "Tầng";
            this.tang.Name = "tang";
            // 
            // loaiphong
            // 
            this.loaiphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiphong.DataPropertyName = "loai";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.Name = "loaiphong";
            // 
            // sltoida
            // 
            this.sltoida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sltoida.DataPropertyName = "sltoida";
            this.sltoida.HeaderText = "Số lượng người tối đa";
            this.sltoida.Name = "sltoida";
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(897, 18);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 3;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // Frmphongtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1207, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frmphongtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng trọ";
            this.Load += new System.EventHandler(this.Frmphongtro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphongtro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbloaiphong;
        private System.Windows.Forms.ComboBox cbtang;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.TextBox txtmapt;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvphongtro;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cmbtrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sltoida;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Button btnhuy;
    }
}