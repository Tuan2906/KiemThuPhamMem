using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.IO;

namespace _59_2151050503_NguyenChauTuan_Unittest
{
    [TestClass]
    public class UnitTest_DangNhap_59_NCT
    {


        public TestContext TestContext { get; set; }
       // [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\\..\\DataTest_59_Tuan\\testDangNhap_59_Tuan.csv", "testDangNhap_59_Tuan#csv", DataAccessMethod.Sequential)]// đọc file test.csv trong thư mục Data
        [TestMethod]
        public void DangNhap_59_NCT()
        {
            //  đóng cửa sổ màn hình đen
            OpenQA.Selenium.Chrome.ChromeDriverService service_59_NguyenChauTuan = ChromeDriverService.CreateDefaultService();
            service_59_NguyenChauTuan.HideCommandPromptWindow = true;
            ChromeDriver driver_59_NguyenChauTuan = new ChromeDriver(service_59_NguyenChauTuan);// khởi tạo driver
                                                     //gọi trang web
            var email_59_NguyenChauTuan = TestContext.DataRow[0].ToString();// lấy dữ liệu email chuyển sang dạng chuổi
            var password_59_NguyenChauTuan = TestContext.DataRow[1].ToString();// lấy dữ liệu password chuyển sang dạng chuỗi


            driver_59_NguyenChauTuan.Navigate().GoToUrl("https://www.ivivu.com/");// truyền đường dẫn để di chuyển đến trang cần test
            driver_59_NguyenChauTuan.FindElement(By.CssSelector("#UserLogin > a")).Click();//click vao icon user de dang nhap
            driver_59_NguyenChauTuan.FindElement(By.ClassName("btn-login-header")).Click();// click vao nút button đăng nhập để hiện form đăng nhập
            driver_59_NguyenChauTuan.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_59_NguyenChauTuan.FindElement(By.Name("EmailPhoneDN")).SendKeys(email_59_NguyenChauTuan);// nhập email
            driver_59_NguyenChauTuan.FindElement(By.Name("PasswordDN")).SendKeys(password_59_NguyenChauTuan);// nhập password
            driver_59_NguyenChauTuan.FindElement(By.XPath("//*[@id='loginForm']/div/div[3]/button")).Click();// click nút button để thực thi 
            int actual_59_NguyenChauTuan = driver_59_NguyenChauTuan.FindElements(By.CssSelector("#UserLogin > ul > div > button")).Count;// đếm nút đăng xuất nếu user đăng nhập thành công
            Console.WriteLine(actual_59_NguyenChauTuan);
            int expected_59_NguyenChauTuan = 1;
            driver_59_NguyenChauTuan.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);// dừng 10s
            driver_59_NguyenChauTuan.Close();// đóng liên kết hiện đại
            string result_59_NguyenChauTuan = "Failed";// khai báo result là failed
            if (actual_59_NguyenChauTuan == expected_59_NguyenChauTuan)// nếu thực tế bằng mong đợi
            {
                result_59_NguyenChauTuan = "Passed";// cập nhật result là Passed

            }

            // Write the test result to a CSV file
            string filePath_59_NguyenChauTuan = @"..\\..\\DataTest_59_Tuan\test_results_59_Tuan.csv";// gán đường dẫn filepath để lưu
            if (!File.Exists(filePath_59_NguyenChauTuan))// kiểm tra file có tồn tại hay chưa
            {
                File.WriteAllText(filePath_59_NguyenChauTuan, "Email,Password,Result,\n");// nếu không tồn tại sẽ tạo một tệp tin mới với đường dẫn đó và ghi dòng "Name,Result" vào tệp tin.
            }
            File.AppendAllText(filePath_59_NguyenChauTuan, email_59_NguyenChauTuan+ ","+password_59_NguyenChauTuan+"," + result_59_NguyenChauTuan + "\n");// ghi dữ liệu tập tin 
            Assert.AreEqual(actual_59_NguyenChauTuan, expected_59_NguyenChauTuan);// so sánh giá trị ket qua nếu không bằng gia tri mong doi thì test case pass ngược lại fail
           

        }
    
    }
}
