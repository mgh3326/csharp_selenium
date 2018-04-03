using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string oh = System.AppDomain.CurrentDomain.BaseDirectory;
            //Console.WriteLine(oh);
            IWebDriver driver = new ChromeDriver("..\\..\\");

            driver.Url = "https://www.youtube.com/?gl=KR&hl=ko";
        }
    }
}
