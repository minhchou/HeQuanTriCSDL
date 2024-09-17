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
    public partial class frmChamCong : Form
    {
        string username; string phanquyen; string MaNV;
        SqlConnection cnn;
        SqlCommand cmd;
        string source;
        public frmChamCong(string user, string pq, string nv)
        {
            InitializeComponent();
            username = user;
            phanquyen = pq;
            MaNV = nv;
            txtMaNV.Text = nv;
            source = @"Data Source=LAPTOP-T6FPOMP0\SQLEXPRESS\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            cnn = new SqlConnection(source);
            cnn.Open();
            cmd = new SqlCommand("SELECT HoTen FROM tblTTNhanVien where MaNV='" + MaNV + "'", cnn);
            string kq = cmd.ExecuteScalar().ToString();
            txtHoTen.Text = kq;
            cmd = new SqlCommand("SELECT GETDATE()" , cnn);
            string kq2 = cmd.ExecuteScalar().ToString();
            dateGio.Text = kq2;
            dateNgay.Text = kq2;
        }

        public void Load_data()
        {
            string str = "SELECT bc.Id, bc.MaNV, nv.HoTen, CAST(Ngay AS VARCHAR(2)) +'/' + CAST(Thang AS VARCHAR(2))" +
                " +'/'+ CAST(Nam AS VARCHAR(4)) AS NgayCham, CAST(GioVao AS VARCHAR(2)) + ':' + CAST(PhutVao AS VARCHAR(2))" +
                " as GioCham, IIF(KetQua=2, '1', '0.5') AS KetQua FROM tblBangCong bc LEFT JOIN tblTTNhanVien nv ON bc.MaNV = nv.MaNV where" +
                " bc.MaNV = '" + MaNV + "' ORDER BY Id DESC";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataCong.DataSource = dt;
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
           
            Load_data();
        }

        private void btnCC_Click(object sender, EventArgs e)
        { 
            int kq;
            if(dateGio.Value.Hour < 8 && dateNgay.Value.DayOfWeek != DayOfWeek.Saturday)
            {
                kq = 2;
            }  
            else
            { kq = 1; }
            source = @"Data Source=LAPTOP-NOP6QIGJ\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            cnn = new SqlConnection(source);
            cnn.Open();
            cmd = new SqlCommand("IF EXISTS (SELECT MaNV FROM tblBangCong where MaNV='" + MaNV + "' and Ngay = '" + dateNgay.Value.Day +"' and Thang = '" + dateNgay.Value.Month + "' and Nam = '" +dateNgay.Value.Year+ "') select 1 else select 0 ", cnn);
            string kq2 = cmd.ExecuteScalar().ToString();
            int check = Int32.Parse(kq2);


            string cc = "INSERT INTO [dbo].[tblBangCong]([MaNV] ,[Nam] ,[Thang],[Ngay],[GioVao],[PhutVao],[KetQua]) VALUES ('" + txtMaNV.Text + "','" + dateNgay.Value.Year + "','" + dateNgay.Value.Month + "','" + dateNgay.Value.Day + "','" + dateGio.Value.Hour + "','" + dateGio.Value.Minute + "','" + kq + "')";
            if (check != 1 && check != 2)
            {
                Conn.executeQuery(cc);
                Load_data();

            }
            
            else
            {
                MessageBox.Show( "Đã có dữ liệu chấm công ngày " + dateNgay.Text, "Lỗi");
            }
        }

        private void dataCong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataCong.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[1].Value.ToString();
            txtHoTen.Text = row.Cells[2].Value.ToString();
            txtId.Text = row.Cells[0].Value.ToString();
            dateNgay.Text = row.Cells[3].Value.ToString();
            dateGio.Text = row.Cells[4].Value.ToString();
            txtKetQua.Text = row.Cells[5].Value.ToString();
        }
    }
}
