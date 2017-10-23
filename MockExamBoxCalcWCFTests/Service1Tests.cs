using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockExamBoxCalcWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamBoxCalcWCF.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetSideTest()
        {
            //arrange
            Service1 Test = new Service1();
            //act
            double testSum = Test.GetSide(8, 2, 2);
            //assert
            Assert.AreEqual(testSum, 2);
        }

        [TestMethod()]
        public void GetVolumeTest()
        {
            //arrange
            Service1 Test = new Service1();
            //act
            double testSum = Test.GetVolume(2, 2, 2);
            //assert
            Assert.AreEqual(testSum, 8);
        }
    }
}