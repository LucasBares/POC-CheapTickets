using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CheapTickets.Utils
{
    class WaitElements
    {
        public IWebElement WaitForElementManipulable(By locator, int timeout)
        {
            return new WebDriverWait(Collection.driver, TimeSpan.FromSeconds(timeout))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        public IWebElement WaitForPageUntilElementIsVisible(By locator, int maxSeconds)
        {
            return new WebDriverWait(Collection.driver, TimeSpan.FromSeconds(maxSeconds))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
