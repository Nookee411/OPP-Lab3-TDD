using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hexademical;

namespace Hex_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertTest1()
        {
            string hex;
            hex = HexInt.DecToHex(10);
            Assert.AreEqual("A", hex);
        }

        [TestMethod]
        public void ConvertTest2()
        {
            string hex;
            hex = HexInt.DecToHex(509);
            Assert.AreEqual("1FD", hex);
        }

        [TestMethod]
        public void ConvertTest3()
        {
            string hex="1FD";
            int dec;
            dec = HexInt.HexToDec(hex);
            Assert.AreEqual(509, dec);
        }

        [TestMethod]
        public void ConvertTest4()
        {
            string hex = "A";
            int dec;
            dec = HexInt.HexToDec(hex);
            Assert.AreEqual(10, dec);
        }


        [TestMethod]
        public void SumTest1()
        {
            string hex1 = "A";
            string hex2 = "A";
            int dec;
            dec = HexInt.HexToDec(HexInt.Add(hex1,hex2));
            Assert.AreEqual(20, dec);
        }

        [TestMethod]
        public void SumTest2()
        {
            string hex1 = "A";
            string hex2 = "A";
            string hex;
            hex = HexInt.Add(hex1, hex2);
            Assert.AreEqual("14", hex);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void SumTest3()
        {
            string hex1 = "A";
            string hex2 = "T";
            string hex;
            hex = HexInt.Add(hex1, hex2);
            Assert.AreEqual("14", hex);
        }

        [TestMethod]
        public void SubTest1()
        {
            string hex1 = "F";
            string hex2 = "A";
            int dec;
            dec = HexInt.HexToDec(HexInt.Subsruct(hex1, hex2));
            Assert.AreEqual(5, dec);
        }

        [TestMethod]
        public void SubTest2()
        {
            string hex1 = "F";
            string hex2 = "A";
            string hex;
            hex = HexInt.Subsruct(hex1, hex2);
            Assert.AreEqual("5", hex);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void SubTest3()
        {
            string hex1 = "A";
            string hex2 = "T";
            string hex;
            hex = HexInt.Subsruct(hex1, hex2);
        }

        [TestMethod]
        public void HexTest1()
        {
            string hex1 = "F";
            Assert.IsTrue(HexInt.IsHex(hex1));
        }

        [TestMethod]
        public void HexTest2()
        {
            string hex1 = "T";
            Assert.IsFalse(HexInt.IsHex(hex1));
        }

        [TestMethod]
        public void AndTest1()
        {
            string hex1 = "A";
            string hex2 = "B";
            Assert.AreEqual("A", HexInt.And(hex1,hex2));
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void AndTest2()
        {
            string hex1 = "A";
            string hex2 = "T";
            Assert.AreEqual("A", HexInt.And(hex1, hex2));
        }

        [TestMethod]
        public void OrTest1()
        {
            string hex1 = "A";
            string hex2 = "B";
            Assert.AreEqual("B", HexInt.Or(hex1, hex2));
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void OrTest2()
        {
            string hex1 = "A";
            string hex2 = "T";
            Assert.AreEqual("A", HexInt.Or(hex1, hex2));
        }
    }
}
