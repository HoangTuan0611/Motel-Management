namespace QLPT
{
    partial class Frmthutien
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
            this.btntinhtien = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgthongtinkhachthue = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtloaiphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbphong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtngaythu = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttienxe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoxe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttienmang = new System.Windows.Forms.TextBox();
            this.txttiennuoc = new System.Windows.Forms.TextBox();
            this.txttiendien = new System.Windows.Forms.TextBox();
            this.txttienphong = new System.Windows.Forms.TextBox();
            this.txtsokidien = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgthongtinkhachthue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntinhtien
            // 
            this.btntinhtien.Location = new System.Drawing.Point(201, 246);
            this.btntinhtien.Margin = new System.Windows.Forms.Padding(2);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(80, 32);
            this.btntinhtien.TabIndex = 15;
            this.btntinhtien.Text = "Tính tiền";
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.Btntinhtien_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgthongtinkhachthue);
            this.groupBox3.Location = new System.Drawing.Point(11, 284);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(811, 150);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách thuê";
            // 
            // dgthongtinkhachthue
            // 
            this.dgthongtinkhachthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgthongtinkhachthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgthongtinkhachthue.Location = new System.Drawing.Point(2, 15);
            this.dgthongtinkhachthue.Margin = new System.Windows.Forms.Padding(2);
            this.dgthongtinkhachthue.Name = "dgthongtinkhachthue";
            this.dgthongtinkhachthue.Size = new System.Drawing.Size(807, 133);
            this.dgthongtinkhachthue.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtloaiphong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.txtmaphong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(11, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(389, 126);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng thuê";
            // 
            // txtloaiphong
            // 
            this.txtloaiphong.Location = new System.Drawing.Point(301, 64);
            this.txtloaiphong.Name = "txtloaiphong";
            this.txtloaiphong.Size = new System.Drawing.Size(69, 20);
            this.txtloaiphong.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại phòng";
            // 
            // txtTang
            // 
            this.txtTang.Location = new System.Drawing.Point(301, 34);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(69, 20);
            this.txtTang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tầng";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(79, 64);
            this.txttenphong.Margin = new System.Windows.Forms.Padding(2);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(126, 20);
            this.txttenphong.TabIndex = 3;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(79, 31);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(2);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(76, 20);
            this.txtmaphong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phòng";
            // 
            // cbphong
            // 
            this.cbphong.FormattingEnabled = true;
            this.cbphong.Location = new System.Drawing.Point(107, 49);
            this.cbphong.Margin = new System.Windows.Forms.Padding(2);
            this.cbphong.Name = "cbphong";
            this.cbphong.Size = new System.Drawing.Size(116, 21);
            this.cbphong.TabIndex = 10;
            this.cbphong.TextChanged += new System.EventHandler(this.Cbphong_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày thu";
            // 
            // dtngaythu
            // 
            this.dtngaythu.CustomFormat = "dd/MM/yyyy";
            this.dtngaythu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaythu.Location = new System.Drawing.Point(506, 49);
            this.dtngaythu.Margin = new System.Windows.Forms.Padding(2);
            this.dtngaythu.Name = "dtngaythu";
            this.dtngaythu.Size = new System.Drawing.Size(188, 20);
            this.dtngaythu.TabIndex = 17;
            this.dtngaythu.ValueChanged += new System.EventHandler(this.Dtngaythu_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txttienxe);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtsoxe);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txttongtien);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txttienmang);
            this.groupBox4.Controls.Add(this.txttiennuoc);
            this.groupBox4.Controls.Add(this.txttiendien);
            this.groupBox4.Controls.Add(this.txttienphong);
            this.groupBox4.Controls.Add(this.txtsokidien);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(455, 106);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(367, 173);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dịch vụ sử dụng";
            // 
            // txttienxe
            // 
            this.txttienxe.Enabled = false;
            this.txttienxe.Location = new System.Drawing.Point(74, 77);
            this.txttienxe.Name = "txttienxe";
            this.txttienxe.Size = new System.Drawing.Size(56, 20);
            this.txttienxe.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tiền xe";
            // 
            // txtsoxe
            // 
            this.txtsoxe.Location = new System.Drawing.Point(74, 53);
            this.txtsoxe.Name = "txtsoxe";
            this.txtsoxe.Size = new System.Drawing.Size(33, 20);
            this.txtsoxe.TabIndex = 27;
            this.txtsoxe.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Số lượng xe";
            // 
            // txttongtien
            // 
            this.txttongtien.Enabled = false;
            this.txttongtien.Location = new System.Drawing.Point(197, 136);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(59, 20);
            this.txttongtien.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 136);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "VND";
            // 
            // txttienmang
            // 
            this.txttienmang.Enabled = false;
            this.txttienmang.Location = new System.Drawing.Point(197, 106);
            this.txttienmang.Margin = new System.Windows.Forms.Padding(2);
            this.txttienmang.Name = "txttienmang";
            this.txttienmang.Size = new System.Drawing.Size(70, 20);
            this.txttienmang.TabIndex = 23;
            // 
            // txttiennuoc
            // 
            this.txttiennuoc.Enabled = false;
            this.txttiennuoc.Location = new System.Drawing.Point(197, 79);
            this.txttiennuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txttiennuoc.Name = "txttiennuoc";
            this.txttiennuoc.Size = new System.Drawing.Size(70, 20);
            this.txttiennuoc.TabIndex = 22;
            // 
            // txttiendien
            // 
            this.txttiendien.Enabled = false;
            this.txttiendien.Location = new System.Drawing.Point(197, 56);
            this.txttiendien.Margin = new System.Windows.Forms.Padding(2);
            this.txttiendien.Name = "txttiendien";
            this.txttiendien.Size = new System.Drawing.Size(70, 20);
            this.txttiendien.TabIndex = 21;
            // 
            // txttienphong
            // 
            this.txttienphong.Enabled = false;
            this.txttienphong.Location = new System.Drawing.Point(197, 28);
            this.txttienphong.Margin = new System.Windows.Forms.Padding(2);
            this.txttienphong.Name = "txttienphong";
            this.txttienphong.Size = new System.Drawing.Size(70, 20);
            this.txttienphong.TabIndex = 20;
            // 
            // txtsokidien
            // 
            this.txtsokidien.Location = new System.Drawing.Point(74, 28);
            this.txtsokidien.Margin = new System.Windows.Forms.Padding(2);
            this.txtsokidien.Name = "txtsokidien";
            this.txtsokidien.Size = new System.Drawing.Size(33, 20);
            this.txtsokidien.TabIndex = 18;
            this.txtsokidien.TextChanged += new System.EventHandler(this.Txtsokidien_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(133, 109);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Internet";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(133, 84);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Tiền nước";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(133, 56);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Tiền điện";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(133, 31);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Tiền phòng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(93, 138);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Tổng tiền phải trả";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Số kí điện";
            // 
            // Frmthutien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 465);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dtngaythu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btntinhtien);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbphong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frmthutien";
            this.Text = "Thu tiền";
            this.Load += new System.EventHandler(this.Frmthutien_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgthongtinkhachthue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinhtien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgthongtinkhachthue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtngaythu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttienmang;
        private System.Windows.Forms.TextBox txttiennuoc;
        private System.Windows.Forms.TextBox txttiendien;
        private System.Windows.Forms.TextBox txttienphong;
        private System.Windows.Forms.TextBox txtsokidien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoxe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloaiphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttienxe;
        private System.Windows.Forms.Label label7;
    }
}