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
    public partial class frmLuongNV : Form
    {
        public frmLuongNV()
        {
            InitializeComponent();
        }

       
        public void Load_data()
        {
            string str = "SELECT lg.MaNV, nv.HoTen, lg.BacLuong, lg.NgayNhap," +
                         " lg.LuongBHXH, lg.SoNguoiPhuThuoc FROM tblLuong lg LEFT JOIN tblTTNhanVien nv ON lg.MaNV = nv.MaNV";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataLuong.DataSource = dt;
        }

        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Load_data();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataLuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataLuong.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtMaLuong.Text = row.Cells[2].Value.ToString();    
                txtLuongBH.Text = row.Cells[4].Value.ToString();
               
                dateNgayNhap.Text = row.Cells[3].Value.ToString();
  
                txtSoNguoiPT.Text = row.Cells[5].Value.ToString();
                btnCapNhat.Enabled = true;              
               
            }
            catch (Exception)
            { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string upLuonng = "UPDATE tblLuong SET BacLuong='" + txtMaLuong.Text + "',NgayNhap=CONVERT(DATETIME,'" + dateNgayNhap.Text + "',103),LuongBHXH='" + txtLuongBH.Text + "',SoNguoiPhuThuoc='" + txtSoNguoiPT.Text + "'WHERE MaNV='" + txtMaNV.Text + "'";
            Conn.executeQuery(upLuonng);

            Load_data();
        }


        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaLuong.Text = "L" + txtMaNV.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
