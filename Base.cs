using NUnit.Framework;
using OpenQA.Selenium;
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(2)]

namespace FactoryExample
{
    public class Base
    {
        public IWebDriver Driver { get; private set; }
       // string BaseUrl = $"https://www.mailinator.com";
 

        [SetUp]
        public void Setup()
        {
            ConfigReader.InitializeSettings();
            var factory = new WebDriverFactories();
            // Driver = factory.Create(BrowserType.Edge);
            Driver = factory.Create(Settings.BrowserType);
            Driver.Navigate().GoToUrl(Settings.AUT);
           // Driver.Navigate().GoToUrl(BaseUrl);
        }

        [TearDown]

        public void Teardown()
        {
            Driver.Close();
            Driver.Quit();

        }
    }
}
