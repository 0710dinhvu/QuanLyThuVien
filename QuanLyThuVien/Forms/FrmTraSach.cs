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
    public partial class FrmTraSach : Form
    {
        List<PhieuMuon> dsPhieuMuon;
        User user;
        List<Sach> dsSach;
        public FrmTraSach()
        {
            InitializeComponent();
        }
        public FrmTraSach(List<PhieuMuon> dsPhieuMuon, User user, List<Sach> dsSach) : this()
        {
            this.dsPhieuMuon = dsPhieuMuon;
            this.user = user;
            this.dsSach = dsSach;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<PhieuMuon> ds = dsPhieuMuon.FindAll(p => p.TenDangNhap == user.TenDangNhap && p.MaPhieu.Contains(txtTim.Text.Trim())
           && (cbTrangThai.SelectedIndex == 0 || p.TrangThai == cbTrangThai.Text));

            lvPhieuMuon.Items.Clear();
            foreach (PhieuMuon p in ds)
            {
                string tenSach = dsSach.Find(s => s.MaSach == p.MaSach).TenSach;
                ListViewItem it = new ListViewItem(p.MaPhieu);
                it.SubItems.Add(p.MaSach);
                it.SubItems.Add(tenSach);
                it.SubItems.Add(p.NgayMuon.ToString("dd/MM/yyyy"));
                it.SubItems.Add(p.NgayTraDuKien.ToString("dd/MM/yyyy"));
                it.SubItems.Add(p.NgayTraThucTe?.ToString("dd/MM/yyyy") ?? "Chưa trả");
                it.SubItems.Add(p.TrangThai);
                lvPhieuMuon.Items.Add(it);
            }
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {
            errp.Clear();
            if (txtMaPhieu.Text=="")
            {
                errp.SetError(txtMaPhieu, "Vui lòng nhập mã phiếu!");
                return;
            }
            PhieuMuon p1 = dsPhieuMuon.Find(p=>p.MaPhieu==txtMaPhieu.Text && p.TenDangNhap==user.TenDangNhap);
            if (p1 == null)
            {
                errp.SetError(txtMaPhieu, "Mã phiếu không tồn tại!");
                return;
            }
            if (p1.TrangThai != "Đang mượn")
            {
                MessageBox.Show("Sách đã được trả trước đó!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string tt;
            if (DateTime.Now.CompareTo(p1.NgayTraDuKien) <= 0)
                tt = "Đã trả (đúng hạn)";
            else
                tt = "Đã trả (quá hạn)";
            p1.TrangThai = tt;
            foreach (ListViewItem i in lvPhieuMuon.Items)
            {
                if (i.Text == p1.MaPhieu)
                {
                    i.SubItems[6].Text = "Đã trả (đúng hạn)";
                    break;
                }
            }
            dsSach.Find(s => s.MaSach == p1.MaSach).SoLuongConLai++;
            lbThongBao.Text = "Trả thành công!";
            timer1.Enabled = true;
        }

        private void FrmTraSach_Load(object sender, EventArgs e)
        {
            hienThiPhieuMuon();
            cbTrangThai.SelectedIndex = 0;
        }
        private void hienThiPhieuMuon()
        {
            lvPhieuMuon.Items.Clear();
            foreach (PhieuMuon p in dsPhieuMuon)
            {
                if (p.TenDangNhap == user.TenDangNhap)
                {
                    Sach s1 = dsSach.Find(s => s.MaSach == p.MaSach);
                    string tenSach;
                    if (s1 == null)
                        tenSach = "Sách không tồn tại!!!!!";
                    else
                        tenSach = s1.TenSach;
                    ListViewItem it = new ListViewItem(p.MaPhieu);
                    it.SubItems.Add(p.MaSach);
                    it.SubItems.Add(tenSach);
                    it.SubItems.Add(p.NgayMuon.ToString("dd/MM/yyyy"));
                    it.SubItems.Add(p.NgayTraDuKien.ToString("dd/MM/yyyy"));
                    it.SubItems.Add(p.NgayTraThucTe?.ToString("dd/MM/yyyy") ?? "Chưa trả");
                    it.SubItems.Add(p.TrangThai);
                    lvPhieuMuon.Items.Add(it);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            timer1.Enabled = false;
        }

        private void lvPhieuMuon_DoubleClick(object sender, EventArgs e)
        {
            if (lvPhieuMuon.SelectedItems.Count > 0 && lvPhieuMuon.SelectedItems[0].SubItems[6].Text=="Đang mượn")
            {
                ListViewItem it = lvPhieuMuon.SelectedItems[0];
                txtMaPhieu.Text = it.Text;
            }
        }
    }
}
