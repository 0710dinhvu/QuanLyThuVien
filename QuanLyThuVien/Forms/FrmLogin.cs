using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using QuanLyThuVien.Models;
using System.IO;

namespace QuanLyThuVien.Forms
{
    public partial class FrmLogin : Form
    {
        List<User> dsUser;
        public FrmLogin()
        {
            InitializeComponent();
            this.dsUser = TaiUserTuFile("users.txt");
        }

        private List<User> TaiUserTuFile(String link)
        {
            try
            {
                return QuanLyTep.DocFileUser(link);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file user: " + ex.Message);
                return new List<User>();
            }
        }

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); 
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); 
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); 
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); 
            path.CloseFigure();
            
            this.Region = new Region(path);

            int radiusBt = 40;
            GraphicsPath pathBt = new GraphicsPath();
            pathBt.AddArc(0, 0, radiusBt, radiusBt, 180, 90);
            pathBt.AddArc(btLogin.Width - radiusBt, 0, radiusBt, radiusBt, 270, 90);
            pathBt.AddArc(btLogin.Width - radiusBt, btLogin.Height - radiusBt, radiusBt, radiusBt, 0, 90);
            pathBt.AddArc(0, btLogin.Height - radiusBt, radiusBt, radiusBt, 90, 90);
            pathBt.CloseFigure();
            btLogin.Region= new Region(pathBt);
        }

        private User CheckLogin(string username, string password)
        {
            foreach (User user in dsUser)
            {
                if (user.TenDangNhap == username && user.MatKhau == password)
                {
                    return user;
                }
            }
            return null;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            User user = CheckLogin(username, password);

            if (user != null)
            {
                FrmMain mainForm = new FrmMain(user,dsUser,this);
                
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMnm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
