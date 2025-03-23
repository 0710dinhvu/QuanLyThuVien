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
    public partial class FrmQLUser : Form
    {
        List<User> dsUser;
        public FrmQLUser()
        {
            InitializeComponent();
        }
        public FrmQLUser(List<User> dsUser):this()
        {
            this.dsUser = dsUser;
        }
    }
}
