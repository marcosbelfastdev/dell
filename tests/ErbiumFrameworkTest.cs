using System;
using System.Threading;
using NUnit;
using OpenQA.Selenium;
using dell.utils;
using NUnit.Framework;
using dell.src.main.pages;
namespace dell.tests
{

    [TestFixture]
    public class ErbiumFrameworkTest : IDisposable {
        IWebDriver driver;

        [SetUp]
        public void SetUp() 
        {
            driver = DriverManager.Create();
        }
        
        [Test]
        public void FindAndClick()
        {
            Home home = new Home();
            home.NavigateToHomePage();
            home.clickCategoriesPreview(); 
        }

        [TearDown]
        public void Dispose() 
        {
            Thread.Sleep(10000);
            DriverManager.Driver().Quit();
        }

    }
    
}
