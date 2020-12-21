using dell.utils;
using dell.attributes;

namespace dell.src.main.pages
{
    public class Home : HomeAttributes
    {
        public void NavigateToHomePage() {
            DriverManager.Driver().Manage().Window.Maximize();
            DriverManager.Driver().Navigate().GoToUrl("http://www.erbiumframework.org");
        }

        public void clickCategoriesPreview() {
            preview().Click();
        }
    }
}