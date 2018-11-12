using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.IE;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.Collections.Specialized;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CheapTickets.Utils
{
    class DriversInitializate
    {
        public IWebDriver _webDriver;
        

        public void Drivers(string driver)
        {
            switch (driver)
            {
                case "Chrome":
                    ChromeDriver();
                    break;

                case "Firefox":
                    FirefoxDriver();
                    break;

                case "Edge":
                    EdgeDriver();
                    break;

                case "IE":
                    IEDriver();
                    break;

                case "Opera":
                    OperaDriver();
                    break;
            }
        }

        public void ChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }

        public void FirefoxDriver()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            _webDriver = new FirefoxDriver();
        }

        public void EdgeDriver()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            _webDriver = new EdgeDriver();
        }

        public void IEDriver()
        {
            new DriverManager().SetUpDriver(new InternetExplorerConfig());
            _webDriver = new InternetExplorerDriver();
        }

        public void OperaDriver()
        {
            new DriverManager().SetUpDriver(new OperaConfig());
            _webDriver = new OperaDriver();
        }

        public void GoTo()
        {
            _webDriver.Url = "https://www.cheaptickets.com/";
        }
        //TODO: Cambiar a otra clase
        public void MaximazeWindow()
        {
            _webDriver.Manage().Window.Maximize();
        }
    }
    
}
