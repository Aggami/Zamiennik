using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class Zamiennik_kursuTests
    {
        [TestMethod()]
        public void Zamiennik_kursuTest()
        {
            //ARRANGE 
            Plan_studiow plan = new Plan_studiow(Poziom_ksztalcenia.I_Stopien, true, 7, null, null);
            Kurs kurs1 = new Kurs("INZ1517Wc", "Algorytmy i struktury danych", 4, true, Forma_kursu.WykladCwiczenia, null, 60, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { }, new List<Zamiennik_kursu>(), plan, true);
            Kurs kurs2 = new Kurs("INZ1517L", "Algorytmy i struktury danych", 3, false, Forma_kursu.Laboratorium, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { }, new List<Zamiennik_kursu>(), plan, true);
            //ACT



            //ASSERT
            Assert.Fail();
        }
    }
}