using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using dell.utils;

namespace dell.attributes 
{
    public class HomeAttributes : ElementFactory {

        public IWebElement preview() {
            return getElementPresent(By.XPath("//*[@class='widgettitle' and text()='Categories']/..//a[text()='Preview']"));
        }

    }
}