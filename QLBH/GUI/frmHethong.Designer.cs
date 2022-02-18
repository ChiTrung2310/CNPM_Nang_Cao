namespace GUI
{
    partial class frmHethong
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
            this.menuHethong = new System.Windows.Forms.MenuStrip();
            this.mnuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHKN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBR = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCIHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDTBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDTMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHethong.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHethong
            // 
            this.menuHethong.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuHethong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuDM,
            this.mnuHD,
            this.mnuBC,
            this.mnuTC,
            this.mnuTG});
            this.menuHethong.Location = new System.Drawing.Point(0, 0);
            this.menuHethong.Name = "menuHethong";
            this.menuHethong.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuHethong.Size = new System.Drawing.Size(1467, 42);
            this.menuHethong.TabIndex = 1;
            this.menuHethong.Text = "menuStrip1";
            // 
            // mnuHT
            // 
            this.mnuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDN,
            this.toolStripSeparator1,
            this.mnuHKN,
            this.toolStripSeparator2,
            this.mnuBR,
            this.toolStripSeparator3,
            this.mnuThoat});
            this.mnuHT.Name = "mnuHT";
            this.mnuHT.Size = new System.Drawing.Size(112, 34);
            this.mnuHT.Text = "Hệ thống";
            // 
            // mnuDN
            // 
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(287, 34);
            this.mnuDN.Text = "Đăng nhập";
            this.mnuDN.Click += new System.EventHandler(this.mnuDN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(284, 6);
            // 
            // mnuHKN
            // 
            this.mnuHKN.Name = "mnuHKN";
            this.mnuHKN.Size = new System.Drawing.Size(287, 34);
            this.mnuHKN.Text = "Hủy kết nối";
            this.mnuHKN.Click += new System.EventHandler(this.mnuHKN_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(284, 6);
            // 
            // mnuBR
            // 
            this.mnuBR.Name = "mnuBR";
            this.mnuBR.Size = new System.Drawing.Size(287, 34);
            this.mnuBR.Text = "Backup and Restore";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(284, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(287, 34);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDM
            // 
            this.mnuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMMH,
            this.mnuDMNV,
            this.mnuDMKH});
            this.mnuDM.Name = "mnuDM";
            this.mnuDM.Size = new System.Drawing.Size(121, 34);
            this.mnuDM.Text = "Danh mục";
            // 
            // mnuDMMH
            // 
            this.mnuDMMH.Name = "mnuDMMH";
            this.mnuDMMH.Size = new System.Drawing.Size(214, 34);
            this.mnuDMMH.Text = "Mặt hàng";
            // 
            // mnuDMNV
            // 
            this.mnuDMNV.Name = "mnuDMNV";
            this.mnuDMNV.Size = new System.Drawing.Size(214, 34);
            this.mnuDMNV.Text = "Nhân viên";
            // 
            // mnuDMKH
            // 
            this.mnuDMKH.Name = "mnuDMKH";
            this.mnuDMKH.Size = new System.Drawing.Size(214, 34);
            this.mnuDMKH.Text = "Khách hàng";
            this.mnuDMKH.Click += new System.EventHandler(this.mnuDMKH_Click);
            // 
            // mnuHD
            // 
            this.mnuHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLHD});
            this.mnuHD.Name = "mnuHD";
            this.mnuHD.Size = new System.Drawing.Size(106, 34);
            this.mnuHD.Text = "Hóa đơn";
            // 
            // mnuLHD
            // 
            this.mnuLHD.Name = "mnuLHD";
            this.mnuLHD.Size = new System.Drawing.Size(221, 34);
            this.mnuLHD.Text = "Lập hóa đơn";
            // 
            // mnuBC
            // 
            this.mnuBC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCIHD,
            this.mnuBCDTBH});
            this.mnuBC.Name = "mnuBC";
            this.mnuBC.Size = new System.Drawing.Size(99, 34);
            this.mnuBC.Text = "Báo cáo";
            // 
            // mnuBCIHD
            // 
            this.mnuBCIHD.Name = "mnuBCIHD";
            this.mnuBCIHD.Size = new System.Drawing.Size(374, 34);
            this.mnuBCIHD.Text = "In hóa đơn";
            // 
            // mnuBCDTBH
            // 
            this.mnuBCDTBH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCDTNV,
            this.mnuBCDTMH});
            this.mnuBCDTBH.Name = "mnuBCDTBH";
            this.mnuBCDTBH.Size = new System.Drawing.Size(374, 34);
            this.mnuBCDTBH.Text = "Báo cáo doanh thu bán hàng";
            // 
            // mnuBCDTNV
            // 
            this.mnuBCDTNV.Name = "mnuBCDTNV";
            this.mnuBCDTNV.Size = new System.Drawing.Size(377, 34);
            this.mnuBCDTNV.Text = "Doanh số cho mỗi nhân viên";
            // 
            // mnuBCDTMH
            // 
            this.mnuBCDTMH.Name = "mnuBCDTMH";
            this.mnuBCDTMH.Size = new System.Drawing.Size(377, 34);
            this.mnuBCDTMH.Text = "Doanh số cho từng mặt hàng";
            this.mnuBCDTMH.Click += new System.EventHandler(this.mnuBCDTMH_Click);
            // 
            // mnuTC
            // 
            this.mnuTC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTCNV,
            this.mnuTCHD,
            this.mnuTCMH,
            this.mnuTCKH});
            this.mnuTC.Name = "mnuTC";
            this.mnuTC.Size = new System.Drawing.Size(92, 34);
            this.mnuTC.Text = "Tra cứu";
            // 
            // mnuTCNV
            // 
            this.mnuTCNV.Name = "mnuTCNV";
            this.mnuTCNV.Size = new System.Drawing.Size(214, 34);
            this.mnuTCNV.Text = "Nhân viên";
            // 
            // mnuTCHD
            // 
            this.mnuTCHD.Name = "mnuTCHD";
            this.mnuTCHD.Size = new System.Drawing.Size(214, 34);
            this.mnuTCHD.Text = "Hóa đơn";
            // 
            // mnuTCMH
            // 
            this.mnuTCMH.Name = "mnuTCMH";
            this.mnuTCMH.Size = new System.Drawing.Size(214, 34);
            this.mnuTCMH.Text = "Mặt hàng";
            // 
            // mnuTCKH
            // 
            this.mnuTCKH.Name = "mnuTCKH";
            this.mnuTCKH.Size = new System.Drawing.Size(214, 34);
            this.mnuTCKH.Text = "Khách hàng";
            // 
            // mnuTG
            // 
            this.mnuTG.Name = "mnuTG";
            this.mnuTG.Size = new System.Drawing.Size(101, 34);
            this.mnuTG.Text = "Trợ giúp";
            // 
            // frmHethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.menuHethong);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHethong;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmHethong";
            this.Text = "Hệ thống quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHethong_Load);
            this.menuHethong.ResumeLayout(false);
            this.menuHethong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHethong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem mnuHT;
        public System.Windows.Forms.ToolStripMenuItem mnuDN;
        public System.Windows.Forms.ToolStripMenuItem mnuHKN;
        public System.Windows.Forms.ToolStripMenuItem mnuBR;
        public System.Windows.Forms.ToolStripMenuItem mnuThoat;
        public System.Windows.Forms.ToolStripMenuItem mnuDM;
        public System.Windows.Forms.ToolStripMenuItem mnuDMMH;
        public System.Windows.Forms.ToolStripMenuItem mnuDMNV;
        public System.Windows.Forms.ToolStripMenuItem mnuDMKH;
        public System.Windows.Forms.ToolStripMenuItem mnuHD;
        public System.Windows.Forms.ToolStripMenuItem mnuLHD;
        public System.Windows.Forms.ToolStripMenuItem mnuBC;
        public System.Windows.Forms.ToolStripMenuItem mnuBCIHD;
        public System.Windows.Forms.ToolStripMenuItem mnuBCDTBH;
        public System.Windows.Forms.ToolStripMenuItem mnuBCDTNV;
        public System.Windows.Forms.ToolStripMenuItem mnuBCDTMH;
        public System.Windows.Forms.ToolStripMenuItem mnuTC;
        public System.Windows.Forms.ToolStripMenuItem mnuTCNV;
        public System.Windows.Forms.ToolStripMenuItem mnuTCHD;
        public System.Windows.Forms.ToolStripMenuItem mnuTCMH;
        public System.Windows.Forms.ToolStripMenuItem mnuTCKH;
        public System.Windows.Forms.ToolStripMenuItem mnuTG;
    }
}

