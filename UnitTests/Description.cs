using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Description
    {
        [Test]
        [Description("verifies login functionalities")]
        public void login()
        {
            Console.WriteLine("lOGGING IN");
        }
    }
}

