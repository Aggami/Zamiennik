using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Dostep_Do_Danych
{
    public class Repozytorium<T> where T : class
    {
        protected DbSet<T> zbior;
         

        public Repozytorium(DbContext kontekst)
        {
            zbior = kontekst.Set<T>();
        }

        public void Wstaw(T rekord)
        {
            zbior.Add(rekord);
        }

        public void WstawKolekcje(ICollection<T> rekordy)
        {
            zbior.AddRange(rekordy);
        }

        public void Usun(T rekord)
        {
            zbior.Remove(rekord);
        }

     
        public IQueryable<T> ZnajdzWszystkie()
        {
            return zbior;
        }

        public void Edytuj(T obj)
        {
            var rekord =zbior.Find(obj);
            if (rekord == null)
            {
                return;
            }
            zbior.Attach(obj);

        }

        public List<T>ZnajdzPoPredykacie(Expression<Func<T, bool>> predykat)
        {
            return zbior.Where(predykat).ToList<T>();
        }
    }
}
