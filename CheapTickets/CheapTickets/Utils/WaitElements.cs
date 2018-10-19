using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CheapTickets.Utils
{
    class WaitElements
    {
        public IWebElement WaitForPageUntilElementIsVisible(IWebElement element, int maxSeconds)
        {
            return new WebDriverWait(Collection.driver, TimeSpan.FromSeconds(maxSeconds))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
