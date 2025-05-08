using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104046; // ganti dengan nama namespace project utama kamu

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBilanganNegatif()
        {
            var form = new Form1();
            string hasil = form.CariTandaBilangan(-5);
            Assert.AreEqual("Negatif", hasil);
        }

        [TestMethod]
        public void TestBilanganNol()
        {
            var form = new Form1();
            string hasil = form.CariTandaBilangan(0);
            Assert.AreEqual("Nol", hasil);
        }

        [TestMethod]
        public void TestBilanganPositif()
        {
            var form = new Form1();
            string hasil = form.CariTandaBilangan(10);
            Assert.AreEqual("Positif", hasil);
        }
    }
}

