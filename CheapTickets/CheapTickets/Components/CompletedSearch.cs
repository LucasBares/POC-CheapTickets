using CheapTickets.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace CheapTickets.Components
{
    class CompletedSearch : BaseComponents
    {
        public WaitElements WaitElements = new WaitElements();

        public CompletedSearch()
        {
            PageFactory.InitElements(Collection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "inpHotelNameMirror")]
        private IWebElement InputPropertyName { get; set; }

        [FindsBy(How = How.Id, Using = "hotelNameGoBtn")]
        private IWebElement GoButton { get; set; }

        [FindsBy(How = How.Id, Using = "hotelNameHeader")]
        public IWebElement HeaderMain { get; set; }

        [FindsBy(How = How.CssSelector, Using = "h3.visuallyhidden")]
        public IWebElement ResultName { get; set; }

        private IList<IWebElement> ResultItems { get; set; }

        public void SearchByPropertyName(string value)
        {
            WaitElements.WaitForPageUntilElementIsVisible(InputPropertyName, 25).SendKeys(value);

            WaitElements.WaitElement(By.ClassName("results-item"), 25);

            ResultItems = Collection.driver.FindElements(By.ClassName("results-item"));

            WaitElements.WaitForPageUntilElementIsVisible(ResultItems.First(), 10).Click();
        }

        public void ClickOnGoButton()
        {
            GoButton.Click();
        }
    }
}
