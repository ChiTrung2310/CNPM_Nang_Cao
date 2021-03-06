using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHethong : Form
    {
        //---------Khai báo lớp GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        //---------Khai báo lớp: BUS_CDBConnect
        BUS_CDBConnect disconn = new BUS_CDBConnect();

        public frmHethong()
        {
            InitializeComponent();
        }

        private void frmHethong_Load(object sender, EventArgs e)
        {
            mnu.CEnableMenu(true, false);
            frmDangnhap frm = new frmDangnhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangnhap frm = new frmDangnhap();
            frm.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuHKN_Click(object sender, EventArgs e)
        {
            if (disconn.CDBConnectDisable() == true)
                mnu.CEnableMenu(true, false);
        }

        private void mnuDMKH_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.ShowDialog();
        }

        private void mnuBCDTMH_Click(object sender, EventArgs e)
        {
            frmBCDSMoiMHReport frm = new frmBCDSMoiMHReport();
            frm.ShowDialog();
        }
    }
}
