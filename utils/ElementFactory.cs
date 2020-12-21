using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using myhelloworld.utils;

namespace myhelloworld.utils
{
    public class ElementFactory
    {
        private const int resolve = 15;

        public IWebElement getElementPresent(By by) {
            WebDriverWait wait = new WebDriverWait(DriverManager.Driver(), System.TimeSpan.FromSeconds(resolve));
            return wait.Until(driver => driver.FindElement(by));
        }
    }
}