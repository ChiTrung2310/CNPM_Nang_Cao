using BUS;
using DTO;
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
    public partial class frmDangnhap : Form
    {
        //-----------1.Khai báo lớp: BUS_CDBConnect
        BUS_CDBConnect cn = new BUS_CDBConnect();

        //-----------2.Khai báo lớp có chứa hàm Ẩn/Hiện menu: GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        public frmDangnhap()
        {
            InitializeComponent();
        }
        //-------Khai báo các biến chứa thông tin đăng nhập
        public static string SV;
        public static string DB;
        public static string UI;
        public static string Pass;

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            SV = txtServername.Text.Trim();
            DB = txtDatabase.Text.Trim();
            UI = txtUserID.Text.Trim();
            Pass = txtPassword.Text.Trim();

            //----------1.Gọi hàm khởi tạo 4 parameters
            DTO_CLogIn lg = new DTO_CLogIn( txtServername.Text.Trim(), 
                                            txtDatabase.Text.Trim(), 
                                            txtUserID.Text.Trim(), 
                                            txtPassword.Text.Trim());
            //-----------2.Gọi hàm kết CSDL
            if (cn.DBConnect(lg) == true)
            {
                this.Close();
                mnu.CEnableMenu(false, true); //-----3.Gọi hàm Ẩn/Hiện menu
            }
        }
    }
}
