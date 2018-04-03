using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace selenium_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver("C:\\chrome");

            driver.Url = "https://www.youtube.com/?gl=KR&hl=ko";
        }
    }
}
