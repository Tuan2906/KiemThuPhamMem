using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _59_2151050503_NguyenChauTuan;
namespace _59_2151050503_NguyenChauTuan
{
    public class InitTest_59_Tuan { 
     
    }
   public class Program
    {
      
        public static void Main(string[] args)
        {

            test_59_Tuan testSelium_59_Tuan = new test_59_Tuan();
           
           
            while (true)
            {
                Console.Write("Enter Chức năng test: ");
                string name = Console.ReadLine();
                Console.Write("Enter  testcase: ");
                string chon_59_Tuan = Console.ReadLine();
                if (name.Contains("Thong tin Lien He"))
                {
                   string ketQua_59_Tuan=testSelium_59_Tuan.testCaseTTLienHe_59_Tuan(int.Parse(chon_59_Tuan));
                    Console.Write("Ket qua testcase " + chon_59_Tuan + ": " + ketQua_59_Tuan +"\n");
                }
                else if (name.Contains("exit"))
                {
                    break;
                }
                else
                {
                    testSelium_59_Tuan.testCaseTTDangKy_59_Tuan(int.Parse(chon_59_Tuan));

                }
            }
        
            
        }
        public class test_59_Tuan {
            private _59_NguyenChauTuan_Selinum_ThongTinLienHe lienHe_59_Tuan = new _59_NguyenChauTuan_Selinum_ThongTinLienHe();
            private _59_NguyenChauTuan_Selinum_DangKy dangKy_59_Tuan = new _59_NguyenChauTuan_Selinum_DangKy();
            public string testCaseTTLienHe_59_Tuan(int chon_59_Tuan)
             {
                string ketqua_59_Tuan = "";
                switch (chon_59_Tuan)
                {
                    case 1:
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC1_59_NCT();
                        ketqua_59_Tuan= "Failed";
                        break;
                    case 2:
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC2_59_NCT();
                        ketqua_59_Tuan = "Failed";
                        break;
                    case 3:
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC3_59_NCT();
                        ketqua_59_Tuan = "Failed";

                        break;
                    case 4:
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC4_59_NCT();
                        ketqua_59_Tuan = "Failed";

                        break;
                    case 5:
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC5_59_NCT();
                        ketqua_59_Tuan = "Failed";

                        break;
                    case 6:
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC6_59_NCT();
                        ketqua_59_Tuan = "Passed";

                        break;
                }
                return ketqua_59_Tuan;
            }
            public void testCaseTTDangKy_59_Tuan(int chon)
            {
                switch (chon)
                {
                    case 1:
                        dangKy_59_Tuan.selinum_DangKy_TC1_59_NCT();
                        break;
                    case 2:
                        dangKy_59_Tuan.selinum_DangKy_TC2_59_NCT();
                        break;
                    case 3:
                        dangKy_59_Tuan.selinum_DangKy_TC3_59_NCT(); ;
                        break;
                    case 4:
                        dangKy_59_Tuan.selinum_DangKy_TC4_59_NCT(); ;
                        break;
                    case 5:
                        dangKy_59_Tuan.selinum_DangKy_TC5_59_NCT(); ;
                        break;
                    case 6:
                        dangKy_59_Tuan.selinum_DangKy_TC6_59_NCT(); ;
                        break;
                    case 7:
                        dangKy_59_Tuan.selinum_DangKy_TC7_59_NCT(); ;
                        break;
                     case 8:
                        dangKy_59_Tuan.selinum_DangKy_TC8_59_NCT(); ;
                        break;
            }
        }
        
        }

        
    }
   
}
