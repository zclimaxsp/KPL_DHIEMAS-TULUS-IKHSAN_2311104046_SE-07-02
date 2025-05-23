namespace TestProject1 

{ 
    using tjmodul12_2311104046; 

    [TestClass]
    public class PangkatTests
    {
        Form1 form = new Form1();

        [TestMethod]
        public void TestB0() => Assert.AreEqual(1, form.CariNilaiPangkat(5, 0));

        [TestMethod]
        public void TestBNegatif() => Assert.AreEqual(-1, form.CariNilaiPangkat(4, -2));

        [TestMethod]
        public void TestBOver10() => Assert.AreEqual(-2, form.CariNilaiPangkat(3, 11));

        [TestMethod]
        public void TestAOver100() => Assert.AreEqual(-2, form.CariNilaiPangkat(101, 3));

        [TestMethod]
        public void TestNormal() => Assert.AreEqual(8, form.CariNilaiPangkat(2, 3));

        [TestMethod]
        public void TestOverflow() => Assert.AreEqual(-3, form.CariNilaiPangkat(9999, 20));
    }

}