using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class TheLoai
    {
        private string maTheLoai;
        private string tenTheLoai;

        public string MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }

        public string TenTheLoai
        {
            get { return tenTheLoai; }
            set { tenTheLoai = value; }
        }

        public TheLoai(string maTheLoai, string tenTheLoai)
        {
            this.maTheLoai = maTheLoai;
            this.tenTheLoai = tenTheLoai;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", maTheLoai, tenTheLoai);
        }
    }
}
