using CheapTickets.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTickets.Components
{
    class HeaderComponents
    {
        public HeaderComponents()
        {
            PageFactory.InitElements(Collection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "primary-header-hotel")]
        public IWebElement HotelButton { get; set; }

        public void ClickOnHotelButton()
        {
            HotelButton.Click();
        }
    }
}
