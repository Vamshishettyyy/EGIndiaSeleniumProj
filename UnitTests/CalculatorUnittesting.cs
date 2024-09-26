using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class CalculatorUnittesting
    {
        Calculatorr c1 = new Calculatorr();
        [Test]
        public void AddTest()
        {
            int result = c1.Add(2, 3);
            int result1 = c1.Add(2, 5);

            Assert.AreEqual(5, result);
            
            Assert.AreEqual(7, result1);
        }
        [Test]
        public void SubTest()
        {
            int result = c1.Sub(2, 3);
            int result1 = c1.Sub(4, 1);
            Assert.AreEqual(-1, result);
            Assert.AreEqual(3, result1);

        }
        [Test]
        public void MulTest()
        {
            int result = c1.Mul(2, 3);
            int result1 = c1.Mul(4, 1);
            Assert.AreEqual(6, result);
            Assert.AreEqual(4, result1);
        }
        [Test]
        public void DivTest()
        {
            int result = c1.Div(15 , 5);
            Assert.AreEqual(3, result);
        }
    }
}
