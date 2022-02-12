using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace FactoryExample
{
    public class ConfigReader
    {
        public static void InitializeSettings()
        {
            //Used to build key/value based configuration settings for use in an application.
            //Adds the JSON configuration provider at path to builder.

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            IConfigurationRoot configurationRoot = builder.Build();

            Settings.AUT = configurationRoot.GetSection("testSettings").Get<TestSettings>().AUT;
            Settings.BrowserType = configurationRoot.GetSection("testSettings").Get<TestSettings>().BrowserType;
            //  TestSettings.UiBaseUrl = config.GetValue<string>("UiBaseUrl");
            //  TestSettings.BrowserType = config.GetValue<BrowserType>("Browser");

        }
    }
}