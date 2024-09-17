using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmDmLuong : Form
    {
        string phanquyen;
        public frmDmLuong(string pq)
        {
            InitializeComponent();
            txtMaDV.Enabled = txtBacLuong.Enabled = false;
            phanquyen = pq;
            if (Int32.Parse(phanquyen) == 2)
            {
                btnDelete.Enabled = btnAdd.Enabled = btnUpdate.Enabled = btnAdd.Enabled = false;

            }
            else
            { }
        }
        public void Load_data()
        {
            string str = "SELECT TenDV,BacLuong,LuongCB FROM tblDmLuong dl LEFT JOIN tblDonVi dv ON dl.MaDV = dv.MaDV";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataDmLuong.DataSource = dt;
        }

        private void frmDmLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSuDataSet4.tblDonVi' table. You can move, or remove it, as needed.
            this.tblDonViTableAdapter.Fill(this.quanLiNhanSuDataSet4.tblDonVi);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Load_data();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string upDmLuong = "UPDATE tblDmLuong SET LuongCB =" + txtLuongCB.Text + "'WHERE(MaDV='" + txtMaDV.Text + "' AND BacLuong = '" + txtBacLuong.Text + "')";
            Conn.executeQuery(upDmLuong);
            Load_data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delCM = "DELETE FROM tblDmLuong WHERE MaDV='" + txtMaDV.Text + "' AND BacLuong = '" + txtBacLuong.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            btnNew.Enabled = false;
            Load_data();
            txtMaDV.Text = "";
            txtBacLuong.Text = "";

            txtLuongCB.Text = "";
            txtMaDV.Enabled = txtBacLuong.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                //
                string addCM = "INSERT INTO tblDmLuong(MaDV, BacLuong, LuongCB) VALUES ('" + txtMaDV.SelectedValue.ToString() + "','" + txtBacLuong.Text + "','" + txtLuongCB.Text + "')";
                Conn.executeQuery(addCM);

                Load_data();
                txtMaDV.Enabled = false;
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;

                btnNew.Enabled = true;
                btnDelete.Enabled = true;

            }
            catch (Exception)
            {

            }


            btnNew.Enabled = false;
        }

        private void dataDmLuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataDmLuong.Rows[e.RowIndex];
            txtMaDV.Text = row.Cells[0].Value.ToString();
            txtBacLuong.Text = row.Cells[1].Value.ToString();
            txtLuongCB.Text = row.Cells[2].Value.ToString();
        }

    } 
   
}
