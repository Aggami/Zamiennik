
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Dostep_Do_Danych
{
    public class RepozytoriumZamiennik:Repozytorium<Zamiennik_kursu>
    {
        public RepozytoriumZamiennik(DbContext kontekst) : base(kontekst)
        {
        }

        public new List<Zamiennik_kursu> ZnajdzPoPredykacie(Expression<Func<Zamiennik_kursu, bool>> predykat)
        {
            return zbior.Where(predykat).Include(z => z.Kurs_zastepowany.Plan_studiow.Kierunek.Wydzial)
                .Include(p => p.Kursy_skladowe.Select(k=>k.Plan_studiow.Kierunek.Wydzial))
                .ToList<Zamiennik_kursu>();
        }
    }
}