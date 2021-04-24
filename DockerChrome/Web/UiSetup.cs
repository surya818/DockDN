using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace uitest.browser
{
    #region Namespace Imports

    using System;
    using System.IO;
    using System.Reflection;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;

    #endregion


    public class UiSetup
    {
        public static IWebDriver getDriver { get; private set; }

        public static IWebDriver InitDriver(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    getDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;

                case "firefox":
                    getDriver = new FirefoxDriver();
                    break;

                default:
                    getDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
            }

            getDriver.Manage().Window.Maximize();
            getDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return getDriver;
        }

        public static IWebDriver InitDriverAndOpenWebPage(string browser, string url)
        {
            var driver = InitDriver(browser);
            driver.Url = url;
            return driver;
        }
    }
}