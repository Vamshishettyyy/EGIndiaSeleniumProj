using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class AllureTestReportGen
    {
        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("lOGGING IN");
        }
        [Test, Order(2)]
        public void addtocart()
        {
            Console.WriteLine("added to cart");
        }
    }
}
