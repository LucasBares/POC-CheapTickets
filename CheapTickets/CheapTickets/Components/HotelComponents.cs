using OpenQA.Selenium.Support.PageObjects;
using CheapTickets.Utils;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CheapTickets.Components
{
    class HotelComponents
    {
        public WaitElements WaitElements = new WaitElements();

        public HotelComponents()
        {
            PageFactory.InitElements(Collection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "hotel-destination-hlp")]
        private IWebElement DestinyInput { get; set; }

        [FindsBy(How = How.Id, Using = "hotel-checkin-hlp")]
        private IWebElement CheckInInput { get; set; }

        public IList<IWebElement> ResultItemsSearchHotel { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".datepicker-cal-date:not(.disabled)")]
        private IWebElement CheckInDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-clear")]
        private IWebElement CleanFieldButton { get; set; }

        [FindsBy(How = How.Id, Using = "hotel-checkout-hlp")]
        private IWebElement CheckOutDate { get; set; }

        [FindsBy(How = How.Id, Using = "hotel-1-adults-hlp")]
        private IWebElement AdultsSelect { get; set; }

        [FindsBy(How = How.Id, Using = "hotel-1-children-hlp")]
        private IWebElement ChildrenSelect { get; set; }

        [FindsBy(How = How.Id, Using = "hotel-1-age-select-1-hlp")]
        private IWebElement ChildrenAgeSelect { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-btn-col button:not([id])")]
        private IWebElement SendHotelForm { get; set; }

        public void SendText(string value)
        {
            DestinyInput.SendKeys(value);

            WaitElements.WaitElement(By.ClassName("results-item"), 25);

            ResultItemsSearchHotel = Collection.driver.FindElements(By.ClassName("results-item"));

            WaitElements.WaitForPageUntilElementIsVisible(ResultItemsSearchHotel.First(), 10).Click();

        }

        public void ClickOnTodayDate()
        {
            CheckInInput.Click();

            CheckInDate.Click();
        }

        public void ClickOnFutureDate()
        {
            var date = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");

            CheckOutDate.Clear();

            CheckOutDate.Click();

            CheckOutDate.SendKeys(date);
        }

        public void SelectAdults(string value)
        {
            var adultsSelect = new SelectElement(Collection.driver.FindElement(By.Id("hotel-1-adults-hlp")));

            adultsSelect.SelectByText(value);
        }

        public void SelectChildren(string value)
        {
            var childrenSelect = new SelectElement(Collection.driver.FindElement(By.Id("hotel-1-children-hlp")));

            childrenSelect.SelectByText(value);

        }

        public void SelectChildrenAge(string value)
        {
            SelectElement ageSelect = new SelectElement(Collection.driver.FindElement(By.Id("hotel-1-age-select-1-hlp")));

            ageSelect.SelectByText(value);
        }

        public void ClickOnSearchForm()
        {
            SendHotelForm.Click();
        }

    }
}
