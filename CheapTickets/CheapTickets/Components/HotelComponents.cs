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
    class HotelComponents : BaseComponents
    {
        public WaitElements WaitElements = new WaitElements();

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

        public HotelComponents SearchHotel(string value)
        {

            SendKeysMethod(DestinyInput, value);

            /*DestinyInput.SendKeys("miam");
            
            DestinyInput.SendKeys(value);

            WaitElements.WaitElement(By.ClassName("results-item"), 25);

            ResultItemsSearchHotel = Collection.driver.FindElements(By.ClassName("results-item"));

            WaitElements.WaitForPageUntilElementIsVisible(ResultItemsSearchHotel.First(), 10).Click();*/

            ClickMethod(ResultItemsSearchHotel);

            return this;

        }

        private void ClickMethod(IList<IWebElement> resultItemsSearchHotel)
        {
            throw new NotImplementedException();
        }

        public HotelComponents ClickOnTodayDate()
        {
            CheckInInput.Click();

            CheckInDate.Click();

            return this;
        }

        public HotelComponents ClickOnFutureDate()
        {
            var date = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");

            CheckOutDate.Clear();

            CheckOutDate.Click();

            CheckOutDate.SendKeys(date);

            return this;
        }

        public HotelComponents SelectAdults(string value)
        {
            var adultsSelect = new SelectElement(Collection.Driver.FindElement(By.Id("hotel-1-adults-hlp")));

            adultsSelect.SelectByText(value);

            return this;
        }

        public HotelComponents SelectChildren(string value)
        {
            var childrenSelect = new SelectElement(Collection.Driver.FindElement(By.Id("hotel-1-children-hlp")));

            childrenSelect.SelectByText(value);

            return this;

        }

        public HotelComponents SelectChildrenAge(string value)
        {
            SelectElement ageSelect = new SelectElement(Collection.Driver.FindElement(By.Id("hotel-1-age-select-1-hlp")));

            ageSelect.SelectByText(value);

            return this;
        }

        public HotelComponents ClickOnSearchForm()
        {
            SendHotelForm.Click();

            return this;
        }

    }
}
