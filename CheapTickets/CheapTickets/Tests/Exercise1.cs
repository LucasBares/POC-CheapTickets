using OpenQA.Selenium.Chrome;
using CheapTickets.Utils;
using NUnit.Framework;
using CheapTickets.Components;

namespace CheapTickets.Tests
{
    class Exercise1 : BaseComponents
    {

        public HeaderComponents HeaderComponents = new HeaderComponents();

        public HotelComponents HotelComponents = new HotelComponents();

        public CompletedSearch CompletedSearch = new CompletedSearch();

        [Test]
        [Category("TAE Evaluation")]
        public void Exercise_1()
        {
            HeaderComponents.ClickOnHotelButton();
            
            HotelComponents.SearchHotel("Miami")
                        .ClickOnTodayDate()
                        .ClickOnFutureDate()
                        .SelectAdults("4")
                        .SelectChildren("1")
                        .SelectChildrenAge("7");

            CompletedSearch.SearchByPropertyName("Faena Hotel")
                                    .ClickOnGoButton();

            Assert.Greater(HotelComponents.ResultItemsSearchHotel.Count, 0);
            
        }

    }
}
