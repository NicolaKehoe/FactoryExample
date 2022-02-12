using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using NUnit.Framework;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System;
using OpenQA.Selenium.Support.UI;
using FactoryExample.Pages;

namespace FactoryExample.Pages
{
    class HomePage
    {
        private IWebDriver Driver;

        public HomePage(IWebDriver driver)
        {
            this.Driver = driver;
        }
        private IWebElement whyMailInator => Driver.FindElement(By.XPath("//a[contains(@href,'/site/why-mailinator/')]"));
       
        public int CountAnchorsInwhyMailInatorMenu()
        {
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Actions a = new Actions(Driver);
            a.MoveToElement(whyMailInator).Build().Perform();
            IList<IWebElement> ancher = Driver.FindElements(By.TagName("a"));
            int i = 0;
            foreach (IWebElement e in ancher)
            {
                i++;
            }
            return i;
        }
    }
    }

