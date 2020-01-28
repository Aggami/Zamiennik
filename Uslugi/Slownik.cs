using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Uslugi
{
    public class Slownik
    {
        public string Forma_Kursu (Forma_kursu forma)
        {
            switch (forma){
                case Forma_kursu.CwiczeniaLaboratorium:
                    return "Ćwiczenia i Laboratorium (GK)";
                case Forma_kursu.WykladCwiczenia:
                    return "Wykład i ćwiczenia (GK)";
                case Forma_kursu.WykladCwiczeniaLaboratorium:
                    return "Wykład, ćwiczenia i laboratorium (GK)";
                case Forma_kursu.WykladProjekt:
                    return "Wykład i projekt (GK)";
                case Forma_kursu.WykladLaboratorium:
                    return "Wykład i laboratorium (GK)";
                case Forma_kursu.Wyklad:
                    return "Wykład";
                case Forma_kursu.Cwiczenia:
                    return "Ćwiczenia";
                default:
                    return forma.ToString();
            }
        }

        public string Typ_semestru(Typ_semestru typ)
        {
            if (typ == global::Typ_semestru.Semestr_letni) return "Semestr letni";
            else return "Semestr zimowy";
        }


    }
}