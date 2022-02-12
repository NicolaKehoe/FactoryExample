using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FactoryExample
{
    public class WebDriverFactories
    {
        public IWebDriver Create(BrowserType browserType)
        {
            switch (Settings.BrowserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                case BrowserType.Edge:
                    return GetEdgeDriver();
                default:
                   throw new ArgumentOutOfRangeException("No such browser exists");
                
            }
        }

        private IWebDriver GetChromeDriver()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver(option);
        }

        private IWebDriver GetEdgeDriver()
        {
            EdgeOptions option = new EdgeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
          //  new DriverManager().SetUpDriver(new EdgeConfig());
            return new EdgeDriver(option);
        }
    }
}
