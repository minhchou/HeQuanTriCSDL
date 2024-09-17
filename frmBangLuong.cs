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

    public partial class frmBangLuong : Form
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }

        public void Load_BangLuong()
        {
            string str = "select bl.MaBangLuong, bl.MaNV, nv.HoTen,  dml.LuongCB, cv.PhuCapCV, bl.SoNgayCong, bl.BaoHiem, " +
                "bl.ThueTNCN, bl.ThuNhapTrongKy, bl.SoTienThucLinh from tblBangLuong bl LEFT JOIN tblTTNhanVien nv " +
                "ON bl.MaNV = nv.MaNV LEFT JOIN  tblChucVu cv ON nv.MaCV = cv.MaCV left join tblLuong l ON " +
                "nv.MaNV = l.MaNV left join tblDmLuong dml ON (l.BacLuong = dml.BacLuong and nv.MaDonVi = dml.MaDV) order by bl.id desc";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataBangLuong.DataSource = dt;
        }
      

        private void BangLuong_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Load_BangLuong();
        }

        

        private void dataBangLuong_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataBangLuong.Rows[e.RowIndex];
                txtMaBangLuong.Text = row.Cells[0].Value.ToString();
                txtMaNV.Text = row.Cells[1].Value.ToString();
                txtHoTen.Text = row.Cells[2].Value.ToString();
                txtLuongCoBan.Text = row.Cells[3].Value.ToString();
                txtPhuCap.Text = row.Cells[4].Value.ToString();
            
                txtNgayCong.Text = row.Cells[5].Value.ToString();
                txtBaoHiem.Text = row.Cells[6].Value.ToString();
                txtThueTNCN.Text = row.Cells[7].Value.ToString();
                txtThuNhapTrongKy.Text = row.Cells[8].Value.ToString();
                txtSoTien.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TinhLuong = "SET DATEFORMAT DMY DECLARE @_NgayDauThang date, @_NgayCuoiThang DATE, @_Date date" +
                " select @_Date = getdate() SELECT @_NgayDauThang =DATEADD(M,-1,DATEADD(D,-day(@_Date)+1,@_Date)) " +
                " SELECT @_NgayCuoiThang = DATEADD(D,-1,DATEADD(M,1,@_NgayDauThang))  DECLARE @_Ma VARCHAR(24) " +
                "SELECT @_Ma= CAST(MONTH(@_NgayDauThang) AS VARCHAR(2)) + CAST(YEAR(@_NgayDauThang) AS VARCHAR(4)) " +
                "DECLARE @_SoNgay float SELECT @_SoNgay =[dbo].[ufn_SoNgayCong] (DATEADD(M,-1,GETDATE())) " +
                "IF OBJECT_ID('TempDb..#temp') IS NOT NULL DROP TABLE #temp; select nv.MaNV, cv.PhuCapCV,  dml.LuongCB," +
                " L.LuongBHXH, l.SoNguoiPhuThuoc into #temp from tblTTNhanVien nv LEFT JOIN  tblChucVu cv " +
                "ON nv.MaCV = cv.MaCV left join tblLuong l ON nv.MaNV = l.MaNV left join tblDmLuong dml " +
                "ON (l.BacLuong = dml.BacLuong and nv.MaDonVi = dml.MaDV) IF OBJECT_ID('TempDb..#temp2')  " +
                "IS NOT NULL DROP TABLE #temp2; select MANV,SUM(ketQua)/2 as SoNgayCong INTO #temp2 from tblBangCong " +
                "WHERE Thang = MONTH(@_NgayDauThang) and Nam = YEAR(@_NgayDauThang) GROUP BY MANV IF OBJECT_ID('TempDb..#temp3') " +
                " IS NOT NULL DROP TABLE #temp3; select MaNV, SUM(SoNgayNghi)as SoNgayNghiPhep into #temp3 from tblNV_NghiPhep " +
                "WHERE Ngay between @_NgayDauThang and @_NgayCuoiThang and LoaiNghi = 'P' and TrangThai = 1  group by MaNV" +
                " IF OBJECT_ID('TempDb..#temp4') IS NOT NULL DROP TABLE #temp4; SELECT a.MaNV, " +
                "IIF((LuongCB+PhuCapCV)*(SoNgayCong +ISNULL(SoNgayNghiPhep,0))/@_SoNgay - LuongBHXH*105/1000 - " +
                "11000000 - SoNguoiPhuThuoc*4400000 <0,0, (LuongCB+PhuCapCV)*(SoNgayCong +ISNULL(SoNgayNghiPhep,0))/@_SoNgay" +
                " - LuongBHXH*105/1000 - 11000000 - SoNguoiPhuThuoc*4400000) AS ThuNhapChiuThue INTO #temp4 FROM #temp a  " +
                "INNER JOIN #temp2 b ON a.MaNV = b.MaNV LEFT JOIN #temp3 c ON a.MaNV = c.MaNV " +
                "IF OBJECT_ID('TempDb..#temp5') IS NOT NULL DROP TABLE #temp5; SELECT A.MaNV, " +
                "ROUND((LuongCB+PhuCapCV)*(SoNgayCong +ISNULL(SoNgayNghiPhep,0))/@_SoNgay,0) as ThuNhapTrongKy," +
                "LuongBHXH*105/1000 AS GiamTruTruocThue, CASE WHEN ThuNhapChiuThue < 5000000  THEN ThuNhapChiuThue*5/100  " +
                "WHEN ThuNhapChiuThue <= 10000000 THEN ThuNhapChiuThue/10 - 250000  WHEN ThuNhapChiuThue <= 18000000 " +
                "THEN ThuNhapChiuThue*15/100 - 750000 WHEN ThuNhapChiuThue <= 32000000 THEN ThuNhapChiuThue*20/100 - 1650000 " +
                "WHEN ThuNhapChiuThue <= 52000000 THEN ThuNhapChiuThue*25/100 - 3250000  WHEN ThuNhapChiuThue <= 80000000 " +
                "THEN ThuNhapChiuThue*30/100 - 5850000  ELSE ThuNhapChiuThue*35/100 - 9850000 END AS ThueTNCN	 " +
                "INTO #temp5 FROM #temp a INNER JOIN #temp2 b ON a.MaNV = b.MaNV LEFT JOIN #temp3 c ON a.MaNV = c.MaNV " +
                "LEFT JOIN #temp4 D on A.MaNV = D.MaNV DELETE FROM tblBangLuong WHERE MaBangLuong =  @_Ma " +
                "INSERT INTO tblBangLuong (MaBangLuong, MaNV, ThuNhapTrongKy,BaoHiem, ThueTNCN, SoTienThucLinh, SoNgayCong) " +
                "SELECT @_Ma, t2.MaNV, ThuNhapTrongKy,GiamTruTruocThue, ThueTNCN, ThuNhapTrongKy - GiamTruTruocThue - ThueTNCN," +
                " t2.SoNgayCong + ISNULL(t3.SoNgayNghiPhep,0) FROM #temp5 t5 LEFT JOIN #temp2 t2 ON t5.MaNV = t2.MaNV " +
                "left join #temp3 t3 on T5.MaNV = t3.MaNV";
            Conn.executeQuery(TinhLuong);
            Load_BangLuong();
            
        }
    }
}
