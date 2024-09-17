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
    public partial class frmChucVu : Form
    {
        string phanquyen;
        public frmChucVu(string pq)
        {
            InitializeComponent();
            phanquyen = pq;
            if (Int32.Parse(phanquyen) == 2)
            {
                btnDelete.Enabled = btnAdd.Enabled = btnUpdate.Enabled = btnNew.Enabled = false;

            }
            else
            { }
        }

        public void Load_data()
        {
            string str = "SELECT * FROM tblChucVu";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataChuyenMon.DataSource = dt;
        }

        private void frmChuyenMon_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btnAdd.Enabled = false;
            Load_data();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string upChuyenMon = "UPDATE tblChucVu SET MaCV=N'" + txtMaCV.Text + "',TenCV=N'" + txtTenCV.Text + "',PhuCapCV=N'" + txtPCCV.Text + "'WHERE(MaCV=N'" + txtMaCV.Text + "')";
            Conn.executeQuery(upChuyenMon);
            Load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            btnNew.Enabled = false;
            Load_data();
            txtMaCV.Text = "";
            txtTenCV.Text = "";

            txtPCCV.Text = "";
            txtMaCV.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Lỗi", "Mã chức vụ không được để trống.");
            }
            else
            {
                try
                {
                    //
                    string addCM = "INSERT INTO tblChucVu(MaCV, TenCV, PhuCapCV) VALUES ('" + txtMaCV.Text + "',N'" + txtTenCV.Text + "','" + txtPCCV.Text + "')";
                    Conn.executeQuery(addCM);

                    Load_data();
                    txtMaCV.Enabled = false;
                    btnNew.Enabled = true;
                    btnUpdate.Enabled = true;

                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    txtMaCV.Enabled = false;
                }
                catch (Exception)
                {

                }
            }

            btnNew.Enabled = false;
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delCM = "DELETE FROM tblChucVu WHERE MaCV='" + txtMaCV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa chức vụ: " + txtMaCV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(delCM);
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

        private void dataChuyenMon_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataChuyenMon.Rows[e.RowIndex];
                txtMaCV.Text = row.Cells[0].Value.ToString();
                txtTenCV.Text = row.Cells[1].Value.ToString();
                txtPCCV.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception)
            { }
        }
    }
}
