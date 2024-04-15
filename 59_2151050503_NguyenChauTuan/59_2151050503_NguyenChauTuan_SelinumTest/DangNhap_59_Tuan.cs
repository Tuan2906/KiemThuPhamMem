using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
  public class DangNhap_59_Tuan
    {
        private string password_59_Tuan;
        private string username_59_Tuan;
        public DangNhap_59_Tuan(string username_59_Tuan, string password_59_Tuan)
        {
            this.username_59_Tuan = username_59_Tuan;
            this.password_59_Tuan = password_59_Tuan;
        }
        public bool checkDangNhap_59_Tuan()
        {
            if(this.username_59_Tuan == "" || this.password_59_Tuan =="")
            {
                return false;

            }
            else if(this.username_59_Tuan != "tuanchau" )
            {
            }
                return false;
            return true;
        }
    }
}
