using System;
using System.Numerics;
using Opgave_1_Bog;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestBog
{
    [TestClass] //Instruktioner Alt i klassen testes - Test klasse 
    public class UnitTest1
    {

        private Bog _bog;

        [TestInitialize] //Refaktureret - Frisk bog at opererer på ved hver test

        public void Init()
        {
            _bog = new Bog();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMinimum2tegn()
        {
            Bog bog = new Bog();
            bog.Forfatter = "I";
            Assert.AreEqual("I", bog.Forfatter);
        }

        [TestMethod]
        public void Testover2tegn()
        {
            Bog bog = new Bog();
            bog.Forfatter = "Ida";
            Assert.AreEqual("Ida", bog.Forfatter);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSidetalUnder4()
        {
            Bog bog = new Bog();
            bog.Sidetal = 3;
            Assert.AreEqual(3, bog.Sidetal);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSidetalOver1000()
        {
            Bog bog = new Bog();
            bog.Sidetal = 1009;
            Assert.AreEqual(1009, bog.Sidetal);

        }

        [TestMethod]
        public void TestIsbn13Præcis13Tegn()
        {
            Bog bog = new Bog();
            bog.Isbn13 = "123456789123h";
            Assert.AreEqual("123456789123h", bog.Isbn13);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIsbn13Under13Tegn()
        {
            Bog bog = new Bog();
            bog.Isbn13 = "123yh9123h";
            Assert.AreEqual("123yh9123h", bog.Isbn13);

        }
    }
}
