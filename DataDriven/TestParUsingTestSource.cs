using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.DataDriven
{
    internal class TestParUsingTestSource
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("ad", "admin123");
            yield return new TestCaseData("adm", "ghhjm");
            yield return new TestCaseData("ad0", "ad");

        }
    }
}
