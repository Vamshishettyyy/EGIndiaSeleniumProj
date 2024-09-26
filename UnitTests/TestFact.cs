using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class TestFact
    {
        Factorial f1 = new Factorial();
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Testing of Factorial Started..");
        }
        [Test]
        public void FactTest1()
        {
            long result = f1.Fact(5);
            long result1 = f1.Fact(7);
            Assert.AreEqual(120, result);
            Assert.AreEqual(5040, result1);
            Console.WriteLine("Test 1 passed");
        }
        [Test]
        public void FactTest2()
        {
            long result = f1.Fact(10);
            long result2 = f1.Fact(15);
            Assert.AreEqual(3628800, result);
            Assert.AreEqual(1307674368000, result2);
            Console.WriteLine("Test 2 passed");
        }
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Testing Done");
        }
    }
}
