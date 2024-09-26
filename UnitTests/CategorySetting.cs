using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.UnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class CategorySetting
    {
        [Test, Category("Regression")]
        public void login()
        {
            Console.WriteLine("lOGGING IN");
        }
        [Test, Category("Sanity,Regression")]
        public void addtocart()
        {
            Console.WriteLine("added to cart");
        }
        [Test, Ignore("Sanity")]
        public void products()
        {
            Console.WriteLine("selected products");
        }
    }
}
