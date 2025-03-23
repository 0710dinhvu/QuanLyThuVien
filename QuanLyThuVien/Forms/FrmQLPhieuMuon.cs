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
        public FrmQLPhieuMuon()
        {
            InitializeComponent();
        }
        public FrmQLPhieuMuon(List<Sach> dsSach, List<User> dsUser, List<PhieuMuon> dsPhieuMuon) :this()
        {
            this.dsSach = dsSach;
            this.dsUser = dsUser;
            this.dsPhieuMuon = dsPhieuMuon;
        }
    }
}
