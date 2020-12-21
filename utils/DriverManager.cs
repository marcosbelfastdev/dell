using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace myhelloworld.utils
{
    public class DriverManager
    {
        private static IWebDriver driver;

        public static IWebDriver Driver() {
            return driver;
        }
       
       public static IWebDriver Create() {
           driver = new ChromeDriver("/home/marcos/lib/webdrivers/chrome_87");
           return driver;
       }
    }
}