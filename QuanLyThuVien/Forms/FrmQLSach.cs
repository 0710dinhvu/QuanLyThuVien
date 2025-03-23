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
    }
}
