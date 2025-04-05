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
    public partial class FrmThongKe : Form
    {
        List<PhieuMuon> dsPhieuMuon;
        int[] data;
        public FrmThongKe()
        {
            InitializeComponent();
        }
        public FrmThongKe(List<PhieuMuon> dsPhieuMuon):this()
        {
            this.dsPhieuMuon = dsPhieuMuon;
        }
        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            data = TinhLuotMuon(DateTime.Now.Year);
            HienThiNam();
        }

        private void HienThiNam()
        {
            int namBD = 2023;
            for(int i=namBD;i<= DateTime.Now.Year; i++)
            {
                cbNam.Items.Add(i.ToString());
            }
            cbNam.SelectedIndex = cbNam.Items.Count - 1;
        }
        private int[] TinhLuotMuon(int nam)
        {
            int[] duLieu = new int[12];
            for(int i = 0; i < 12; i++)
            {
                duLieu[i]= dsPhieuMuon.Count(p => p.NgayMuon.Year == nam && p.NgayMuon.Month==i+1);
            }
            return duLieu;
        }

        private void FrmThongKe_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            Font fontNhat = new Font("Arial", 11);
            Font fontDam = new Font("Arial", 12,FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.FromArgb(255, 103, 105));
            Pen pen = new Pen(Color.Black, 2);

            int rongCot = 42; 
            int khoangCach = 27;
            int startX = 40;
            int startY = 600;
            int maxHeight = 400;

            int cotMax = data.Max();

            // X
            g.DrawLine(pen, startX, startY, startX + (rongCot + khoangCach) * 12, startY);
            g.DrawString("Tháng", fontDam, Brushes.Blue, startX + (rongCot + khoangCach) * 12, startY-10);

            //Y
            g.DrawLine(pen, startX, startY, startX, startY - maxHeight - 50);
            g.DrawString("Số lượng", fontDam, Brushes.Blue, startX-35, startY - maxHeight - 70);
            

            

            for (int i = 0; i < 12; i++)
            {
                int chieuCaoCot;
                if (cotMax != 0)
                    chieuCaoCot = (int)((float)data[i] * maxHeight / cotMax);
                else
                    chieuCaoCot = 0;
                int x = startX + i * (rongCot + khoangCach) + khoangCach / 2;
                int y = startY - chieuCaoCot;
                g.FillRectangle(br, x, y, rongCot, chieuCaoCot);

                // Vẽ số
                Rectangle rc1 = new Rectangle(x, y - 25, rongCot, 25);
                g.DrawString(data[i].ToString(), fontNhat, Brushes.Black, rc1,fm);

                // Vẽ tháng
                Rectangle rc2 = new Rectangle(x, startY, rongCot, 25);
                g.DrawString("Th" + (i + 1), fontNhat, Brushes.Black, rc2,fm);

            }

        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            data = TinhLuotMuon(int.Parse(cbNam.Text));
            Invalidate();
        }
    }
}
