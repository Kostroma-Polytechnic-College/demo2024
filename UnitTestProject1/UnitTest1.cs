using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expRes = 3;
            int actRes = MyClass.LibraryTestMetod(1, 2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod2()
        {
            int expRes = 1;
            int actRes = MyClass.LibraryTestMetod(-1, 2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }        [TestMethod]
        public void TestMethod3()
        {
            int expRes = -1;
            int actRes = MyClass.LibraryTestMetod(1, -2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod4()
        {
            int expRes = -3;
            int actRes = MyClass.LibraryTestMetod(-1, -2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod5()
        {
            int expRes = int.MaxValue;
            int actRes = MyClass.LibraryTestMetod(int.MinValue, -1);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod6()
        {
            int expRes = 3;
            int actRes = MyClass.LibraryTestMetod(1, 2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod7()
        {
            int expRes = 3;
            int actRes = MyClass.LibraryTestMetod(1, 2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod8()
        {
            int expRes = 3;
            int actRes = MyClass.LibraryTestMetod(1, 2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod9()
        {
            int expRes = 3;
            int actRes = MyClass.LibraryTestMetod(1, 2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
        [TestMethod]
        public void TestMethod10()
        {
            int expRes = 3;
            int actRes = MyClass.LibraryTestMetod(1, 2);
            Assert.AreEqual(expRes, actRes, "Сложение не работает");
        }
    }
}
