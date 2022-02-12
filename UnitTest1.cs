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



namespace FactoryExample
{
    [TestFixture]
    [Parallelizable]
    public class UnitTest1 : Base
    {
      //  public IWebDriver Driver { get; private set; }
      //  string BaseUrl = $"https://www.mailinator.com";

        //[SetUp]
        //public void Setup()
        //{
        //    var factory = new WebDriverFactories();
        //    Driver = factory.Create(BrowserType.Edge);
        //    Driver.Navigate().GoToUrl(BaseUrl);
        //}

        [Test]
        public void Test1()
        {
            HomePage homePage = new HomePage(Driver);
            var number = homePage.CountAnchorsInwhyMailInatorMenu();
            Assert.That(100, Is.EqualTo(number), "Incorrect values");
        }
        [Test]
        public void Test2()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement whyMailInator = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(@href,'/site/why-mailinator/')]")));
            // WhyMailInator.Click();
            //driver.FindElement(By.XPath("//a[contains(@href,'login-popup')]")).Click();
            Actions a = new Actions(Driver);
            a.MoveToElement(whyMailInator).Build().Perform();
            IList<IWebElement> ancher = Driver.FindElements(By.TagName("a"));
            int i = 0;
            foreach (IWebElement e in ancher)
            {
                i++;
            }
            Assert.That(100, Is.EqualTo(i), "Incorrect values");
        }


        //[TearDown]

        //public void Teardown()
        //{
        //    Driver.Close();
        //    Driver.Quit();

        //}

    }
}