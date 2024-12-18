namespace KyTucXa.GUI
{
    partial class Form_QLNhanVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btghi = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.dgTT = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ tên : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "CCCD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày sinh : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "SDT : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGT);
            this.groupBox1.Controls.Add(this.dtNS);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtcccd);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(33, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(759, 223);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // cbGT
            // 
            this.cbGT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Location = new System.Drawing.Point(179, 168);
            this.cbGT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(195, 31);
            this.cbGT.TabIndex = 23;
            // 
            // dtNS
            // 
            this.dtNS.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNS.Location = new System.Drawing.Point(536, 39);
            this.dtNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(195, 31);
            this.dtNS.TabIndex = 22;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(536, 120);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(195, 31);
            this.txtsdt.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(536, 81);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(195, 31);
            this.txtemail.TabIndex = 20;
            // 
            // txtcccd
            // 
            this.txtcccd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcccd.Location = new System.Drawing.Point(179, 122);
            this.txtcccd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(195, 31);
            this.txtcccd.TabIndex = 19;
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(179, 78);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(195, 31);
            this.txthoten.TabIndex = 18;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(179, 39);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(195, 31);
            this.txtmanv.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btthem);
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btghi);
            this.groupBox3.Controls.Add(this.btcapnhat);
            this.groupBox3.Controls.Add(this.btthoat);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(817, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(179, 244);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHỨC NĂNG";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(25, 30);
            this.btthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(129, 35);
            this.btthem.TabIndex = 18;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btXoa.Location = new System.Drawing.Point(25, 156);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(129, 34);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btghi
            // 
            this.btghi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btghi.Location = new System.Drawing.Point(25, 69);
            this.btghi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btghi.Name = "btghi";
            this.btghi.Size = new System.Drawing.Size(129, 35);
            this.btghi.TabIndex = 17;
            this.btghi.Text = "Ghi";
            this.btghi.UseVisualStyleBackColor = true;
            this.btghi.Click += new System.EventHandler(this.btghi_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btcapnhat.Location = new System.Drawing.Point(25, 114);
            this.btcapnhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(129, 34);
            this.btcapnhat.TabIndex = 11;
            this.btcapnhat.Text = "Cập nhật";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btthoat.Location = new System.Drawing.Point(25, 198);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(129, 34);
            this.btthoat.TabIndex = 14;
            this.btthoat.Text = "Thoát ";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // dgTT
            // 
            this.dgTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTT.Location = new System.Drawing.Point(33, 296);
            this.dgTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgTT.Name = "dgTT";
            this.dgTT.RowHeadersWidth = 51;
            this.dgTT.Size = new System.Drawing.Size(963, 179);
            this.dgTT.TabIndex = 15;
            this.dgTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTT_CellContentClick);
            // 
            // Form_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 493);
            this.Controls.Add(this.dgTT);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_QLNhanVien";
            this.Text = "Form_QLNhanVien";
            this.Load += new System.EventHandler(this.Form_QLNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btghi;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DataGridView dgTT;
        private System.Windows.Forms.Button btthem;
    }
}