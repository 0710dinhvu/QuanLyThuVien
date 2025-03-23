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
        public FrmThongKe()
        {
            InitializeComponent();
        }
        public FrmThongKe(List<PhieuMuon> dsPhieuMuon):this()
        {
            this.dsPhieuMuon = dsPhieuMuon;
        }
    }
}
