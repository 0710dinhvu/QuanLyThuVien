namespace QuanLyThuVien.Forms
{
    partial class FrmQLPhieuMuon
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
            "user01",
            "S001",
            "Đêm Trường Tăm Tối",
            "01/01/2022",
            "01/01/2023",
            "01/01/2024",
            "Đã trả (quá hạn)"}, -1);
            this.lvPhieuMuon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimMaSach = new System.Windows.Forms.TextBox();
            this.txtTimUser = new System.Windows.Forms.TextBox();
            this.txtTimMaPhieu = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lbNgayTraDK = new System.Windows.Forms.Label();
            this.cbThoiHan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtNgayTraTT = new System.Windows.Forms.DateTimePicker();
            this.btClear = new System.Windows.Forms.Button();
            this.rdDangMuon = new System.Windows.Forms.RadioButton();
            this.rdDaTra = new System.Windows.Forms.RadioButton();
            this.lbNgayTraTT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTaoTuDong = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errp = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbThongBao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errp)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPhieuMuon
            // 
            this.lvPhieuMuon.BackColor = System.Drawing.Color.AliceBlue;
            this.lvPhieuMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
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
            this.lvPhieuMuon.Location = new System.Drawing.Point(0, 392);
            this.lvPhieuMuon.MultiSelect = false;
            this.lvPhieuMuon.Name = "lvPhieuMuon";
            this.lvPhieuMuon.Size = new System.Drawing.Size(1242, 400);
            this.lvPhieuMuon.TabIndex = 3;
            this.lvPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lvPhieuMuon.View = System.Windows.Forms.View.Details;
            this.lvPhieuMuon.DoubleClick += new System.EventHandler(this.lvPhieuMuon_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên user";
            this.columnHeader8.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã sách";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sách";
            this.columnHeader3.Width = 215;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày mượn";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày trả dự kiến";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày trả thực tế";
            this.columnHeader6.Width = 116;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Trạng thái";
            this.columnHeader7.Width = 136;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTimMaSach);
            this.groupBox1.Controls.Add(this.txtTimUser);
            this.groupBox1.Controls.Add(this.txtTimMaPhieu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(871, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 321);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đang mượn",
            "Đã trả (đúng hạn)",
            "Đã trả (quá hạn)"});
            this.cbTrangThai.Location = new System.Drawing.Point(46, 265);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(215, 28);
            this.cbTrangThai.TabIndex = 21;
            // 
            // btTim
            // 
            this.btTim.BackgroundImage = global::QuanLyThuVien.Properties.Resources.search;
            this.btTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTim.Location = new System.Drawing.Point(291, 263);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(45, 40);
            this.btTim.TabIndex = 20;
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(42, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên user";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(42, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã phiếu";
            // 
            // txtTimMaSach
            // 
            this.txtTimMaSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTimMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaSach.Location = new System.Drawing.Point(46, 195);
            this.txtTimMaSach.Name = "txtTimMaSach";
            this.txtTimMaSach.Size = new System.Drawing.Size(209, 27);
            this.txtTimMaSach.TabIndex = 18;
            // 
            // txtTimUser
            // 
            this.txtTimUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimUser.Location = new System.Drawing.Point(46, 125);
            this.txtTimUser.Name = "txtTimUser";
            this.txtTimUser.Size = new System.Drawing.Size(209, 27);
            this.txtTimUser.TabIndex = 18;
            // 
            // txtTimMaPhieu
            // 
            this.txtTimMaPhieu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTimMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaPhieu.Location = new System.Drawing.Point(46, 55);
            this.txtTimMaPhieu.Name = "txtTimMaPhieu";
            this.txtTimMaPhieu.Size = new System.Drawing.Size(209, 27);
            this.txtTimMaPhieu.TabIndex = 18;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.LemonChiffon;
            this.btSua.FlatAppearance.BorderSize = 0;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(538, 280);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 50);
            this.btSua.TabIndex = 24;
            this.btSua.Text = "Sửa";
            this.toolTip1.SetToolTip(this.btSua, "Sửa theo mã phiếu");
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.LemonChiffon;
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(676, 212);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 50);
            this.btXoa.TabIndex = 25;
            this.btXoa.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btXoa, "Xóa theo mã phiếu");
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.LemonChiffon;
            this.btThem.FlatAppearance.BorderSize = 0;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(538, 212);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 50);
            this.btThem.TabIndex = 26;
            this.btThem.Text = "Thêm";
            this.toolTip1.SetToolTip(this.btThem, "Thêm phiếu");
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã phiếu";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(142, 19);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(245, 27);
            this.txtMaPhieu.TabIndex = 27;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(559, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(245, 27);
            this.txtUser.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên user";
            // 
            // txtMaSach
            // 
            this.txtMaSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(142, 92);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(245, 27);
            this.txtMaSach.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày mượn";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayMuon.Location = new System.Drawing.Point(559, 92);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(245, 27);
            this.dtNgayMuon.TabIndex = 29;
            this.dtNgayMuon.ValueChanged += new System.EventHandler(this.dtNgayMuon_ValueChanged);
            // 
            // lbNgayTraDK
            // 
            this.lbNgayTraDK.BackColor = System.Drawing.SystemColors.Window;
            this.lbNgayTraDK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNgayTraDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraDK.Location = new System.Drawing.Point(559, 161);
            this.lbNgayTraDK.Name = "lbNgayTraDK";
            this.lbNgayTraDK.Size = new System.Drawing.Size(245, 30);
            this.lbNgayTraDK.TabIndex = 33;
            this.lbNgayTraDK.Text = "01/01/2000";
            this.lbNgayTraDK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbThoiHan
            // 
            this.cbThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThoiHan.FormattingEnabled = true;
            this.cbThoiHan.Items.AddRange(new object[] {
            "1 tháng",
            "3 tháng"});
            this.cbThoiHan.Location = new System.Drawing.Point(142, 163);
            this.cbThoiHan.Name = "cbThoiHan";
            this.cbThoiHan.Size = new System.Drawing.Size(245, 28);
            this.cbThoiHan.TabIndex = 32;
            this.cbThoiHan.SelectedIndexChanged += new System.EventHandler(this.cbThoiHan_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Thời hạn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(431, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Ngày trả DK";
            // 
            // dtNgayTraTT
            // 
            this.dtNgayTraTT.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTraTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTraTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTraTT.Location = new System.Drawing.Point(174, 78);
            this.dtNgayTraTT.Name = "dtNgayTraTT";
            this.dtNgayTraTT.Size = new System.Drawing.Size(172, 27);
            this.dtNgayTraTT.TabIndex = 29;
            this.dtNgayTraTT.Visible = false;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.LightCyan;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(676, 280);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 50);
            this.btClear.TabIndex = 34;
            this.btClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btClear, "Clear");
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // rdDangMuon
            // 
            this.rdDangMuon.AutoSize = true;
            this.rdDangMuon.Checked = true;
            this.rdDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDangMuon.ForeColor = System.Drawing.Color.Black;
            this.rdDangMuon.Location = new System.Drawing.Point(58, 36);
            this.rdDangMuon.Name = "rdDangMuon";
            this.rdDangMuon.Size = new System.Drawing.Size(115, 24);
            this.rdDangMuon.TabIndex = 30;
            this.rdDangMuon.TabStop = true;
            this.rdDangMuon.Text = "Đang mượn";
            this.rdDangMuon.UseVisualStyleBackColor = true;
            this.rdDangMuon.CheckedChanged += new System.EventHandler(this.rdDangMuon_CheckedChanged);
            // 
            // rdDaTra
            // 
            this.rdDaTra.AutoSize = true;
            this.rdDaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDaTra.ForeColor = System.Drawing.Color.Black;
            this.rdDaTra.Location = new System.Drawing.Point(208, 36);
            this.rdDaTra.Name = "rdDaTra";
            this.rdDaTra.Size = new System.Drawing.Size(76, 24);
            this.rdDaTra.TabIndex = 31;
            this.rdDaTra.Text = "Đã trả";
            this.rdDaTra.UseVisualStyleBackColor = true;
            // 
            // lbNgayTraTT
            // 
            this.lbNgayTraTT.AutoSize = true;
            this.lbNgayTraTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraTT.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbNgayTraTT.Location = new System.Drawing.Point(58, 81);
            this.lbNgayTraTT.Name = "lbNgayTraTT";
            this.lbNgayTraTT.Size = new System.Drawing.Size(97, 20);
            this.lbNgayTraTT.TabIndex = 28;
            this.lbNgayTraTT.Text = "Ngày trả TT";
            this.lbNgayTraTT.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgayTraTT);
            this.groupBox2.Controls.Add(this.lbNgayTraTT);
            this.groupBox2.Controls.Add(this.rdDaTra);
            this.groupBox2.Controls.Add(this.rdDangMuon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(42, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 130);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // cbTaoTuDong
            // 
            this.cbTaoTuDong.AutoSize = true;
            this.cbTaoTuDong.Location = new System.Drawing.Point(142, 50);
            this.cbTaoTuDong.Name = "cbTaoTuDong";
            this.cbTaoTuDong.Size = new System.Drawing.Size(133, 21);
            this.cbTaoTuDong.TabIndex = 37;
            this.cbTaoTuDong.Text = "Tạo mới tự động";
            this.cbTaoTuDong.UseVisualStyleBackColor = true;
            this.cbTaoTuDong.CheckedChanged += new System.EventHandler(this.cbTaoTuDong_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // errp
            // 
            this.errp.BlinkRate = 100;
            this.errp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errp.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbThongBao
            // 
            this.lbThongBao.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbThongBao.Location = new System.Drawing.Point(575, 345);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(171, 33);
            this.lbThongBao.TabIndex = 38;
            this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmQLPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1242, 792);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.cbTaoTuDong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbNgayTraDK);
            this.Controls.Add(this.cbThoiHan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtNgayMuon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvPhieuMuon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLPhieuMuon";
            this.Text = "QLPhieuMuon";
            this.Load += new System.EventHandler(this.FrmQLPhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimUser;
        private System.Windows.Forms.TextBox txtTimMaPhieu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimMaSach;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.Label lbNgayTraDK;
        private System.Windows.Forms.ComboBox cbThoiHan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgayTraTT;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.RadioButton rdDaTra;
        private System.Windows.Forms.RadioButton rdDangMuon;
        private System.Windows.Forms.Label lbNgayTraTT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTaoTuDong;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbThongBao;
    }
}