namespace QLPT
{
    partial class Frmthongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmthongke));
            this.label1 = new System.Windows.Forms.Label();
            this.dvthutien = new System.Windows.Forms.DataGridView();
            this.mathu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiendien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiennuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienmang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtngaythu = new System.Windows.Forms.DateTimePicker();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvthutien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // dvthutien
            // 
            this.dvthutien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvthutien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathu,
            this.mapt,
            this.ngaythu,
            this.tiendien,
            this.tiennuoc,
            this.tienmang,
            this.tienxe,
            this.tienphong,
            this.tongtien});
            this.dvthutien.Location = new System.Drawing.Point(1, 86);
            this.dvthutien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvthutien.Name = "dvthutien";
            this.dvthutien.Size = new System.Drawing.Size(860, 350);
            this.dvthutien.TabIndex = 1;
            // 
            // mathu
            // 
            this.mathu.DataPropertyName = "mathu";
            this.mathu.HeaderText = "Mã Thu";
            this.mathu.Name = "mathu";
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Mã Phòng Trọ";
            this.mapt.Name = "mapt";
            // 
            // ngaythu
            // 
            this.ngaythu.DataPropertyName = "ngaythu";
            this.ngaythu.HeaderText = "Ngày Thu";
            this.ngaythu.Name = "ngaythu";
            // 
            // tiendien
            // 
            this.tiendien.DataPropertyName = "tiendien";
            this.tiendien.HeaderText = "Tiền Điện";
            this.tiendien.Name = "tiendien";
            // 
            // tiennuoc
            // 
            this.tiennuoc.DataPropertyName = "tiennuoc";
            this.tiennuoc.HeaderText = "Tiền Nước";
            this.tiennuoc.Name = "tiennuoc";
            // 
            // tienmang
            // 
            this.tienmang.DataPropertyName = "tienmang";
            this.tienmang.HeaderText = "Tiền Mạng";
            this.tienmang.Name = "tienmang";
            // 
            // tienxe
            // 
            this.tienxe.DataPropertyName = "tienxe";
            this.tienxe.HeaderText = "Tiền Xe";
            this.tienxe.Name = "tienxe";
            // 
            // tienphong
            // 
            this.tienphong.DataPropertyName = "tienphong";
            this.tienphong.HeaderText = "Tiền Phòng";
            this.tienphong.Name = "tienphong";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            // 
            // dtngaythu
            // 
            this.dtngaythu.CustomFormat = "MM/yyyy";
            this.dtngaythu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaythu.Location = new System.Drawing.Point(255, 22);
            this.dtngaythu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtngaythu.Name = "dtngaythu";
            this.dtngaythu.Size = new System.Drawing.Size(97, 22);
            this.dtngaythu.TabIndex = 2;
            this.dtngaythu.ValueChanged += new System.EventHandler(this.Dtngaythu_ValueChanged);
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(396, 21);
            this.btnxem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(100, 28);
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.Btnxem_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(537, 21);
            this.btnexcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(100, 28);
            this.btnexcel.TabIndex = 4;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.Btnexcel_Click);
            // 
            // Frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.dtngaythu);
            this.Controls.Add(this.dvthutien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frmthongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Frmthongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvthutien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvthutien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiendien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiennuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienmang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DateTimePicker dtngaythu;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btnexcel;
    }
}