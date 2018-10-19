using CheapTickets.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace CheapTickets.Components
{
    class CompletedSearch
    {
        public WaitElements WaitElements = new WaitElements();

        public CompletedSearch()
        {
            PageFactory.InitElements(Collection.driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "inpHotelNameMirror")]
        public IWebElement InputPropertyName { get; set; }

        private IList<IWebElement> ResultItems { get; set; }


        [FindsBy(How = How.Id, Using = "hotelNameGoBtn")]
        public IWebElement GoButton { get; set; }

        public void SearchByPropertyName(string value)
        {
            InputPropertyName.SendKeys(value);
            ResultItems = Collection.driver.FindElements(By.ClassName("results-item"));
            WaitElements.WaitForPageUntilElementIsVisible(ResultItems.First(), 10).Click();
        }

        public void ClickOnGoButton()
        {
            GoButton.Click();
        }
    }
}
