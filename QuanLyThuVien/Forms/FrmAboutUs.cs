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
using System.IO;
using System.Diagnostics;

namespace QuanLyThuVien.Forms
{
    public partial class FrmAboutUs : Form
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string feedback = txtFeedBack.Text.Trim();
            string filepath = "feedback.txt";
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(feedback) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int feedbackCount = 0;
                if (File.Exists(filepath))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    feedbackCount = lines.Count(line => line.StartsWith("Phản hồi #"));
                }

                feedbackCount++; // Tăng số lượng phản hồi lên
                using (StreamWriter sw = new StreamWriter(filepath, true))
                {
                    sw.WriteLine($"Phản hồi #{feedbackCount}");
                    sw.WriteLine(name);
                    sw.WriteLine(email);
                    sw.WriteLine(feedback);
                    if (rbB.Checked)
                    {
                        sw.WriteLine("Tệ");
                    } else if (rbN.Checked)
                    {
                        sw.WriteLine("Trung bình");
                    } else if (rbG.Checked)
                    {
                        sw.WriteLine("Tốt");
                    }
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    sw.WriteLine(new string('-', 50));
                    
                }
                MessageBox.Show($"Cảm ơn bạn đã gửi phản hồi!)", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtFeedBack.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phản hồi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbWA_Click(object sender, EventArgs e)
        {
            if(sender == pbYTB)
            {
                Process.Start("https://youtube.com/");
            } else if ( sender == pbFB)
            {
                Process.Start("https://facebook.com/");
            } else if (sender == pbGM)
            {
                Process.Start("https://gmail.com/");
            } else if(sender == pbWA)
            {
                Process.Start("https://web.whatsapp.com/");
            } else
            {
                Process.Start("https://github.com");
            }
        }
        
    }
}
