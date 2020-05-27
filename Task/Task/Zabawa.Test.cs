using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task
{
    [TestFixture]
    class ZabawaTest
    {
        [TestCase]
        public void Test()
        {
            Zabawa z = new Zabawa();
            Assert.AreEqual(3, z.Gra(3, 0.66));
        }

        [TestCase]
        public void Test2()
        {
            Zabawa z = new Zabawa();
            Assert.AreEqual(-1, z.Gra(3, 1));
        }


    }
}
