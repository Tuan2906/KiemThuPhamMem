using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Drawing.Imaging;
using System.Threading;
namespace _59_2151050503_NguyenChauTuan_SelinumTest
{
    public class _59_NguyenChauTuan_Selinum_ThongTinLienHe
    {
        private ChromeDriver driver_59_NCT;// khai báo chormdriver
        public ChromeDriver init_59_NCT()// hàm Khởi tạo Chorm driver
        {
            // đóng cửa sổ màn hình đen
            OpenQA.Selenium.Chrome.ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver_59_NCT = new ChromeDriver(service);// khởi tạo chormDriver
            driver_59_NCT.Navigate().GoToUrl("https://www.ivivu.com/ve-may-bay/thong-tin-hanh-khach/2567521");// di chuyển đến đường dẫn được chỉ địnj
            return driver_59_NCT;// trả về driver_59_NCT đã được di chuyển

        }
        public void selinum_ThongTinLienHe_TC1_59_NCT()
        {
            driver_59_NCT = init_59_NCT();// gọi hàm khởi tạo

           
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("Nguyen Tuấn Châu");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0902212777");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
        public void selinum_ThongTinLienHe_TC2_59_NCT()
        {
            driver_59_NCT = init_59_NCT();// gọi hàm khởi tạo
            var select = driver_59_NCT.FindElement(By.Name("gender"));// tìm element giới tính để gán cho select
            var selected = new SelectElement(select);// khởi tạo có tham số là select cho selectEmlement 
             selected.SelectByIndex(1);// tlấy selected có vị trí là 1 nam
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("");// nhập họ và tên là rỗng
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0925890292");// nhập số điện thoại
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();// nhấn nút button là nhập thông tin hành khách
            Thread.Sleep(10000);// người 10s
            driver_59_NCT.Close();// đóng cửa sổ

        }
        public void selinum_ThongTinLienHe_TC3_59_NCT()
        {
            driver_59_NCT = init_59_NCT();// gọi hàm khởi tạo
            var select = driver_59_NCT.FindElement(By.Name("gender"));// tìm element giới tính để gán cho select
            var selected = new SelectElement(select);// khởi tạo có tham số là select cho selectEmlement 
            selected.SelectByIndex(2);// tlấy selected có vị trí là 1 nu
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("Nguyen Châu Tuấn");// nhập họ và tên là 
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
        public void selinum_ThongTinLienHe_TC4_59_NCT()
        {
            driver_59_NCT = init_59_NCT();
            var select = driver_59_NCT.FindElement(By.Name("gender"));
            var selected = new SelectElement(select);
            selected.SelectByIndex(1);
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("Tuấn");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0925890292");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
        public void selinum_ThongTinLienHe_TC5_59_NCT()
        {
            driver_59_NCT = init_59_NCT();
            var select = driver_59_NCT.FindElement(By.Name("gender"));
            var selected = new SelectElement(select);
            selected.SelectByIndex(2);
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("Châu Tuấn");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("113");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
        public void selinum_ThongTinLienHe_TC6_59_NCT()
        {
            driver_59_NCT = init_59_NCT();
            var select = driver_59_NCT.FindElement(By.Name("gender"));
            var selected = new SelectElement(select);
            selected.SelectByIndex(1);
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("Châu Tuấn");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0925890292");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
    }

    // Viet class cho chuc nang selinum_DangKy
    public class _59_NguyenChauTuan_Selinum_DangKy
    {
        // đóng cửa sổ màn hình đen
        private OpenQA.Selenium.Chrome.ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        private ChromeDriver driver_59_NCT;// khai báo driver_59_NCT kiểu ChromeDriver
        private string url = "https://www.ivivu.com/";// khai báo đường dẫn url vs tham số là đường dẫn cần test
        public ChromeDriver init_59_NCT()
        {
            
            service.HideCommandPromptWindow = true;
            driver_59_NCT = new ChromeDriver(service);// khởi tạo driver_59_NCT
            driver_59_NCT.Navigate().GoToUrl(url);// di chuyển đến trang cần test là trang iviu.com
            return driver_59_NCT;// trả về driver_59_NCT hiện đại chính là trang đã mở 

        }
        public void selinum_DangKy_TC1_59_NCT()
        {

            driver_59_NCT = init_59_NCT();// gọi hàm 
            driver_59_NCT.FindElement(By.CssSelector("#UserLogin > a")).Click();// tìm thẻ a và thực hiện click 
            driver_59_NCT.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();// chọn  đăng ký
            Thread.Sleep(2000);// dừng 2s
            driver_59_NCT.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");//gửi dl vào input voi name EmailDK
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345"); ;//gửi dl vào input voi XPath
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345"); ;//gửi dl vào input voi XPath
            IWebElement checkbox = driver_59_NCT.FindElement(By.CssSelector("#policy-checkbox"));// lấy ô checkbox của policy-checkbox
            ((IJavaScriptExecutor)driver_59_NCT).ExecuteScript("arguments[0].click();", checkbox);// thực hiện click vào ô thông qua javascript

            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();// nhấn nút đăng ký
            var screenshot = ((ITakesScreenshot)driver_59_NCT).GetScreenshot();// chụp màn hình kết quả sau khi nhấn nút
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");// lưu  ảnh vào đường có tên test.png trong thư mục img
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);// dừng 2s
            driver_59_NCT.Close();// đóng cửa sổ 
        }
        public void selinum_DangKy_TC2_59_NCT()
        {

            driver_59_NCT = init_59_NCT();
            driver_59_NCT.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver_59_NCT.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();
            driver_59_NCT.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_59_NCT.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345");
            IWebElement checkbox = driver_59_NCT.FindElement(By.CssSelector("#policy-checkbox"));
            ((IJavaScriptExecutor)driver_59_NCT).ExecuteScript("arguments[0].click();", checkbox);

            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();
            var screenshot = ((ITakesScreenshot)driver_59_NCT).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);
            driver_59_NCT.Close();
        }
        public void selinum_DangKy_TC3_59_NCT()
        {

            driver_59_NCT = init_59_NCT();
            driver_59_NCT.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver_59_NCT.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();
            driver_59_NCT.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_59_NCT.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345");
            IWebElement checkbox = driver_59_NCT.FindElement(By.CssSelector("#policy-checkbox"));
            ((IJavaScriptExecutor)driver_59_NCT).ExecuteScript("arguments[0].click();", checkbox);

            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();
            var screenshot = ((ITakesScreenshot)driver_59_NCT).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);
            driver_59_NCT.Close();
        }
        public void selinum_DangKy_TC4_59_NCT()
        {

            driver_59_NCT = init_59_NCT();
            driver_59_NCT.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver_59_NCT.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();
            driver_59_NCT.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_59_NCT.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345");
            IWebElement checkbox = driver_59_NCT.FindElement(By.CssSelector("#policy-checkbox"));
            ((IJavaScriptExecutor)driver_59_NCT).ExecuteScript("arguments[0].click();", checkbox);

            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();
            var screenshot = ((ITakesScreenshot)driver_59_NCT).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);
            driver_59_NCT.Close();
        }
        public void selinum_DangKy_TC5_59_NCT()
        {

            driver_59_NCT = init_59_NCT();
            driver_59_NCT.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver_59_NCT.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();
            driver_59_NCT.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_59_NCT.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345");
            IWebElement checkbox = driver_59_NCT.FindElement(By.CssSelector("#policy-checkbox"));
            ((IJavaScriptExecutor)driver_59_NCT).ExecuteScript("arguments[0].click();", checkbox);

            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();
            var screenshot = ((ITakesScreenshot)driver_59_NCT).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);
            driver_59_NCT.Close();
        }
        public void selinum_DangKy_TC6_59_NCT()
        {

            driver_59_NCT = init_59_NCT();
            driver_59_NCT.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver_59_NCT.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();
            driver_59_NCT.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_59_NCT.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345");
            IWebElement checkbox = driver_59_NCT.FindElement(By.CssSelector("#policy-checkbox"));
            ((IJavaScriptExecutor)driver_59_NCT).ExecuteScript("arguments[0].click();", checkbox);

            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();
            var screenshot = ((ITakesScreenshot)driver_59_NCT).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);
            driver_59_NCT.Close();
        }
        public void selinum_DangKy_TC7_59_NCT()
        {

            driver_59_NCT = init_59_NCT();
            driver_59_NCT.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver_59_NCT.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();
            driver_59_NCT.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_59_NCT.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345");
            IWebElement checkbox = driver_59_NCT.FindElement(By.CssSelector("#policy-checkbox"));
            ((IJavaScriptExecutor)driver_59_NCT).ExecuteScript("arguments[0].click();", checkbox);

            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();
            var screenshot = ((ITakesScreenshot)driver_59_NCT).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);
            driver_59_NCT.Close();
        }
        public void selinum_DangKy_TC8_59_NCT()
        {

            driver_59_NCT = init_59_NCT();
            driver_59_NCT.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver_59_NCT.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();
            driver_59_NCT.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_59_NCT.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345");
            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345");
            IWebElement checkbox = driver_59_NCT.FindElement(By.CssSelector("#policy-checkbox"));
            ((IJavaScriptExecutor)driver_59_NCT).ExecuteScript("arguments[0].click();", checkbox);

            driver_59_NCT.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();
            var screenshot = ((ITakesScreenshot)driver_59_NCT).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);
            driver_59_NCT.Close();
        }
        
        public void selinum_DangNhap()
        {
            service.HideCommandPromptWindow = true;
            ChromeDriver driver = new ChromeDriver(service);
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver.FindElement(By.ClassName("btn-login-header")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("EmailPhoneDN")).SendKeys("tuanchaunguyen13@gmail.com");

        }
    }
}
