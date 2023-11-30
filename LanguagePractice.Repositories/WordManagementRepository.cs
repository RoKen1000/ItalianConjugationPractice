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
            throw new NotImplementedException();
        }

        public void Delete(T word)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(T word)
        {
            throw new NotImplementedException();
        }
    }
}
