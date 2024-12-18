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
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.cbLoaiTB = new System.Windows.Forms.ComboBox();
            this.dtNgayTB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btghi = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG BÁO";
            // 
            // dgTB
            // 
            this.dgTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTB.Location = new System.Drawing.Point(2, 34);
            this.dgTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgTB.Name = "dgTB";
            this.dgTB.RowHeadersWidth = 51;
            this.dgTB.Size = new System.Drawing.Size(969, 216);
            this.dgTB.TabIndex = 1;
            this.dgTB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTB_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgTB);
            this.groupBox1.Location = new System.Drawing.Point(22, 349);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(971, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÔNG BÁO:";
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
            this.groupBox2.Location = new System.Drawing.Point(24, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(777, 265);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NỘI DUNG THÔNG BÁO:";
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(197, 90);
            this.txtnoidung.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(375, 31);
            this.txtnoidung.TabIndex = 8;
            // 
            // cbLoaiTB
            // 
            this.cbLoaiTB.FormattingEnabled = true;
            this.cbLoaiTB.Location = new System.Drawing.Point(197, 148);
            this.cbLoaiTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbLoaiTB.Name = "cbLoaiTB";
            this.cbLoaiTB.Size = new System.Drawing.Size(375, 31);
            this.cbLoaiTB.TabIndex = 7;
            // 
            // dtNgayTB
            // 
            this.dtNgayTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTB.Location = new System.Drawing.Point(197, 201);
            this.dtNgayTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtNgayTB.Name = "dtNgayTB";
            this.dtNgayTB.Size = new System.Drawing.Size(375, 31);
            this.dtNgayTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Thông báo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Thông báo:";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(197, 36);
            this.txtMaTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(375, 31);
            this.txtMaTB.TabIndex = 2;
            this.txtMaTB.TextChanged += new System.EventHandler(this.txtMaTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nội dung:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Thông báo:";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(30, 219);
            this.btthoat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(127, 35);
            this.btthoat.TabIndex = 4;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(30, 174);
            this.btxoa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(127, 35);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Location = new System.Drawing.Point(30, 122);
            this.btcapnhat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(127, 35);
            this.btcapnhat.TabIndex = 6;
            this.btcapnhat.Text = "Cập nhật";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btghi
            // 
            this.btghi.Location = new System.Drawing.Point(30, 75);
            this.btghi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btghi.Name = "btghi";
            this.btghi.Size = new System.Drawing.Size(127, 35);
            this.btghi.TabIndex = 7;
            this.btghi.Text = "Ghi";
            this.btghi.UseVisualStyleBackColor = true;
            this.btghi.Click += new System.EventHandler(this.btghi_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(30, 28);
            this.btthem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(127, 35);
            this.btthem.TabIndex = 8;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btxoa);
            this.groupBox3.Controls.Add(this.btthem);
            this.groupBox3.Controls.Add(this.btthoat);
            this.groupBox3.Controls.Add(this.btghi);
            this.groupBox3.Controls.Add(this.btcapnhat);
            this.groupBox3.Location = new System.Drawing.Point(814, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 265);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHỨC NĂNG";
            // 
            // Form_ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 630);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ThongBao";
            this.Text = "Form_ThongBao";
            this.Load += new System.EventHandler(this.Form_ThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
    }
}