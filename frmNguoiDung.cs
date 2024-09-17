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
    public partial class frmNguoiDung : Form
    {
        string username, password;
        public frmNguoiDung(string user, string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
        }
        public void Load_data()
        {
            string str = "select ID,PhanQuyen from tblUser";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataNguoiDung.DataSource = dt;
        }
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Load_data();
        }

        private void dataNguoiDung_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataNguoiDung.Rows[e.RowIndex];
                txtTaiKhoan.Text = row.Cells[0].Value.ToString();

                if (row.Cells[1].Value.ToString() == "1")
                { cboxPhanQuyen.Text = "Quản Trị"; }
                else
                { cboxPhanQuyen.Text = "Thành Viên"; }    
                    
            }
            catch (Exception)
            {

            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string _PhanQuyen="";
            if (cboxPhanQuyen.Text == "Quản Trị")
                _PhanQuyen = "1";
            if (cboxPhanQuyen.Text == "Thành Viên")
                _PhanQuyen = "2";
            string update = "update tblUser set PhanQuyen='" + _PhanQuyen + "' where(ID=N'" + txtTaiKhoan.Text + "')";
            Conn.executeQuery(update);
            Load_data();

        }
    }
}
