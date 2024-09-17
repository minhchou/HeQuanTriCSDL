
namespace QLNS
{
    partial class frmDmLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmLuong));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataDmLuong = new System.Windows.Forms.DataGridView();
            this.MaCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaDV = new System.Windows.Forms.ComboBox();
            this.tblDonViBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiNhanSuDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiNhanSuDataSet4 = new QLNS.QuanLiNhanSuDataSet4();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.lblTenCV = new System.Windows.Forms.Label();
            this.txtBacLuong = new System.Windows.Forms.TextBox();
            this.lblMaCV = new System.Windows.Forms.Label();
            this.tblDonViTableAdapter = new QLNS.QuanLiNhanSuDataSet4TableAdapters.tblDonViTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDmLuong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDonViBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSuDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSuDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(48, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 84);
            this.panel2.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.Location = new System.Drawing.Point(221, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 50);
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
            this.btnNew.Location = new System.Drawing.Point(15, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(195, 50);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Tạo bản ghi mới";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 0;
            this.btnDelete.Location = new System.Drawing.Point(535, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 50);
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
            this.btnUpdate.Location = new System.Drawing.Point(367, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 50);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "   Cập Nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataDmLuong
            // 
            this.dataDmLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDmLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCM,
            this.TenCM,
            this.GhiChu});
            this.dataDmLuong.Location = new System.Drawing.Point(48, 216);
            this.dataDmLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDmLuong.Name = "dataDmLuong";
            this.dataDmLuong.RowHeadersWidth = 62;
            this.dataDmLuong.RowTemplate.Height = 28;
            this.dataDmLuong.Size = new System.Drawing.Size(689, 191);
            this.dataDmLuong.TabIndex = 13;
            this.dataDmLuong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataDmLuong_CellMouseClick);
            // 
            // MaCM
            // 
            this.MaCM.DataPropertyName = "TenDV";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaCM.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaCM.HeaderText = "Phòng Ban";
            this.MaCM.MinimumWidth = 8;
            this.MaCM.Name = "MaCM";
            this.MaCM.Width = 170;
            // 
            // TenCM
            // 
            this.TenCM.DataPropertyName = "BacLuong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.TenCM.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenCM.HeaderText = "Bậc Lương";
            this.TenCM.MinimumWidth = 8;
            this.TenCM.Name = "TenCM";
            this.TenCM.Width = 80;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "LuongCB";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.GhiChu.DefaultCellStyle = dataGridViewCellStyle3;
            this.GhiChu.HeaderText = "Lương Cơ Bản";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.txtMaDV);
            this.panel1.Controls.Add(this.lblGhiChu);
            this.panel1.Controls.Add(this.txtLuongCB);
            this.panel1.Controls.Add(this.lblTenCV);
            this.panel1.Controls.Add(this.txtBacLuong);
            this.panel1.Controls.Add(this.lblMaCV);
            this.panel1.Location = new System.Drawing.Point(48, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 71);
            this.panel1.TabIndex = 12;
            // 
            // txtMaDV
            // 
            this.txtMaDV.DataSource = this.tblDonViBindingSource;
            this.txtMaDV.DisplayMember = "TenDV";
            this.txtMaDV.FormattingEnabled = true;
            this.txtMaDV.Location = new System.Drawing.Point(84, 26);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(201, 24);
            this.txtMaDV.TabIndex = 6;
            this.txtMaDV.ValueMember = "MaDV";
            // 
            // tblDonViBindingSource
            // 
            this.tblDonViBindingSource.DataMember = "tblDonVi";
            this.tblDonViBindingSource.DataSource = this.quanLiNhanSuDataSet4BindingSource;
            // 
            // quanLiNhanSuDataSet4BindingSource
            // 
            this.quanLiNhanSuDataSet4BindingSource.DataSource = this.quanLiNhanSuDataSet4;
            this.quanLiNhanSuDataSet4BindingSource.Position = 0;
            // 
            // quanLiNhanSuDataSet4
            // 
            this.quanLiNhanSuDataSet4.DataSetName = "QuanLiNhanSuDataSet4";
            this.quanLiNhanSuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(457, 30);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(95, 17);
            this.lblGhiChu.TabIndex = 5;
            this.lblGhiChu.Text = "Lương cơ bản";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(556, 27);
            this.txtLuongCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(120, 22);
            this.txtLuongCB.TabIndex = 4;
            this.txtLuongCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTenCV
            // 
            this.lblTenCV.AutoSize = true;
            this.lblTenCV.Location = new System.Drawing.Point(291, 30);
            this.lblTenCV.Name = "lblTenCV";
            this.lblTenCV.Size = new System.Drawing.Size(71, 17);
            this.lblTenCV.TabIndex = 3;
            this.lblTenCV.Text = "Bậc lương";
            // 
            // txtBacLuong
            // 
            this.txtBacLuong.Location = new System.Drawing.Point(367, 27);
            this.txtBacLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBacLuong.Name = "txtBacLuong";
            this.txtBacLuong.Size = new System.Drawing.Size(85, 22);
            this.txtBacLuong.TabIndex = 2;
            // 
            // lblMaCV
            // 
            this.lblMaCV.AutoSize = true;
            this.lblMaCV.Location = new System.Drawing.Point(3, 30);
            this.lblMaCV.Name = "lblMaCV";
            this.lblMaCV.Size = new System.Drawing.Size(77, 17);
            this.lblMaCV.TabIndex = 1;
            this.lblMaCV.Text = "Phòng ban";
            // 
            // tblDonViTableAdapter
            // 
            this.tblDonViTableAdapter.ClearBeforeFill = true;
            // 
            // frmDmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(792, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataDmLuong);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDmLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục bậc lương";
            this.Load += new System.EventHandler(this.frmDmLuong_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDmLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDonViBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSuDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSuDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataDmLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label lblTenCV;
        private System.Windows.Forms.TextBox txtBacLuong;
        private System.Windows.Forms.Label lblMaCV;
        private System.Windows.Forms.ComboBox txtMaDV;
        private System.Windows.Forms.BindingSource quanLiNhanSuDataSet4BindingSource;
        private QuanLiNhanSuDataSet4 quanLiNhanSuDataSet4;
        private System.Windows.Forms.BindingSource tblDonViBindingSource;
        private QuanLiNhanSuDataSet4TableAdapters.tblDonViTableAdapter tblDonViTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}