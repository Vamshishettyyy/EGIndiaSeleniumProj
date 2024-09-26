using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Parallelizable(ParallelScope.All)]
    internal class ParalleleExecution
    {
        [Test]
        public void login()
        {
            Console.WriteLine("lOGGING IN");
        }
        [Test]
        public void addtocart()
        {
            Console.WriteLine("added to cart");
        }
    }
}
