namespace KyTucXa.GUI
{
    partial class Form_ThongBao
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
            this.dgTB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayTB = new System.Windows.Forms.DateTimePicker();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btghi = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.cbLoaiTB = new System.Windows.Forms.ComboBox();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "THONG BAO";
            // 
            // dgTB
            // 
            this.dgTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTB.Location = new System.Drawing.Point(14, 14);
            this.dgTB.Name = "dgTB";
            this.dgTB.Size = new System.Drawing.Size(790, 229);
            this.dgTB.TabIndex = 1;
            this.dgTB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTB_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgTB);
            this.groupBox1.Location = new System.Drawing.Point(38, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnoidung);
            this.groupBox2.Controls.Add(this.cbLoaiTB);
            this.groupBox2.Controls.Add(this.dtNgayTB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(38, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 225);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma TB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Noi Dung";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(67, 42);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(141, 20);
            this.txtMaTB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loai TB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngay TB";
            // 
            // dtNgayTB
            // 
            this.dtNgayTB.Location = new System.Drawing.Point(348, 38);
            this.dtNgayTB.Name = "dtNgayTB";
            this.dtNgayTB.Size = new System.Drawing.Size(200, 20);
            this.dtNgayTB.TabIndex = 5;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(735, 243);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(107, 44);
            this.btthoat.TabIndex = 4;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(735, 188);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(107, 43);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "xoa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Location = new System.Drawing.Point(735, 139);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(107, 43);
            this.btcapnhat.TabIndex = 6;
            this.btcapnhat.Text = "cap nhat";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btghi
            // 
            this.btghi.Location = new System.Drawing.Point(735, 97);
            this.btghi.Name = "btghi";
            this.btghi.Size = new System.Drawing.Size(107, 36);
            this.btghi.TabIndex = 7;
            this.btghi.Text = "ghi";
            this.btghi.UseVisualStyleBackColor = true;
            this.btghi.Click += new System.EventHandler(this.btghi_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(731, 52);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(111, 39);
            this.btthem.TabIndex = 8;
            this.btthem.Text = "them";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // cbLoaiTB
            // 
            this.cbLoaiTB.FormattingEnabled = true;
            this.cbLoaiTB.Location = new System.Drawing.Point(75, 154);
            this.cbLoaiTB.Name = "cbLoaiTB";
            this.cbLoaiTB.Size = new System.Drawing.Size(134, 21);
            this.cbLoaiTB.TabIndex = 7;
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(84, 96);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(414, 20);
            this.txtnoidung.TabIndex = 8;
            // 
            // Form_ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 562);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btghi);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_ThongBao";
            this.Text = "Form_ThongBao";
            this.Load += new System.EventHandler(this.Form_ThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btghi;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.ComboBox cbLoaiTB;
        private System.Windows.Forms.TextBox txtnoidung;
    }
}