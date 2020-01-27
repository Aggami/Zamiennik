using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dostep_Do_Danych
{
    public class RepozytoriumPropozycja : Repozytorium<Propozycja_zamiennika>
    {
        public RepozytoriumPropozycja(DbContext kontekst) : base(kontekst)
        {
        }

        public new List<Propozycja_zamiennika> ZnajdzPoPredykacie(Expression<Func<Propozycja_zamiennika, bool>> predykat)
        {
            return zbior.Where(predykat).Include(p => p.Kurs_zastepowany.Plan_studiow.Lata).Include(p => p.Kurs_zastepowany.Plan_studiow.Kierunek.Wydzial).Include(p => p.Kurs_zastepujacy.Plan_studiow.Lata).Include(p => p.Kurs_zastepujacy.Plan_studiow.Kierunek.Wydzial).Include("Kurs_zastepujacy.Efekty").Include("Kurs_zastepowany.Efekty")
                .ToList<Propozycja_zamiennika>();
        }
    }
}
