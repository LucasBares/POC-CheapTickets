using CheapTickets.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CheapTickets.Components
{
    class BaseComponents
    {
        public BaseComponents()
        {
            PageFactory.InitElements(Collection.driver, this);
        }

    }
}
