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
    }
}
