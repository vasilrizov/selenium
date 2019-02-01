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

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\vasilpc\Desktop\Jars\");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.vum.bg/hello-vum/";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElement(By.XPath("//*[@id='panel-w5978b385b7435-0-0-1']/div/div/ul/li[1]/a")).SendKeys(Keys.Enter);

            string valueString = "I was here";
            Console.WriteLine(valueString);


        }
    }
}
