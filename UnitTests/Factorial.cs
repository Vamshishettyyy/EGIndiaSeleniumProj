using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Factorial
    {
        public long Fact(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Fact(n - 1);
        }
    }
}
