using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CLogIn
    {
        //----Khai báo các biến uses LogIn
        /*
            1.Để dấu nháy con chuột ngay biến mà bạn muốn tạo get và set
            2.Nhấn và giữ nút Ctrl, sau đó nhấn nút R và nhấn nút E
            3.Nhấn nút Enter 2 lần liên tiếp
         */
        private string _Servername;

        public string Servername
        {
            get { return _Servername; }
            set { _Servername = value; }
        }
        private string _Database;

        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }
        private string _UserID;

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        //------------Các thuộc tính get và set này thuộc Version Visual Studio 2019
        //public string Servername 
        //{
        //    get => _Servername; 
        //    set => _Servername = value; 
        //}
        //public string Database 
        //{ 
        //    get => _Database; 
        //    set => _Database = value; 
        //}
        //public string UserID 
        //{ 
        //    get => _UserID; 
        //    set => _UserID = value; 
        //}
        //public string Password 
        //{ 
        //    get => _Password; 
        //    set => _Password = value; 
        //}

        //---------Khai báo có 02 hàm khởi tạo (Constructor)
        public DTO_CLogIn() { }
        public DTO_CLogIn(  string sv, string db, 
                            string userid, string pass)
        {
            this.Servername = sv;
            this.Database = db;
            this.UserID = userid;
            this.Password = pass;
        }
    }
}
