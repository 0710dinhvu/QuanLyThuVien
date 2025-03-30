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
    public partial class FrmQLPhieuMuon : Form
    {
        List<Sach> dsSach;
        List<User> dsUser;
        List<PhieuMuon> dsPhieuMuon;
        FrmMain fMain;
        public FrmQLPhieuMuon()
        {
            InitializeComponent();
        }
        public FrmQLPhieuMuon(List<Sach> dsSach, List<User> dsUser,
            List<PhieuMuon> dsPhieuMuon, FrmMain fMain) :this()
        {
            this.dsSach = dsSach;
            this.dsUser = dsUser;
            this.dsPhieuMuon = dsPhieuMuon;
            this.fMain = fMain;
        }

        private void FrmQLPhieuMuon_Load(object sender, EventArgs e)
        {
            hienThiPhieuMuon(dsPhieuMuon);
            cbTrangThai.SelectedIndex = 0;
            dtNgayMuon.Value = DateTime.Now;
            dtNgayTraTT.Value = DateTime.Now;
        }
        private void hienThiPhieuMuon(List<PhieuMuon> ds)
        {
            lvPhieuMuon.Items.Clear();
            foreach (PhieuMuon p in ds)
            {
                Sach s1 = dsSach.Find(s => s.MaSach == p.MaSach);
                string tenSach;
                if (s1 == null)
                    tenSach = "Sách không tồn tại!!!!!";
                else
                    tenSach = s1.TenSach;
                ListViewItem it = new ListViewItem(p.MaPhieu);
                it.SubItems.Add(p.TenDangNhap);
                it.SubItems.Add(p.MaSach);
                it.SubItems.Add(tenSach);
                it.SubItems.Add(p.NgayMuon.ToString("dd/MM/yyyy"));
                it.SubItems.Add(p.NgayTraDuKien.ToString("dd/MM/yyyy"));
                it.SubItems.Add(p.NgayTraThucTe?.ToString("dd/MM/yyyy") ?? "Chưa trả");
                it.SubItems.Add(p.TrangThai);
                lvPhieuMuon.Items.Add(it);
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<PhieuMuon> ds = dsPhieuMuon.FindAll(p => p.MaPhieu.Contains(txtTimMaPhieu.Text.Trim()) 
            && p.TenDangNhap.IndexOf(txtTimUser.Text.Trim(), StringComparison.OrdinalIgnoreCase)>=0
            && p.MaSach.Contains(txtTimMaSach.Text.Trim()) 
            && ( cbTrangThai.SelectedIndex==0 || p.TrangThai==cbTrangThai.Text) );
            hienThiPhieuMuon(ds);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            errp.Clear();
            txtTimMaPhieu.Text = txtTimMaSach.Text = txtTimUser.Text = txtMaPhieu.Text
                = txtMaSach.Text = txtUser.Text = "";
            cbTrangThai.SelectedIndex = 0;
            cbThoiHan.SelectedIndex = -1;
            lbNgayTraDK.Text = "01/01/2000";
            dtNgayMuon.Value = DateTime.Now;
            dtNgayTraTT.Value = DateTime.Now;
            rdDangMuon.Checked = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool loi = false;
            errp.Clear();
            if(txtMaPhieu.Text=="")
            {
                errp.SetError(txtMaPhieu, "Vui lòng nhập mã phiếu!");
                loi = true;
            }
            PhieuMuon p1 = dsPhieuMuon.Find(p => p.MaPhieu == txtMaPhieu.Text);
            if(p1!=null)
            {
                errp.SetError(txtMaPhieu, "Mã phiếu đã tồn tại!");
                loi=true;
            }
            Sach s1 = dsSach.Find(s => s.MaSach == txtMaSach.Text);
            if (s1 == null)
            {
                errp.SetError(txtMaSach, "Mã sách không tồn tại!");
                loi=true;
            }
            
            User u1 = dsUser.Find(u => u.TenDangNhap == txtUser.Text);
            if (u1 == null)
            {
                errp.SetError(txtUser, "Tên user không tồn tại!");
                loi = true;
            }
            if (cbThoiHan.SelectedIndex == -1)
            {
                errp.SetError(cbThoiHan, "Vui lòng chọn thời hạn!");
                loi = true;
            }
            if(rdDaTra.Checked && dtNgayTraTT.Value.CompareTo(dtNgayMuon.Value)<0)
            {
                errp.SetError(dtNgayTraTT, "Ngày trả không thể trước ngày mượn!");
                loi = true;
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
                ngayTraDK = dtNgayMuon.Value.AddMonths(1);
            else
                ngayTraDK = dtNgayMuon.Value.AddMonths(3);

            string trangThai;
            DateTime? ngayTraTT;
            if (rdDangMuon.Checked)
            {
                trangThai = "Đang mượn";
                ngayTraTT = null;
            }
            else if (dtNgayTraTT.Value.CompareTo(ngayTraDK)<=0)
            {
                trangThai = "Đã trả (đúng hạn)";
                ngayTraTT = dtNgayTraTT.Value;
            }
            else
            {
                trangThai = "Đã trả (quá hạn)";
                ngayTraTT = dtNgayTraTT.Value;
            }

            PhieuMuon phieuMoi = new PhieuMuon(txtMaPhieu.Text, txtMaSach.Text, txtUser.Text, dtNgayMuon.Value, ngayTraDK, trangThai, ngayTraTT);
            dsPhieuMuon.Add(phieuMoi);
            
            string tenSach = s1.TenSach;
            ListViewItem it = new ListViewItem(phieuMoi.MaPhieu);
            it.SubItems.Add(phieuMoi.TenDangNhap);
            it.SubItems.Add(phieuMoi.MaSach);
            it.SubItems.Add(tenSach);
            it.SubItems.Add(phieuMoi.NgayMuon.ToString("dd/MM/yyyy"));
            it.SubItems.Add(phieuMoi.NgayTraDuKien.ToString("dd/MM/yyyy"));
            it.SubItems.Add(phieuMoi.NgayTraThucTe?.ToString("dd/MM/yyyy") ?? "Chưa trả");
            it.SubItems.Add(phieuMoi.TrangThai);
            lvPhieuMuon.Items.Add(it);

            s1.SoLuongConLai -= 1;
            TaoMaPhieu();
            lbThongBao.Text = "Thêm thành công!";
            timer1.Enabled = true;
        }

        private void rdDangMuon_CheckedChanged(object sender, EventArgs e)
        {
            lbNgayTraTT.Visible = dtNgayTraTT.Visible = !rdDangMuon.Checked;
        }

        private void cbThoiHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhapNgayTraDK();
        }

        private void dtNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            CapNhapNgayTraDK();
        }
        private void CapNhapNgayTraDK()
        {
            if (cbThoiHan.SelectedIndex == 0)
                lbNgayTraDK.Text = dtNgayMuon.Value.AddMonths(1).ToString("dd/MM/yyyy");
            else if (cbThoiHan.SelectedIndex == 1)
                lbNgayTraDK.Text = dtNgayMuon.Value.AddMonths(3).ToString("dd/MM/yyyy");
        }

        private void cbTaoTuDong_CheckedChanged(object sender, EventArgs e)
        {
            TaoMaPhieu();
        }
        private void TaoMaPhieu()
        {
            if (cbTaoTuDong.Checked)
            {
                int i = 1;
                while (dsPhieuMuon.Any(p => p.MaPhieu == string.Format("MP{0:D3}", i)))
                {
                    i++;
                }
                string maPhieu = string.Format("MP{0:D3}", i);
                txtMaPhieu.Text = maPhieu;
                txtMaPhieu.ReadOnly = true;
            }
            else
            {
                txtMaPhieu.Text = "";
                txtMaPhieu.ReadOnly = false;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            errp.Clear();
            if (txtMaPhieu.Text == "")
            {
                errp.SetError(txtMaPhieu, "Vui lòng nhập mã phiếu!");
                return;
            }
            PhieuMuon p1 = dsPhieuMuon.Find(p => p.MaPhieu == txtMaPhieu.Text);
            if (p1 == null)
            {
                errp.SetError(txtMaPhieu, "Mã phiếu không tồn tại!");
                return;
            }
            dsPhieuMuon.Remove(p1);
            foreach (ListViewItem i in lvPhieuMuon.Items)
            {
                if (i.Text == p1.MaPhieu)
                {
                    lvPhieuMuon.Items.Remove(i);
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
            PhieuMuon p1 = dsPhieuMuon.Find(p => p.MaPhieu == txtMaPhieu.Text);
            if (p1 == null)
            {
                errp.SetError(txtMaPhieu, "Mã phiếu không tồn tại!");
                loi = true;
            }
            Sach s1 = dsSach.Find(s => s.MaSach == txtMaSach.Text);
            if (s1 == null)
            {
                errp.SetError(txtMaSach, "Mã sách không tồn tại!");
                loi = true;
            }
            User u1 = dsUser.Find(u => u.TenDangNhap == txtUser.Text);
            if (u1 == null)
            {
                errp.SetError(txtUser, "Tên user không tồn tại!");
                loi = true;
            }
            if (cbThoiHan.SelectedIndex == -1)
            {
                errp.SetError(cbThoiHan, "Vui lòng chọn thời hạn!");
                loi = true;
            }
            if (rdDaTra.Checked && dtNgayTraTT.Value.CompareTo(dtNgayMuon.Value) < 0)
            {
                errp.SetError(dtNgayTraTT, "Ngày trả không thể trước ngày mượn!");
                loi = true;
            }
            if (loi)
                return;
            DateTime ngayTraDK;
            if (cbThoiHan.SelectedIndex == 0)
                ngayTraDK = dtNgayMuon.Value.AddMonths(1);
            else
                ngayTraDK = dtNgayMuon.Value.AddMonths(3);

            string trangThai;
            DateTime? ngayTraTT;
            if (rdDangMuon.Checked)
            {
                trangThai = "Đang mượn";
                ngayTraTT = null;
            }
            else if (dtNgayTraTT.Value.CompareTo(ngayTraDK) <= 0)
            {
                trangThai = "Đã trả (đúng hạn)";
                ngayTraTT = dtNgayTraTT.Value;
            }
            else
            {
                trangThai = "Đã trả (quá hạn)";
                ngayTraTT = dtNgayTraTT.Value;
            }

            p1.MaSach = txtMaSach.Text;
            p1.TenDangNhap = txtUser.Text;
            p1.NgayMuon = dtNgayMuon.Value;
            p1.NgayTraDuKien = ngayTraDK;
            p1.NgayTraThucTe = ngayTraTT;
            p1.TrangThai = trangThai;

            foreach(ListViewItem i in lvPhieuMuon.Items)
            {
                if(i.Text == txtMaPhieu.Text)
                {
                    i.SubItems[1].Text = txtUser.Text;
                    i.SubItems[2].Text = txtMaSach.Text;
                    i.SubItems[3].Text = s1.TenSach;
                    i.SubItems[4].Text = dtNgayMuon.Value.ToString("dd/MM/yyyy");
                    i.SubItems[5].Text = lbNgayTraDK.Text;
                    i.SubItems[6].Text = p1.NgayTraThucTe?.ToString("dd/MM/yyyy") ?? "Chưa trả";
                    i.SubItems[7].Text = p1.TrangThai;
                    break;
                }
            }
            lbThongBao.Text = "Sửa thành công!";
            timer1.Enabled = true;
        }

        private void lvPhieuMuon_DoubleClick(object sender, EventArgs e)
        {
            if (lvPhieuMuon.SelectedItems.Count > 0)
            {
                ListViewItem it = lvPhieuMuon.SelectedItems[0];
                txtMaPhieu.Text = it.Text;
                txtUser.Text = it.SubItems[1].Text;
                txtMaSach.Text = it.SubItems[2].Text;
                DateTime ngayMuon= DateTime.ParseExact(it.SubItems[4].Text, "dd/MM/yyyy",
                                 System.Globalization.CultureInfo.InvariantCulture);
                DateTime ngayTraDK= DateTime.ParseExact(it.SubItems[5].Text, "dd/MM/yyyy",
                                 System.Globalization.CultureInfo.InvariantCulture);
                dtNgayMuon.Value = ngayMuon;
                if (dtNgayMuon.Value.AddMonths(1).Equals(ngayTraDK))
                    cbThoiHan.SelectedIndex = 0;
                else
                    cbThoiHan.SelectedIndex = 1;
                lbNgayTraDK.Text = it.SubItems[5].Text;
                if(it.SubItems[6].Text=="Chưa trả")
                {
                    rdDangMuon.Checked = true;
                }
                else
                {
                    rdDaTra.Checked = true;
                    dtNgayTraTT.Value = DateTime.ParseExact(it.SubItems[6].Text, "dd/MM/yyyy",
                                 System.Globalization.CultureInfo.InvariantCulture);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            timer1.Enabled = false;
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "File txt|*.txt";
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dsPhieuMuon.Clear();
                    dsPhieuMuon.AddRange(QuanLyTep.docFilePhieuMuon(dlg.FileName));
                    hienThiPhieuMuon(dsPhieuMuon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTep.luuDSPhieuMuon("phieumuon.txt", dsPhieuMuon);
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "File txt|*.txt";
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    QuanLyTep.luuDSPhieuMuon(dlg.FileName, dsPhieuMuon);
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
