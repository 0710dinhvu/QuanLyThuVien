namespace QuanLyThuVien.Forms
{
    partial class FrmThueSach
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "P001",
            "S001",
            "Đêm Trường Tăm Tối",
            "01/01/2022",
            "01/01/2023",
            "01/01/2024",
            "Đã trả (quá hạn)"}, -1);
            this.lvPhieuMuon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTaoPhieu = new System.Windows.Forms.Button();
            this.cbThoiHan = new System.Windows.Forms.ComboBox();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.errp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbThongBao = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errp)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPhieuMuon
            // 
            this.lvPhieuMuon.BackColor = System.Drawing.Color.AliceBlue;
            this.lvPhieuMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPhieuMuon.FullRowSelect = true;
            this.lvPhieuMuon.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPhieuMuon.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPhieuMuon.Location = new System.Drawing.Point(0, 352);
            this.lvPhieuMuon.Name = "lvPhieuMuon";
            this.lvPhieuMuon.Size = new System.Drawing.Size(1242, 440);
            this.lvPhieuMuon.TabIndex = 2;
            this.lvPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lvPhieuMuon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã sách";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sách";
            this.columnHeader3.Width = 225;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày mượn";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày trả dự kiến";
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày trả thực tế";
            this.columnHeader6.Width = 136;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Trạng thái";
            this.columnHeader7.Width = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(310, 43);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(219, 28);
            this.txtMaSach.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thời hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày trả";
            // 
            // btTaoPhieu
            // 
            this.btTaoPhieu.BackColor = System.Drawing.Color.OldLace;
            this.btTaoPhieu.FlatAppearance.BorderSize = 0;
            this.btTaoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoPhieu.Location = new System.Drawing.Point(291, 235);
            this.btTaoPhieu.Name = "btTaoPhieu";
            this.btTaoPhieu.Size = new System.Drawing.Size(171, 50);
            this.btTaoPhieu.TabIndex = 19;
            this.btTaoPhieu.Text = "Tạo phiếu mượn";
            this.btTaoPhieu.UseVisualStyleBackColor = false;
            this.btTaoPhieu.Click += new System.EventHandler(this.btTaoPhieu_Click);
            // 
            // cbThoiHan
            // 
            this.cbThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThoiHan.FormattingEnabled = true;
            this.cbThoiHan.Items.AddRange(new object[] {
            "1 tháng",
            "3 tháng"});
            this.cbThoiHan.Location = new System.Drawing.Point(310, 107);
            this.cbThoiHan.Name = "cbThoiHan";
            this.cbThoiHan.Size = new System.Drawing.Size(219, 30);
            this.cbThoiHan.TabIndex = 20;
            this.cbThoiHan.SelectedIndexChanged += new System.EventHandler(this.cbThoiHan_SelectedIndexChanged);
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.BackColor = System.Drawing.SystemColors.Window;
            this.lbNgayTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTra.Location = new System.Drawing.Point(310, 170);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(219, 30);
            this.lbNgayTra.TabIndex = 21;
            this.lbNgayTra.Text = "01/01/2000";
            this.lbNgayTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(637, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 239);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đang mượn",
            "Đã trả (đúng hạn)",
            "Đã trả (quá hạn)"});
            this.cbTrangThai.Location = new System.Drawing.Point(47, 167);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(215, 30);
            this.cbTrangThai.TabIndex = 21;
            // 
            // btTim
            // 
            this.btTim.BackgroundImage = global::QuanLyThuVien.Properties.Resources.search;
            this.btTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTim.Location = new System.Drawing.Point(296, 161);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(45, 40);
            this.btTim.TabIndex = 20;
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trạng thái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(43, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã phiếu";
            // 
            // txtTim
            // 
            this.txtTim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(47, 79);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(209, 27);
            this.txtTim.TabIndex = 18;
            // 
            // errp
            // 
            this.errp.BlinkRate = 100;
            this.errp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errp.ContainerControl = this;
            // 
            // lbThongBao
            // 
            this.lbThongBao.BackColor = System.Drawing.Color.Azure;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbThongBao.Location = new System.Drawing.Point(291, 303);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(171, 33);
            this.lbThongBao.TabIndex = 23;
            this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmThueSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1242, 792);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNgayTra);
            this.Controls.Add(this.cbThoiHan);
            this.Controls.Add(this.btTaoPhieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lvPhieuMuon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThueSach";
            this.Text = "FrmThueSach";
            this.Load += new System.EventHandler(this.FrmThueSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPhieuMuon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTaoPhieu;
        private System.Windows.Forms.ComboBox cbThoiHan;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ErrorProvider errp;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Timer timer1;
    }
}