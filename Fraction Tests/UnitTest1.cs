using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1_Fractions;

namespace Fraction_Tests
{
    [TestClass]
    public class FractionTestOne
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ConstructorTest()
        {
            Fraction a = new Fraction(2,0);
        }

        [TestMethod]
        public void AccessTest()
        {
            Fraction b = new Fraction(2, 3);
            Assert.AreEqual(2, b.Numerator);
        }

        [TestMethod]
        public void AccessTest2()
        {
            Fraction b = new Fraction(2, 3);
            Assert.AreEqual(3, b.Denominator);
        }

        [TestMethod]
        public void SettingTest()
        {
            Fraction c = new Fraction(2, 3);
            c.Denominator = 7;
            Assert.AreEqual(7, c.Denominator);
        }

        [TestMethod]
        public void SettingTest2()
        {
            Fraction c = new Fraction(2, 3);
            c.Numerator = 7;
            Assert.AreEqual(7, c.Numerator);
        }

        [TestMethod]
        public void SimplificationTest()
        {
            Fraction d = new Fraction(5, 10);
            Assert.AreEqual(1, d.Numerator);
        }

        [TestMethod]
        public void SimplificationAfterSettingTest()
        {
            Fraction e = new Fraction(3, 10);
            e.Numerator = 5;
            Assert.AreEqual(1, e.Numerator);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Fraction a = new Fraction(2, 5);
            Fraction b = new Fraction(3, 7);
            a *= b;
            Assert.AreEqual(35, a.Denominator);
        }

        [TestMethod]
        public void SummingTest()
        {
            Fraction a = new Fraction(2, 5);
            Fraction b = new Fraction(3, 7);
            a += b;
            Assert.AreEqual(29, a.Numerator);
        }

        [TestMethod]
        public void SubstractionTest()
        {
            Fraction a = new Fraction(2, 5);
            Fraction b = new Fraction(3, 7);
            b -= a;
            Assert.AreEqual(1, b.Numerator);
        }

        [TestMethod]
        public void DividingTest()
        {
            Fraction a = new Fraction(2, 5);
            Fraction b = new Fraction(3, 7);
            a /= b;
            Assert.AreEqual(3, b.Numerator);
        }

        [TestMethod]
        public void EqualityTest()
        {
            Fraction a = new Fraction(2, 5);
            Fraction b = new Fraction(4, 10);
            Assert.IsTrue(a==b);
        }

        [TestMethod]
        public void UnEqualityTest()
        {
            Fraction a = new Fraction(2, 5);
            Fraction b = new Fraction(5, 10);
            Assert.IsTrue(a!=b);
        }

        [TestMethod]
        public void PowTest()
        {
            Fraction a = new Fraction(2, 5);
            a.Pow(3);
            Assert.AreEqual(a,new Fraction(8,125));
        }

        [TestMethod]
        public void OutputTest()
        {
            Fraction a = new Fraction(2, 5);
            Assert.AreEqual("2/5",a.ToString());
        }

        [TestMethod]
        public void ReverseTest()
        {
            Fraction a = new Fraction(2, 5);
            a = -a;
            Assert.AreEqual(-2, a.Numerator);
        }

        [TestMethod]
        public void ComparationTest()
        {
            Fraction a = new Fraction(3, 5);
            Fraction b = new Fraction(5, 10);
            Assert.AreEqual(true, (a > b));
        }

        [TestMethod]
        public void ComparationTest2()
        {
            Fraction a = new Fraction(1, 5);
            Fraction b = new Fraction(5, 10);
            Assert.AreEqual(true, (a < b));
        }

        [TestMethod]
        public void HashCodeTest()
        {
            Fraction a = new Fraction(3, 2);
            Fraction b = new Fraction(2, 3);
            Assert.IsTrue(a.GetHashCode() == b.GetHashCode());
        }

        [TestMethod]
        public void HashCodeTest2()
        {
            Fraction a = new Fraction(3, 2);
            Fraction b = new Fraction(1, 3);
            Assert.IsFalse(a.GetHashCode() == b.GetHashCode());
        }
    }
}
