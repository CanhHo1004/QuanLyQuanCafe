namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbToTalPrice = new System.Windows.Forms.TextBox();
            this.cbChuyenDoi = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numSoMon = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbThucUong = new System.Windows.Forms.ComboBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChuyenDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvHoaDon);
            this.panel2.Location = new System.Drawing.Point(466, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 333);
            this.panel2.TabIndex = 2;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(359, 327);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 92;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbToTalPrice);
            this.panel3.Controls.Add(this.cbChuyenDoi);
            this.panel3.Controls.Add(this.btnChuyenBan);
            this.panel3.Controls.Add(this.numGiamGia);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(466, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 55);
            this.panel3.TabIndex = 3;
            // 
            // txbToTalPrice
            // 
            this.txbToTalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbToTalPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.txbToTalPrice.Location = new System.Drawing.Point(176, 15);
            this.txbToTalPrice.Name = "txbToTalPrice";
            this.txbToTalPrice.ReadOnly = true;
            this.txbToTalPrice.Size = new System.Drawing.Size(91, 25);
            this.txbToTalPrice.TabIndex = 8;
            this.txbToTalPrice.Text = "0";
            this.txbToTalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbToTalPrice.TextChanged += new System.EventHandler(this.txbToTalPrice_TextChanged);
            // 
            // cbChuyenDoi
            // 
            this.cbChuyenDoi.Location = new System.Drawing.Point(6, 32);
            this.cbChuyenDoi.Name = "cbChuyenDoi";
            this.cbChuyenDoi.Size = new System.Drawing.Size(80, 20);
            this.cbChuyenDoi.TabIndex = 7;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(6, 3);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(80, 26);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // numGiamGia
            // 
            this.numGiamGia.Location = new System.Drawing.Point(92, 32);
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(80, 20);
            this.numGiamGia.TabIndex = 5;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Location = new System.Drawing.Point(92, 3);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(80, 26);
            this.btnGiamGia.TabIndex = 4;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(268, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(94, 47);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numSoMon);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.cbThucUong);
            this.panel4.Controls.Add(this.cbLoai);
            this.panel4.Location = new System.Drawing.Point(469, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 56);
            this.panel4.TabIndex = 4;
            // 
            // numSoMon
            // 
            this.numSoMon.Location = new System.Drawing.Point(323, 19);
            this.numSoMon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSoMon.Name = "numSoMon";
            this.numSoMon.Size = new System.Drawing.Size(36, 20);
            this.numSoMon.TabIndex = 3;
            this.numSoMon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(201, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 47);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm thức uống";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // cbThucUong
            // 
            this.cbThucUong.FormattingEnabled = true;
            this.cbThucUong.Location = new System.Drawing.Point(3, 30);
            this.cbThucUong.Name = "cbThucUong";
            this.cbThucUong.Size = new System.Drawing.Size(192, 21);
            this.cbThucUong.TabIndex = 1;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(3, 3);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(192, 21);
            this.cbLoai.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 27);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(448, 453);
            this.flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 492);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChuyenDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numSoMon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbThucUong;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.NumericUpDown cbChuyenDoi;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.NumericUpDown numGiamGia;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbToTalPrice;
    }
}