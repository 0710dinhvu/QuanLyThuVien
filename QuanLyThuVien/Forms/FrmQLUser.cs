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
    public partial class FrmQLUser : Form
    {
        List<User> dsUser;
        FrmMain fMain;
        public FrmQLUser()
        {
            InitializeComponent();
        }
        public FrmQLUser(List<User> dsUser, FrmMain fMain) :this()
        {
            this.dsUser = dsUser;
            this.fMain = fMain;
        }

        private void FrmQLUser_Load(object sender, EventArgs e)
        {
            HienThiUser(dsUser);
        }
        private void HienThiUser(List<User> ds)
        {
            lvUser.Items.Clear();
            foreach(User u in ds)
            {
                if (u.TenDangNhap != "admin")
                {
                    ListViewItem it = new ListViewItem(u.TenDangNhap);
                    it.SubItems.Add(u.HoTen);
                    it.SubItems.Add(u.NgaySinh.ToString("dd/MM/yyyy"));
                    it.SubItems.Add(u.GioiTinh);
                    it.SubItems.Add(u.DiaChi);
                    it.SubItems.Add(u.SoDienThoai);
                    it.SubItems.Add("******");
                    it.Tag = u.MatKhau;
                    if (u.GioiTinh == "Nam")
                        it.ImageIndex = 0;
                    else
                        it.ImageIndex = 1;
                    lvUser.Items.Add(it);
                }
            }
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

        private void btThem_Click(object sender, EventArgs e)
        {
            bool loi = false;
            errp.Clear();
            if(txtUser.Text=="")
            {
                errp.SetError(txtUser, "Vui lòng nhập user!");
                loi = true;
            }
            User u1 = dsUser.Find(u => u.TenDangNhap == txtUser.Text);
            if(u1!=null)
            {
                errp.SetError(txtUser, "User đã tồn tại!");
                loi = true;
            }
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
            User uMoi = new User(txtUser.Text, txtMatKhau.Text, txtHoTen.Text, dtNgaySinh.Value,
                gt, txtDiaChi.Text, txtSDT.Text);
            dsUser.Add(uMoi);
            ListViewItem it = new ListViewItem(uMoi.TenDangNhap);
            it.SubItems.Add(uMoi.HoTen);
            it.SubItems.Add(uMoi.NgaySinh.ToString("dd/MM/yyyy"));
            it.SubItems.Add(uMoi.GioiTinh);
            it.SubItems.Add(uMoi.DiaChi);
            it.SubItems.Add(uMoi.SoDienThoai);
            it.SubItems.Add("******");
            it.Tag = uMoi.MatKhau;
            lvUser.Items.Add(it);
            TaoMa();

            lbThongBao.Text = "Thêm thành công!";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            timer1.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            errp.Clear();
            if (txtUser.Text == "")
            {
                errp.SetError(txtUser, "Vui lòng nhập user!");
                return;
            }
            User u1 = dsUser.Find(u => u.TenDangNhap == txtUser.Text);
            if (u1 == null)
            {
                errp.SetError(txtUser, "User không tồn tại!");
                return;
            }
            dsUser.Remove(u1);
            foreach(ListViewItem i in lvUser.Items)
            {
                if(i.Text==u1.TenDangNhap)
                {
                    lvUser.Items.Remove(i);
                    break;
                }
            }
            lbThongBao.Text = "Xóa thành công!";
            timer1.Enabled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            bool loi = false;
            errp.Clear();
            User u1 = dsUser.Find(u => u.TenDangNhap == txtUser.Text);
            if (u1 == null)
            {
                errp.SetError(txtUser, "User không tồn tại!");
                loi = true;
            }
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
            u1.HoTen = txtHoTen.Text;
            u1.GioiTinh = gt;
            u1.NgaySinh = dtNgaySinh.Value;
            u1.DiaChi = txtDiaChi.Text;
            u1.SoDienThoai = txtSDT.Text;
            u1.MatKhau = txtMatKhau.Text;
            foreach (ListViewItem i in lvUser.Items)
            {
                if (i.Text == u1.TenDangNhap)
                {
                    i.SubItems[1].Text = u1.HoTen;
                    i.SubItems[2].Text = u1.NgaySinh.ToString("dd/MM/yyyy");
                    i.SubItems[3].Text = u1.GioiTinh;
                    i.SubItems[4].Text = u1.DiaChi;
                    i.SubItems[5].Text = u1.SoDienThoai;
                    i.Tag = u1.MatKhau;
                    break;
                }
            }
            lbThongBao.Text = "Lưu thành công!";
            timer1.Enabled = true;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            errp.Clear();
            txtUser.Text = txtUser.Text = txtDiaChi.Text = txtMatKhau.Text = txtHoTen.Text = txtSDT.Text = "";
            rdNam.Checked = true;
            dtNgaySinh.Value = DateTime.Now;
        }

        private void cbTaoTuDong_CheckedChanged(object sender, EventArgs e)
        {
            TaoMa();
        }
        private void TaoMa()
        {
            if (cbTaoTuDong.Checked)
            {
                int i = 1;
                while (dsUser.Any(u => u.TenDangNhap == string.Format("user{0:D2}", i)))
                {
                    i++;
                }
                string maSach = string.Format("user{0:D2}", i);
                txtUser.Text = maSach;
                txtUser.ReadOnly = true;
            }
            else
            {
                txtUser.Text = "";
                txtUser.ReadOnly = false;
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<User> ds = dsUser.FindAll(u => u.TenDangNhap.IndexOf(txtTim.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0
            || u.HoTen.IndexOf(txtTim.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
            HienThiUser(ds);
        }

        private void lvUser_DoubleClick(object sender, EventArgs e)
        {
            if (lvUser.SelectedItems.Count > 0)
            {
                cbHienThiMK.Checked = false;
                ListViewItem it = lvUser.SelectedItems[0];
                txtUser.Text = it.Text;
                txtHoTen.Text = it.SubItems[1].Text;
                dtNgaySinh.Value = DateTime.ParseExact(it.SubItems[2].Text, "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture);
                if (it.SubItems[3].Text == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                txtDiaChi.Text = it.SubItems[4].Text;
                txtSDT.Text = it.SubItems[5].Text;
                txtMatKhau.Text = (string)it.Tag;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "File txt|*.txt";
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dsUser.Clear();
                    dsUser.AddRange(QuanLyTep.DocFileUser(dlg.FileName));
                    HienThiUser(dsUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTep.luuDSUser(Application.StartupPath + @"\users.txt", dsUser);
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "File txt|*.txt";
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    QuanLyTep.luuDSUser(dlg.FileName, dsUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
            }
        }

        private void saveAllMenuItem_Click(object sender, EventArgs e)
        {
            fMain.SaveAll();
        }
    }
}
