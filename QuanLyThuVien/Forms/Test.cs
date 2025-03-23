using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            this.Width = 300;
            this.Height = 200;

            txtSearch = new TextBox { Left = 20, Top = 20, Width = 200 };
            txtSearch.TextChanged += TxtSearch_TextChanged;

            lstSuggestions = new ListBox { Left = 20, Top = 50, Width = 200, Height = 100 };
            lstSuggestions.Visible = false;
            lstSuggestions.Click += LstSuggestions_Click;

            this.Controls.Add(txtSearch);
            this.Controls.Add(lstSuggestions);
        }

        private TextBox txtSearch;
        private ListBox lstSuggestions;
        private List<string> bookCodes = new List<string> { "B001", "B002", "B003", "A123", "C456" };
        

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var results = bookCodes.Where(code => code.ToLower().Contains(query)).ToList();

            lstSuggestions.Items.Clear();
            if (results.Count > 0 && !string.IsNullOrEmpty(query))
            {
                lstSuggestions.Items.AddRange(results.ToArray());
                lstSuggestions.Visible = true;
            }
            else
            {
                lstSuggestions.Visible = false;
            }
        }

        private void LstSuggestions_Click(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItem != null)
            {
                txtSearch.Text = lstSuggestions.SelectedItem.ToString();
                lstSuggestions.Visible = false;
            }
        }
    }
}
