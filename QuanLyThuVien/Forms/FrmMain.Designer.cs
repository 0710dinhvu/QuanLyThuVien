namespace QuanLyThuVien.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAboutUs = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btLogout = new System.Windows.Forms.Button();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            this.subMenuQL = new System.Windows.Forms.Panel();
            this.btQLPhieuMuon = new System.Windows.Forms.Button();
            this.btQLNguoiDung = new System.Windows.Forms.Button();
            this.btQLTheLoai = new System.Windows.Forms.Button();
            this.btQLSach = new System.Windows.Forms.Button();
            this.BtQuanLy = new System.Windows.Forms.Button();
            this.subMenuHome = new System.Windows.Forms.Panel();
            this.btTraSach = new System.Windows.Forms.Button();
            this.btThueSach = new System.Windows.Forms.Button();
            this.btTraCuuSach = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTenMenu = new System.Windows.Forms.Label();
            this.btMnm = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.pnForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.subMenuQL.SuspendLayout();
            this.subMenuHome.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btAboutUs);
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.btTaiKhoan);
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.subMenuQL);
            this.panel1.Controls.Add(this.BtQuanLy);
            this.panel1.Controls.Add(this.subMenuHome);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 850);
            this.panel1.TabIndex = 0;
            // 
            // btAboutUs
            // 
            this.btAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAboutUs.FlatAppearance.BorderSize = 0;
            this.btAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAboutUs.ForeColor = System.Drawing.Color.White;
            this.btAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAboutUs.ImageIndex = 5;
            this.btAboutUs.ImageList = this.imageList1;
            this.btAboutUs.Location = new System.Drawing.Point(0, 875);
            this.btAboutUs.Name = "btAboutUs";
            this.btAboutUs.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.btAboutUs.Size = new System.Drawing.Size(237, 60);
            this.btAboutUs.TabIndex = 8;
            this.btAboutUs.Text = "About us";
            this.btAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAboutUs.UseVisualStyleBackColor = false;
            this.btAboutUs.Click += new System.EventHandler(this.btAboutUs_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sign-out-alt.png");
            this.imageList1.Images.SetKeyName(1, "house-solid (3).png");
            this.imageList1.Images.SetKeyName(2, "user-gear-solid (1).png");
            this.imageList1.Images.SetKeyName(3, "bars-progress-solid.png");
            this.imageList1.Images.SetKeyName(4, "chart-simple-solid (1).png");
            this.imageList1.Images.SetKeyName(5, "circle-info-solid (2).png");
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogout.ImageIndex = 0;
            this.btLogout.ImageList = this.imageList1;
            this.btLogout.Location = new System.Drawing.Point(0, 935);
            this.btLogout.Name = "btLogout";
            this.btLogout.Padding = new System.Windows.Forms.Padding(50, 0, 40, 0);
            this.btLogout.Size = new System.Drawing.Size(237, 55);
            this.btLogout.TabIndex = 7;
            this.btLogout.Text = "Đăng xuất";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btTaiKhoan
            // 
            this.btTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaiKhoan.ImageIndex = 2;
            this.btTaiKhoan.ImageList = this.imageList1;
            this.btTaiKhoan.Location = new System.Drawing.Point(0, 815);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.btTaiKhoan.Size = new System.Drawing.Size(237, 60);
            this.btTaiKhoan.TabIndex = 6;
            this.btTaiKhoan.Text = "Tài khoản";
            this.btTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaiKhoan.UseVisualStyleBackColor = false;
            this.btTaiKhoan.Click += new System.EventHandler(this.btTaiKhoan_Click);
            // 
            // btThongKe
            // 
            this.btThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThongKe.FlatAppearance.BorderSize = 0;
            this.btThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.ForeColor = System.Drawing.Color.White;
            this.btThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThongKe.ImageIndex = 4;
            this.btThongKe.ImageList = this.imageList1;
            this.btThongKe.Location = new System.Drawing.Point(0, 755);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.btThongKe.Size = new System.Drawing.Size(237, 60);
            this.btThongKe.TabIndex = 5;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThongKe.UseVisualStyleBackColor = false;
            this.btThongKe.Visible = false;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // subMenuQL
            // 
            this.subMenuQL.AutoSize = true;
            this.subMenuQL.Controls.Add(this.btQLPhieuMuon);
            this.subMenuQL.Controls.Add(this.btQLNguoiDung);
            this.subMenuQL.Controls.Add(this.btQLTheLoai);
            this.subMenuQL.Controls.Add(this.btQLSach);
            this.subMenuQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuQL.Location = new System.Drawing.Point(0, 515);
            this.subMenuQL.Name = "subMenuQL";
            this.subMenuQL.Size = new System.Drawing.Size(237, 240);
            this.subMenuQL.TabIndex = 4;
            this.subMenuQL.Visible = false;
            // 
            // btQLPhieuMuon
            // 
            this.btQLPhieuMuon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btQLPhieuMuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLPhieuMuon.FlatAppearance.BorderSize = 0;
            this.btQLPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLPhieuMuon.Location = new System.Drawing.Point(0, 180);
            this.btQLPhieuMuon.Name = "btQLPhieuMuon";
            this.btQLPhieuMuon.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btQLPhieuMuon.Size = new System.Drawing.Size(237, 60);
            this.btQLPhieuMuon.TabIndex = 6;
            this.btQLPhieuMuon.Text = "Quản lý phiếu mượn";
            this.btQLPhieuMuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQLPhieuMuon.UseVisualStyleBackColor = false;
            this.btQLPhieuMuon.Click += new System.EventHandler(this.btQLPhieuMuon_Click);
            // 
            // btQLNguoiDung
            // 
            this.btQLNguoiDung.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btQLNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLNguoiDung.FlatAppearance.BorderSize = 0;
            this.btQLNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLNguoiDung.Location = new System.Drawing.Point(0, 120);
            this.btQLNguoiDung.Name = "btQLNguoiDung";
            this.btQLNguoiDung.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btQLNguoiDung.Size = new System.Drawing.Size(237, 60);
            this.btQLNguoiDung.TabIndex = 5;
            this.btQLNguoiDung.Text = "Quản lý người dùng";
            this.btQLNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQLNguoiDung.UseVisualStyleBackColor = false;
            this.btQLNguoiDung.Click += new System.EventHandler(this.btQLNguoiDung_Click);
            // 
            // btQLTheLoai
            // 
            this.btQLTheLoai.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btQLTheLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLTheLoai.FlatAppearance.BorderSize = 0;
            this.btQLTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLTheLoai.Location = new System.Drawing.Point(0, 60);
            this.btQLTheLoai.Name = "btQLTheLoai";
            this.btQLTheLoai.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btQLTheLoai.Size = new System.Drawing.Size(237, 60);
            this.btQLTheLoai.TabIndex = 4;
            this.btQLTheLoai.Text = "Quản lý thể loại";
            this.btQLTheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQLTheLoai.UseVisualStyleBackColor = false;
            this.btQLTheLoai.Click += new System.EventHandler(this.btQLTheLoai_Click);
            // 
            // btQLSach
            // 
            this.btQLSach.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btQLSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLSach.FlatAppearance.BorderSize = 0;
            this.btQLSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLSach.Location = new System.Drawing.Point(0, 0);
            this.btQLSach.Name = "btQLSach";
            this.btQLSach.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btQLSach.Size = new System.Drawing.Size(237, 60);
            this.btQLSach.TabIndex = 3;
            this.btQLSach.Text = "Quản lý sách";
            this.btQLSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQLSach.UseVisualStyleBackColor = false;
            this.btQLSach.Click += new System.EventHandler(this.btQLSach_Click);
            // 
            // BtQuanLy
            // 
            this.BtQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.BtQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtQuanLy.FlatAppearance.BorderSize = 0;
            this.BtQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtQuanLy.ForeColor = System.Drawing.Color.White;
            this.BtQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtQuanLy.ImageIndex = 3;
            this.BtQuanLy.ImageList = this.imageList1;
            this.BtQuanLy.Location = new System.Drawing.Point(0, 455);
            this.BtQuanLy.Name = "BtQuanLy";
            this.BtQuanLy.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.BtQuanLy.Size = new System.Drawing.Size(237, 60);
            this.BtQuanLy.TabIndex = 3;
            this.BtQuanLy.Text = "Quản lý";
            this.BtQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtQuanLy.UseVisualStyleBackColor = false;
            this.BtQuanLy.Visible = false;
            this.BtQuanLy.Click += new System.EventHandler(this.BtQuanLy_Click);
            // 
            // subMenuHome
            // 
            this.subMenuHome.AutoSize = true;
            this.subMenuHome.Controls.Add(this.btTraSach);
            this.subMenuHome.Controls.Add(this.btThueSach);
            this.subMenuHome.Controls.Add(this.btTraCuuSach);
            this.subMenuHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuHome.Location = new System.Drawing.Point(0, 275);
            this.subMenuHome.Name = "subMenuHome";
            this.subMenuHome.Size = new System.Drawing.Size(237, 180);
            this.subMenuHome.TabIndex = 2;
            this.subMenuHome.Visible = false;
            // 
            // btTraSach
            // 
            this.btTraSach.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btTraSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTraSach.FlatAppearance.BorderSize = 0;
            this.btTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraSach.Location = new System.Drawing.Point(0, 120);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btTraSach.Size = new System.Drawing.Size(237, 60);
            this.btTraSach.TabIndex = 4;
            this.btTraSach.Text = "Trả sách";
            this.btTraSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTraSach.UseVisualStyleBackColor = false;
            this.btTraSach.Click += new System.EventHandler(this.btTraSach_Click);
            // 
            // btThueSach
            // 
            this.btThueSach.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btThueSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThueSach.FlatAppearance.BorderSize = 0;
            this.btThueSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThueSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThueSach.Location = new System.Drawing.Point(0, 60);
            this.btThueSach.Name = "btThueSach";
            this.btThueSach.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btThueSach.Size = new System.Drawing.Size(237, 60);
            this.btThueSach.TabIndex = 3;
            this.btThueSach.Text = "Thuê sách";
            this.btThueSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThueSach.UseVisualStyleBackColor = false;
            this.btThueSach.Click += new System.EventHandler(this.btThueSach_Click);
            // 
            // btTraCuuSach
            // 
            this.btTraCuuSach.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btTraCuuSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTraCuuSach.FlatAppearance.BorderSize = 0;
            this.btTraCuuSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTraCuuSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraCuuSach.Location = new System.Drawing.Point(0, 0);
            this.btTraCuuSach.Name = "btTraCuuSach";
            this.btTraCuuSach.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btTraCuuSach.Size = new System.Drawing.Size(237, 60);
            this.btTraCuuSach.TabIndex = 2;
            this.btTraCuuSach.Text = "Tra cứu sách";
            this.btTraCuuSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTraCuuSach.UseVisualStyleBackColor = false;
            this.btTraCuuSach.Click += new System.EventHandler(this.btTraCuuSach_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHome.ImageIndex = 1;
            this.btHome.ImageList = this.imageList1;
            this.btHome.Location = new System.Drawing.Point(0, 215);
            this.btHome.Name = "btHome";
            this.btHome.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.btHome.Size = new System.Drawing.Size(237, 60);
            this.btHome.TabIndex = 1;
            this.btHome.Text = "Trang chính";
            this.btHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 215);
            this.panel2.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Beige;
            this.lbName.Location = new System.Drawing.Point(4, 164);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(251, 23);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Xin chào Họ và tên";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Beige;
            this.lbUserName.Location = new System.Drawing.Point(28, 131);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(203, 23);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "username";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(79, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.lbTenMenu);
            this.panel3.Controls.Add(this.btMnm);
            this.panel3.Controls.Add(this.btClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1242, 58);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // lbTenMenu
            // 
            this.lbTenMenu.AutoSize = true;
            this.lbTenMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMenu.ForeColor = System.Drawing.Color.Navy;
            this.lbTenMenu.Location = new System.Drawing.Point(25, 17);
            this.lbTenMenu.Name = "lbTenMenu";
            this.lbTenMenu.Size = new System.Drawing.Size(187, 36);
            this.lbTenMenu.TabIndex = 6;
            this.lbTenMenu.Text = "Tra cứu sách";
            this.lbTenMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.lbTenMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // btMnm
            // 
            this.btMnm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMnm.AutoSize = true;
            this.btMnm.BackgroundImage = global::QuanLyThuVien.Properties.Resources.minus__1_;
            this.btMnm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMnm.FlatAppearance.BorderSize = 0;
            this.btMnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMnm.ForeColor = System.Drawing.Color.White;
            this.btMnm.Location = new System.Drawing.Point(1162, 12);
            this.btMnm.Name = "btMnm";
            this.btMnm.Size = new System.Drawing.Size(27, 35);
            this.btMnm.TabIndex = 5;
            this.btMnm.UseVisualStyleBackColor = true;
            this.btMnm.Click += new System.EventHandler(this.btMnm_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.AutoSize = true;
            this.btClose.BackgroundImage = global::QuanLyThuVien.Properties.Resources.close_window;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(1195, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(35, 35);
            this.btClose.TabIndex = 5;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pnForm
            // 
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnForm.Location = new System.Drawing.Point(258, 58);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(1242, 792);
            this.pnForm.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.subMenuQL.ResumeLayout(false);
            this.subMenuHome.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel subMenuHome;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMnm;
        private System.Windows.Forms.Label lbTenMenu;
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Button btTraSach;
        private System.Windows.Forms.Button btThueSach;
        private System.Windows.Forms.Button btTraCuuSach;
        private System.Windows.Forms.Panel subMenuQL;
        private System.Windows.Forms.Button BtQuanLy;
        private System.Windows.Forms.Button btQLNguoiDung;
        private System.Windows.Forms.Button btQLTheLoai;
        private System.Windows.Forms.Button btQLSach;
        private System.Windows.Forms.Button btTaiKhoan;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btQLPhieuMuon;
        private System.Windows.Forms.Button btAboutUs;
        private System.Windows.Forms.ImageList imageList1;
    }
}