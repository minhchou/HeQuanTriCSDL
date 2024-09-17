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

    public partial class frmBHXH : Form
    { string user, phanquyen;
        public frmBHXH(string username, string pq)
        {
            InitializeComponent();
            user = username;
            phanquyen = pq;
           
            if (Int32.Parse(phanquyen) == 2)
            {
                btnCapNhat.Enabled = btnDelete.Enabled= false;
            }
            else
            { }
        }
        public void Load_data()
        {
            string str = "SELECT * FROM tblBaoHiemXH";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataBaoHiem.DataSource = dt;
        }
        private void frmBHXH_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Load_data();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {   
           string upLuonng = "UPDATE tblBaoHiemXH SET MaSoBH=N'" + txtMaSBH.Text + "',NgayCap='" + dateNgayCap.Text + "',NoiCap=N'" + txtNoiCap.Text + "',NoiDKKCB=N'" + txtNoiDKKCB.Text + "',GhiChu=N'" + txtGhiChu.Text +"'WHERE(MaNV=N'" + txtMaNV.Text + "')";          
           Conn.executeQuery(upLuonng);
           Load_data();
        }

      

        private void dataBaoHiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataBaoHiem.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtMaSBH.Text = row.Cells[1].Value.ToString();
                dateNgayCap.Text = row.Cells[2].Value.ToString();
                txtNoiCap.Text = row.Cells[3].Value.ToString();
                txtNoiDKKCB.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception)
            { }
        }

     

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaSBH.Text = "BH" + txtMaNV.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string del = "DELETE tblBaoHiemXH WHERE MaNV = '" + txtMaNV.Text + "'";
            Conn.executeQuery(del);
            Load_data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
