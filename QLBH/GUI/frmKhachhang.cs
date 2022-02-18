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
    public partial class frmKhachhang : Form
    {
        //--------Khai báo tầng BUS
        BUS_CCustomers c = new BUS_CCustomers();
        
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            //---------Gọi hàm khởi tạo dữ liệu Customer
            DTO_CCustomers cus = new DTO_CCustomers(txtMskh.Text.Trim(),
                                                    txtTenkh.Text.Trim(),
                                                    cboPhai.Text.Trim(),
                                                    txtDiachi.Text.Trim(),
                                                    txtDienthoai.Text.Trim());
            c.pr_ThemKH(cus);
        }
    }
}
