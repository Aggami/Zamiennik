using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dostep_Do_Danych;

namespace Uslugi
{
    //klasa wykorzystywana do wprowadzenia testowych danych do bazy 
    public class GeneratorDanych
    {
        static DbContext db = new ZamiennikKontekst();
        static Repozytorium<Wydzial> wydzialyRep = new Repozytorium<Wydzial>(db);
        static Repozytorium<Kierunek_studiow> kierunkiRep = new Repozytorium<Kierunek_studiow>(db);
        static Repozytorium<Rok_akademicki> lataRep = new Repozytorium<Rok_akademicki>(db);
        static Repozytorium<Plan_studiow> planyRep = new Repozytorium<Plan_studiow>(db);
        static Repozytorium<Efekt_ksztalcenia> efektyRep = new Repozytorium<Efekt_ksztalcenia>(db);
        static Repozytorium<Kurs> kursyRep = new Repozytorium<Kurs>(db);
        static Repozytorium<Zamiennik_kursu> zamiennikiRep= new Repozytorium<Zamiennik_kursu>(db);
        static Repozytorium<Propozycja_zamiennika> propozycjeRep = new Repozytorium<Propozycja_zamiennika>(db);


        public static void DodajKursy()
        {

        }

        public static void DodajZamienniki(Kurs kurs)
        {
        }

        public static void DodajPierwszeDane()
        {
            Wydzial w1 = new Wydzial("1", "Wydział Architektury");
            Wydzial w2 = new Wydzial("2", "Wydział Budownictwa Lądowego i Wodnego");
            Wydzial w3 = new Wydzial("3", "Wydział Chemiczny");
            Wydzial w4 = new Wydzial("4", "Wydział Elektroniki");
            Wydzial w6 = new Wydzial("6", "Wydział Geoinżynierii, Górnictwa i Geologii");
            Wydzial w7 = new Wydzial("7", "Wydział Inżynierii Środowiska");
            Wydzial w5 = new Wydzial("5", "Wydział Elektryki ");
            Wydzial w8 = new Wydzial("8", "Wydział Informatyki i Zarządzania");
            Wydzial w9 = new Wydzial("9", "Wydział Mechaniczno-elektryczny");
            Wydzial w10 = new Wydzial("10", "Wydział Mechaniczny");
            Wydzial w11 = new Wydzial("11", "Wydział Podstawowych Problemów Techniki");
            Wydzial w12 = new Wydzial("12", "Wydział Elektroniki Mikrosystemów i Fotoniki");
            Wydzial w13 = new Wydzial("13", "Wydział Matematyki");
            
            List<Wydzial> wydzialy = new List<Wydzial>{ w1, w2,w3,w4,w5,w6,w7,w8,w9,w10,w11,w12,w13 };
            wydzialyRep.WstawKolekcje(wydzialy);

            Kierunek_studiow infW8 = new Kierunek_studiow("Informatyka", w8);
            Kierunek_studiow infW4 = new Kierunek_studiow("Informatyka", w4);
            Kierunek_studiow matStosW13 = new Kierunek_studiow("Matematyka stosowana", w13);
            Kierunek_studiow zarzW8 = new Kierunek_studiow("Zarządzanie", w8);
            Kierunek_studiow infW11 = new Kierunek_studiow("Informatyka", w11);
            List<Kierunek_studiow> kierunki = new List<Kierunek_studiow> { infW8, infW4, infW11, matStosW13, zarzW8 };
            kierunkiRep.WstawKolekcje(kierunki);

            Rok_akademicki r17 = new Rok_akademicki("2017/2018", DateTime.Parse("01-Oct-2017"), DateTime.Parse("01-Jul-2018"));
            Rok_akademicki r16 = new Rok_akademicki("2016/2017", DateTime.Parse("01-Oct-2016"), DateTime.Parse("01-Jul-2017"));
            Rok_akademicki r18 = new Rok_akademicki("2018/2019", DateTime.Parse("01-Oct-2018"), DateTime.Parse("01-Jul-2019"));
            Rok_akademicki r15 = new Rok_akademicki("2015/2016", DateTime.Parse("01-Oct-2015"), DateTime.Parse("01-Jul-2016"));
            List<Rok_akademicki> lata = new List<Rok_akademicki> { r15,r16, r17,r18};
            lataRep.WstawKolekcje(lata);

            Plan_studiow plW8Inf16 = new Plan_studiow(Poziom_ksztalcenia.I_Stopien, true, 7, new List<Rok_akademicki> { r16, r17 }, infW8);
            Plan_studiow plW4Inf16 = new Plan_studiow(Poziom_ksztalcenia.I_Stopien, true, 7, new List<Rok_akademicki> { r16, r17 }, infW4);
            Plan_studiow plW11Inf16 = new Plan_studiow(Poziom_ksztalcenia.I_Stopien, true, 7, new List<Rok_akademicki> { r16, r17 }, infW11);
            Plan_studiow plW8Zarz15 = new Plan_studiow(Poziom_ksztalcenia.I_Stopien, true, 7, new List<Rok_akademicki> { r16, r17 }, zarzW8);

            List<Plan_studiow> plany = new List<Plan_studiow> { plW8Inf16, plW4Inf16, plW11Inf16, plW8Zarz15 };
            planyRep.WstawKolekcje(plany);

            Efekt_ksztalcenia W8Inf15w1 = new Efekt_ksztalcenia("K1INF_W01", plW8Inf16, "Ma podstawową wiedzę w zakresie algebry liniowej, geometrii analitycznej i analizy matematycznej,konieczną do rozwiązywania prostych zadań obliczeniowych o charakterze inżynierskim z dyscyplintechnicznych i nietechnicznych", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W8Inf15w2 = new Efekt_ksztalcenia("K1INF_W02", plW8Inf16, "Ma podstawową wiedzę w zakresie matematyki dyskretnej, logiki matematycznej i statystykimatematycznej, konieczną do rozwiązywania prostych informatycznych problemów inżynierskich.", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W8Inf15w3 = new Efekt_ksztalcenia("K1INF_W03", plW8Inf16, "Ma podstawową wiedzę w zakresie mechaniki klasycznej; ruchu falowego; termodynamikifenomenologicznej; fizyki: kwantowej, jądra atomu; astrofizyki", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W8Inf15w4 = new Efekt_ksztalcenia("K1INF_W04", plW8Inf16, "Zna podstawowe konstrukcje programistyczne, algorytmy, strategie algorytmiczne i struktury danych", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W8Inf15w5 = new Efekt_ksztalcenia("K1INF_W05", plW8Inf16, "Zna podstawowy zestaw dobrych praktyk wytwarzania oprogramowania ", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W8Inf15w6 = new Efekt_ksztalcenia("K1INF_W06", plW8Inf16, "Zna podstawowe paradygmaty programowania i przykładowe języki wykorzystujące te paradygmaty", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W8Inf15u1 = new Efekt_ksztalcenia("K1INF_U01", plW8Inf16, "Potrafi konstruować i implementować algorytmy, w tym algorytmy rozproszone, wykorzystując podstawowe strategie algorytmiczne i struktury danych", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W8Inf15u2 = new Efekt_ksztalcenia("K1INF_U02", plW8Inf16, "Potrafi dobrać i ocenić przydatność paradygmatu programowania do problemu i zbudować prostą aplikację wykorzystującą ten paradygmat", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W8Inf15u3 = new Efekt_ksztalcenia("K1INF_U03", plW8Inf16, "Potrafi opisać wymagania i zaprojektować – korzystając z wybranego języka modelowania – ogólną architekturę oprogramowania i schemat bazy danych", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W8Inf15u4 = new Efekt_ksztalcenia("K1INF_U04", plW8Inf16, "Potrafi zaimplementować, zgodnie z projektem, oprogramowanie dla prostych, typowych zastosowań i utworzyć bazę danych oraz zweryfikować poprawność rozwiązania", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W8Inf15u5 = new Efekt_ksztalcenia("K1INF_U05", plW8Inf16, "Ma umiejętność samokształcenia, m.in. w celu podnoszenia kompetencji zawodowych", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W8Inf15u6 = new Efekt_ksztalcenia("K1INF_U06", plW8Inf16, "Potrafi dobierać komponenty sprzętowe i programowe systemu komputerowego dla wskazanych zastosowań", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W8Inf15k1 = new Efekt_ksztalcenia("K1INF_K01", plW8Inf16, "Rozumie potrzebę i zna możliwości ciągłego dokształcania się oraz podnoszenia własnych kompetencji zawodowych i społecznych", Typ_efektu_ksztalcenia.Kompetencja);
            Efekt_ksztalcenia W8Inf15k2 = new Efekt_ksztalcenia("K1INF_K02", plW8Inf16, "Ma świadomość ważności i zrozumienie pozatechnicznych aspektów i skutków działalności inżynierainformatyka, w tym jej wpływu na środowisko, i związanej z tym odpowiedzialności za podejmowane decyzje", Typ_efektu_ksztalcenia.Kompetencja);
            Efekt_ksztalcenia W8Inf15k3 = new Efekt_ksztalcenia("K1INF_K03", plW8Inf16, "Potrafi współdziałać i pracować w grupie, przyjmując w niej różne role", Typ_efektu_ksztalcenia.Kompetencja);
            Efekt_ksztalcenia W8Inf15k4 = new Efekt_ksztalcenia("K1INF_K04", plW8Inf16, "Potrafi odpowiednio określić priorytety służące realizacji określonego przez siebie lub innych zadania", Typ_efektu_ksztalcenia.Kompetencja);

            Efekt_ksztalcenia W4Inf15w5 = new Efekt_ksztalcenia("K1INF_W05", plW4Inf16, "Ma podstawową wiedzę w zakresie mechaniki klasycznej, ruchu falowego, termodynamiki fenomenologicznej, fizyki jądra atomu i fizyki fazy skondensowanej ", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W4Inf15w7 = new Efekt_ksztalcenia("K1INF_W07w4", plW4Inf16, "Zna pojęcie algorytmu oraz metody jego reprezentacji, podstawowe konstrukcję języków algorytmicznych, pojęcie rekurencji, zasady programowania strukturalnego, podstawowe algorytmy sortowania i przeszukiwania danych, a także dynamiczne i złożone struktury danych.", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W4Inf15w8 = new Efekt_ksztalcenia("K1INF_W08", plW4Inf16, "Zna podstawy inżynierii i metodologii programowania obiektowego ", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W4Inf15w21 = new Efekt_ksztalcenia("K1INF_W21", plW4Inf16, "Ma podstawową wiedzę w zakresie logiki matematycznej i rachunku zdań i matematyki dyskretnej(indukcja matematyczna,rekurencja, drzewa i grafy)", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W4Inf15w35 = new Efekt_ksztalcenia("K1INF_W35", plW4Inf16, "zna podstawowe algorytmy przetwarzające struktury danych, znapodstawy teorii złożoności obliczeniowej ", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W4Inf15w36 = new Efekt_ksztalcenia("K1INF_W36", plW4Inf16, "ma wiedzę z zakresu modelowania danych, projektowania baz danych oraz pozyskiwania informacji z baz danych ", Typ_efektu_ksztalcenia.Wiedza);

            Efekt_ksztalcenia W4Inf15u7 = new Efekt_ksztalcenia("K1INF_U07", plW4Inf16, "Umie zapisać algorytm w postaci schematu blokowego, podać rozwiązanie prostych zadań programistycznych w postaci algorytmów oraz podać sposób ich testowania", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W4Inf15u8 = new Efekt_ksztalcenia("K1INF_U08", plW4Inf16, "Umie korzystać z środowiska programistycznego oraz programować z użyciem typów prostych, łańcuchów znakowych, pętli, procedur i funkcji. ", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W4Inf15u35 = new Efekt_ksztalcenia("K1INF_U35", plW4Inf16, "umie konstruować algorytmy z użyciem różnych technik algorytmicznych ", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W4Inf15u36 = new Efekt_ksztalcenia("K1INF_U36", plW4Inf16, "umie ocenić złożoności algorytmów oraz problemów decyzyjnych i optymalizacyjnych", Typ_efektu_ksztalcenia.Umiejetnosc);

            Efekt_ksztalcenia W4Inf15k5 = new Efekt_ksztalcenia("W4K1INF_U05", plW4Inf16, "Ma świadomość niezbędności aktywności indywidualnych i zespołowych wykraczających poza działalność inżynierską", Typ_efektu_ksztalcenia.Kompetencja);

            Efekt_ksztalcenia W11Inf15w6 = new Efekt_ksztalcenia("K1INF_W06", plW11Inf16, "Zna najważniejsze struktury danych występujące w informatyce", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W11Inf15w2 = new Efekt_ksztalcenia("K1INF_W02", plW11Inf16, "Posiada wiedzę potrzebną do zrozumienia fizycznych podstaw przechowywania, przetwarzania i transmisji informacji", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W11Inf15w3 = new Efekt_ksztalcenia("K1INF_W03", plW11Inf16, "Zna algorytmy sortowania, wyszukiwania, przeglądania i porównywania oraz ich złożoności obliczeniowe", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W11Inf15w4 = new Efekt_ksztalcenia("K1INF_W04", plW11Inf16, "Zna techniki służące do badania i analizy efektywności algorytmów", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W11Inf15w7 = new Efekt_ksztalcenia("K1INF_W07", plW11Inf16, "Zna pojęcie automatu skończonego, gramatyki formalnej i klasyfikacji języków formalnych", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W11Inf15w8 = new Efekt_ksztalcenia("K1INF_W08", plW11Inf16, "Posiada wiedzę na temat języków i paradygmatów programowania", Typ_efektu_ksztalcenia.Wiedza);
            Efekt_ksztalcenia W11Inf15u19 = new Efekt_ksztalcenia("K1INF_U19", plW11Inf16, "Potrafi projektować i budować aplikacje ", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W11Inf15u2 = new Efekt_ksztalcenia("K1INF_U02", plW11Inf16, "Potrafi dobrać i ocenić przydatność paradygmatu programowania do problemu i zbudować prostą aplikację wykorzystującą ten paradygmat", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W11Inf15u3 = new Efekt_ksztalcenia("K1INF_U03", plW11Inf16, "Potrafi opisać wymagania i zaprojektować – korzystając z wybranego języka modelowania – ogólną architekturę oprogramowania i schemat bazy danych", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W11Inf15u4 = new Efekt_ksztalcenia("K1INF_U04", plW11Inf16, "Potrafi opracować w języku polskim i języku angielskim dokumentację techniczną zrealizowanego projektu informatycznego ", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W11Inf15u5 = new Efekt_ksztalcenia("K1INF_U05", plW11Inf16, "Ma umiejętność samokształcenia, m.in. w celu podnoszenia kompetencji zawodowych", Typ_efektu_ksztalcenia.Umiejetnosc);
            Efekt_ksztalcenia W11Inf15u6 = new Efekt_ksztalcenia("K1INF_U06", plW11Inf16, "Potrafi dobierać komponenty sprzętowe i programowe systemu komputerowego dla wskazanych zastosowań", Typ_efektu_ksztalcenia.Umiejetnosc);
            /*
            Efekt_ksztalcenia W11Inf15k1 = new Efekt_ksztalcenia("K1INF_K01", plW11Inf16, "Rozumie potrzebę i zna możliwości ciągłego dokształcania się oraz podnoszenia własnych kompetencji zawodowych i społecznych", Typ_efektu_ksztalcenia.Kompetencja);
            Efekt_ksztalcenia W11Inf15k2 = new Efekt_ksztalcenia("K1INF_K02", plW11Inf16, "Ma świadomość ważności i zrozumienie pozatechnicznych aspektów i skutków działalności inżynierainformatyka, w tym jej wpływu na środowisko, i związanej z tym odpowiedzialności za podejmowane decyzje", Typ_efektu_ksztalcenia.Kompetencja);
            Efekt_ksztalcenia W11Inf15k3 = new Efekt_ksztalcenia("K1INF_K03", plW11Inf16, "Potrafi współdziałać i pracować w grupie, przyjmując w niej różne role", Typ_efektu_ksztalcenia.Kompetencja);
            Efekt_ksztalcenia W11Inf15k4 = new Efekt_ksztalcenia("K1INF_K04", plW11Inf16, "Potrafi odpowiednio określić priorytety służące realizacji określonego przez siebie lub innych zadania", Typ_efektu_ksztalcenia.Kompetencja);
            */

            List<Efekt_ksztalcenia> efekty = new List<Efekt_ksztalcenia> { W8Inf15w1, W8Inf15w2, W8Inf15w3, W8Inf15w4, W8Inf15w5, W8Inf15w6, W8Inf15u1, W8Inf15u2, W8Inf15u3, W8Inf15u4, W8Inf15u5, W8Inf15u6, W8Inf15k1, W8Inf15k2, W8Inf15k3, W8Inf15k4, W4Inf15w5, W4Inf15w7, W4Inf15u7, W4Inf15u8, W4Inf15u35, W4Inf15u36, W4Inf15w8, W4Inf15w21, W4Inf15w35, W4Inf15k5, W4Inf15w36, W11Inf15w6, W11Inf15w2, W11Inf15w3, W11Inf15w4, W11Inf15w7, W11Inf15w8, W11Inf15u19, W11Inf15u2, W11Inf15u3, W11Inf15u4, W11Inf15u5, W11Inf15u6 };
            efektyRep.WstawKolekcje(efekty);

            Kurs w8inf15LogikaW = new Kurs("INZ1518W", "Logika dla informatyków", 2, true, Forma_kursu.Wyklad, null, 30, Typ_semestru.Semestr_zimowy, 1, new List<Efekt_ksztalcenia> {W8Inf15w1}, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15LogikaC = new Kurs("INZ1518C", "Logika dla informatyków", 2, false, Forma_kursu.Cwiczenia, null, 30, Typ_semestru.Semestr_zimowy, 1, new List<Efekt_ksztalcenia> { W8Inf15w1 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15AlgIStrWC = new Kurs("INZ1517Wc", "Algorytmy i struktury danych", 4, true, Forma_kursu.WykladCwiczenia, null, 60, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { W8Inf15w4 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15AlgIStrL = new Kurs("INZ1517L", "Algorytmy i struktury danych", 3, false, Forma_kursu.Laboratorium, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { W8Inf15u1 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15MatDysW = new Kurs("MAZ1500C", "Matematyka Dyskretna", 3, false, Forma_kursu.Cwiczenia, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { W8Inf15w2 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15MatDysC = new Kurs("MAZ1500W", "Matematyka Dyskretna", 3, true, Forma_kursu.Wyklad, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { W8Inf15w2 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15ParProgWC = new Kurs("INZ2528Wc", "Paradygmaty programowania", 4, true, Forma_kursu.WykladCwiczenia, null, 45, Typ_semestru.Semestr_zimowy, 3, new List<Efekt_ksztalcenia> { W8Inf15w5, W8Inf15w6 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15ParProgL = new Kurs("INZ2528L", "Paradygmaty programowania", 3, false, Forma_kursu.Laboratorium, null, 30, Typ_semestru.Semestr_zimowy, 3, new List<Efekt_ksztalcenia> { W8Inf15u2 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15PdstInzOprC = new Kurs("INZ2558C", "Podstawy inżynierii oprogramowania", 1, false, Forma_kursu.Cwiczenia, null, 15, Typ_semestru.Semestr_letni, 4, new List<Efekt_ksztalcenia> { W8Inf15u3 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15PdstInzOprL = new Kurs("INZ2558L", "Podstawy inżynierii oprogramowania", 3, false, Forma_kursu.Laboratorium, null, 30, Typ_semestru.Semestr_letni, 4, new List<Efekt_ksztalcenia> { W8Inf15u3 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15ProjOprL = new Kurs("INZ3561L", "Projektowanie oprogramowania", 3, false, Forma_kursu.Laboratorium, null, 30, Typ_semestru.Semestr_zimowy, 5, new List<Efekt_ksztalcenia> { W8Inf15u2, W8Inf15u3, W8Inf15u4 }, new List<Zamiennik_kursu>(), plW8Inf16, true);
            Kurs w8inf15ProjOprW = new Kurs("INZ3561W", "Projektowanie oprogramowania", 2, true, Forma_kursu.Wyklad, null, 30, Typ_semestru.Semestr_zimowy, 5, new List<Efekt_ksztalcenia> { W8Inf15w5 }, new List<Zamiennik_kursu>(), plW8Inf16, true);

            Kurs w4inf15AlgIStrWC = new Kurs("INEK026W", "Struktury danych i złożoność obliczeniowa ", 4, true, Forma_kursu.WykladCwiczenia, null, 60, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { W8Inf15w4 }, new List<Zamiennik_kursu>(), plW4Inf16, true);
            Kurs w4infMatDysW = new Kurs("MAT001445W", "Matematyka Dyskretna", 4, false, Forma_kursu.Cwiczenia, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { W4Inf15w21 }, new List<Zamiennik_kursu>(), plW4Inf16, true);
            Kurs w4infMatDysC = new Kurs("MAT001445C", "Matematyka Dyskretna", 0, false, Forma_kursu.Cwiczenia, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { W4Inf15w21 }, new List<Zamiennik_kursu>(), plW4Inf16, true);
            Grupa_kursow w4infMatDysWC = new Grupa_kursow(new List<Kurs> { w4infMatDysW , w4infMatDysC}, Forma_kursu.WykladCwiczenia);

            Kurs w11inf15AlgIStrWCL = new Kurs("INP002263Wcl", "Algorytmy i struktury danych", 6, true, Forma_kursu.WykladCwiczeniaLaboratorium, null, 30, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { W11Inf15w3, W11Inf15w4 }, new List<Zamiennik_kursu>(), plW11Inf16, true);
            Kurs w11inf15MatDysWC = new Kurs("INP002263Wc", "Matematyka Dyskretna", 6, true, Forma_kursu.WykladCwiczenia, null, 60, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> {}, new List<Zamiennik_kursu>(), plW11Inf16, true);
            Kurs w11inf15JeziParProgWl = new Kurs("INP002215Wl", "Języki i paradygmaty program.", 6, true, Forma_kursu.WykladLaboratorium, null, 60, Typ_semestru.Semestr_letni, 2, new List<Efekt_ksztalcenia> { }, new List<Zamiennik_kursu>(), plW11Inf16, true);

            List<Kurs> kursy = new List<Kurs> { w8inf15LogikaW, w8inf15LogikaC, w8inf15AlgIStrWC, w8inf15AlgIStrL, w8inf15MatDysW, w8inf15MatDysC, w8inf15ParProgWC, w8inf15ParProgL, w8inf15PdstInzOprC, w8inf15PdstInzOprL, w8inf15ProjOprL, w8inf15ProjOprW, w4inf15AlgIStrWC, w4infMatDysW, w4infMatDysC, w4infMatDysWC, w11inf15AlgIStrWCL, w11inf15MatDysWC, w11inf15JeziParProgWl };
            kursyRep.WstawKolekcje(kursy);

            Propozycja_zamiennika propozycjaMatDys = new Propozycja_zamiennika(w8inf15MatDysW, w4infMatDysWC);
            Propozycja_zamiennika propozycjaAlgIStr = new Propozycja_zamiennika(w8inf15AlgIStrWC, w4inf15AlgIStrWC);
            Propozycja_zamiennika propozycjaAlgIStr2 = new Propozycja_zamiennika(w8inf15AlgIStrWC, w11inf15AlgIStrWCL);
            List<Propozycja_zamiennika> propozycje = new List<Propozycja_zamiennika> { propozycjaMatDys, propozycjaAlgIStr, propozycjaAlgIStr2 };
            propozycjeRep.WstawKolekcje(propozycje);

            Zamiennik_kursu zamMatDys = new Zamiennik_kursu(w11inf15MatDysWC, new List<Kurs> { w8inf15MatDysW, w8inf15MatDysC });

            Zamiennik_kursu zamParProg = new Zamiennik_kursu(w11inf15JeziParProgWl, new List<Kurs> { w8inf15ParProgWC, w8inf15ParProgL });


            List<Zamiennik_kursu> zamienniki = new List<Zamiennik_kursu> { zamParProg, zamMatDys };
            zamiennikiRep.WstawKolekcje(zamienniki);

            db.SaveChanges();
        }


        



    }
}
