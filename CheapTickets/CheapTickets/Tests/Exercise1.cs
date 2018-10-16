using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using CheapTickets.Utils;
using NUnit.Framework;

namespace CheapTickets.Tests
{
    class Exercise1
    {
        [SetUp]
        public void Inicializate()
        {
            Collection.driver = new ChromeDriver(@"C:\Users\lucas.mazzini\source\repos\ConsoleApp1\ConsoleApp1");
        }

        [Test]
        public void OpenPage()
        {
            Collection.driver.Url = "https://www.cheaptickets.com/";

            HeaderObjects headerObjects = new HeaderObjects();

            headerObjects.Header.Click();
        }
    }
}
