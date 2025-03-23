using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class User
    {
        private string tenDangNhap;
        private string matKhau;
        private string hoTen;
        private DateTime ngaySinh;
        private string queQuan;
        private string diaChi;
        private string soDienThoai;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public User(string tenDangNhap, string matKhau, string hoTen, DateTime ngaySinh, string queQuan, string diaChi, string soDienThoai)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.queQuan = queQuan;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
        }
    }
}
