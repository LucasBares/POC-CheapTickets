using OpenQA.Selenium.Chrome;
using CheapTickets.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using CheapTickets.Components;

namespace CheapTickets.Tests
{
    class Exercise1
    {

        [SetUp]
        public void Inicializate()
        {
            Collection.driver = new ChromeDriver(@"C:\Users\lucas.mazzini\Source\Repos\POC-CheapTickets\CheapTickets\CheapTickets");

            Collection.driver.Manage().Window.Maximize();

            Collection.driver.Url = "https://www.cheaptickets.com/";
        }

        [Test]
        [Category("Exercise 1")]
        public void Ex1()
        {
            HeaderComponents HeaderComponents = new HeaderComponents();

            HotelComponents HotelComponents = new HotelComponents();

            CompletedSearch CompletedSearch = new CompletedSearch();

            // 2. Click on Hotels header link

            HeaderComponents.ClickOnHotelButton();

            //  3. Type “Miami Beach” in the Going To input field

            HotelComponents.SendText("Miami Beach");
            

            //  4. Choose a valid check-in date - Bonus: Use the Calendar Date Picker element to select the date

            HotelComponents.ClickOnTodayDate();

            //  5. Choose a valid check-out date - Bonus: Use the Calendar Date Picker element to select the date

            HotelComponents.ClickOnFutureDate();

            //  6. Select the number of adults - Adults: 4

            HotelComponents.SelectAdults("4");

            //  7. Select the number of children - Childs: 1

            HotelComponents.SelectChildren("1");

            //  7a. Select the child’s age - Age: 7 years old

            HotelComponents.SelectChildrenAge("7");

            // 8. Click on the Search button

            HotelComponents.ClickOnSearchForm();

            // Wtf with this

            // 9. Type “Faena Hotel Miami Beach” in the Search By Property Input - Bonus: Type the first 3 letters "Faena Hotel" and select the first suggestion.

            CompletedSearch.SearchByPropertyName("Faena Hotel");

            // 9.a. Click on Go button

            CompletedSearch.ClickOnGoButton();

            Collection.driver.Close();
        }

    }
}
