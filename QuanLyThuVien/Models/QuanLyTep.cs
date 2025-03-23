using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Models
{
    public class QuanLyTep
    {
        //phải xử lý ngoại lệ lỗi đọc ghi file ở form
        public static void luuDSUser(string link, List<User> dsUser)
        {
            using (StreamWriter sw = new StreamWriter(link))
            {
                foreach (var u in dsUser)
                {
                    sw.WriteLine(u.ToString());
                }
            }
        }
        public static void luuDSTheLoai(string link, List<TheLoai> dsTheLoai)
        {
            using (StreamWriter sw = new StreamWriter(link))
            {
                foreach (var tl in dsTheLoai)
                {
                    sw.WriteLine(tl.ToString());
                }
            }
        }
        public static void luuDSSach(string link, List<Sach> dsSach)
        {
            using (StreamWriter sw = new StreamWriter(link))
            {
                foreach (var s in dsSach)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }
        public static void luuDSPhieuMuon(string link, List<PhieuMuon> dsPhieuMuon)
        {
            using (StreamWriter sw = new StreamWriter(link))
            {
                foreach (var pm in dsPhieuMuon)
                {
                    sw.WriteLine(pm.ToString());
                }
            }
        }
        public static List<Sach> docFileSach(string link)
        {
            List<Sach> dsSach = new List<Sach>();
            string[] parts;
            foreach (string line in File.ReadAllLines(link))
            {
                parts = line.Split(',');
                Sach s;
                if (parts.Length == 7)
                {
                    s = new Sach(parts[0], parts[1], parts[2], int.Parse(parts[3]), parts[4], int.Parse(parts[5]), int.Parse(parts[6]));
                    dsSach.Add(s);
                }
            }
            return dsSach;
        }
        public static List<TheLoai> docFileTheLoai(string link)
        {
            List<TheLoai> dsTheLoai = new List<TheLoai>();
            foreach (string line in File.ReadAllLines(link))
            {
                string[] parts = line.Split(',');
                TheLoai tl;
                if (parts.Length == 2)
                {
                    tl = new TheLoai(parts[0], parts[1]);
                    dsTheLoai.Add(tl);
                }
            }
            return dsTheLoai;
        }
        public static List<PhieuMuon> docFilePhieuMuon(string link)
        {
            List<PhieuMuon> dsPhieuMuon = new List<PhieuMuon>();
            foreach (string line in File.ReadAllLines(link))
            {
                string[] parts = line.Split(',');
                PhieuMuon pm;
                if (parts.Length == 7)
                {
                    DateTime ngayMuon = DateTime.ParseExact(parts[3], "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture);
                    DateTime ngayTraDuKien = DateTime.ParseExact(parts[4], "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture);
                    DateTime? ngayTraThucTe;
                    if (parts[6] == "")
                        ngayTraThucTe = null;
                    else
                    {
                        ngayTraThucTe = DateTime.ParseExact(parts[6], "dd/MM/yyyy",
                            System.Globalization.CultureInfo.InvariantCulture);
                    }
                    pm = new PhieuMuon(parts[0], parts[1], parts[2],
                        ngayMuon, ngayTraDuKien, parts[5], ngayTraThucTe);
                    dsPhieuMuon.Add(pm);
                }
            }
            return dsPhieuMuon;
        }
        public static List<User> DocFileUser(string link)
        {
            List<User> dsUser = new List<User>();
            foreach (string line in File.ReadAllLines(link))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 7)
                {
                    DateTime ngaySinh = DateTime.ParseExact(parts[3], "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture); ;
                    User user = new User(parts[0], parts[1], parts[2], ngaySinh, parts[4], parts[5], parts[6]);
                    dsUser.Add(user);
                }
            }
            return dsUser;
        }
    }
}
