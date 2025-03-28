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
    public partial class FrmThueSach : Form
    {
        List<PhieuMuon> dsPhieuMuon;
        User user;
        List<Sach> dsSach;
        public FrmThueSach()
        {
            InitializeComponent();
        }
        public FrmThueSach(List<PhieuMuon> dsPhieuMuon, User user, List<Sach> dsSach) : this()
        {
            this.dsPhieuMuon = dsPhieuMuon;
            this.user = user;
            this.dsSach = dsSach;
        }

        private void FrmThueSach_Load(object sender, EventArgs e)
        {
            HienThiPhieuMuon(dsPhieuMuon);
            cbTrangThai.SelectedIndex = 0;
        }
        private void HienThiPhieuMuon(List<PhieuMuon> ds)
        {
            lvPhieuMuon.Items.Clear();
            foreach (PhieuMuon p in ds)
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

        private void btTaoPhieu_Click(object sender, EventArgs e)
        {
            bool loi = false;
            errp.Clear();
            Sach s1 = dsSach.Find(s => s.MaSach == txtMaSach.Text);
            if (s1 == null)
            {
                errp.SetError(txtMaSach,"Mã sách không tồn tại!");
                loi = true;
            }
            if (cbThoiHan.SelectedIndex==-1)
            {
                errp.SetError(cbThoiHan, "Vui lòng chọn thời hạn!");
                loi=true;
            }
            if (loi)
                return;
            if (s1.SoLuongConLai == 0)
            {
                MessageBox.Show("Rất tiếc, quyển sách này đang tạm hết", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime ngayTraDK;
            if (cbThoiHan.SelectedIndex == 0)
                ngayTraDK = DateTime.Now.AddMonths(1);
            else
                ngayTraDK = DateTime.Now.AddMonths(3);
            PhieuMuon p = new PhieuMuon(TaoMaPhieu(), txtMaSach.Text, user.TenDangNhap, DateTime.Now, ngayTraDK, "Đang mượn");
            dsPhieuMuon.Add(p);

            string tenSach = dsSach.Find(s => s.MaSach == p.MaSach).TenSach;
            ListViewItem it = new ListViewItem(p.MaPhieu);
            it.SubItems.Add(p.MaSach);
            it.SubItems.Add(tenSach);
            it.SubItems.Add(p.NgayMuon.ToString("dd/MM/yyyy"));
            it.SubItems.Add(p.NgayTraDuKien.ToString("dd/MM/yyyy"));
            it.SubItems.Add(p.NgayTraThucTe?.ToString("dd/MM/yyyy"));
            it.SubItems.Add(p.TrangThai);
            lvPhieuMuon.Items.Add(it);

            s1.SoLuongConLai -= 1;

            lbThongBao.Text = "Tạo thành công!";
            timer1.Enabled = true;
        }

        private string TaoMaPhieu()
        {
            int i = 1;
            while (dsPhieuMuon.Any(p => p.MaPhieu == string.Format("MP{0:D3}", i)))
            {
                i++;
            }
            string maPhieu = string.Format("MP{0:D3}", i);
            return maPhieu;
        }

      

        private void btTim_Click(object sender, EventArgs e)
        {
            List<PhieuMuon> ds = dsPhieuMuon.FindAll(p => p.MaPhieu.Contains(txtTim.Text.Trim())
            && (cbTrangThai.SelectedIndex == 0 || p.TrangThai == cbTrangThai.Text));

            HienThiPhieuMuon(ds);
        }

        private void cbThoiHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThoiHan.SelectedIndex == 0)
                lbNgayTra.Text = DateTime.Now.AddMonths(1).ToString("dd/MM/yyyy");
            else if (cbThoiHan.SelectedIndex == 1)
                lbNgayTra.Text = DateTime.Now.AddMonths(3).ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            timer1.Enabled = false;
        }
        
    }
}
