using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using myhelloworld.utils;

namespace myhelloworld.attributes 
{
    public class HomeAttributes : ElementFactory {

        public IWebElement preview() {
            return getElementPresent(By.XPath("//*[@class='widgettitle' and text()='Categories']/..//a[text()='Preview']"));
        }

    }
}