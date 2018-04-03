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
            ////string oh = System.AppDomain.CurrentDomain.BaseDirectory;//실행 경로 확인하기 위해서 이렇게 했음
            ////Console.WriteLine(oh);
            //var chromeOptions = new ChromeOptions
            //{
            //    BinaryLocation = @"../../",
            //    //IWebDriver driver = new ChromeDriver(@"C:\my\path\to\chromedriver\directory");

            //DebuggerAddress = "localhost:9222"
            //};

            //chromeOptions.AddArguments(new List<string>() { "headless", "disable-gpu" });

            //IWebDriver driver = new ChromeDriver(chromeOptions);//Debug Release 다 가능하게 하기 위함


            ////var browser = new ChromeDriver(chromeOptions);

            ////driver.Url = "https://www.youtube.com/?gl=KR&hl=ko";//처음 링크 유튜브
            //driver.Url = "https://mgh3326.github.io";//처음 링크 유튜브
            //String pageSource = driver.PageSource;
            //Console.WriteLine(pageSource);
            //Console.WriteLine("Finish");
            var chromeOptions = new ChromeOptions();


            chromeOptions.AddArguments(new List<string>() { "no-sandbox", "headless", "disable-gpu" }); //옵션 왜 3개 인지는 모르겠는데 일단 이렇게 해야겠다.

            var driverService = ChromeDriverService.CreateDefaultService();//크롬 드라이버 경고 안뜨게 하는거 
            driverService.HideCommandPromptWindow = true;// 출처 : http://yizeng.me/2014/03/05/hide-command-prompt-window-in-selenium-webdriver-net-binding/


            var driver = new ChromeDriver(driverService, chromeOptions);


            driver.Url = "https://www.youtube.com/?gl=KR&hl=ko";//처음 링크 유튜브
            Console.Clear();
            String pageSource = driver.PageSource;
            Console.WriteLine(pageSource);
            Console.WriteLine("Finish");
        }
    }
}
