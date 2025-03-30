using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;
using OfficeOpenXml;
using System.Linq;
using System.Xml.Linq;


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
            if (link.EndsWith(".txt"))
                luuDSSachTXT(link, dsSach);
            else if (link.EndsWith(".docx"))
                luuDSSachDocx(link, dsSach);
            else if (link.EndsWith(".xlsx") || link.EndsWith(".xlsm"))
                luuDSSachExcel(link, dsSach);
            else if (link.EndsWith(".xml"))
                luuDSSachXml(link, dsSach);
                
        }
        private static void luuDSSachTXT(string link, List<Sach> dsSach)
        {
            using (StreamWriter sw = new StreamWriter(link))
            {
                foreach (var s in dsSach)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }
        private static void luuDSSachDocx(string link, List<Sach> dsSach)
        {
            using(DocX data= DocX.Create(link))
            {
                foreach(Sach s in dsSach)
                {
                    data.InsertParagraph(s.ToString());
                }
                data.Save();
            }
        }
        private static void luuDSSachExcel(string link, List<Sach> dsSach) 
        {
            ExcelPackage.License.SetNonCommercialOrganization("Bài tập nhóm");
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets.Add("Sheet1");
                sheet.Cells[1, 1].Value = "Mã sách";
                sheet.Cells[1, 2].Value = "Tên sách";
                sheet.Cells[1, 3].Value = "Tác giả";
                sheet.Cells[1, 4].Value = "Năm XB";
                sheet.Cells[1, 5].Value = "Mã thể loại";
                sheet.Cells[1, 6].Value = "Số lượng";
                sheet.Cells[1, 7].Value = "Số lượng còn lại";
                int row = 2;
                foreach(Sach s in dsSach)
                {
                    sheet.Cells[row, 1].Value = s.MaSach;
                    sheet.Cells[row, 2].Value = s.TenSach;
                    sheet.Cells[row, 3].Value = s.TacGia;
                    sheet.Cells[row, 4].Value = s.NamXuatBan;
                    sheet.Cells[row, 5].Value = s.MaTheLoai;
                    sheet.Cells[row, 6].Value = s.SoLuong;
                    sheet.Cells[row, 7].Value = s.SoLuongConLai;
                    row++;
                }
                File.WriteAllBytes(link, package.GetAsByteArray());
            }
        }
        private static void luuDSSachXml(string link, List<Sach> dsSach)
        {
            XDocument doc = new XDocument(new XElement("Library", dsSach.ConvertAll(s=>
                new XElement("Sach",
                    new XElement("maSach", s.MaSach),
                    new XElement("tenSach", s.TenSach),
                    new XElement("tacGia",s.TacGia),
                    new XElement("namXuatBan",s.NamXuatBan),
                    new XElement("maTheLoai",s.MaTheLoai),
                    new XElement("soLuong",s.SoLuong),
                    new XElement("soLuongConLai", s.SoLuongConLai)
                    )
            )));
            doc.Save(link);
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
        public static List<Sach> DocFileSach(string link)
        {
            if (link.EndsWith(".txt"))
                return docFileSachTXT(link);
            else if (link.EndsWith(".docx"))
                return docFileSachDOCX(link);
            else if (link.EndsWith(".xlsx") || link.EndsWith(".xlsm"))
                return docFileSachExcel(link);
            else if (link.EndsWith(".xml"))
                return docFileSachXML(link);
            return null;
        }
        private static List<Sach> docFileSachTXT(string link)
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
        private static List<Sach> docFileSachDOCX(string link)
        {
            List<Sach> dsSach = new List<Sach>();
            string[] parts;
            using (DocX data = DocX.Load(link))
            {
                foreach (var line in data.Paragraphs)
                {
                    parts = line.Text.Split(',');
                    Sach s;
                    if (parts.Length == 7)
                    {
                        s = new Sach(parts[0], parts[1], parts[2], int.Parse(parts[3]), parts[4], int.Parse(parts[5]), int.Parse(parts[6]));
                        dsSach.Add(s);
                    }
                }
            }
            return dsSach;
        }
        private static List<Sach> docFileSachExcel(string link)
        {
           

            List<Sach> dsSach = new List<Sach>();
            ExcelPackage.License.SetNonCommercialOrganization("Bài tập nhóm");
            using (ExcelPackage package = new ExcelPackage(new FileInfo(link)))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets[0];

                int rowCount = sheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    Sach s = new Sach();
                    s.MaSach = sheet.Cells[row, 1].Text;
                    s.TenSach = sheet.Cells[row, 2].Text;
                    s.TacGia = sheet.Cells[row, 3].Text;
                    s.NamXuatBan = int.Parse(sheet.Cells[row, 4].Text);
                    s.MaTheLoai = sheet.Cells[row, 5].Text;
                    s.SoLuong = int.Parse(sheet.Cells[row, 6].Text);
                    s.SoLuongConLai = int.Parse(sheet.Cells[row, 7].Text);

                    dsSach.Add(s);
                }
            }
            return dsSach;
        }
        private static List<Sach> docFileSachXML(string link)
        {
            XDocument doc = XDocument.Load(link);
            return doc.Descendants("Sach").Select(b => new Sach()
            {
                MaSach = b.Element("maSach")?.Value,
                TenSach = b.Element("tenSach")?.Value,
                TacGia = b.Element("tacGia")?.Value,
                NamXuatBan = int.Parse(b.Element("namXuatBan")?.Value ?? "0"),
                MaTheLoai = b.Element("maTheLoai")?.Value,
                SoLuong = int.Parse(b.Element("soLuong")?.Value ?? "0"),
                SoLuongConLai = int.Parse(b.Element("soLuongConLai")?.Value ?? "0")
            }).ToList();
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
                                System.Globalization.CultureInfo.InvariantCulture);
                    User user = new User(parts[0], parts[1], parts[2], ngaySinh, parts[4], parts[5], parts[6]);
                    dsUser.Add(user);
                }
            }
            return dsUser;
        }
    }
}
