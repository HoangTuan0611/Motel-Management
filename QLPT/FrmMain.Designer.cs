namespace QLPT
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtndangnhap = new System.Windows.Forms.ToolStripButton();
            this.tbtnthuephong = new System.Windows.Forms.ToolStripButton();
            this.tbtnphongtro = new System.Windows.Forms.ToolStripSplitButton();
            this.danhSáchPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtnthongke = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtndangnhap,
            this.tbtnthuephong,
            this.tbtnphongtro,
            this.tbtnthongke,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(599, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtndangnhap
            // 
            this.tbtndangnhap.Image = ((System.Drawing.Image)(resources.GetObject("tbtndangnhap.Image")));
            this.tbtndangnhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtndangnhap.Name = "tbtndangnhap";
            this.tbtndangnhap.Size = new System.Drawing.Size(89, 24);
            this.tbtndangnhap.Text = "Đăng nhập";
            this.tbtndangnhap.Click += new System.EventHandler(this.tbtndangNhap_Click);
            // 
            // tbtnthuephong
            // 
            this.tbtnthuephong.Image = ((System.Drawing.Image)(resources.GetObject("tbtnthuephong.Image")));
            this.tbtnthuephong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnthuephong.Name = "tbtnthuephong";
            this.tbtnthuephong.Size = new System.Drawing.Size(96, 24);
            this.tbtnthuephong.Text = "Thuê phòng";
            this.tbtnthuephong.Click += new System.EventHandler(this.tbtnthuephong_Click);
            // 
            // tbtnphongtro
            // 
            this.tbtnphongtro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchPhòngToolStripMenuItem,
            this.thuTiềnToolStripMenuItem,
            this.trảPhòngToolStripMenuItem});
            this.tbtnphongtro.Image = ((System.Drawing.Image)(resources.GetObject("tbtnphongtro.Image")));
            this.tbtnphongtro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnphongtro.Name = "tbtnphongtro";
            this.tbtnphongtro.Size = new System.Drawing.Size(96, 24);
            this.tbtnphongtro.Text = "Phòng trọ";
            // 
            // danhSáchPhòngToolStripMenuItem
            // 
            this.danhSáchPhòngToolStripMenuItem.Name = "danhSáchPhòngToolStripMenuItem";
            this.danhSáchPhòngToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.danhSáchPhòngToolStripMenuItem.Text = "Danh sách phòng";
            this.danhSáchPhòngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhòngToolStripMenuItem_Click);
            // 
            // thuTiềnToolStripMenuItem
            // 
            this.thuTiềnToolStripMenuItem.Name = "thuTiềnToolStripMenuItem";
            this.thuTiềnToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.thuTiềnToolStripMenuItem.Text = "Thu tiền";
            this.thuTiềnToolStripMenuItem.Click += new System.EventHandler(this.ThuTiềnToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.TrảPhòngToolStripMenuItem_Click);
            // 
            // tbtnthongke
            // 
            this.tbtnthongke.Image = ((System.Drawing.Image)(resources.GetObject("tbtnthongke.Image")));
            this.tbtnthongke.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnthongke.Name = "tbtnthongke";
            this.tbtnthongke.Size = new System.Drawing.Size(81, 24);
            this.tbtnthongke.Text = "Thống kê";
            this.tbtnthongke.Click += new System.EventHandler(this.Tbtnthongke_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 24);
            this.toolStripButton1.Text = "Qui Định";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Location = new System.Drawing.Point(142, 351);
            this.lbltaikhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(0, 13);
            this.lbltaikhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản người dùng: ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng trọ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtndangnhap;
        private System.Windows.Forms.ToolStripButton tbtnthuephong;
        private System.Windows.Forms.ToolStripButton tbtnthongke;
        private System.Windows.Forms.ToolStripSplitButton tbtnphongtro;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}