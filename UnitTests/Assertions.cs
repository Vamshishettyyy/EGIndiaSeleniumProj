using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Assertions
    {
        [Test]
        public void TestAssertion()
        {
            string actual = "google";
            string expected = "yahoo";
            if (actual == expected)
            {
                Console.WriteLine("Matching");
            }
            else
            {
                Console.WriteLine("Results are not matching");
            }
          

            //assert equal
           // Assert.AreEqual(actual, expected);
           // Assert.AreNotEqual(actual, expected);
            //assert that
            //Assert.That(actual, Is.EqualTo(expected));
            //Assert.That(actual, Is.Not.EqualTo(expected));
            //assert for strings ignore case
            //Assert.That(actual, Is.EqualTo(expected).IgnoreCase);
            //substring presence
            //Assert.That(actual, Does.Contain("goo").IgnoreCase);
            //empty assertion

           // Assert.IsEmpty(actual);
           //

            //collection constraints

           // int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            //not null
        }
    }
}
