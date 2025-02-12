using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
   
            IWebDriver driver = new ChromeDriver();//creating chrome driver to open webpage called driver

            
            driver.Navigate().GoToUrl("https://www.google.com");//use chrome driver to open google

           
            string pageTitle = driver.Title;//create a string called pageTitle value of the title of the page
            Console.WriteLine("Page Title: " + pageTitle);//output the title of the page for readiblity

            
            if (pageTitle.Contains("Google"))//if pageTitle is google
            {
                Console.WriteLine("Test Passed!");//test passed
            }
            else
            {
                Console.WriteLine("Test Failed!");
            }

    
            driver.Quit();
        }
    }
}
