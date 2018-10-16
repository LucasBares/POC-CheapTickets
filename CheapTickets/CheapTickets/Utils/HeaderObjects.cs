using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CheapTickets.Utils
{
    class HeaderObjects
    {
        public HeaderObjects()
        {
            PageFactory.InitElements(Collection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "primary-header-hotel")]
        public IWebElement Header { get; set; }
    }
}
