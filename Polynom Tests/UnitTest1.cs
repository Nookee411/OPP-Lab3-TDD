using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2_Polynom;

namespace Polynom_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest1()
        {
            Polinomial a = new Polinomial();
            Assert.AreEqual(0, a[0]);
        }

        [TestMethod]
        public void ConstructorTest2()
        {
            Polinomial a = new Polinomial(new double[] { 2,3,4,5});
            Assert.AreEqual(5, a[3]);
        }

        [TestMethod]
        public void ConstructorTest3()
        {
            Polinomial a = new Polinomial(5);
            Assert.AreEqual(0, a[4]);
        }

        [TestMethod]
        public void DegreeTest()
        {
            Polinomial a = new Polinomial(5);
            Assert.AreEqual(4,a.Degree);
        }

        [TestMethod]
        public void DegreeTest2()
        {
            Polinomial a=new Polinomial();
            Assert.AreEqual(0, a.Degree);
        }

        [TestMethod]
        public void ValueTest()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Assert.AreEqual(64, a.Value(2));
        }

        [TestMethod]
        public void ValueTes2()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Assert.AreEqual(2, a.Value(0));
        }

        [TestMethod]
        public void EqualsTest1()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 2, 3, 4, 5 });
            Assert.IsTrue(a.Equals(b));
        }

        [TestMethod]
        public void EqualsTest2()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 2, 2, 4, 5 });
            Assert.IsFalse(a.Equals(b));
        }

        [TestMethod]
        public void HashCode1()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 2, 3, 4, 5 });
            Assert.IsTrue(a.GetHashCode()==b.GetHashCode());
        }

        [TestMethod]
        public void HashCode2()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 5, 4, 3, 2 });
            Assert.IsTrue(a.GetHashCode() == b.GetHashCode());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexing()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            a[6] = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexing2()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            a[-2]=3;
        }

        [TestMethod]
        public void SummingTest()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 5, 4, 3, 2 });
            Polinomial c = new Polinomial(new double[] { 7, 7, 7, 7 });
            a += b;
            Assert.IsTrue(a==c);
        }

        [TestMethod]
        public void SubstractionTest()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 5, 4, 3, 2 });
            Polinomial c = new Polinomial(new double[] { -3, -1, 1, 3 });
            a -= b;
            Assert.IsTrue(a == c);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Polinomial a = new Polinomial(new double[] { 1, 1});
            Polinomial b = new Polinomial(new double[] { 1, 1});
            a *= b;
            Assert.IsTrue(new Polinomial(new double[] { 1, 2, 1 })==a);
        }

        [TestMethod]
        public void EqualityTest1()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 2, 3, 4, 5 });
            Assert.IsTrue(a==b);
        }

        [TestMethod]
        public void EqualityTest2()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 2, 2, 4, 5 });
            Assert.IsFalse(a==b);
        }

        [TestMethod]
        public void EqualityTest3()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 2, 3, 4, 5 });
            Assert.IsFalse(a != b);
        }

        [TestMethod]
        public void EqualityTest4()
        {
            Polinomial a = new Polinomial(new double[] { 2, 3, 4, 5 });
            Polinomial b = new Polinomial(new double[] { 2, 2, 4, 5 });
            Assert.IsTrue(a != b);
        }
    }
}
