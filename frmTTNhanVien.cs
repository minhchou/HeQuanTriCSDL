using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace QLNS
{
    public partial class frmTTNhanVien : Form
    {
        string username; string phanquyen;
        

        public frmTTNhanVien(string user, string pq)
        {
            InitializeComponent();
            username = user;
            phanquyen = pq;
            if (Int32.Parse(phanquyen) == 2)
            {
                btnDelete.Enabled = btnAdd.Enabled = btnUpdate.Enabled = button1.Enabled = btnReset.Enabled= false;
                
            }
            else
            { }
        }
        public void Load_data()
        {
            string str = "SELECT nv.MaNV,HoTen,NgaySinh,GioiTinh,CMND,NoiSinh,DiaChi,SDT,case when TDHV = 1" +
                " then N'Đại Học' when tdhv = 2 then N'Cao Đẳng' else N'Khác' end as TDHV, TenDV, Email, nv.GhiChu," +
                " DanToc,TonGiao,NgayVaoLam, p.SoNgayConLai, cv.TenCV FROM tblTTNhanVien nv LEFT JOIN tblDonVi" +
                " dv ON nv.MaDonVi = dv.MaDV LEFT JOIN tblChucVu cv ON nv.MaCV = cv.MaCV LEFT JOIN tblQuanLyPhep p ON nv.MaNV = p.MaNV";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataNhanVien.DataSource = dt;
        }
        private void frmTTNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSuDataSet3.tblChucVu' table. You can move, or remove it, as needed.
            this.tblChucVuTableAdapter.Fill(this.quanLiNhanSuDataSet3.tblChucVu);
            // TODO: This line of code loads data into the 'quanLiNhanSuDataSet.tblChuyenMon' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLiNhanSuDataSet.tblDonVi' table. You can move, or remove it, as needed.
            this.tblDonViTableAdapter.Fill(this.quanLiNhanSuDataSet.tblDonVi);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Load_data();
            btnAdd.Enabled = false;
            
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            string GioiTinh; int TDHV;
            if (radNam.Checked == true)
                GioiTinh = "Nam";
            else
                GioiTinh = "Nữ";
            if (cbbTrinhDo.Text == "Đại Học")
                TDHV = 1;
            else
            {
                if (cbbTrinhDo.Text == "Cao Đẳng")
                    TDHV = 2;
                else
                    TDHV = 3;
            }

            string upTTNV = "UPDATE tblTTNhanVien SET HoTen=N'" + txtHoTen.Text 
                            +"',NgaySinh=CONVERT(DATETIME,'" + dateNgaySinh.Text + "',103),GioiTinh=N'" + GioiTinh 
                            + "',CMND='" + txtCMND.Text + "',NoiSinh=N'" + txtNoiSinh.Text 
                            + "',DiaChi=N'" + txtDiaChi.Text + "',SDT='" + txtSDT.Text 
                            + "',TDHV='" + TDHV 
                            +   "',MaDonVi='" + cboxMaDV.SelectedValue.ToString()
                            + "',MaCV='" + cboxChuyenMon.SelectedValue.ToString()
                            + "',Email='" + txtEmail.Text + "',GhiChu=N'" + txtGhiChu.Text + "',DanToc=N'" 
                            + cboxDanToc.Text + "',TonGiao=N'" + cboxTonGiao.Text
                             + "',NgayVaoLam=CONVERT(DATETIME,'" + dateNgayVaoLam.Text
                            + "',103) WHERE(MaNV='" + txtMaNV.Text + "')";

            Conn.executeQuery(upTTNV);
            Load_data();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnNew_Click(object sender, EventArgs e)
        {

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            button1.Enabled = false;
            txtSoNgayPhep.Enabled = false;
            txtSoNgayPhep.Text = "";
            Load_data();
            SqlConnection cnn;
            SqlCommand cmd;
            string source;

            source = @"Data Source=LAPTOP-T6FPOMP0\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            cnn = new SqlConnection(source);
            cnn.Open();

            cmd = new SqlCommand("SELECT TOP 1 '00' + CAST(CAST(MaNV AS INT) + 1 AS VARCHAR(3)) FROM tblTTNhanVien ORDER BY MaNV DESC", cnn);
            string ketqua1 = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("SELECT GETDATE()", cnn);
            string kq1 = cmd.ExecuteScalar().ToString();
            dateNgayVaoLam.Text = kq1;

            txtMaNV.Text = ketqua1;

            txtHoTen.Text = "";
            dateNgaySinh.Text = "1/1/1990";
            radNam.Checked = true;
            txtCMND.Text = "";
            cbbTrinhDo.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtNoiSinh.Text = "";
            txtDiaChi.Text = "";
            cboxMaDV.Text = "";
            cboxChuyenMon.Text = "";
            cboxDanToc.Text = "";
            cboxTonGiao.Text = "";
            txtSDT.Text = "";
            txtGhiChu.Text = "";
            cmd = new SqlCommand("SELECT year(GETDATE())", cnn);
            string Kq = cmd.ExecuteScalar().ToString();
            int NamVaoLamnv;
            int NamNay;
            int ThangVaoLam, SoNgay;
            NamNay = Int32.Parse(Kq);
            NamVaoLamnv = dateNgayVaoLam.Value.Year;
            if (NamNay == NamVaoLamnv)
            {
                ThangVaoLam = dateNgayVaoLam.Value.Month;
                SoNgay = 12 - ThangVaoLam + 1;
            }
            else { SoNgay = 12; };
            txtSoNgayPhep.Text = SoNgay.ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Lỗi", "Không thể thêm nhân viên.");
            }
            else
            {
                SqlConnection cnn;
                SqlCommand cmd;
                string source;

                source = @"Data Source=LAPTOP-T6FPOMP0\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
                cnn = new SqlConnection(source);
                cnn.Open();
                cmd = new SqlCommand("SELECT year(GETDATE())", cnn);
                string Kq = cmd.ExecuteScalar().ToString();
                int NamVaoLamnv;
                int NamNay;
                int ThangVaoLam, SoNgay;
                NamNay = Int32.Parse(Kq);
                NamVaoLamnv = dateNgayVaoLam.Value.Year;
                if (NamNay == NamVaoLamnv)
                {
                    ThangVaoLam = dateNgayVaoLam.Value.Month;
                    SoNgay = 12 - ThangVaoLam + 1;
                }
                else { SoNgay = 12; };
                //

                string GioiTinh; int TDHV2;
                    if (radNam.Checked == true)
                        GioiTinh = "Nam";
                    else
                        GioiTinh = "Nữ";
                    if (cbbTrinhDo.Text == "Đại Học")
                        TDHV2= 1;
                    else
                    {
                        if (cbbTrinhDo.Text == "Cao Đẳng")
                            TDHV2 = 2;
                        else
                            TDHV2 = 3;
                    }
                    

                    string addTTNV = "INSERT INTO [dbo].[tblTTNhanVien] ([MaNV],[HoTen],[NgaySinh],[GioiTinh]," +
                                      "[CMND],[NoiSinh] ,[DiaChi],[SDT],[TDHV],[MaDonVi],[Email] ,[GhiChu],[DanToc]," +
                                      "[TonGiao],[NgayVaoLam],[MaCV]) VALUES('" +
                                      txtMaNV.Text + "',N'" + txtHoTen.Text + "',convert(datetime,'"
                                     + dateNgaySinh.Text + "',103),N'" + GioiTinh + "','" + txtCMND.Text +
                                     "',N'" + txtNoiSinh.Text + "',N'" + txtDiaChi.Text + "','"  +
                                     txtSDT.Text + "','" + TDHV2 +
                                     "','"  + cboxMaDV.SelectedValue.ToString() + 
                                     "','" + txtEmail.Text + "',N'" + txtGhiChu.Text + "',N'" + cboxDanToc.Text +
                                     "',N'" + cboxTonGiao.Text + "',convert(datetime,'" + dateNgayVaoLam.Text 
                                      + "',103),'" + cboxChuyenMon.SelectedValue.ToString() + "')";                    
                    txtMaNV.Enabled = false;
                    // --- Thêm nhân viên vào bảng lương
                    string manv = txtMaNV.Text;
                    string maluong = "L" + manv;
                    string mabh = "BH" + manv;
                 

                    string AddLuong = "INSERT INTO tblLuong(MaNV,ID) VALUES('" +txtMaNV.Text +  "','" + maluong + "')";
                  //  --- Thêm nhân viên vào bảng BHXH
                 string AddBH = "INSERT INTO tblBaoHiemXH(MaNV,MaSoBH) VALUES('" + txtMaNV.Text + "','" + mabh + "')";
               
                string addUser = "INSERT INTO tblUser(Id,Password,PhanQuyen,MaNV) VALUES ('NV" + txtMaNV.Text + "','12345',2, '" + txtMaNV.Text + "')";
                 string addNghiPhep = "INSERT INTO tblQuanLyPhep (MaPhep,MaNV,SoNgayConLai) VALUES ('2022','" + txtMaNV.Text + "','" +SoNgay + "')";
                   Conn.executeQuery(addTTNV);
                    Load_data();
                    Conn.executeQuery(AddLuong);
                  Conn.executeQuery(AddBH);
                   
                   Conn.executeQuery(addUser);
                    Conn.executeQuery(addNghiPhep);
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    button1.Enabled = true;


                   
                
                
            }

            btnAdd.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string delTTNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + txtMaNV.Text+"'";
            // --- Xóa nhân viên ở bảng BHXH
            string delBH = "DELETE FROM tblBaoHiemXH WHERE MaNV='" + txtMaNV.Text + "'";
            // --- Xóa nhân viên ở bảng Lương
            string delLuong = "DELETE FROM tblLuong WHERE MaNV='" + txtMaNV.Text + "'";
           
            string delUser = "DELETE FROM tblUser WHERE MaNV='" + txtMaNV.Text + "'";
            string delPhep = "DELETE FROM tblQuanLyPhep WHERE MaNV='" + txtMaNV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhân viên:"+txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(delTTNV);
                    Conn.executeQuery(delBH);
                    Conn.executeQuery(delLuong);
                    Conn.executeQuery(delUser);
                    Conn.executeQuery(delPhep);
                    Load_data();
                }
                catch (Exception)
                {
                }
            }
            else if (dialog == DialogResult.No)
            {
                //
            }



        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dataNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dateNgaySinh.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                txtCMND.Text = row.Cells[4].Value.ToString();
                txtNoiSinh.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();
                cbbTrinhDo.Text = row.Cells[8].Value.ToString();
                cboxMaDV.Text = row.Cells[9].Value.ToString();
       
               
                txtEmail.Text = row.Cells[10].Value.ToString();
                txtGhiChu.Text = row.Cells[11].Value.ToString();
                cboxDanToc.Text = row.Cells[12].Value.ToString();
                cboxTonGiao.Text = row.Cells[13].Value.ToString();
                dateNgayVaoLam.Text = row.Cells[14].Value.ToString();
                txtSoNgayPhep.Text = row.Cells[15].Value.ToString();
                cboxChuyenMon.Text = row.Cells[16].Value.ToString();


                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                
                button1.Enabled = true;
            }
            catch (Exception) { }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {

        }


       

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboxChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateNgayVaoLam_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand cmd;
            string source;

            source = @"Data Source=LAPTOP-T6FPOMP0\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            cnn = new SqlConnection(source);
            cnn.Open();
            int NamVaoLamnv;
            int NamNay;
            int ThangVaoLam, SoNgay;

            cmd = new SqlCommand("SELECT year(GETDATE())", cnn);
            string Kq = cmd.ExecuteScalar().ToString();
            NamNay = Int32.Parse(Kq);
            NamVaoLamnv = dateNgayVaoLam.Value.Year;
            if (NamNay == NamVaoLamnv)
            {
                ThangVaoLam = dateNgayVaoLam.Value.Month;
                SoNgay = 12 - ThangVaoLam + 1;
            }
            else { SoNgay = 12; };
            txtSoNgayPhep.Text = SoNgay.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ResetPhep = "update tblQuanLyPhep set SoNgayConLai = 12, MaPhep = YEAR(GETDATE())" +
                " WHERE Id NOT IN (SELECT Id FROM tblQuanLyPhep QL1 left join tblTTNhanVien nv" +
                " ON ql1.MaNV = nv.MaNV WHERE Ql1.MaPhep = YEAR(GETDATE()))";
            Conn.executeQuery(ResetPhep);
            Load_data();
        }
    }
}
