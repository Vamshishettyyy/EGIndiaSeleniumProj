using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class testPrime
    {
        PrimeCheck pc = new PrimeCheck();
        [Test]
        public void primeTest()
        {
            bool result = pc.IsPrime(50);
            Assert.IsFalse(result);
            bool result1 = pc.IsPrime(11);
            Assert.IsTrue(result1);
        }
    }
}
