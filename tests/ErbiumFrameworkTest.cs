using System;
using System.Threading;
using Xunit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using myhelloworld.utils;
using myhelloworld.main.pages;
using myhelloworld.main.api;

namespace myhelloworld.tests
{

    public class ErbiumFrameworkTest : IDisposable {
        //IWebDriver driver = DriverManager.Create();
        const string LIVROS = "livros";

        // [Fact]
        // public void FindAndClick()
        // {
        //     Home home = new Home();
        //     home.NavigateToHomePage();
        //     home.clickCategoriesPreview(); 
        // }

        public void Dispose() {
            //Thread.Sleep(10000);
            //DriverManager.Driver().Quit();
        }

        [Fact]
        public void ApiTest()
        {
            var api = new Api("127.0.0.1:8080");
            Console.WriteLine("Im here...");
            RA.ResponseContext response = api.SetUri(LIVROS, "/lista/todos/")
               .SetCode(200)
               .Get();
            Console.WriteLine("." + response.Debug() + ".");
        
        }

    }
    
}
