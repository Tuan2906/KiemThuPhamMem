using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.IO;
using System.Text;

namespace _59_2151050503_NguyenChauTuan_Unitest
{
    [TestClass]
    public class UnitTest_TimKiem
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\\..\\DatTestTim\testTim.csv", "testTim#csv", DataAccessMethod.Sequential)]// đọc file test.csv trong thư mục Data
       //[TestMethod]
        public void TestMethod1()
        {
            OpenQA.Selenium.Chrome.ChromeDriverService service_59_NguyenChauTuan = ChromeDriverService.CreateDefaultService();
            ChromeDriver driver_59_NguyenChauTuan = new ChromeDriver();// khởi tạo driver
                                                                       //gọi trang web
            var tim = TestContext.DataRow[0].ToString();// lấy dữ liệu của tìm
            driver_59_NguyenChauTuan.Navigate().GoToUrl("https://www.ivivu.com/");
            driver_59_NguyenChauTuan.FindElement(By.LinkText("Vé vui chơi")).Click();// click vào link có text là vé vui chơi
            driver_59_NguyenChauTuan.FindElement(By.CssSelector("#search-component > div > div > div.col-md-8.col-xs-12.mx-0 > div > div > div > div.col-sm-10.col-xs-9.pl-0.search-wrapper > input")).SendKeys(tim);// bỏ dữ liệu tìm vào input tìm kiếm
            driver_59_NguyenChauTuan.FindElement(By.CssSelector("#search-component > div > div > div.col-md-8.col-xs-12.mx-0 > div > div > div > div.col-lg-2.col-sm-2.col-xs-3.p-0.d-flex.btn-tim > button")).Click();// click nút tìm kiem
            Thread.Sleep(4000);
            int kq_59_NguyenChauTuan = driver_59_NguyenChauTuan.FindElements(By.CssSelector("#keyword-search > div.keyword-search-container.container > div > div.keyword-search-layout > div.search-right > div > div.keyword-search-items.no-results > p")).Count;// đếm noi dung khong tim thay nếu user tìm kiếm không thấy
            int expect_59_NguyenChauTuan = 1;
            bool result_59_NguyenChauTuan = false;
            try
            {
                Assert.AreNotEqual(kq_59_NguyenChauTuan, expect_59_NguyenChauTuan);//ket qua khong bang 1 thi pass nguoc lai thi faile quăng cho catch
                result_59_NguyenChauTuan = true;// nếu kết quả asesrt trả ra hợp lệ thì cập nhật true cho reult
            }
            catch (Exception)
            {
                //Khong Lam nhung thu gi neu ket qua va expect bang nhau
            }

            // Write the test result to a CSV file
            string filePath_59_NguyenChauTuan = @"..\\..\\DatTestTim\test_results.csv";// gán đường dẫn filepath để lưu
            if (!File.Exists(filePath_59_NguyenChauTuan))// kiểm tra file có tồn tại hay chưa
            {
                File.WriteAllText(filePath_59_NguyenChauTuan, "Name,Result\n");// nếu không tồn tại sẽ tạo một tệp tin mới với đường dẫn đó và ghi dòng "Name,Result" vào tệp tin.
            }
            File.AppendAllText(filePath_59_NguyenChauTuan, tim + "," + result_59_NguyenChauTuan + "\n");// ghi dữ liệu tập tin 
            Thread.Sleep(4000);// Chờ 4s
            driver_59_NguyenChauTuan.Quit();// đóng tất cả liên kết
            Assert.AreNotEqual(kq_59_NguyenChauTuan, expect_59_NguyenChauTuan);//ket qua khong bang 1 thi pass nguoc lai thi faile quăng cho catch
            

        }

    }
}
