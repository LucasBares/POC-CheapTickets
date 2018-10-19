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
            // 1.Go to https://www.cheaptickets.com/
            Collection.driver.Url = "https://www.cheaptickets.com/";

            // 2. Click on Hotels header link

            WaitElements.WaitForPageUntilElementIsVisible(By.Id("primary-header-hotel"), 10).Click();


            //  3. Type “Miami Beach” in the Going To input field

            WaitElements.WaitForElementManipulable(By.Id("hotel-destination-hlp"), 10).SendKeys("Miami Beach");


            WaitElements.WaitForPageUntilElementIsVisible(By.ClassName("results-item"), 10).Click();




            // Preguntar al mono xd

            //  4. Choose a valid check-in date - Bonus: Use the Calendar Date Picker element to select the date
            // TO DO: Click on another date

            WaitElements.WaitForElementManipulable(By.Id("hotel-checkin-hlp"), 1).SendKeys("10/19/2018");

            //WaitElements.WaitForElementManipulable(By.Id("hotel-checkin-hlp"), 1).Click();
            
            //# hotel-checkin-wrapper-hlp > div > div > div:nth-child(4) > table > tbody > tr:nth-child(3) > td:nth-child(5) > button

            //WaitElements.WaitForPageUntilElementIsVisible(By.ClassName("div#hotel-checkin-wrapper-hlp > button.datepicker-cal-date"), 10).Click();

            //  5. Choose a valid check-out date - Bonus: Use the Calendar Date Picker element to select the date
            // TO DO: Click on another date






            //  6. Select the number of adults - Adults: 4

            SelectElement adultsSelect = new SelectElement(Collection.driver.FindElement(By.Id("hotel-1-adults-hlp")));

            adultsSelect.SelectByText("4");

            //  7. Select the number of children - Childs: 1

            SelectElement childrenSelect = new SelectElement(Collection.driver.FindElement(By.Id("hotel-1-children-hlp")));

            childrenSelect.SelectByText("1");

            //  7a. Select the child’s age - Age: 7 years old

            SelectElement ageSelect = new SelectElement(Collection.driver.FindElement(By.Id("hotel-1-age-select-1-hlp")));

            ageSelect.SelectByText("7");

            // 8. Click on the Search button

            Collection.driver.FindElement(By.XPath("//button[contains(@class, 'btn-primary') and contains(@class ,'btn-action') and contains(@class, 'gcw-submit')]")).Click();

            // Wtf with this
            
            // 9. Type “Faena Hotel Miami Beach” in the Search By Property Input - Bonus: Type the first 3 letters “Sky” and select the first suggestion.

            WaitElements.WaitForElementManipulable(By.Id("inpHotelNameMirror"), 5).SendKeys("Faena Hotel Miami Beach");

            WaitElements.WaitForPageUntilElementIsVisible(By.CssSelector("ul#taHotelsResultsContainer > li:nth-of-type(1)"), 15).Click();

            // 9.a. Click on Go button

            Collection.driver.FindElement(By.Id("hotelNameGoBtn")).Click();






            Collection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

            Collection.driver.Close();
        }

    }
}
