namespace QLNS
{
    partial class frmTimKiem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radNgaySinh = new System.Windows.Forms.RadioButton();
            this.radMaNV = new System.Windows.Forms.RadioButton();
            this.radQuocTich = new System.Windows.Forms.RadioButton();
            this.radDiaChi = new System.Windows.Forms.RadioButton();
            this.radDonVi = new System.Windows.Forms.RadioButton();
            this.radTenNV = new System.Windows.Forms.RadioButton();
            this.radDanToc = new System.Windows.Forms.RadioButton();
            this.radNoiCapBHXH = new System.Windows.Forms.RadioButton();
            this.radTonGiao = new System.Windows.Forms.RadioButton();
            this.radNoiSinh = new System.Windows.Forms.RadioButton();
            this.radNoiDKKCB = new System.Windows.Forms.RadioButton();
            this.radSDT = new System.Windows.Forms.RadioButton();
            this.radEmail = new System.Windows.Forms.RadioButton();
            this.radGioiTinh = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataTimKiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKQTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 36);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(521, 42);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 368);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.radNgaySinh);
            this.panel1.Controls.Add(this.radMaNV);
            this.panel1.Controls.Add(this.radQuocTich);
            this.panel1.Controls.Add(this.radDiaChi);
            this.panel1.Controls.Add(this.radDonVi);
            this.panel1.Controls.Add(this.radTenNV);
            this.panel1.Controls.Add(this.radDanToc);
            this.panel1.Controls.Add(this.radNoiCapBHXH);
            this.panel1.Controls.Add(this.radTonGiao);
            this.panel1.Controls.Add(this.radNoiSinh);
            this.panel1.Controls.Add(this.radNoiDKKCB);
            this.panel1.Controls.Add(this.radSDT);
            this.panel1.Controls.Add(this.radEmail);
            this.panel1.Controls.Add(this.radGioiTinh);
            this.panel1.Location = new System.Drawing.Point(6, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 278);
            this.panel1.TabIndex = 3;
            // 
            // radNgaySinh
            // 
            this.radNgaySinh.AutoSize = true;
            this.radNgaySinh.Location = new System.Drawing.Point(224, 188);
            this.radNgaySinh.Name = "radNgaySinh";
            this.radNgaySinh.Size = new System.Drawing.Size(169, 21);
            this.radNgaySinh.TabIndex = 2;
            this.radNgaySinh.TabStop = true;
            this.radNgaySinh.Text = "Ngày Sinh(YY/MM/DD)";
            this.radNgaySinh.UseVisualStyleBackColor = true;
            // 
            // radMaNV
            // 
            this.radMaNV.AutoSize = true;
            this.radMaNV.Location = new System.Drawing.Point(33, 3);
            this.radMaNV.Name = "radMaNV";
            this.radMaNV.Size = new System.Drawing.Size(68, 21);
            this.radMaNV.TabIndex = 2;
            this.radMaNV.TabStop = true;
            this.radMaNV.Text = "Mã NV";
            this.radMaNV.UseVisualStyleBackColor = true;
            // 
            // radQuocTich
            // 
            this.radQuocTich.AutoSize = true;
            this.radQuocTich.Location = new System.Drawing.Point(33, 188);
            this.radQuocTich.Name = "radQuocTich";
            this.radQuocTich.Size = new System.Drawing.Size(91, 21);
            this.radQuocTich.TabIndex = 2;
            this.radQuocTich.TabStop = true;
            this.radQuocTich.Text = "Quốc Tịch";
            this.radQuocTich.UseVisualStyleBackColor = true;
            // 
            // radDiaChi
            // 
            this.radDiaChi.AutoSize = true;
            this.radDiaChi.Location = new System.Drawing.Point(33, 93);
            this.radDiaChi.Name = "radDiaChi";
            this.radDiaChi.Size = new System.Drawing.Size(71, 21);
            this.radDiaChi.TabIndex = 2;
            this.radDiaChi.TabStop = true;
            this.radDiaChi.Text = "Địa Chỉ";
            this.radDiaChi.UseVisualStyleBackColor = true;
            // 
            // radDonVi
            // 
            this.radDonVi.AutoSize = true;
            this.radDonVi.Location = new System.Drawing.Point(224, 3);
            this.radDonVi.Name = "radDonVi";
            this.radDonVi.Size = new System.Drawing.Size(96, 21);
            this.radDonVi.TabIndex = 2;
            this.radDonVi.TabStop = true;
            this.radDonVi.Text = "Phòng Ban";
            this.radDonVi.UseVisualStyleBackColor = true;
            // 
            // radTenNV
            // 
            this.radTenNV.AutoSize = true;
            this.radTenNV.Location = new System.Drawing.Point(33, 33);
            this.radTenNV.Name = "radTenNV";
            this.radTenNV.Size = new System.Drawing.Size(74, 21);
            this.radTenNV.TabIndex = 2;
            this.radTenNV.TabStop = true;
            this.radTenNV.Text = "Tên NV";
            this.radTenNV.UseVisualStyleBackColor = true;
            // 
            // radDanToc
            // 
            this.radDanToc.AutoSize = true;
            this.radDanToc.Location = new System.Drawing.Point(33, 128);
            this.radDanToc.Name = "radDanToc";
            this.radDanToc.Size = new System.Drawing.Size(80, 21);
            this.radDanToc.TabIndex = 2;
            this.radDanToc.TabStop = true;
            this.radDanToc.Text = "Dân Tộc";
            this.radDanToc.UseVisualStyleBackColor = true;
            // 
            // radNoiCapBHXH
            // 
            this.radNoiCapBHXH.AutoSize = true;
            this.radNoiCapBHXH.Location = new System.Drawing.Point(224, 33);
            this.radNoiCapBHXH.Name = "radNoiCapBHXH";
            this.radNoiCapBHXH.Size = new System.Drawing.Size(118, 21);
            this.radNoiCapBHXH.TabIndex = 2;
            this.radNoiCapBHXH.TabStop = true;
            this.radNoiCapBHXH.Text = "Nơi Cấp BHXH";
            this.radNoiCapBHXH.UseVisualStyleBackColor = true;
            // 
            // radTonGiao
            // 
            this.radTonGiao.AutoSize = true;
            this.radTonGiao.Location = new System.Drawing.Point(32, 158);
            this.radTonGiao.Name = "radTonGiao";
            this.radTonGiao.Size = new System.Drawing.Size(85, 21);
            this.radTonGiao.TabIndex = 2;
            this.radTonGiao.TabStop = true;
            this.radTonGiao.Text = "Tôn Giáo";
            this.radTonGiao.UseVisualStyleBackColor = true;
            // 
            // radNoiSinh
            // 
            this.radNoiSinh.AutoSize = true;
            this.radNoiSinh.Location = new System.Drawing.Point(33, 63);
            this.radNoiSinh.Name = "radNoiSinh";
            this.radNoiSinh.Size = new System.Drawing.Size(79, 21);
            this.radNoiSinh.TabIndex = 2;
            this.radNoiSinh.TabStop = true;
            this.radNoiSinh.Text = "Nơi Sinh";
            this.radNoiSinh.UseVisualStyleBackColor = true;
            // 
            // radNoiDKKCB
            // 
            this.radNoiDKKCB.AutoSize = true;
            this.radNoiDKKCB.Location = new System.Drawing.Point(224, 63);
            this.radNoiDKKCB.Name = "radNoiDKKCB";
            this.radNoiDKKCB.Size = new System.Drawing.Size(101, 21);
            this.radNoiDKKCB.TabIndex = 2;
            this.radNoiDKKCB.TabStop = true;
            this.radNoiDKKCB.Text = "Nơi ĐK KCB";
            this.radNoiDKKCB.UseVisualStyleBackColor = true;
            // 
            // radSDT
            // 
            this.radSDT.AutoSize = true;
            this.radSDT.Location = new System.Drawing.Point(224, 123);
            this.radSDT.Name = "radSDT";
            this.radSDT.Size = new System.Drawing.Size(66, 21);
            this.radSDT.TabIndex = 2;
            this.radSDT.TabStop = true;
            this.radSDT.Text = "Số ĐT";
            this.radSDT.UseVisualStyleBackColor = true;
            // 
            // radEmail
            // 
            this.radEmail.AutoSize = true;
            this.radEmail.Location = new System.Drawing.Point(224, 153);
            this.radEmail.Name = "radEmail";
            this.radEmail.Size = new System.Drawing.Size(60, 21);
            this.radEmail.TabIndex = 2;
            this.radEmail.TabStop = true;
            this.radEmail.Text = "Email";
            this.radEmail.UseVisualStyleBackColor = true;
            // 
            // radGioiTinh
            // 
            this.radGioiTinh.AutoSize = true;
            this.radGioiTinh.Location = new System.Drawing.Point(224, 93);
            this.radGioiTinh.Name = "radGioiTinh";
            this.radGioiTinh.Size = new System.Drawing.Size(83, 21);
            this.radGioiTinh.TabIndex = 2;
            this.radGioiTinh.TabStop = true;
            this.radGioiTinh.Text = "Giới Tính";
            this.radGioiTinh.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageIndex = 1;
            this.btnTimKiem.ImageList = this.imageList1;
            this.btnTimKiem.Location = new System.Drawing.Point(533, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 42);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "698627-icon-111-search-128.png");
            this.imageList1.Images.SetKeyName(1, "search_icon.png");
            // 
            // dataTimKiem
            // 
            this.dataTimKiem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimKiem.Location = new System.Drawing.Point(18, 417);
            this.dataTimKiem.Name = "dataTimKiem";
            this.dataTimKiem.ReadOnly = true;
            this.dataTimKiem.RowHeadersWidth = 62;
            this.dataTimKiem.RowTemplate.Height = 24;
            this.dataTimKiem.Size = new System.Drawing.Size(621, 267);
            this.dataTimKiem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số KQ tìm kiếm:";
            // 
            // txtKQTimKiem
            // 
            this.txtKQTimKiem.Enabled = false;
            this.txtKQTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQTimKiem.ForeColor = System.Drawing.Color.Red;
            this.txtKQTimKiem.Location = new System.Drawing.Point(136, 381);
            this.txtKQTimKiem.Name = "txtKQTimKiem";
            this.txtKQTimKiem.Size = new System.Drawing.Size(77, 26);
            this.txtKQTimKiem.TabIndex = 5;
            this.txtKQTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTimKiem
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 696);
            this.Controls.Add(this.txtKQTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDanToc;
        private System.Windows.Forms.RadioButton radDiaChi;
        private System.Windows.Forms.RadioButton radNoiSinh;
        private System.Windows.Forms.RadioButton radTenNV;
        private System.Windows.Forms.RadioButton radMaNV;
        private System.Windows.Forms.RadioButton radQuocTich;
        private System.Windows.Forms.RadioButton radTonGiao;
        private System.Windows.Forms.RadioButton radNgaySinh;
        private System.Windows.Forms.RadioButton radDonVi;
        private System.Windows.Forms.RadioButton radNoiCapBHXH;
        private System.Windows.Forms.RadioButton radNoiDKKCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataTimKiem;
        private System.Windows.Forms.RadioButton radGioiTinh;
        private System.Windows.Forms.RadioButton radEmail;
        private System.Windows.Forms.RadioButton radSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKQTimKiem;
    }
}