using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class Sach
    {
        private string maSach;
        private string tenSach;
        private string tacGia;
        private int namXuatBan;
        private string maTheLoai;
        private int soLuong;
        private int soLuongConLai;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }

        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }

        public int NamXuatBan
        {
            get { return namXuatBan; }
            set { namXuatBan = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public int SoLuongConLai
        {
            get { return soLuongConLai; }
            set { soLuongConLai = value; }
        }

        public string MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }

        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, string maTheLoai, int soLuong, int soLuongConLai)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.namXuatBan = namXuatBan;
            this.soLuong = soLuong;
            this.soLuongConLai = soLuongConLai;
            this.maTheLoai = maTheLoai;
        }
    }
}
