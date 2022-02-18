using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CDBConnect
    {
        //------1.Khai báo lớp kết nối CSDL:DAL_CDBConnect
        DAL_CDBConnect conn = new DAL_CDBConnect();

        //------2.Gọi hàm kết nối CSDL
        public bool DBConnect(DTO_CLogIn lg)
        {
            return conn.CDBConnect(lg);
        }

        //-------3.Gọi hàm hủy kết nối CSDL
        public bool CDBConnectDisable()
        {
            return conn.CDBConnectDisable();
        }
    }
}  
