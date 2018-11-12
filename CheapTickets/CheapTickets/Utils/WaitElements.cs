using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CheapTickets.Components
{
    class WaitElements : BaseComponents
    {
        public IWebElement WaitForPageUntilElementIsVisible(IWebElement element, int maxSeconds)
        {
            return new WebDriverWait(_webDriver, TimeSpan.FromSeconds(maxSeconds))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public IWebElement WaitElement(By locator, int maxSeconds)
        {
            return new WebDriverWait(_webDriver, TimeSpan.FromSeconds(maxSeconds))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
    }
}