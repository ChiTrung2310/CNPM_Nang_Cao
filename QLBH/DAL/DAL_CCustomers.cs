using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CCustomers
    {
        //---------1.Viết hàm gọi Stored Procedure để thêm khách hàng mới
        public void pr_ThemKH(DTO_CCustomers t)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemKH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MsKH", System.Data.SqlDbType.Char, 10).Value = t.MsKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 30).Value = t.TENKH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 5).Value = t.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = t.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.VarChar, 10).Value = t.DIENTHOAI;
                cmd.ExecuteNonQuery(); //-----Thực thi Stored Procedure
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        //---------2.Viết hàm gọi Stored Procedure để xóa khách hàng mới->SV

        //---------3.Viết hàm gọi Stored Procedure để sửa khách hàng mới->SV

    }
}
