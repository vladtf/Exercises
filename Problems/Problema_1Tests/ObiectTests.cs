using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema.Tests
{
    [TestClass()]
    public class ObiectTests
    {
        [TestMethod()]
        public void PrimeTest()
        {
            var obj = new Obiect(4,5);
            var ans = Obiect.Prime(3);
            Assert.IsTrue(ans);

        }

    }
}