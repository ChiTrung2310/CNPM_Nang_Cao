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
    public class DAL_CDBConnect
    {
        //------1.Khai báo lớp kết nối với CSDL(Databasse)
        public static SqlConnection myconn = null;

        //------2.Viết hàm kết nối CSDL
        public bool CDBConnect(DTO_CLogIn teo)
        {
            try
            {
                myconn = new SqlConnection("Data Source="+teo.Servername+
                                           "; Initial Catalog="+teo.Database+
                                           "; User ID="+teo.UserID+
                                           "; Password="+teo.Password);
                myconn.Open(); //Mở kết nối với CSDL (Database)
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return false;
            }
        }
        //-------3.Viết hàm hủy kết nối CSDL
        public bool CDBConnectDisable()
        {
            try
            {
                myconn.Close();
                return true;
            }
            catch (Exception ty)
            {
                MessageBox.Show("Hủy kết nối CSDL thất bại!!!Huhuhuhu" + ty.ToString());
                return false;
            }
        }
    }
}
