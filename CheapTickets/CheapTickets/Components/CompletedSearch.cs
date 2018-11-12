using CheapTickets.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace CheapTickets.Components
{
    class CompletedSearch : BaseComponents
    {
        public WaitElements WaitElements = new WaitElements();

        [FindsBy(How = How.Id, Using = "inpHotelNameMirror")]
        private IWebElement InputPropertyName { get; set; }

        [FindsBy(How = How.Id, Using = "hotelNameGoBtn")]
        private IWebElement GoButton { get; set; }

        [FindsBy(How = How.Id, Using = "hotelNameHeader")]
        public IWebElement HeaderMain { get; set; }

        [FindsBy(How = How.CssSelector, Using = "h3.visuallyhidden")]
        public IWebElement ResultName { get; set; }

        private IList<IWebElement> ResultItems { get; set; }

        public CompletedSearch SearchByPropertyName(string value)
        {
            WaitElements.WaitForPageUntilElementIsVisible(InputPropertyName, 25).SendKeys(value);

            WaitElements.WaitElement(By.ClassName("results-item"), 25);

            ResultItems = _webDriver.FindElements(By.ClassName("results-item"));

            WaitElements.WaitForPageUntilElementIsVisible(ResultItems.First(), 10).Click();

            return this;
        }

        public CompletedSearch ClickOnGoButton()
        {
            Assert.That(HeaderMain.Text, Is.EqualTo("Search by property name"));

            GoButton.Click();

            return this;
        }
    }
}
