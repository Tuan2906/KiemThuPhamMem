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

            test_59_Tuan testSelium_59_Tuan = new test_59_Tuan();// Khởi tạo test_59_Tuan
            int dem_59_Tuan = 0;// khai báo dem_59_Tuan
            string chon_59_Tuan = "";// khai báo chon_59_Tuan
            string name_59_Tuan = "";// khai báo name_59_Tuan


            while (true)// chạy vòng lặp vô tận
            {
                if (dem_59_Tuan == 0)// so sánh dem_59_Tuan có bằng 0 thực hiện nhập chức năng test
                {
                    Console.Write("Enter Chức năng test: ");
                    name_59_Tuan = Console.ReadLine();
                }
                if (name_59_Tuan.Contains("exit"))// so sánh nếu nam_59_Tuan chứa exit
                {
                    break;// thoát khỏi vòng lặp
                }
                dem_59_Tuan++;// tăng dem_59_Tuan
                if (dem_59_Tuan >= 1)// Nếu dem_59_Tuan lớn hơn hoặc bằng 1 thì thực hiện nhập testcase
                {
                    Console.Write("Enter  testcase: ");
                    chon_59_Tuan = Console.ReadLine();
                }
                if (chon_59_Tuan=="0")// nếu chon_59_Tuan bằng "0" thì reset lại dem_59_Tuan=0
                {
                    dem_59_Tuan = 0;
                }
               else if (name_59_Tuan.Contains("Thong Tin Lien He"))// ngược lại nếu nam_59_Tuan chứa Thong Tin Lien He
                {
                   string ketQua_59_Tuan=testSelium_59_Tuan.testCaseTTLienHe_59_Tuan(int.Parse(chon_59_Tuan));// thực hiện gán ketQua_59_Tuan sau khi gọi hàm testCaseTTLienHe_59_Tuan(int.Parse(chon_59_Tuan))
                    Console.Write("Ket qua testcase " + chon_59_Tuan + ": " + ketQua_59_Tuan +"\n");// In kết quả của test case được chỉ định test
                }
                else if(name_59_Tuan.Contains("Dang ki"))// ngược lại nếu nam)_59_Tuan chứa Dang ki
                {
                    testSelium_59_Tuan.testCaseTTDangKy_59_Tuan(int.Parse(chon_59_Tuan));// thực hiện gọi hàm testCaseTTDangKy_59_Tuan(int.Parse(chon_59_Tuan))

                }
            }
        
            
        }
        // Viết class chứa các hàm testCaseTTLienHe_59_Tuan và testCaseTTDangKy_59_Tuan
        public class test_59_Tuan {
            private _59_NguyenChauTuan_Selinum_ThongTinLienHe lienHe_59_Tuan = new _59_NguyenChauTuan_Selinum_ThongTinLienHe();// khởi tạo _59_NguyenChauTuan_Selinum_ThongTinLienHe() từ file _59_NguyenChauTuan_Selinum_ThongTinLienHe()
            private _59_NguyenChauTuan_Selinum_DangKy dangKy_59_Tuan = new _59_NguyenChauTuan_Selinum_DangKy(); // khởi tạo _59_NguyenChauTuan_Selinum_DangKy từ file _59_NguyenChauTuan_Selinum_DangKy
            public string testCaseTTLienHe_59_Tuan(int chon_59_Tuan)// viết hàm trả về string của testCaseTTLienHe_59_Tuan
            {
                string ketqua_59_Tuan = "";// khai báo ketqua_59_Tuan bằng rỗng
                switch (chon_59_Tuan)// kiểm tra chon_59_Tuan
                {
                    case 1:// nếu chon_59_Tuan = 1 
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC1_59_Tuan();// gọi hàm selinum_ThongTinLienHe_TC1_59_Tuan()
                        ketqua_59_Tuan = "Failed";// gán kết quả là Failed
                        break;
                    case 2:// nếu chon_59_Tuan = 2
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC2_59_Tuan();// gọi hàm selinum_ThongTinLienHe_TC2_59_Tuan()
                        ketqua_59_Tuan = "Failed";// gán kết quả là Failed
                        break;
                    case 3:// nếu chon_59_Tuan = 3 
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC3_59_Tuan();// gọi hàm selinum_ThongTinLienHe_TC3_59_Tuan()
                        ketqua_59_Tuan = "Failed";// gán kết quả là Failed

                        break;
                    case 4:// nếu chon_59_Tuan = 4 
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC4_59_Tuan();// gọi hàm selinum_ThongTinLienHe_TC4_59_Tuan()
                        ketqua_59_Tuan = "Failed";// gán kết quả là Failed

                        break;
                    case 5:// nếu chon_59_Tuan = 5 
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC5_59_Tuan();// gọi hàm selinum_ThongTinLienHe_TC5_59_Tuan()
                        ketqua_59_Tuan = "Failed";// gán kết quả là Failed

                        break;
                    case 6:// nếu chon_59_Tuan = 6 
                        lienHe_59_Tuan.selinum_ThongTinLienHe_TC6_59_Tuan();// gọi hàm selinum_ThongTinLienHe_TC6_59_Tuan()
                        ketqua_59_Tuan = "Passed";// gán kết quả là Passed

                        break;
                }
                return ketqua_59_Tuan;// trả về ketqua_59_Tuan
            }
            public void testCaseTTDangKy_59_Tuan(int chon_59_Tuan)// viết hàm testCaseTTDangKy_59_Tuan
            {
                switch (chon_59_Tuan)// kiểm tra chon_59_Tuan
                {
                    case 1:// nếu chon_59_Tuan = 1
                        dangKy_59_Tuan.selinum_DangKy_TC1_59_Tuan();// gọi hàm selinum_DangKi_TC1_59_Tuan()
                        break;
                    case 2:// nếu chon_59_Tuan = 2
                        dangKy_59_Tuan.selinum_DangKy_TC2_59_Tuan();// gọi hàm selinum_DangKi_TC2_59_Tuan()
                        break;
                    case 3:// nếu chon_59_Tuan = 3
                        dangKy_59_Tuan.selinum_DangKy_TC3_59_Tuan();// gọi hàm selinum_DangKi_TC3_59_Tuan()
                        break;
                    case 4:// nếu chon_59_Tuan = 4
                        dangKy_59_Tuan.selinum_DangKy_TC4_59_Tuan();// gọi hàm selinum_DangKi_TC4_59_Tuan()
                        break;
                    case 5:// nếu chon_59_Tuan = 5
                        dangKy_59_Tuan.selinum_DangKy_TC5_59_Tuan();// gọi hàm selinum_DangKi_TC5_59_Tuan()
                        break;
                    case 6:// nếu chon_59_Tuan = 6
                        dangKy_59_Tuan.selinum_DangKy_TC6_59_Tuan();// gọi hàm selinum_DangKi_TC6_59_Tuan()
                        break;
                    case 7:// nếu chon_59_Tuan = 7
                        dangKy_59_Tuan.selinum_DangKy_TC7_59_Tuan(); // gọi hàm selinum_DangKi_TC7_59_Tuan()
                        break;
                     case 8:// nếu chon_59_Tuan = 8
                        dangKy_59_Tuan.selinum_DangKy_TC8_59_Tuan();// gọi hàm selinum_DangKi_TC8_59_Tuan()
                        break;
            }
        }
        
        }

        
    }
   
}
