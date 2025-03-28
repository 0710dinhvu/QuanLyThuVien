using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class PhieuMuon
    {
        private string maPhieu;
        private string maSach;
        private string tenDangNhap;
        private DateTime ngayMuon;
        private DateTime ngayTraDuKien;
        private string trangThai;
        private DateTime? ngayTraThucTe;

        public string MaPhieu
        {
            get
            {
                return maPhieu;
            }

            set
            {
                maPhieu = value;
            }
        }

        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public string TenDangNhap
        {
            get
            {
                return tenDangNhap;
            }

            set
            {
                tenDangNhap = value;
            }
        }

        public DateTime NgayMuon
        {
            get
            {
                return ngayMuon;
            }

            set
            {
                ngayMuon = value;
            }
        }

        public DateTime NgayTraDuKien
        {
            get
            {
                return ngayTraDuKien;
            }

            set
            {
                ngayTraDuKien = value;
            }
        }

        public DateTime? NgayTraThucTe
        {
            get
            {
                return ngayTraThucTe;
            }

            set
            {
                ngayTraThucTe = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public PhieuMuon(string maPhieu, string maSach, string tenDangNhap, DateTime ngayMuon,
            DateTime ngayTraDuKien, string trangThai, DateTime? ngayTraThucTe = null)
        {
            this.maPhieu = maPhieu;
            this.maSach = maSach;
            this.tenDangNhap = tenDangNhap;
            this.ngayMuon = ngayMuon;
            this.ngayTraDuKien = ngayTraDuKien;
            this.trangThai = trangThai;
            this.ngayTraThucTe = ngayTraThucTe;
        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5},{6}", maPhieu, maSach, tenDangNhap,
                ngayMuon.ToString("dd/MM/yyyy"), ngayTraDuKien.ToString("dd/MM/yyyy"),
                trangThai, NgayTraThucTe?.ToString("dd/MM/yyyy") ?? "");
        }
    }
}
