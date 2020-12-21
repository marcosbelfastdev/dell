using System;
using System.Threading;
using NUnit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using myhelloworld.utils;
using myhelloworld.main.pages;
using myhelloworld.main.api;
using NUnit.Framework;

namespace myhelloworld.tests
{

    [TestFixture]
    public class ErbiumFrameworkTest : IDisposable {
        IWebDriver driver = DriverManager.Create();
        
        public void FindAndClick()
        {
            Home home = new Home();
            home.NavigateToHomePage();
            home.clickCategoriesPreview(); 
        }

        public void Dispose() {
            Thread.Sleep(10000);
            DriverManager.Driver().Quit();
        }

    }
    
}
