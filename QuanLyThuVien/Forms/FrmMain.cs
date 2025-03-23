using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.Models;
using System.Drawing.Drawing2D;
using System.IO;

namespace QuanLyThuVien.Forms
{
    public partial class FrmMain : Form
    {
        FrmLogin fLogin = new FrmLogin();
        bool choPhepTatFormLogin = true;
        Point pForm, pChuot;
        List<User> dsUser;
        List<Sach> dsSach;
        List<TheLoai> dsTheLoai;
        List<PhieuMuon> dsPhieuMuon;
        User user;
        public FrmMain()
        {
            InitializeComponent();
            LamFormboTron();
            
        }
        

        public FrmMain(User u,List<User> us, FrmLogin fLogin):this()
        {
            this.fLogin = fLogin;
            this.user = u;
            this.dsUser = us;
            if (u.TenDangNhap == "admin")
            {
                BtQuanLy.Visible = true;
                btThongKe.Visible = true;
            }
            lbUserName.Text = user.TenDangNhap;
            lbName.Text = "Xin chào " + user.HoTen;
        }

        private void LamFormboTron()
        {
            int radius = 30;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.dsTheLoai = DocFileTheLoai("theloai.txt");
            this.dsSach = DocFileSach("sach.txt");
            this.dsPhieuMuon = DocFilePhieuMuon("phieumuon.txt");

            FrmTraCuuSach f = new FrmTraCuuSach(dsSach, dsTheLoai);
            moForm(f);
        }

        private List<Sach> DocFileSach(string link)
        {
            try
            {
                return QuanLyTep.docFileSach(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file sách: " + ex.Message);
                return new List<Sach>();
            }
        }
        private List<TheLoai> DocFileTheLoai(string link)
        {
            try
            {
                return QuanLyTep.docFileTheLoai(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file thể loại: " + ex.Message);
                return new List<TheLoai>();
            }
        }
        private List<PhieuMuon> DocFilePhieuMuon(string link)
        {
            try
            {
                return QuanLyTep.docFilePhieuMuon(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file phiếu mượn: " + ex.Message);
                return new List<PhieuMuon>();
            }
        }
        private void btHome_Click(object sender, EventArgs e)
        {
            subMenuQL.Visible = false;
            subMenuHome.Visible = !subMenuHome.Visible;
        }

        private void BtQuanLy_Click(object sender, EventArgs e)
        {
            subMenuHome.Visible = false;
            subMenuQL.Visible = !subMenuQL.Visible;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            fLogin.Show();
            choPhepTatFormLogin = false;
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (choPhepTatFormLogin)
                fLogin.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMnm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //di chuyển form
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            pForm = this.Location;
            pChuot = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.Location.X - pChuot.X,
                                 this.Location.Y + e.Location.Y - pChuot.Y);
            }
        }


        
        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            subMenuHome.Visible = false;
            subMenuQL.Visible = false;
            lbTenMenu.Text = "Tài khoản";
            FrmTaiKhoan f = new FrmTaiKhoan(user, dsUser);
            moForm(f);
        }

        private void btAboutUs_Click(object sender, EventArgs e)
        {
            subMenuHome.Visible = false;
            subMenuQL.Visible = false;
            lbTenMenu.Text = "About us";
            FrmAboutUs f = new FrmAboutUs();
            moForm(f);
        }

        private void btTraCuuSach_Click(object sender, EventArgs e)
        {
            lbTenMenu.Text = "Tra cứu sách";
            FrmTraCuuSach f = new FrmTraCuuSach(dsSach, dsTheLoai);
            moForm(f);
        }

        private void btThueSach_Click(object sender, EventArgs e)
        {
            lbTenMenu.Text = "Thuê sách";
            FrmThueSach f = new FrmThueSach(dsPhieuMuon, user, dsSach);
            moForm(f);
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {
            lbTenMenu.Text = "Trả sách";
            FrmTraSach f = new FrmTraSach(dsPhieuMuon, user, dsSach);
            moForm(f);
        }

        private void btQLSach_Click(object sender, EventArgs e)
        {
            lbTenMenu.Text = "Quản lý sách";
            FrmQLSach f = new FrmQLSach(dsSach, dsTheLoai);
            moForm(f);
        }

        private void btQLTheLoai_Click(object sender, EventArgs e)
        {
            lbTenMenu.Text = "Quản lý thể loại";
            FrmQLTheLoai f = new FrmQLTheLoai(dsTheLoai);
            moForm(f);
        }

        private void btQLNguoiDung_Click(object sender, EventArgs e)
        {
            lbTenMenu.Text = "Quản lý người dùng";
            FrmQLUser f = new FrmQLUser(dsUser);
            moForm(f);
        }

        private void btQLPhieuMuon_Click(object sender, EventArgs e)
        {
            lbTenMenu.Text = "Quản lý phiếu mượn";
            FrmQLPhieuMuon f = new FrmQLPhieuMuon(dsSach, dsUser, dsPhieuMuon);
            moForm(f);
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            lbTenMenu.Text = "Thống kê";
            FrmThongKe f = new FrmThongKe(dsPhieuMuon);
            moForm(f);
        }

        private void moForm(Form f)
        {
            pnForm.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            pnForm.Controls.Add(f);
            f.Show();
        }

    }
}
