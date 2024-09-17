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
using System.IO;

namespace QLNS
{
    public partial class frmMain : Form
    {
        string username,password,phanquyen,MaNV;

        public frmMain( string user,string pass, string pq, string NV)
        {
            InitializeComponent();
            username=user;
            password = pass;
            phanquyen = pq;
            MaNV = NV;
            if (Int32.Parse(phanquyen) == 2)
            {
                bảiHiểmXHToolStripMenuItem.Visible = lươngToolStripMenuItem.Visible = tínhLươngToolStripMenuItem.Visible = false;
                đổiMậtKhẩuToolStripMenuItem.Visible = false;
                quảnLýCôngadminToolStripMenuItem.Visible = toolStripSeparator3.Visible =  false;
            }    
            else
            {
                đơnXinNghỉPhépToolStripMenuItem.Visible = false;
                chấmCôngToolStripMenuItem.Visible = false;
            }

        }


        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
                 
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form login = new frmDangNhap();
                login.ShowDialog();
            }
            else if (dialog == DialogResult.No)
            {
                //
            }

        }
     

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form DMK = new frmDoiMatKhau(username,password);
            DMK.ShowDialog();
        }

        private void NguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NguoiDung = new frmNguoiDung(username,password);
            NguoiDung.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NV = new frmTTNhanVien(username,phanquyen);
            NV.ShowDialog();
        }

     
        
        private void bảiHiểmXHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BHXH = new frmBHXH(username, phanquyen);
            BHXH.ShowDialog();
        }


        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Luong = new frmLuongNV();
            Luong.ShowDialog();
        }

       


        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TimKiem = new frmTimKiem();
            TimKiem.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PhongBan = new frmPhongBan(phanquyen);
            PhongBan.ShowDialog();
        }

        private void chuyênMônToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ChuyenMon = new frmChucVu(phanquyen);
            ChuyenMon.ShowDialog();
        }

       

        private void tínhLươngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form BangLuong = new frmBangLuong();
            BangLuong.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DmLuong = new frmDmLuong(phanquyen);
            DmLuong.ShowDialog();
        }

        private void duyệtĐơnXinNghỉPhépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form duyet = new frmDuyetNghiPhep();
            duyet.ShowDialog();
        }
        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cc = new frmChamCong(username, phanquyen, MaNV);
            cc.ShowDialog();
        }



        //private void bảngChiTiếtLươngThángToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form loc = new locrptTongHopLuong();
        //    loc.ShowDialog();
        //}
        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

       
        private void quảnLýCôngadminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form qlc = new frmCCadmin();
            qlc.ShowDialog();
        }

        private void đơnXinNghỉPhépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NghiPhep = new frmDonXinNghiPhep(username, phanquyen, MaNV);
            NghiPhep.ShowDialog();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
