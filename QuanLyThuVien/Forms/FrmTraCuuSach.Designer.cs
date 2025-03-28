namespace QuanLyThuVien.Forms
{
    partial class FrmTraCuuSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "S001",
            "Đêm Trường Tăm Tối",
            "Tử Kim Trần",
            "2013",
            "Trinh thám",
            "5",
            "3"}, -1);
            this.lvSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btTimNhanh = new System.Windows.Forms.Button();
            this.txtTimNhanh = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btTimNC = new System.Windows.Forms.Button();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSach
            // 
            this.lvSach.BackColor = System.Drawing.Color.AliceBlue;
            this.lvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSach.FullRowSelect = true;
            this.lvSach.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSach.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvSach.Location = new System.Drawing.Point(0, 265);
            this.lvSach.Name = "lvSach";
            this.lvSach.Size = new System.Drawing.Size(1242, 527);
            this.lvSach.TabIndex = 0;
            this.lvSach.UseCompatibleStateImageBehavior = false;
            this.lvSach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sách";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 251;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tác giả";
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm XB";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thể loại";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SL còn lại";
            this.columnHeader7.Width = 99;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1242, 267);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btTimNhanh);
            this.tabPage1.Controls.Add(this.txtTimNhanh);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1234, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm nhanh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm nhanh";
            // 
            // btTimNhanh
            // 
            this.btTimNhanh.BackgroundImage = global::QuanLyThuVien.Properties.Resources.search;
            this.btTimNhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTimNhanh.Location = new System.Drawing.Point(937, 82);
            this.btTimNhanh.Name = "btTimNhanh";
            this.btTimNhanh.Size = new System.Drawing.Size(45, 43);
            this.btTimNhanh.TabIndex = 1;
            this.btTimNhanh.UseVisualStyleBackColor = true;
            this.btTimNhanh.Click += new System.EventHandler(this.btTimNhanh_Click);
            // 
            // txtTimNhanh
            // 
            this.txtTimNhanh.BackColor = System.Drawing.Color.Honeydew;
            this.txtTimNhanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNhanh.Location = new System.Drawing.Point(394, 88);
            this.txtTimNhanh.Name = "txtTimNhanh";
            this.txtTimNhanh.Size = new System.Drawing.Size(516, 31);
            this.txtTimNhanh.TabIndex = 0;
            this.txtTimNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.btClear);
            this.tabPage2.Controls.Add(this.btTimNC);
            this.tabPage2.Controls.Add(this.cbTheLoai);
            this.tabPage2.Controls.Add(this.numEnd);
            this.tabPage2.Controls.Add(this.numStart);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtTacGia);
            this.tabPage2.Controls.Add(this.txtTenSach);
            this.tabPage2.Controls.Add(this.txtMaSach);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1234, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm nâng cao";
            // 
            // btTimNC
            // 
            this.btTimNC.BackgroundImage = global::QuanLyThuVien.Properties.Resources.search;
            this.btTimNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTimNC.Location = new System.Drawing.Point(1021, 131);
            this.btTimNC.Name = "btTimNC";
            this.btTimNC.Size = new System.Drawing.Size(45, 42);
            this.btTimNC.TabIndex = 4;
            this.btTimNC.UseVisualStyleBackColor = true;
            this.btTimNC.Click += new System.EventHandler(this.btTimNC_Click);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(782, 139);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(163, 28);
            this.cbTheLoai.TabIndex = 3;
            // 
            // numEnd
            // 
            this.numEnd.Location = new System.Drawing.Point(782, 89);
            this.numEnd.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numEnd.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(163, 27);
            this.numEnd.TabIndex = 2;
            this.numEnd.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(782, 38);
            this.numStart.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numStart.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(163, 27);
            this.numStart.TabIndex = 2;
            this.numStart.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Năm xuất bản: Đến năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Năm xuất bản: Từ năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(282, 136);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(201, 27);
            this.txtTacGia.TabIndex = 0;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(282, 85);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(201, 27);
            this.txtTenSach.TabIndex = 0;
            // 
            // txtMaSach
            // 
            this.txtMaSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaSach.Location = new System.Drawing.Point(282, 34);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(201, 27);
            this.txtMaSach.TabIndex = 0;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.LightCyan;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(878, 173);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(67, 39);
            this.btClear.TabIndex = 52;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // FrmTraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1242, 792);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lvSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTraCuuSach";
            this.Text = "FrmTraCuuSach";
            this.Load += new System.EventHandler(this.FrmTraCuuSach_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btTimNhanh;
        private System.Windows.Forms.TextBox txtTimNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btTimNC;
        private System.Windows.Forms.Button btClear;
    }
}