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
    public partial class FrmQLTheLoai : Form
    {
        List<TheLoai> dsTheLoai;
        List<Sach> dsSach;
        List<PhieuMuon> dsPhieuMuon;
        FrmMain fMain;
        public FrmQLTheLoai()
        {
            InitializeComponent();
        }
        public FrmQLTheLoai(List<TheLoai> dsTheLoai, List<Sach> dsSach,
            List<PhieuMuon> dsPhieuMuon,FrmMain fMain):this()
        {
            this.dsTheLoai = dsTheLoai;
            this.dsSach = dsSach;
            this.dsPhieuMuon = dsPhieuMuon;
            this.fMain = fMain;
        }

        private void FrmQLTheLoai_Load(object sender, EventArgs e)
        {
            HienThiTheLoai(dsTheLoai);
        }
        private void HienThiTheLoai(List<TheLoai> ds)
        {
            lvTheLoai.Items.Clear();
            foreach(TheLoai tl in ds)
            {
                int sl = 0, slMuon = 0;
                List<Sach> dsSach2 = dsSach.FindAll(s => s.MaTheLoai == tl.MaTheLoai);
                sl = dsSach2.Count;
                slMuon = dsPhieuMuon.FindAll(p => dsSach2.Any(s=>p.MaSach==s.MaSach)).Count;
                ListViewItem it = new ListViewItem(tl.MaTheLoai);
                it.SubItems.Add(tl.TenTheLoai);
                it.SubItems.Add(sl.ToString());
                it.SubItems.Add(slMuon.ToString());
                lvTheLoai.Items.Add(it);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool loi = false;
            errp.Clear();
            if (txtMaTL.Text == "")
            {
                errp.SetError(txtMaTL, "Vui lòng nhập mã thể loại!");
                loi=true;
            }
            TheLoai tl1 = dsTheLoai.Find(tl => tl.MaTheLoai == txtMaTL.Text);
            if (tl1 != null)
            {
                errp.SetError(txtMaTL, "Mã thể loại đã tồn tại!");
                loi = true;
            }
            if (txtTenTL.Text == "")
            {
                errp.SetError(txtTenTL, "Vui lòng nhập tên thể loại!");
                loi = true;
            }
            if (loi)
                return;
            TheLoai tlMoi = new TheLoai(txtMaTL.Text, txtTenTL.Text);
            dsTheLoai.Add(tlMoi);

            ListViewItem it = new ListViewItem(txtMaTL.Text);
            it.SubItems.Add(txtTenTL.Text);
            lvTheLoai.Items.Add(it);

            lbThongBao.Text = "Thêm thành công!";
            timer1.Enabled = true;
            this.btClear_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            timer1.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            errp.Clear();
            if (txtMaTL.Text == "")
            {
                errp.SetError(txtMaTL, "Vui lòng nhập mã thể loại!");
                return;
            }
            TheLoai tl1 = dsTheLoai.Find(tl => tl.MaTheLoai == txtMaTL.Text);
            if (tl1 == null)
            {
                errp.SetError(txtMaTL, "Mã thể loại không tồn tại!");
                return;
            }

            dsTheLoai.Remove(tl1);
            foreach (ListViewItem i in lvTheLoai.Items)
            {
                if(i.Text==txtMaTL.Text)
                {
                    lvTheLoai.Items.Remove(i);
                    break;
                }
            }
            lbThongBao.Text = "Xóa thành công!";
            timer1.Enabled = true;
            this.btClear_Click(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            bool loi = false;
            errp.Clear();
            TheLoai tl1 = dsTheLoai.Find(tl => tl.MaTheLoai == txtMaTL.Text);
            if (tl1 == null)
            {
                errp.SetError(txtMaTL, "Mã thể loại không tồn tại!");
                loi = true;
            }
            if (txtTenTL.Text == "")
            {
                errp.SetError(txtTenTL, "Vui lòng nhập tên thể loại!");
                loi = true;
            }
            if (loi)
                return;
            tl1.TenTheLoai = txtTenTL.Text;
            foreach (ListViewItem i in lvTheLoai.Items)
            {
                if (i.Text == txtMaTL.Text)
                {
                    i.SubItems[1].Text = txtTenTL.Text;
                    break;
                }
            }
            lbThongBao.Text = "Sửa thành công!";
            timer1.Enabled = true;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<TheLoai> ds = dsTheLoai.FindAll(tl => tl.MaTheLoai.IndexOf(txtTim.Text, StringComparison.OrdinalIgnoreCase) >= 0
            || tl.TenTheLoai.IndexOf(txtTim.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            HienThiTheLoai(ds);
        }

        private void TaoMaTheLoai()
        {
            if (cbTaoTuDong.Checked)
            {
                int i = 1;
                while (dsTheLoai.Any(tl => tl.MaTheLoai == string.Format("TL{0:D3}", i)))
                {
                    i++;
                }
                string maTL = string.Format("TL{0:D3}", i);
                txtMaTL.Text = maTL;
                txtMaTL.ReadOnly = true;
            }
            else
            {
                txtMaTL.Text = "";
                txtMaTL.ReadOnly = false;
            }
        }

        private void cbTaoTuDong_CheckedChanged(object sender, EventArgs e)
        {
            TaoMaTheLoai();
        }

        private void lvTheLoai_DoubleClick(object sender, EventArgs e)
        {
            if (lvTheLoai.SelectedItems.Count > 0)
            {
                ListViewItem it = lvTheLoai.SelectedItems[0];
                txtMaTL.Text = it.Text;
                txtTenTL.Text = it.SubItems[1].Text;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            errp.Clear();
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtMaTL.Focus();
            TaoMaTheLoai();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "File txt|*.txt";
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dsTheLoai.Clear();
                    dsTheLoai.AddRange(QuanLyTep.docFileTheLoai(dlg.FileName));
                    HienThiTheLoai(dsTheLoai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTep.luuDSTheLoai(Application.StartupPath + @"\theloai.txt", dsTheLoai);
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "File txt|*.txt";
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    QuanLyTep.luuDSTheLoai(dlg.FileName, dsTheLoai);
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
