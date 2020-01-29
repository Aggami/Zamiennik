using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testy
{
    [TestClass]
    public class PropozycjaTest
    {
        [TestMethod]
        public void zaakceptujPropozycjeTest()
        {
            //ARRANGE
            Propozycja_zamiennika propozycja = new Propozycja_zamiennika();

            //ACT

            propozycja.zaakceptujPropozycje("tak");

            //ASSERT
            Assert.AreEqual(Status_propozycji.Zweryfikowana, propozycja.Status, "Zły status");
            Assert.AreEqual("tak", propozycja.Komentarz_Opiniodawcy, "Zły komentarz");
        }

        [TestMethod]
        public void odrzucPropozycjeTest()
        {
            //ARRANGE
            Propozycja_zamiennika propozycja = new Propozycja_zamiennika();

            //ACT

            propozycja.odrzucPropozycje("nie");

            //ASSERT
            Assert.AreEqual(Status_propozycji.Odrzucona, propozycja.Status, "Zły status");
            Assert.AreEqual("nie", propozycja.Komentarz_Opiniodawcy, "Zły komentarz");
        }
    }
}
