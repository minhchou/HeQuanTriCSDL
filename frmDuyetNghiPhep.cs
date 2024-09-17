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
    public partial class frmDuyetNghiPhep : Form
    {
        string username; string phanquyen;
        SqlConnection cnn;
        SqlCommand cmd;
        string source;
        public frmDuyetNghiPhep()
        {
            InitializeComponent();
        }

        public void Load_data()
        {
            string str = "SELECT Id, np.MaNV,HoTen, Ngay, SoNgayNghi,"+
                "  N'Chờ duyệt' AS" +
                "  TrangThai, IIF(LoaiNghi = 'X', N'Nghỉ không lương', N'Nghỉ phép') AS LoaiNghi" +
                " FROM tblNV_NghiPhep np LEFT JOIN tblTTNhanVien nv ON np.MaNV = nv.MaNV where" +
                " TrangThai = 0 ORDER BY Ngay DESC";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataNgghiPhep.DataSource = dt;
        }
        private void frmDuyetNghiPhep_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Load_data();
        }

        private void dataNgghiPhep_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataNgghiPhep.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[1].Value.ToString();
            txtHoTen.Text = row.Cells[2].Value.ToString();
            txtId.Text = row.Cells[0].Value.ToString();
            dateNgay.Text = row.Cells[3].Value.ToString();
            txtSoNgay.Text = row.Cells[4].Value.ToString();
            comboBox1.Text = row.Cells[6].Value.ToString();
        }

        private void btnKoDuyet_Click(object sender, EventArgs e)
        {
            string upKduyet = "UPDATE tblNV_NghiPhep SET TrangThai = 2 where ID ='" + txtId.Text +"'";
            Conn.executeQuery(upKduyet);
            Load_data();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string SoNgay = txtSoNgay.Text.Replace(",", ".");
            string upKduyet = "UPDATE tblNV_NghiPhep SET TrangThai = 1 where ID ='" + txtId.Text + "'";
            Conn.executeQuery(upKduyet);
            string UpdatePhep = "UPDATE tblQuanLyPhep SET SoNgayConLai = SoNgayConLai -" + SoNgay + "WHERE MaNV = '" + txtMaNV.Text + "'";
            Conn.executeQuery(UpdatePhep);

            // if (comboBox1.Text == "Nghỉ Phép")
            //  { string upCC = "INSERT INTO tblBangCong (MaNV,Nam,Thang,Ngay,GioVao,PhutVao,KetQua) VALUES ('" + txtMaNV.Text +"','" + dateNgay.Value.Year + "','" + dateNgay.Value.Month +


            //  }       
            Load_data();
        }
    }
}
