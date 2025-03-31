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

namespace QuanLyThuVien.Forms
{
    public partial class FrmTaiKhoan : Form
    {
        User user;
        List<User> dsUser;
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }
        public FrmTaiKhoan(User user, List<User> dsUser):this()
        {
            this.user = user;
            this.dsUser = dsUser;
        }
        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }
        private void HienThiThongTin()
        {
            txtUser.Text = user.TenDangNhap;
            txtHoTen.Text = user.HoTen;
            txtDiaChi.Text = user.DiaChi;
            txtMatKhau.Text = user.MatKhau;
            txtSDT.Text = user.SoDienThoai;
            dtNgaySinh.Value = user.NgaySinh;
            if (user.GioiTinh == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
        }

        private void cbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMK.Checked)
            {
                cbHienThiMK.BackgroundImage = Properties.Resources.view;
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                cbHienThiMK.BackgroundImage = Properties.Resources.close_eye;
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            timer1.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            bool loi = false;
            errp.Clear();
            if (txtHoTen.Text == "")
            {
                errp.SetError(txtHoTen, "Vui lòng nhập họ tên!");
                loi = true;
            }
            if (txtDiaChi.Text == "")
            {
                errp.SetError(txtDiaChi, "Vui lòng nhập địa chỉ!");
                loi = true;
            }
            if (txtSDT.Text == "")
            {
                errp.SetError(txtSDT, "Vui lòng nhập SĐT!");
                loi = true;
            }
            if (txtMatKhau.Text == "")
            {
                errp.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
                loi = true;
            }
            if (loi)
                return;

            string gt;
            if (rdNam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            user.HoTen = txtHoTen.Text;
            user.GioiTinh = gt;
            user.NgaySinh = dtNgaySinh.Value;
            user.DiaChi = txtDiaChi.Text;
            user.SoDienThoai = txtSDT.Text;
            user.MatKhau = txtMatKhau.Text;
            lbThongBao.Text = "Sửa thành công!";
            timer1.Enabled = true;
        }
    }
}
