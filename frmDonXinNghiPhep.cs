using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNS
{
    public partial class frmDonXinNghiPhep : Form
    {
        string username; string phanquyen; string MaNV;
        SqlConnection cnn;
        SqlCommand cmd;
        string source;

        public frmDonXinNghiPhep(string user, string pq, string nv)
        {
            InitializeComponent();
            username = user;
            phanquyen = pq;
            MaNV = nv;
            txtMaNV.Text = nv;
 
        }

        public void Load_data()
        {
            string str = "SELECT Id, np.MaNV,HoTen, Ngay, SoNgayNghi, CASE WHEN TrangThai = 0" +
                " then N'Chờ duyệt' WHEN TrangThai = 1 THEN N'Đã duyệt' ELSE N'Không được phê duyệt'" +
                " END AS TrangThai, IIF(LoaiNghi = 'X', N'Nghỉ không lương', N'Nghỉ phép') AS LoaiNghi" +
                " FROM tblNV_NghiPhep np LEFT JOIN tblTTNhanVien nv ON np.MaNV = nv.MaNV where" +
                " np.MaNV = '" + MaNV + "' ORDER BY Ngay DESC";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataNgghiPhep.DataSource = dt;
        }
        private void frmDonXinNghiPhep_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btnAdd.Enabled = false;
            Load_data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Loai;
            if (comboBox1.Text == "Nghỉ Phép")
            {  Loai = "P"; }
            else { Loai = "X"; }
            string SoNgay = txtSoNgay.Text.Replace(",", ".");
           
                
            string upNghiPhep = "UPDATE tblNV_NghiPhep SET Ngay=CONVERT(DATETIME,'" + dateNgay.Text + "',103),SoNgayNghi=" +SoNgay + ",LoaiNghi='" + Loai + "'WHERE Id='" + txtId.Text + "'";
            Conn.executeQuery(upNghiPhep);
            Load_data();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            btnNew.Enabled = false;
            Load_data();
            txtMaNV.Text = MaNV;

            source = @"Data Source=LAPTOP-T6FPOMP0\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            cnn = new SqlConnection(source);
            cnn.Open();
            cmd = new SqlCommand("SELECT HoTen FROM tblTTNhanVien where MaNV='" + MaNV + "'", cnn);
            string kq = cmd.ExecuteScalar().ToString();
            txtHoTen.Text = kq;
            


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            source = @"Data Source=LAPTOP-T6FPOMP0\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            cnn = new SqlConnection(source);
            cnn.Open();
            cmd = new SqlCommand("SELECT SoNgayConLai FROM tblQuanLyPhep where MaNV='" + MaNV + "'", cnn);
            string kq = cmd.ExecuteScalar().ToString();
            Decimal SoNgayConLai = Convert.ToDecimal(kq);

            if(comboBox1.Text == "Nghỉ Phép" && Convert.ToDecimal(txtSoNgay.Text) > SoNgayConLai)
            {
                MessageBox.Show("Lỗi", "Số ngày phép còn lại không đủ");
            }   
            
            else
            {
                string Loai;
                if (comboBox1.Text == "Nghỉ Phép")
                { Loai = "P"; }
                else { Loai = "X"; }
                string SoNgay = txtSoNgay.Text.Replace(",", ".");
                string addPhep = "INSERT INTO tblNV_NghiPhep (MaNV,Ngay,SoNgayNghi,TrangThai, LoaiNghi) VALUES" +
                    " ('" + txtMaNV.Text + "', CONVERT(DATETIME,'" + dateNgay.Text + "',103),'" + SoNgay + "',0,'" + Loai + "')";

                Conn.executeQuery(addPhep);

                Load_data();
                txtMaNV.Enabled = false;
                txtHoTen.Enabled = false;
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;

                btnNew.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            source = @"Data Source=LAPTOP-T6FPOMP0\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            cnn = new SqlConnection(source);
            cnn.Open();
            btnDelete.Enabled = true;
            string delPhep = "DELETE FROM tblNV_NghiPhep WHERE TrangThai = 0 AND Id='" + txtId.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa đơn xin nghỉ phép này ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                cmd = new SqlCommand("SELECT TrangThai FROM tblNV_NghiPhep where Id='" + txtId.Text + "'", cnn);
                string kq = cmd.ExecuteScalar().ToString();
                Decimal TrangThai = Int32.Parse(kq);
                if (TrangThai == 0)
                {
                    Conn.executeQuery(delPhep);
                    Load_data();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Đơn xin nghỉ phép đã duyệt");
                }

                
            }
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void dataNgghiPhep_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataNgghiPhep.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[1].Value.ToString();
            txtHoTen.Text = row.Cells[2].Value.ToString();
            txtId.Text = row.Cells[0].Value.ToString();
            dateNgay.Text = row.Cells[3].Value.ToString();
            txtSoNgay.Text =  row.Cells[4].Value.ToString();
            comboBox1.Text  = row.Cells[6].Value.ToString();
        }
    }
}
