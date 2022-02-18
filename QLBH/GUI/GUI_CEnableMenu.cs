using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class GUI_CEnableMenu
    {
        //--------Khai báo form hệ thống
        public static frmHethong mnuHT = new frmHethong();

        //--------Viết hàm Ẩn/Hiện menu hệ thống
        public void CEnableMenu(bool d1, bool d2)
        {
            mnuHT.mnuDN.Enabled = d1;   //-----Đăng nhập
            mnuHT.mnuHKN.Enabled = d2;  //-----Hủy kết nối
            mnuHT.mnuBR.Enabled = d2;   //-----Backup and Restore
            mnuHT.mnuDM.Enabled = d2;   //-----Danh mục
            mnuHT.mnuHD.Enabled = d2;   //-----Hóa đơn
            mnuHT.mnuBC.Enabled = d2;   //-----Báo cáo
        }

        //---------Viết hàm Main
        static void Main()
        {
            Application.Run(mnuHT);
        }
    }
}
