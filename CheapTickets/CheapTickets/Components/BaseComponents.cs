using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CheapTickets.Components
{
    class BaseComponents
    {

        public IWebDriver _webDriver;

        public BaseComponents()
        {
            PageFactory.InitElements(_webDriver, this);
        }

        public void ClickMethod(IWebElement element)
        {
            element.Click();
        }

        public void SendKeysMethod(IWebElement element, string value)
        {
            element.SendKeys(value);
        }
    }
}