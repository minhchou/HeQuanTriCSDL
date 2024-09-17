using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace QLNS
{
    public partial class frmPhongBan : Form
    {
        string phanquyen;
        public frmPhongBan(string pq)
        {
            phanquyen = pq;
            InitializeComponent();
            if (Int32.Parse(phanquyen) == 2)
            {
                btnDelete.Enabled = btnAdd.Enabled = btnUpdate.Enabled = btnNew.Enabled =  false;

            }
            else
            { }
        }

        public void Load_data()
        {
            string str = "SELECT * FROM tblDonVi";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataPhongBan.DataSource = dt;
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btnAdd.Enabled = false;
            Load_data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string upDV = "UPDATE tblDonVi SET MaDV='" + txtMaDV.Text + "',TenDV=N'" + txtTenDV.Text + "',GhiChu=N'" + txtGhiChu.Text + "'WHERE(MaDV='" + txtMaDV.Text + "')";
            Conn.executeQuery(upDV);
            Load_data();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            btnNew.Enabled = false;
            Load_data();
            txtMaDV.Text = "";
            txtTenDV.Text = "";

            txtGhiChu.Text = "";
            txtMaDV.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "")
            {
                MessageBox.Show("Lỗi", "Mã phòng ban không được để trống.");
            }
            else
            {
                try
                {
                    //
                    string addDV = "INSERT INTO tblDonVi(MaDV, TenDV, GhiChu) VALUES ('" + txtMaDV.Text + "',N'" + txtTenDV.Text + "',N'" + txtGhiChu.Text + "')";
                    Conn.executeQuery(addDV);

                    Load_data();
                    txtMaDV.Enabled = false;
                    btnNew.Enabled = true;
                    btnUpdate.Enabled = true;

                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    txtMaDV.Enabled = false;
                }
                catch (Exception)
                {

                }
            }

            btnNew.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delDV = "DELETE FROM tblDonVi WHERE MaDV='" + txtMaDV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Chuyên môn: " + txtMaDV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(delDV);
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

        private void dataPhongBan_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataPhongBan.Rows[e.RowIndex];
                txtMaDV.Text = row.Cells[0].Value.ToString();
                txtTenDV.Text = row.Cells[1].Value.ToString();
                txtGhiChu.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception)
            { }
        }

      
    }
}
