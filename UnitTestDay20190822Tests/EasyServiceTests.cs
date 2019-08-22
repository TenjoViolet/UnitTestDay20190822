using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDay20190822;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDay20190822.Tests
{
    [TestClass()]
    public class EasyServiceTests
    {
        [TestMethod()]
        public void GetCalResultTest()
        {
            //arrange
            var esSut = new EasyService();
            var expected = 7;

            //act
            var actual = esSut.GetCalResult();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetCalResult2Test()
        {
            //arrange
            var esSut = new EasyService();
            var expected = 10;

            //act
            var actual = esSut.GetCalResult2();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}