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
    public partial class FrmQLSach : Form
    {
        List<Sach> dsSach;
        List<TheLoai> dsTheLoai;
        public FrmQLSach()
        {
            InitializeComponent();
        }
        public FrmQLSach(List<Sach> dsSach, List<TheLoai> dsTheLoai) : this()
        {
            this.dsSach = dsSach;
            this.dsTheLoai = dsTheLoai;
        }
        private void HienThiTheLoai()
        {
            foreach (TheLoai tl in dsTheLoai)
            {
                cbTheLoai.Items.Add(tl.TenTheLoai);
            }
            cbTheLoai.Items.Add("Khác");
        }

        private void FrmQLSach_Load(object sender, EventArgs e)
        {
            HienThiTheLoai();
            hienThiSach(dsSach);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            errp.Clear();
            txtMaSach.Text = txtTacGia.Text = txtTenSach.Text = "";
            cbTheLoai.SelectedIndex = -1;
            numNamXB.Value = 2000;
            numSL.Value = numSLConLai.Value = 0;

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<Sach> ds = dsSach.FindAll(s => s.MaSach.Contains(txtTim.Text.Trim()));
            hienThiSach(ds);
        }
        private void hienThiSach(List<Sach> ds)
        {
            lvSach.Items.Clear();
            foreach (Sach s in ds)
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

        private void btThem_Click(object sender, EventArgs e)
        {
            bool loi = false;
            errp.Clear();
            if (txtMaSach.Text == "")
            {
                errp.SetError(txtMaSach, "Vui lòng nhập mã sách!");
                loi = true;
            }
            Sach s1 = dsSach.Find(s => s.MaSach == txtMaSach.Text);
            if(s1 != null)
            {
                errp.SetError(txtMaSach, "Mã sách đã tồn tại!");
                loi = true;
            }
            if (txtTenSach.Text == "")
            {
                errp.SetError(txtTenSach, "Vui lòng nhập tên sách!");
                loi = true;
            }
            if(txtTacGia.Text == "")
            {
                errp.SetError(txtTacGia, "Vui lòng nhập tác giả!");
                loi = true;
            }
            if(cbTheLoai.SelectedIndex==-1)
            {
                errp.SetError(cbTheLoai, "Vui lòng chọn thể loại!");
                loi = true;
            }
            if (numSL.Value<numSLConLai.Value)
            {
                errp.SetError(numSLConLai, "Tổng số lượng không thể bé hơn số lượng còn lại!");
                loi = true;
            }
            if (loi)
                return;

            ThemSach();
            lbThongBao.Text = "Thêm thành công!";
            timer1.Enabled = true;
        }
        private void ThemSach()
        {
            string maTL = dsTheLoai.Find(tl => tl.TenTheLoai == cbTheLoai.Text).MaTheLoai;
            Sach sachMoi = new Sach(txtMaSach.Text.ToUpper(), txtTenSach.Text, txtTacGia.Text,
                (int)numNamXB.Value, maTL, (int)numSL.Value, (int)numSLConLai.Value);
            dsSach.Add(sachMoi);

            ListViewItem it = new ListViewItem(sachMoi.MaSach);
            it.SubItems.Add(sachMoi.TenSach);
            it.SubItems.Add(sachMoi.TacGia);
            it.SubItems.Add(sachMoi.NamXuatBan.ToString());
            it.SubItems.Add(cbTheLoai.Text);
            it.SubItems.Add(sachMoi.SoLuong.ToString());
            it.SubItems.Add(sachMoi.SoLuongConLai.ToString());
            lvSach.Items.Add(it);
            TaoMaSach();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            errp.Clear();
            if (txtMaSach.Text == "")
            {
                errp.SetError(txtMaSach, "Vui lòng nhập mã sách!");
                return;
            }
            Sach s1 = dsSach.Find(s => s.MaSach == txtMaSach.Text);
            if(s1==null)
            {
                errp.SetError(txtMaSach, "Mã sách không tồn tại!");
                return;
            }

            dsSach.Remove(s1);
            foreach(ListViewItem i in lvSach.Items)
            {
                if(i.Text == txtMaSach.Text)
                {
                    lvSach.Items.Remove(i);
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
            Sach s1 = dsSach.Find(s => s.MaSach == txtMaSach.Text);
            if (s1 == null)
            {
                errp.SetError(txtMaSach, "Mã sách không tồn tại!");
                loi = true;
            }
            if (txtTenSach.Text == "")
            {
                errp.SetError(txtTenSach, "Vui lòng nhập tên sách!");
                loi = true;
            }
            if (txtTacGia.Text == "")
            {
                errp.SetError(txtTacGia, "Vui lòng nhập tác giả!");
                loi = true;
            }
            if (cbTheLoai.SelectedIndex == -1)
            {
                errp.SetError(cbTheLoai, "Vui lòng chọn thể loại!");
                loi = true;
            }
            if (numSL.Value < numSLConLai.Value)
            {
                errp.SetError(numSLConLai, "Tổng số lượng không thể bé hơn số lượng còn lại!");
                loi = true;
            }
            if (loi)
                return;
            SuaSach(s1);
            lbThongBao.Text = "Sửa thành công!";
            timer1.Enabled = true;
        }
        private void SuaSach(Sach s)
        {
            string maTL = dsTheLoai.Find(tl => tl.TenTheLoai == cbTheLoai.Text).MaTheLoai;
            s.TenSach = txtTenSach.Text;
            s.TacGia = txtTacGia.Text;
            s.NamXuatBan = (int)numNamXB.Value;
            s.SoLuong = (int)numSL.Value;
            s.SoLuongConLai = (int)numSLConLai.Value;
            s.MaTheLoai = maTL;

            foreach (ListViewItem i in lvSach.Items)
            {
                if (i.Text == txtMaSach.Text)
                {
                    i.SubItems[1].Text = txtTenSach.Text;
                    i.SubItems[2].Text = txtTacGia.Text;
                    i.SubItems[3].Text = numNamXB.Value.ToString();
                    i.SubItems[4].Text = cbTheLoai.Text;
                    i.SubItems[5].Text = numSL.Value.ToString();
                    i.SubItems[6].Text = numSLConLai.Value.ToString();
                    break;
                }
            }
        }

        private void cbTaoTuDong_CheckedChanged(object sender, EventArgs e)
        {
            TaoMaSach();
        }
        private void TaoMaSach()
        {
            if (cbTaoTuDong.Checked)
            {
                int i = 1;
                while (dsSach.Any(s => s.MaSach == string.Format("S{0:D3}", i)))
                {
                    i++;
                }
                string maSach = string.Format("S{0:D3}", i);
                txtMaSach.Text = maSach;
                txtMaSach.ReadOnly = true;
            }
            else
            {
                txtMaSach.Text = "";
                txtMaSach.ReadOnly = false;
            }
        }

        private void lvSach_DoubleClick(object sender, EventArgs e)
        {
            if (lvSach.SelectedItems.Count > 0)
            {
                ListViewItem it = lvSach.SelectedItems[0];
                txtMaSach.Text = it.Text;
                txtTenSach.Text = it.SubItems[1].Text;
                txtTacGia.Text = it.SubItems[2].Text;
                numNamXB.Value = int.Parse(it.SubItems[3].Text);
                cbTheLoai.Text = it.SubItems[4].Text;
                numSL.Value= int.Parse(it.SubItems[5].Text);
                numSLConLai.Value = int.Parse(it.SubItems[6].Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            timer1.Enabled = false;
        }
        
    }
}
