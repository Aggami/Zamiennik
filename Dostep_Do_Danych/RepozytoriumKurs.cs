using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dostep_Do_Danych
{
    public class RepozytoriumKurs : Repozytorium<Kurs>
    {
        public RepozytoriumKurs(DbContext kontekst) : base(kontekst)
        {

        }

        public new List<Kurs> ZnajdzPoPredykacie(Expression<Func<Kurs, bool>> predykat)
        {
            return zbior.Where(predykat).Include(p => p.Plan_studiow.Kierunek.Wydzial)
                .Include(p => p.Zamienniki.Select(z => z.Kursy_skladowe.Select(k=>k.Plan_studiow.Lata)))
                .Include(p => p.Zamienniki.Select(z => z.Kursy_skladowe.Select(k => k.Plan_studiow.Kierunek.Wydzial)))
                .ToList<Kurs>();
        }
    }
}
