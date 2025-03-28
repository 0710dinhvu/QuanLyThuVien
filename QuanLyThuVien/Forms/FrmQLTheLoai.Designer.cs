namespace QuanLyThuVien.Forms
{
    partial class FrmQLTheLoai
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
            "S001",
            "Khoa học",
            "5",
            "7"}, -1);
            this.lvTheLoai = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbTaoTuDong = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.errp = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btClear = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errp)).BeginInit();
            this.SuspendLayout();
            // 
            // lvTheLoai
            // 
            this.lvTheLoai.BackColor = System.Drawing.Color.AliceBlue;
            this.lvTheLoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTheLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTheLoai.FullRowSelect = true;
            this.lvTheLoai.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTheLoai.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvTheLoai.Location = new System.Drawing.Point(0, 371);
            this.lvTheLoai.MultiSelect = false;
            this.lvTheLoai.Name = "lvTheLoai";
            this.lvTheLoai.Size = new System.Drawing.Size(1242, 421);
            this.lvTheLoai.TabIndex = 2;
            this.lvTheLoai.UseCompatibleStateImageBehavior = false;
            this.lvTheLoai.View = System.Windows.Forms.View.Details;
            this.lvTheLoai.DoubleClick += new System.EventHandler(this.lvTheLoai_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã thể loại";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thể loại";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng sách";
            this.columnHeader3.Width = 174;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượt mượn";
            this.columnHeader4.Width = 204;
            // 
            // cbTaoTuDong
            // 
            this.cbTaoTuDong.AutoSize = true;
            this.cbTaoTuDong.Location = new System.Drawing.Point(313, 85);
            this.cbTaoTuDong.Name = "cbTaoTuDong";
            this.cbTaoTuDong.Size = new System.Drawing.Size(133, 21);
            this.cbTaoTuDong.TabIndex = 41;
            this.cbTaoTuDong.Text = "Tạo mới tự động";
            this.cbTaoTuDong.UseVisualStyleBackColor = true;
            this.cbTaoTuDong.CheckedChanged += new System.EventHandler(this.cbTaoTuDong_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã thể loại";
            // 
            // txtMaTL
            // 
            this.txtMaTL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.Location = new System.Drawing.Point(313, 52);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(245, 27);
            this.txtMaTL.TabIndex = 39;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.Location = new System.Drawing.Point(313, 138);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(245, 27);
            this.txtTenTL.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tên thể loại";
            // 
            // btTim
            // 
            this.btTim.BackgroundImage = global::QuanLyThuVien.Properties.Resources.search;
            this.btTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTim.Location = new System.Drawing.Point(989, 105);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(45, 40);
            this.btTim.TabIndex = 44;
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(770, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tìm kiếm";
            // 
            // txtTim
            // 
            this.txtTim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(774, 111);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(209, 27);
            this.txtTim.TabIndex = 42;
            // 
            // lbThongBao
            // 
            this.lbThongBao.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbThongBao.Location = new System.Drawing.Point(279, 303);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(178, 33);
            this.lbThongBao.TabIndex = 48;
            this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.LemonChiffon;
            this.btSua.FlatAppearance.BorderSize = 0;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(443, 224);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(110, 50);
            this.btSua.TabIndex = 45;
            this.btSua.Text = "Sửa";
            this.toolTip1.SetToolTip(this.btSua, "Sửa theo mã thể loại");
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.LemonChiffon;
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(313, 224);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(110, 50);
            this.btXoa.TabIndex = 46;
            this.btXoa.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btXoa, "Xóa theo mã thể loại");
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.LemonChiffon;
            this.btThem.FlatAppearance.BorderSize = 0;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(183, 224);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(110, 50);
            this.btThem.TabIndex = 47;
            this.btThem.Text = "Thêm";
            this.toolTip1.SetToolTip(this.btThem, "Thêm thể loại");
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
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
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.LightCyan;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(589, 134);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(86, 35);
            this.btClear.TabIndex = 49;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // FrmQLTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1242, 792);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbTaoTuDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTL);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.lvTheLoai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLTheLoai";
            this.Text = "FrmQLTheLoai";
            this.Load += new System.EventHandler(this.FrmQLTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTheLoai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox cbTaoTuDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ErrorProvider errp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}