using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTickets.Utils.Drivers
{
    class SetUpTearDown : DriversInitializate
    {

        [SetUp]
        public void Initializate(string driver)
        {
            Drivers("Chrome");
            MaximazeWindow();
            GoTo();
        }

        [TearDown]
        public void CloseUp()
        {
            _webDriver.Close();
        }
    }
}
