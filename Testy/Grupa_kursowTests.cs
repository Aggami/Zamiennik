using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class Grupa_kursowTests
    {
        [TestMethod()]
        public void Grupa_kursowPrawidloweEfekty()
        {
            //ARRANGE
            Plan_studiow plan = new Plan_studiow(Poziom_ksztalcenia.I_Stopien, true, 7, null, null);
            Efekt_ksztalcenia efekt1 = new Efekt_ksztalcenia("K1INF_W04", plan, "Y", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia efekt2 = new Efekt_ksztalcenia("K1INF_W02", plan, "x", Typ_efektu_ksztalcenia.Wiedza);
            Kurs kurs1 = new Kurs("INZ1517Wc", "Algorytmy i struktury danych", 4, true, Forma_kursu.WykladCwiczenia, null, 60, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { efekt1 }, new List<Zamiennik_kursu>(), plan, true);
            Kurs kurs2 = new Kurs("INZ1517L", "Algorytmy i struktury danych", 3, false, Forma_kursu.Laboratorium, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { efekt2 }, new List<Zamiennik_kursu>(), plan, true);
            List<Efekt_ksztalcenia> oczekiwaneEfekty = new List<Efekt_ksztalcenia> { efekt1, efekt2 };

            //ACT

            Grupa_kursow grupa = new Grupa_kursow(new List<Kurs> { kurs1, kurs2 }, Forma_kursu.WykladCwiczeniaLaboratorium);

            //ASSERT

            List<Efekt_ksztalcenia> efekty = grupa.Efekty;
            CollectionAssert.AreEqual(oczekiwaneEfekty, efekty, "Niepoprawne efekty ksztalcenia");

        }

        [TestMethod()]
        public void Grupa_kursowEfektyNull()
        {
            //ARRANGE
            Plan_studiow plan = new Plan_studiow(Poziom_ksztalcenia.I_Stopien, true, 7, null, null);
            Efekt_ksztalcenia efekt1 = new Efekt_ksztalcenia("K1INF_W04", plan, "Y", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia efekt2 = new Efekt_ksztalcenia("K1INF_W02", plan, "x", Typ_efektu_ksztalcenia.Wiedza);
            Kurs kurs1 = new Kurs("INZ1517Wc", "Algorytmy i struktury danych", 4, true, Forma_kursu.WykladCwiczenia, null, 60, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { efekt1 }, new List<Zamiennik_kursu>(), plan, true);
            Kurs kurs2 = new Kurs("INZ1517L", "Algorytmy i struktury danych", 3, false, Forma_kursu.Laboratorium, null, 30, Typ_semestru.Semestr_letni, 2, null, new List<Zamiennik_kursu>(), plan, true);
            List<Efekt_ksztalcenia> oczekiwaneEfekty = new List<Efekt_ksztalcenia> { efekt1};

            //ACT

            Grupa_kursow grupa = new Grupa_kursow(new List<Kurs> { kurs1, kurs2 }, Forma_kursu.WykladCwiczeniaLaboratorium);

            //ASSERT

            List<Efekt_ksztalcenia> efekty = grupa.Efekty;
            CollectionAssert.AreEqual(oczekiwaneEfekty, efekty, "Niepoprawne efekty ksztalcenia");

        }

        [TestMethod()]
        public void Grupa_kursowEfektyPowtarzajaceSie()
        {
            //ARRANGE
            Plan_studiow plan = new Plan_studiow(Poziom_ksztalcenia.I_Stopien, true, 7, null, null);
            Efekt_ksztalcenia efekt1 = new Efekt_ksztalcenia("K1INF_W04", plan, "Y", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia efekt2 = new Efekt_ksztalcenia("K1INF_W02", plan, "x", Typ_efektu_ksztalcenia.Wiedza);
            Kurs kurs1 = new Kurs("INZ1517Wc", "Algorytmy i struktury danych", 4, true, Forma_kursu.WykladCwiczenia, null, 60, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { efekt1 }, new List<Zamiennik_kursu>(), plan, true);
            Kurs kurs2 = new Kurs("INZ1517L", "Algorytmy i struktury danych", 3, false, Forma_kursu.Laboratorium, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { efekt1 }, new List<Zamiennik_kursu>(), plan, true);
            List<Efekt_ksztalcenia> oczekiwaneEfekty = new List<Efekt_ksztalcenia> { efekt1 };

            //ACT

            Grupa_kursow grupa = new Grupa_kursow(new List<Kurs> { kurs1, kurs2 }, Forma_kursu.WykladCwiczeniaLaboratorium);

            //ASSERT

            List<Efekt_ksztalcenia> efekty = grupa.Efekty;
            CollectionAssert.AreEqual(oczekiwaneEfekty, efekty, "Niepoprawne efekty ksztalcenia");

        }


    }
}