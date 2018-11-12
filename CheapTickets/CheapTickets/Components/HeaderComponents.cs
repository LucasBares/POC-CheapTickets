using CheapTickets.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CheapTickets.Components
{
    class HeaderComponents : BaseComponents
    {
        [FindsBy(How = How.Id, Using = "primary-header-hotel")]
        public IWebElement HotelButton { get; set; }

        public void ClickOnHotelButton()
        {
            HotelButton.Click();
        }
    }
}
