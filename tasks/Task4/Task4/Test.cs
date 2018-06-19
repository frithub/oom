using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    public class Tests
    {
        private Switch testSwitch;
        private Switch[] testSwitches;

        public Tests()
        {
            testSwitch = new Switch(24, 1000, 110, false, "Testswitch");
        }

        [Test]
        public void Test1Equal1()
        {
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void Test1Equal0()
        {
            Assert.IsTrue(1 == 0);
        }

        [Test]
        public void TestTurnedOn()
        {
            Assert.IsTrue(testSwitch.turnedOn == true);
        }

        [Test]
        public void TestInterfaces48()
        {
            Assert.IsTrue(testSwitch.Interfaces == 48);
        }

        [Test]
        public void TestInterfaces24()
        {
            Assert.IsTrue(testSwitch.Interfaces == 24);
        }



        [Test]
        public void TestBandwith1000()
        {
            Assert.IsTrue(testSwitch.BandwithMBit == 1000);
        }
        /*
        [Test]
        public void TestConstructorArgumentNullException()
        {
            Switch testSwitch2;

            try
            {
                testSwitch2 = new Switch(null, 1000);
                Assert.IsTrue(false);
            }

            catch (ArgumentNullException ex)
            {
                Assert.IsTrue(true);
            }
            
        }*/

        [Test]
        public void TestArrayContains()
        {
            Assert.IsTrue(Array.Exists(testSwitches, element => testSwitch.name == "Switchname"));
        }

        [Test]
        public void TestObjectEqual()
        {
            Assert.AreEqual(testSwitch, testSwitch);
        }
    }
}
