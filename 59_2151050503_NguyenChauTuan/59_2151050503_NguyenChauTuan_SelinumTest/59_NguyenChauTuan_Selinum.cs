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
using System.Drawing.Imaging;
using System.Threading;
namespace _59_2151050503_NguyenChauTuan_SelinumTest
{
    // Viết class để viết testcase cho chức năng ThongTinLienHe
    public class _59_NguyenChauTuan_Selinum_ThongTinLienHe
    {
        private IWebDriver driver_59_Tuan;// khai báo chormdriver
        public IWebDriver init_59_Tuan()// hàm Khởi tạo Chorm driver
        {
            // đóng cửa sổ màn hình đen
            OpenQA.Selenium.Chrome.ChromeDriverService service_59_Tuan = ChromeDriverService.CreateDefaultService();
            service_59_Tuan.HideCommandPromptWindow = true;
            driver_59_Tuan = new ChromeDriver(service_59_Tuan);// khởi tạo chormDriver
            driver_59_Tuan.Navigate().GoToUrl("https://www.ivivu.com/ve-may-bay/thong-tin-hanh-khach/2572072");// di chuyển đến đường dẫn được chỉ địnj
            return driver_59_Tuan;// trả về  driver_59_Tuan đã được di chuyển

        }
        public void selinum_ThongTinLienHe_TC1_59_Tuan()// Nhập thông tin liên hệ thiếu chọn giới tính
        {

            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo
            driver_59_Tuan.FindElement(By.Name("fullName")).SendKeys("");// bỏ dữ liệu vào thẻ input nhập họ tên có thuộc tính name là fullName
            driver_59_Tuan.FindElement(By.Name("phone")).SendKeys("0902212777");// // bỏ dữ liệu vào thẻ input nhập sđt có thuộc tính name là phone
            driver_59_Tuan.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();// nhấn nút button của thuộc tính Xpath
            Thread.Sleep(10000);// ngưng 1s
            driver_59_Tuan.Close();// đóng cửa số trình duyệt


        }
        public void selinum_ThongTinLienHe_TC2_59_Tuan()// Nhập thông tin liên hệ thiếu họ tên
        {
            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo
            var select = driver_59_Tuan.FindElement(By.Name("gender"));// tìm element giới tính để gán cho select
            var selected = new SelectElement(select);// khởi tạo có tham số là select cho selectEmlement 
            selected.SelectByIndex(1);// tlấy selected có vị trí là 1 nam
            driver_59_Tuan.FindElement(By.Name("fullName")).SendKeys("");// bỏ dữ liệu vào thẻ input nhập họ tên có thuộc tính name là fullName
            driver_59_Tuan.FindElement(By.Name("phone")).SendKeys("0925890292");// bỏ dữ liệu vào thẻ input nhập sđt có thuộc tính name là phone
            driver_59_Tuan.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();// nhấn nút button của thuộc tính Xpath
            Thread.Sleep(10000);// ngưng 10s
            driver_59_Tuan.Close();// đóng cửa số trình duyệt

        }
        public void selinum_ThongTinLienHe_TC3_59_Tuan()// Nhập thông tin liên hệ thiếu số điện thoại
        {
            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo
            var select = driver_59_Tuan.FindElement(By.Name("gender"));// tìm element giới tính để gán cho select
            var selected = new SelectElement(select);// khởi tạo có tham số là select cho selectEmlement 
            selected.SelectByIndex(2);// tlấy selected có vị trí là 1 nu
            driver_59_Tuan.FindElement(By.Name("fullName")).SendKeys("Nguyễn Châu Tuấn");// bỏ dữ liệu vào thẻ input nhập họ tên có thuộc tính name là fullName
            driver_59_Tuan.FindElement(By.Name("phone")).SendKeys("");// bỏ dữ liệu vào thẻ input nhập sđt có thuộc tính name là phone
            driver_59_Tuan.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();// nhấn nút button của thuộc tính Xpath
            Thread.Sleep(20000);// ngưng 2s
            driver_59_Tuan.Close();// đóng cửa số trình duyệt

        }
        public void selinum_ThongTinLienHe_TC4_59_Tuan()//: Nhập thông tin liên hệ sai họ tên
        {
            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo
            var select = driver_59_Tuan.FindElement(By.Name("gender"));// tìm element giới tính để gán cho select
            var selected = new SelectElement(select);// khởi tạo có tham số là select cho selectEmlement 
            selected.SelectByIndex(1);// tlấy selected có vị trí là 1 nam
            driver_59_Tuan.FindElement(By.Name("fullName")).SendKeys("Tuấn");// bỏ dữ liệu vào thẻ input nhập họ tên có thuộc tính name là fullName
            driver_59_Tuan.FindElement(By.Name("phone")).SendKeys("0925890292");// bỏ dữ liệu vào thẻ input nhập sđt có thuộc tính name là phone
            driver_59_Tuan.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();// nhấn nút button của thuộc tính Xpath
            Thread.Sleep(30000);// ngưng 3s
            driver_59_Tuan.Close();// đóng cửa số trình duyệt

        }
        public void selinum_ThongTinLienHe_TC5_59_Tuan()// Nhập thông tin liên hệ sai số điện thoại
        {
            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo
            var select = driver_59_Tuan.FindElement(By.Name("gender"));// tìm element giới tính để gán cho select
            var selected = new SelectElement(select);// khởi tạo có tham số là select cho selectEmlement 
            selected.SelectByIndex(2);// tlấy selected có vị trí là 2 nữ
            driver_59_Tuan.FindElement(By.Name("fullName")).SendKeys("Nguyễn Châu Tuấn");// bỏ dữ liệu vào thẻ input nhập họ tên có thuộc tính name là fullName
            driver_59_Tuan.FindElement(By.Name("phone")).SendKeys("59_Tuan");// bỏ dữ liệu vào thẻ input nhập sđt có thuộc tính name là phone
            driver_59_Tuan.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();// nhấn nút button của thuộc tính Xpath
            Thread.Sleep(10000);// ngưng 1s
            driver_59_Tuan.Close();// đóng cửa số trình duyệt

        }
        public void selinum_ThongTinLienHe_TC6_59_Tuan()//: Nhập thông tin liên hệ thành công
        {
            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo
            var select = driver_59_Tuan.FindElement(By.Name("gender"));// tìm element giới tính để gán cho select
            var selected = new SelectElement(select);// khởi tạo có tham số là select cho selectEmlement 
            selected.SelectByIndex(1);// tlấy selected có vị trí là 1 nam
            driver_59_Tuan.FindElement(By.Name("fullName")).SendKeys("Nguyễn Châu Tuấn");// bỏ dữ liệu vào thẻ input nhập họ tên có thuộc tính name là fullName
            driver_59_Tuan.FindElement(By.Name("phone")).SendKeys("0925890292");// bỏ dữ liệu vào thẻ input nhập sđt có thuộc tính name là phone
            driver_59_Tuan.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();// nhấn nút button của thuộc tính Xpath
            Thread.Sleep(10000);// ngưng 1s
            driver_59_Tuan.Close();// đóng cửa số trình duyệt

        }
    }

    // Viet class cho chuc nang selinum_DangKy
    public class _59_NguyenChauTuan_Selinum_DangKy
    {
        // đóng cửa sổ màn hình đen
        private OpenQA.Selenium.Chrome.ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        private IWebDriver driver_59_Tuan;// khai báo  driver_59_Tuan kiểu ChromeDriver
        private string url = "https://www.ivivu.com/";// khai báo đường dẫn url vs tham số là đường dẫn cần test
        public IWebDriver init_59_Tuan()// Hàm khởi tạo IwebDriver
        {

            service.HideCommandPromptWindow = true;
            driver_59_Tuan = new ChromeDriver(service);// khởi tạo  driver_59_Tuan
            driver_59_Tuan.Navigate().GoToUrl(url);// di chuyển đến trang cần test là trang iviu.com
            return driver_59_Tuan;// trả về  driver_59_Tuan hiện đại chính là trang đã mở 

        }
        public void selinum_DangKy_TC1_59_Tuan()// Đăng ký thiếu email
        {

            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo IwebDriver
            driver_59_Tuan.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_Tuan.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.FindElement(By.Name("EmailDK")).SendKeys("");//gửi dl vào input voi name EmailDK
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            IWebElement checkbox_59_Tuan = driver_59_Tuan.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            ((IJavaScriptExecutor)driver_59_Tuan).ExecuteScript("arguments[0].click();", checkbox_59_Tuan);// thực hiện click vào ô thông qua javascript

            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            var screenshot = ((ITakesScreenshot)driver_59_Tuan).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img

            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.Close();// đóng cửa sổ 
        }
        public void selinum_DangKy_TC2_59_Tuan()// Đăng ký thiếu mật khẩu
        {

            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo IwebDriver
            driver_59_Tuan.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_Tuan.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");//gửi dl vào input voi name EmailDK
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys(""); ;//gửi dl vào input voi XPath
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            IWebElement checkbox_59_Tuan = driver_59_Tuan.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            ((IJavaScriptExecutor)driver_59_Tuan).ExecuteScript("arguments[0].click();", checkbox_59_Tuan);// thực hiện click vào ô thông qua javascript

            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            var screenshot = ((ITakesScreenshot)driver_59_Tuan).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img

            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.Close();// đóng cửa sổ 
        }
        public void selinum_DangKy_TC3_59_Tuan()// Đăng ký thiếu xác nhận mật khẩu
        {

            driver_59_Tuan = init_59_Tuan();//  gọi hàm khởi tạo IwebDriver
            driver_59_Tuan.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_Tuan.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");//gửi dl vào input voi name EmailDK
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys(""); ;//gửi dl vào input voi XPath
            IWebElement checkbox = driver_59_Tuan.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            ((IJavaScriptExecutor)driver_59_Tuan).ExecuteScript("arguments[0].click();", checkbox);// thực hiện click vào ô thông qua javascript

            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            var screenshot = ((ITakesScreenshot)driver_59_Tuan).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img

            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.Close();// đóng cửa sổ 
        }
        public void selinum_DangKy_TC4_59_Tuan()//Đăng ký thiếu tick điều khoản
        {

            driver_59_Tuan = init_59_Tuan();//gọi hàm khởi tạo IwebDriver
            driver_59_Tuan.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_Tuan.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");//gửi dl vào input voi name EmailDK
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            //IWebElement checkbox = driver_59_Tuan.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            //((IJavaScriptExecutor)driver_59_Tuan).ExecuteScript("arguments[0].click();", checkbox);// thực hiện click vào ô thông qua javascript

            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            var screenshot_59_Tuan = ((ITakesScreenshot)driver_59_Tuan).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot_59_Tuan.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img

            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.Close();// đóng cửa sổ 
        }
        public void selinum_DangKy_TC5_59_Tuan()//Đăng ký sai email
        {

            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo IwebDriver
            driver_59_Tuan.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_Tuan.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.FindElement(By.Name("EmailDK")).SendKeys("tuan_59");//gửi dl vào input voi name EmailDK
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            IWebElement checkbox = driver_59_Tuan.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            ((IJavaScriptExecutor)driver_59_Tuan).ExecuteScript("arguments[0].click();", checkbox);// thực hiện click vào ô thông qua javascript

            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            var screenshot_59_Tuan = ((ITakesScreenshot)driver_59_Tuan).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot_59_Tuan.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img

            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.Close();// đóng cửa sổ 
        }
        public void selinum_DangKy_TC6_59_Tuan()
        {
            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo IwebDriver
            driver_59_Tuan.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_Tuan.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");//gửi dl vào input voi name EmailDK
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("2906"); ;//gửi dl vào input voi XPath
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            IWebElement checkbox = driver_59_Tuan.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            ((IJavaScriptExecutor)driver_59_Tuan).ExecuteScript("arguments[0].click();", checkbox);// thực hiện click vào ô thông qua javascript

            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            var screenshot = ((ITakesScreenshot)driver_59_Tuan).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img

            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.Close();// đóng cửa sổ 
        }
        public void selinum_DangKy_TC7_59_Tuan()// Đăng ký sai xác nhận mật khẩu
        {

            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo IwebDriver
            driver_59_Tuan.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_Tuan.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");//gửi dl vào input voi name EmailDK
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("2906"); ;//gửi dl vào input voi XPath
            IWebElement checkbox = driver_59_Tuan.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            ((IJavaScriptExecutor)driver_59_Tuan).ExecuteScript("arguments[0].click();", checkbox);// thực hiện click vào ô thông qua javascript

            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            var screenshot = ((ITakesScreenshot)driver_59_Tuan).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img

            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.Close();// đóng cửa sổ 
        }
        public void selinum_DangKy_TC8_59_Tuan()// Đăng ký thành công
        {

            driver_59_Tuan = init_59_Tuan();// gọi hàm khởi tạo IwebDriver
            driver_59_Tuan.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_Tuan.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen29@gmail.com");//gửi dl vào input voi name EmailDK
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("290620"); ;//gửi dl vào input voi XPath
            IWebElement checkbox = driver_59_Tuan.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            ((IJavaScriptExecutor)driver_59_Tuan).ExecuteScript("arguments[0].click();", checkbox);// thực hiện click vào ô thông qua javascript

            driver_59_Tuan.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            Thread.Sleep(2000);// dừng 2s
            var screenshot = ((ITakesScreenshot)driver_59_Tuan).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img

            Thread.Sleep(2000);// dừng 2s
            driver_59_Tuan.Close();// đóng cửa sổ 
        }
    }
}
