using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;

namespace LanguagePractice.Repositories
{
    public class ItalianRepository : IItalianRepository
    {
        private readonly WordDatabaseContext _db;

        public ItalianRepository(WordDatabaseContext db)
        {
            _db = db;
        }

        public void Imperfect()
        {
            throw new NotImplementedException();
        }

        public void PresentIndicative()
        {
            throw new NotImplementedException();
        }

        public void PresentPerfect()
        {
            throw new NotImplementedException();
        }

        public int ProduceRandomOffset(string verbTense)
        {
            throw new NotImplementedException();
        }
    }
}
