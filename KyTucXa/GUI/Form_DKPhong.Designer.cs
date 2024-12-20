namespace KyTucXa.GUI
{
    partial class Form_DKPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtNBD = new System.Windows.Forms.DateTimePicker();
            this.dtNDK = new System.Windows.Forms.DateTimePicker();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtMaDK = new System.Windows.Forms.TextBox();
            this.dGDKPhong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGDKPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐĂNG KÝ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtNgayKT);
            this.groupBox1.Controls.Add(this.dtNBD);
            this.groupBox1.Controls.Add(this.dtNDK);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtMaDK);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(30, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 265);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ĐĂNG KÝ";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(133, 103);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(219, 31);
            this.txtMaSV.TabIndex = 13;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(541, 52);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(211, 31);
            this.txtMaPhong.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mã Phòng : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã SV : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày kết thúc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày bắt đầu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày đăng ký:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ tên SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã đăng ký:";
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.Location = new System.Drawing.Point(553, 208);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(208, 31);
            this.dtNgayKT.TabIndex = 3;
            // 
            // dtNBD
            // 
            this.dtNBD.Location = new System.Drawing.Point(553, 153);
            this.dtNBD.Name = "dtNBD";
            this.dtNBD.Size = new System.Drawing.Size(208, 31);
            this.dtNBD.TabIndex = 3;
            // 
            // dtNDK
            // 
            this.dtNDK.Location = new System.Drawing.Point(150, 208);
            this.dtNDK.Name = "dtNDK";
            this.dtNDK.Size = new System.Drawing.Size(208, 31);
            this.dtNDK.TabIndex = 3;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(541, 103);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(219, 31);
            this.txtTenPhong.TabIndex = 2;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(139, 153);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(219, 31);
            this.txthoten.TabIndex = 1;
            // 
            // txtMaDK
            // 
            this.txtMaDK.Location = new System.Drawing.Point(133, 52);
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(219, 31);
            this.txtMaDK.TabIndex = 0;
            // 
            // dGDKPhong
            // 
            this.dGDKPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGDKPhong.Location = new System.Drawing.Point(32, 363);
            this.dGDKPhong.Name = "dGDKPhong";
            this.dGDKPhong.RowHeadersWidth = 51;
            this.dGDKPhong.RowTemplate.Height = 24;
            this.dGDKPhong.Size = new System.Drawing.Size(959, 216);
            this.dGDKPhong.TabIndex = 5;
            this.dGDKPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGDKPhong_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btCapNhat);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btGhi);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(817, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 267);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHỨC NĂNG";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(21, 216);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(127, 36);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(20, 171);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(127, 36);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(21, 124);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(126, 36);
            this.btCapNhat.TabIndex = 5;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(21, 34);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(127, 35);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(21, 78);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(127, 36);
            this.btGhi.TabIndex = 3;
            this.btGhi.Text = "Ghi";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // Form_DKPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGDKPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_DKPhong";
            this.Text = "Form_DKPhong";
            this.Load += new System.EventHandler(this.Form_DKPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGDKPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.DateTimePicker dtNBD;
        private System.Windows.Forms.DateTimePicker dtNDK;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtMaDK;
        private System.Windows.Forms.DataGridView dGDKPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaPhong;
    }
}