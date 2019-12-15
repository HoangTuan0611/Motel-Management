namespace QLPT
{
    partial class Frmtraphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtraphong));
            this.label1 = new System.Windows.Forms.Label();
            this.cbphong = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgthongtinkhachthue = new System.Windows.Forms.DataGridView();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgthongtinkhachthue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn phòng";
            // 
            // cbphong
            // 
            this.cbphong.DisplayMember = "mapt";
            this.cbphong.FormattingEnabled = true;
            this.cbphong.Location = new System.Drawing.Point(251, 76);
            this.cbphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbphong.Name = "cbphong";
            this.cbphong.Size = new System.Drawing.Size(153, 24);
            this.cbphong.TabIndex = 2;
            this.cbphong.TextChanged += new System.EventHandler(this.Cbphong_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.txtmaphong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(127, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(752, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng thuê";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(536, 62);
            this.txttenphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(100, 22);
            this.txttenphong.TabIndex = 3;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(233, 62);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(100, 22);
            this.txtmaphong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phòng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgthongtinkhachthue);
            this.groupBox3.Location = new System.Drawing.Point(12, 366);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1067, 185);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách thuê";
            // 
            // dgthongtinkhachthue
            // 
            this.dgthongtinkhachthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgthongtinkhachthue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makt,
            this.mapt,
            this.hoten,
            this.cmnd,
            this.gioitinh,
            this.nghenghiep,
            this.sdt});
            this.dgthongtinkhachthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgthongtinkhachthue.Location = new System.Drawing.Point(3, 17);
            this.dgthongtinkhachthue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgthongtinkhachthue.Name = "dgthongtinkhachthue";
            this.dgthongtinkhachthue.RowTemplate.Height = 24;
            this.dgthongtinkhachthue.Size = new System.Drawing.Size(1061, 166);
            this.dgthongtinkhachthue.TabIndex = 0;
            // 
            // makt
            // 
            this.makt.DataPropertyName = "makt";
            this.makt.HeaderText = "Mã khách trọ";
            this.makt.Name = "makt";
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Mã phòng trọ";
            this.mapt.Name = "mapt";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // nghenghiep
            // 
            this.nghenghiep.DataPropertyName = "nghenghiep";
            this.nghenghiep.HeaderText = "Nghề nghiệp";
            this.nghenghiep.Name = "nghenghiep";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Sdt";
            this.sdt.Name = "sdt";
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(449, 313);
            this.btnxacnhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(107, 39);
            this.btnxacnhan.TabIndex = 7;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.Btnxacnhan_Click);
            // 
            // Frmtraphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1007, 561);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbphong);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frmtraphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng";
            this.Load += new System.EventHandler(this.Frmtraphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgthongtinkhachthue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbphong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.DataGridView dgthongtinkhachthue;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}