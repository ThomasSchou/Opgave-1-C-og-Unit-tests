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
                (() => footBallPlayer.ID = -1));
        }
        [TestMethod()]
        public void TestName()
        {
            FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                (() => footBallPlayer.Name = "Bo"));
        }
        [TestMethod()]
        public void TestPrice()
        {
            FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                (() => footBallPlayer.Price = -100));
        }
        [TestMethod()]
        public void TestShirtNumber()
        {
            FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                (() => footBallPlayer.ShirtNumber = 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                (() => footBallPlayer.ShirtNumber = 5000));
        }

        [TestMethod()]
        public void SetID()
        {
            FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
            footBallPlayer.ID = 3;
            Assert.AreEqual(footBallPlayer.ID, 3);
        }

        [TestMethod()]
        public void SetName()
        {
            FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
            footBallPlayer.Name = "Jacko";
            Assert.AreEqual(footBallPlayer.Name, "Jacko");
        }

        [TestMethod()]
        public void SetPrice()
        {
            FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
            footBallPlayer.Price = 700;
            Assert.AreEqual(footBallPlayer.Price, 700);
        }

        [TestMethod()]
        public void SetShirtNumber()
        {
            FootBallPlayer footBallPlayer = new FootBallPlayer("Jack", 1500, 3);
            footBallPlayer.ShirtNumber = 10;
            Assert.AreEqual(footBallPlayer.ShirtNumber, 10);

        }
    }
}