
namespace QLNS
{
    partial class frmChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtPCCV = new System.Windows.Forms.TextBox();
            this.lblTenCV = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.lblMaCV = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.dataChuyenMon = new System.Windows.Forms.DataGridView();
            this.MaCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChuyenMon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lblGhiChu);
            this.panel1.Controls.Add(this.txtPCCV);
            this.panel1.Controls.Add(this.lblTenCV);
            this.panel1.Controls.Add(this.txtTenCV);
            this.panel1.Controls.Add(this.lblMaCV);
            this.panel1.Controls.Add(this.txtMaCV);
            this.panel1.Location = new System.Drawing.Point(25, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 58);
            this.panel1.TabIndex = 0;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(365, 24);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(48, 13);
            this.lblGhiChu.TabIndex = 5;
            this.lblGhiChu.Text = "Phụ Cấp";
            this.lblGhiChu.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPCCV
            // 
            this.txtPCCV.Location = new System.Drawing.Point(415, 22);
            this.txtPCCV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPCCV.Name = "txtPCCV";
            this.txtPCCV.Size = new System.Drawing.Size(93, 20);
            this.txtPCCV.TabIndex = 4;
            this.txtPCCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPCCV.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblTenCV
            // 
            this.lblTenCV.AutoSize = true;
            this.lblTenCV.Location = new System.Drawing.Point(153, 24);
            this.lblTenCV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenCV.Name = "lblTenCV";
            this.lblTenCV.Size = new System.Drawing.Size(68, 13);
            this.lblTenCV.TabIndex = 3;
            this.lblTenCV.Text = "Tên chức vụ";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(219, 22);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(143, 20);
            this.txtTenCV.TabIndex = 2;
            // 
            // lblMaCV
            // 
            this.lblMaCV.AutoSize = true;
            this.lblMaCV.Location = new System.Drawing.Point(9, 24);
            this.lblMaCV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaCV.Name = "lblMaCV";
            this.lblMaCV.Size = new System.Drawing.Size(64, 13);
            this.lblMaCV.TabIndex = 1;
            this.lblMaCV.Text = "Mã chức vụ";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(72, 22);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(68, 20);
            this.txtMaCV.TabIndex = 0;
            // 
            // dataChuyenMon
            // 
            this.dataChuyenMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChuyenMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCM,
            this.TenCM,
            this.GhiChu});
            this.dataChuyenMon.Location = new System.Drawing.Point(25, 182);
            this.dataChuyenMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataChuyenMon.Name = "dataChuyenMon";
            this.dataChuyenMon.RowHeadersWidth = 62;
            this.dataChuyenMon.RowTemplate.Height = 28;
            this.dataChuyenMon.Size = new System.Drawing.Size(517, 155);
            this.dataChuyenMon.TabIndex = 1;
            this.dataChuyenMon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataChuyenMon_CellContentClick);
            // 
            // MaCM
            // 
            this.MaCM.DataPropertyName = "MaCV";
            this.MaCM.HeaderText = "Mã Chức Vụ";
            this.MaCM.MinimumWidth = 8;
            this.MaCM.Name = "MaCM";
            this.MaCM.Width = 120;
            // 
            // TenCM
            // 
            this.TenCM.DataPropertyName = "TenCV";
            this.TenCM.HeaderText = "Tên Chức Vụ";
            this.TenCM.MinimumWidth = 8;
            this.TenCM.Name = "TenCM";
            this.TenCM.Width = 200;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "PhuCapCV";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.GhiChu.DefaultCellStyle = dataGridViewCellStyle1;
            this.GhiChu.HeaderText = "Phụ Cấp Chức Vụ";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(25, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 68);
            this.panel2.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.Location = new System.Drawing.Point(166, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.ImageIndex = 4;
            this.btnNew.Location = new System.Drawing.Point(11, 15);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(146, 40);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Tạo bản ghi mới";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 0;
            this.btnDelete.Location = new System.Drawing.Point(401, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.ImageIndex = 1;
            this.btnUpdate.Location = new System.Drawing.Point(275, 15);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "   Cập Nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(563, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataChuyenMon);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục chức vụ";
            this.Load += new System.EventHandler(this.frmChuyenMon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChuyenMon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataChuyenMon;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtPCCV;
        private System.Windows.Forms.Label lblTenCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Label lblMaCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}