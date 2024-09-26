using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.DataDriven
{
    internal class TestparUsingTestcase
    {
        [Test]
        [TestCase("abc.com","abcd")]
        [TestCase("cde.com", "ghij")]
        [TestCase("mll.com", "llll")]
        public void Loginest(string username,string password)
        {
            Console.WriteLine(username + " " + password);
        }
    }
}
