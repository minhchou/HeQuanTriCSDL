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

namespace QLNS
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (radMaNV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE MaNV like '%" +txtTimKiem.Text+ "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTenNV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE HoTen LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiSinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE NoiSinh LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDiaChi.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE DiaChi LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
               
                //
               
                //
                if (radDanToc.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE DanToc LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTonGiao.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE TonGiao LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radQuocTich.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE QuocTich LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
               
                //
                if (radDonVi.Checked == true)
                {
                    string Search = "SELECT nv.*,dv.TenDV FROM tblTTNhanVien nv LEFT JOIN tblDonVi dv ON nv.MaDonVi = dv.MaDV WHERE dv.TenDV like N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiCapBHXH.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NoiCap LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiDKKCB.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NoiDKKCB LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radGioiTinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE GioiTinh=N'" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radSDT.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE SDT LIKE'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radEmail.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE Email='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgaySinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE NgaySinh='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
               
                //
               
                //
                
                //
                if (txtTimKiem.Text == "Nhân viên nào có lương cao nhất?" || txtTimKiem.Text == "nhân viên nào có lương cao nhất?" || txtTimKiem.Text == "lương cao nhất?")
                {
                    string Search = "SELECT * FROM tblLuong  where LuongCoBan = (select max(LuongCoBan) from tblLuong )";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (txtTimKiem.Text == "Nhân viên nào có lương thấp nhất?" || txtTimKiem.Text == "nhân viên nào có lương thấp nhất?" || txtTimKiem.Text == "lương thấp nhất?")
                {
                    string Search = "SELECT * FROM tblLuong  where LuongCoBan = (select min(LuongCoBan) from tblLuong )";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //

            }
            catch (Exception)
            { }
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

 
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radMaNV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE MaNV='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTenNV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE HoTen LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiSinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE NoiSinh LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDiaChi.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE DiaChi LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
              
                //
               
                //
                if (radDanToc.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE DanToc LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTonGiao.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE TonGiao LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radQuocTich.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE QuocTich LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                
                //
                if (radDonVi.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien a left join tblDonVi b ON a.MaDonVi=b.MaDV where b.TenDV like N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiCapBHXH.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NoiCap LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiDKKCB.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NoiDKKCB LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radGioiTinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE GioiTinh=N'" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radSDT.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE SDT LIKE'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radEmail.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE Email='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgaySinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE NgaySinh='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = Conn.getDataTable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
               
                //
               
                //
               

            }
            catch (Exception)
            { }
        }

        private void radChuyenMon_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
