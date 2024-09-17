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
    public partial class frmDangNhap : Form
    {

        
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = 385;
            txtID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
            {
                //
            }
           
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo");
                return;
            }
            DataTable dt = Conn.getDataTable("SELECT * FROM tblUser WHERE ID = '" + txtID.Text + "' AND Password = '" + txtPass.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào "+txtID.Text+"! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();

                SqlConnection cnn;
                SqlCommand cmd;
                string source;

                source = @"Data Source=LAPTOP-T6FPOMP0\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
                cnn = new SqlConnection(source);
                cnn.Open();

                cmd = new SqlCommand("SELECT PhanQuyen FROM tblUser where ID='" + txtID.Text + "'", cnn);
                string phanquyen = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("SELECT MaNV FROM tblUser where ID='" + txtID.Text + "'", cnn);
                string MaNV = cmd.ExecuteScalar().ToString();

                Form main = new frmMain(txtID.Text,txtPass.Text,phanquyen,MaNV);
                main.Show();
            }
                
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                txtID.Clear();
                txtPass.Clear();
                txtID.Focus();
            }
                
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show("Hãy báo với phòng HCNS!");

        }

       

     
       

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

