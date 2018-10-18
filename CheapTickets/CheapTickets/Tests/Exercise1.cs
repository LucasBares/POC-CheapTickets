using OpenQA.Selenium.Chrome;
using CheapTickets.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace CheapTickets.Tests
{
    class Exercise1
    {

        public WaitElements WaitElements = new WaitElements();

        [SetUp]
        public void Inicializate()
        {
            Collection.driver = new ChromeDriver(@"C:\Users\Lucas\Source\repos\POC-CheapTickets\CheapTickets\CheapTickets");

            Collection.driver.Manage().Window.Maximize();
        }

        [Test]
        [Category("Exercise 1")]
        public void Ex1()
        {
            Collection.driver.Url = "https://www.cheaptickets.com/";

            WaitElements.WaitForPageUntilElementIsVisible(By.Id("primary-header-hotel"), 10).Click();

            WaitElements.WaitForElementManipulable(By.Id("hotel-destination-hlp"), 10).SendKeys("Miami Beach");

            //string clas = Collection.driver.FindElements(By.ClassName("results-item")).ToString();
            
            WaitElements.WaitForPageUntilElementIsVisible(By.ClassName("results-item"), 10).Click();

            WaitElements.WaitForElementManipulable(By.Id("hotel-checkin-hlp"), 1).Click();

            WaitElements.WaitForPageUntilElementIsVisible(By.CssSelector("datepicker-cal-date"), 10).Click();




            // Selectors hotels and that

            SelectElement adultsSelect = new SelectElement(Collection.driver.FindElement(By.Id("hotel-1-adults-hlp")));

            adultsSelect.SelectByText("4");

            SelectElement childrenSelect = new SelectElement(Collection.driver.FindElement(By.CssSelector(" num-children gcw-storeable gcw-toggles-fields gcw-toggles-field-by-value gcw-guests-field seat-children")));

            childrenSelect.SelectByText("1");

            WaitElements.WaitForPageUntilElementIsVisible(By.CssSelector(""), 10).Click();

            SelectElement ageSelect = new SelectElement(Collection.driver.FindElement(By.CssSelector("gcw-storeable gcw-toggles-field-by-value gcw-child-age-select")));

            ageSelect.SelectByText("7");

            Collection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

            Collection.driver.Close();
        }

    }
}
