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
    public partial class FrmTaiKhoan : Form
    {
        User user;
        List<User> dsUser;
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }
        public FrmTaiKhoan(User user, List<User> dsUser):this()
        {
            this.user = user;
            this.dsUser = dsUser;
        }
    }
}
