
using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Selenium
{
    public static class Bot
    {
        [STAThread]
        static void Main()
        {
            //Creating instance
            IWebDriver chromeDriver = new ChromeDriver();

            //Navigation
            chromeDriver.Navigate().GoToUrl("https://www.dijipol.com/zorunlu-trafik-sigortasi/form");
            
            //TC
            IWebElement TC = chromeDriver.FindElement(By.Id("tc"));
            Assert.That(TC.Displayed, Is.True);
            TC.SendKeys("14384136774");
            
            //Plaque
            chromeDriver.FindElement(By.Id("plaque")).SendKeys("26UR072");
            
            //Phone
            chromeDriver.FindElement(By.Id("phone")).SendKeys("5070897289");
            
            Thread.Sleep(4000);
            chromeDriver.FindElement(By.CssSelector("div.formSubmitButton:nth-child(5) > div:nth-child(1) > " +
                                                    "div:nth-child(1) > div:nth-child(1) > " +
                                                    "div:nth-child(1) > button:nth-child(1) > span:nth-child(1)")).Click();
            //Quit
            //chromeDriver.Quit();
        }
        
    }
}