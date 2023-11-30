using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LanguagePractice.Repositories
{
    public class WordManagementRepository<T> : IWordManagementRepository<T> where T : class
    {
        private readonly WordDatabaseContext _db;
        internal DbSet<T> dbSet;

        public WordManagementRepository(WordDatabaseContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public void Create(T word)
        {
            dbSet.Add(word);
        }

        public void Delete(T word)
        {
            dbSet.Remove(word);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;

            return query.ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;

            query = query.Where(filter);

            return query.FirstOrDefault();
        }

        public void Update(T word)
        {
            dbSet.Update(word);
        }
    }
}
