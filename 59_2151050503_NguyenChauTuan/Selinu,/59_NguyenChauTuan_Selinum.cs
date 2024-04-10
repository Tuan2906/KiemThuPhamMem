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
        private OpenQA.Selenium.Chrome.ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        private ChromeDriver driver_59_NCT;
        public ChromeDriver init_59_NCT()
        {
            OpenQA.Selenium.Chrome.ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver_59_NCT = new ChromeDriver(service);
            driver_59_NCT.Navigate().GoToUrl("https://www.ivivu.com/ve-may-bay/thong-tin-hanh-khach/2564128");
            return driver_59_NCT;

        }
        public void selinum_ThongTinLienHe_TC1_59_NCT()
        {
            driver_59_NCT = init_59_NCT();

            var select = driver_59_NCT.FindElement(By.Name("gender"));
            var selected = new SelectElement(select);
            // selected.SelectByIndex(1);
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("Nguyen Tuấn Châu");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0902212777");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
        public void selinum_ThongTinLienHe_TC2_59_NCT()
        {
            driver_59_NCT = init_59_NCT();
            var select = driver_59_NCT.FindElement(By.Name("gender"));
            var selected = new SelectElement(select);
            selected.SelectByIndex(1);
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0902212777");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
        public void selinum_ThongTinLienHe_TC3_59_NCT()
        {
            driver_59_NCT = init_59_NCT();
            var select = driver_59_NCT.FindElement(By.Name("gender"));
            var selected = new SelectElement(select);
            selected.SelectByIndex(1);
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0902212777");
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
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0902212777");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
        public void selinum_ThongTinLienHe_TC5_59_NCT()
        {
            driver_59_NCT = init_59_NCT();
            var select = driver_59_NCT.FindElement(By.Name("gender"));
            var selected = new SelectElement(select);
            selected.SelectByIndex(1);
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0902212777");
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
            driver_59_NCT.FindElement(By.Name("fullName")).SendKeys("");
            driver_59_NCT.FindElement(By.Name("phone")).SendKeys("0902212777");
            driver_59_NCT.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(10000);
            driver_59_NCT.Close();

        }
    }
    public class _59_NguyenChauTuan_Selinum_DangKy
    {
        private OpenQA.Selenium.Chrome.ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        private ChromeDriver driver_59_NCT;
        private string url = "https://www.ivivu.com/";
        public void selinum_DangKy()
        {

            service.HideCommandPromptWindow = true;
            ChromeDriver driver = new ChromeDriver(service);
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.CssSelector("#UserLogin > a")).Click();
            driver.FindElement(By.XPath("//*[@id='UserLogin']/ul/li[2]/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("EmailDK")).SendKeys("tuanchaunguyen13@gmail.com");
            driver.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[2]/div/input")).SendKeys("12345");
            driver.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[3]/div/input")).SendKeys("12345");
            IWebElement checkbox = driver.FindElement(By.CssSelector("#policy-checkbox"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);

            driver.FindElement(By.XPath("//*[@id='RegisterModal']/div/div[2]/form/div/div[5]/button")).Click();
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@"..\\..\\img\\test.png");
            // driver.FindElement(By.Name("phone")).SendKeys("0902212777");
            // driver.FindElement(By.XPath("/html/body/app-root/app-passenger/div/div/div/section/div/div/passenger-info/div[1]/div/div/div/form/div/div[2]/div/div/div[7]/button")).Click();
            Thread.Sleep(2000);
            driver.Close();
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
