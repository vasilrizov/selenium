using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FileUploadDemo
{
    class Program
    {
        private static object qbig;
        private static object sbtc;

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\vasilpc\Desktop\Jars\");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.google.bg/imghp?hl=bg&tab=wi";
            driver.FindElement(By.XPath("//*[@id='sbtc']/div/div[2]/div[1]/span")).Click();

            driver.FindElement(By.XPath("//*[@id='qbug']/div/a")).Click();
            IWebElement fileUpload = driver.FindElement(By.XPath("//*[@id='qbfile']"));

            fileUpload.SendKeys(@"C:\Users\vasilpc\Desktop\3ey7r0sqm7p01.jpg");
        }
    }
}
