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
            //string oh = System.AppDomain.CurrentDomain.BaseDirectory;//실행 경로 확인하기 위해서 이렇게 했음
            //Console.WriteLine(oh);
            IWebDriver driver = new ChromeDriver("..\\..\\");//Debug Release 다 가능하게 하기 위함

            driver.Url = "https://www.youtube.com/?gl=KR&hl=ko";//처음 링크 유튜브
        }
    }
}
