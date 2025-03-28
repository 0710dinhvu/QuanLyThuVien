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
    public partial class FrmTraCuuSach : Form
    {
        private List<Sach> dsSach;
        private List<TheLoai> dsTheLoai;
        public FrmTraCuuSach()
        {
            InitializeComponent();
        }

        public FrmTraCuuSach(List<Sach> dsSach, List<TheLoai> dsTheLoai) : this()
        {
            this.dsSach = dsSach;
            this.dsTheLoai = dsTheLoai;
        }

        private void FrmTraCuuSach_Load(object sender, EventArgs e)
        {
            hienThiSach(dsSach);
            hienThiTheLoai();
            numEnd.Value = numEnd.Maximum = numStart.Maximum = DateTime.Now.Year;
        }

        private void hienThiSach(List<Sach> ds)
        {
            lvSach.Items.Clear();
            foreach(Sach s in ds)
            {
                TheLoai t = dsTheLoai.Find(t1 => t1.MaTheLoai == s.MaTheLoai);
                string tenTL;
                if (t == null)
                    tenTL = "Khác";
                else
                    tenTL = t.TenTheLoai;
                ListViewItem it = new ListViewItem(s.MaSach);
                it.SubItems.Add(s.TenSach);
                it.SubItems.Add(s.TacGia);
                it.SubItems.Add(s.NamXuatBan.ToString());
                it.SubItems.Add(tenTL);
                it.SubItems.Add(s.SoLuong.ToString());
                it.SubItems.Add(s.SoLuongConLai.ToString());

                lvSach.Items.Add(it);
            }
        }
        private void hienThiTheLoai()
        {
            cbTheLoai.Items.Add("Tất cả");
            foreach (TheLoai tl in dsTheLoai)
            {
                cbTheLoai.Items.Add(tl.TenTheLoai);
            }
            cbTheLoai.Items.Add("Khác");
            cbTheLoai.SelectedIndex = 0;
        }

        private void btTimNC_Click(object sender, EventArgs e)
        {
            List<Sach> ds = dsSach.FindAll(s =>
            {
                string tenTL;
                TheLoai tl = dsTheLoai.Find(t => t.MaTheLoai == s.MaTheLoai);
                if (tl != null)
                    tenTL = tl.TenTheLoai;
                else
                    tenTL = "Khác";
                return s.MaSach.IndexOf(txtMaSach.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0
                && s.TenSach.IndexOf(txtTenSach.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0
                && s.TacGia.IndexOf(txtTacGia.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0
                && s.NamXuatBan >= numStart.Value
                && s.NamXuatBan <= numEnd.Value
                && (cbTheLoai.Text == "Tất cả" || tenTL == cbTheLoai.Text);
            });
            hienThiSach(ds);
        }

        private void btTimNhanh_Click(object sender, EventArgs e)
        {
            List<Sach> ds = dsSach.FindAll(s =>
            {
                string tenTL = dsTheLoai.Find(tl => tl.MaTheLoai == s.MaTheLoai).TenTheLoai;
                return s.MaSach.IndexOf(txtTimNhanh.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0
                || s.TenSach.IndexOf(txtTimNhanh.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0
                || s.TacGia.IndexOf(txtTimNhanh.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0
                || tenTL.IndexOf(txtTimNhanh.Text.Trim(), StringComparison.OrdinalIgnoreCase)>=0;
            });
            hienThiSach(ds);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = txtTacGia.Text = txtTenSach.Text = "";
            cbTheLoai.SelectedIndex = 0;
            numStart.Value = 1000;
            numEnd.Value = DateTime.Now.Year;
        }
    }
}
