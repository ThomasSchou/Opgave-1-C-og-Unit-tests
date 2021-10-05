using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library_og_Unit_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_og_Unit_Test.Tests
{
    [TestClass()]
    public class FootBallPlayerTests
    {

        //[ClassInitialize()]
        //public static void setup(TestContext context)
        //{
        //    FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
        //}

        [TestMethod()]
        public void TestID()
        {
            FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                (() => footBallPlayer.Name = "Bo"));
        }
        [TestMethod()]
        public void TestName()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void TestPrice()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void TestShirtNumber()
        {
            Assert.Fail();
        }
    }
}