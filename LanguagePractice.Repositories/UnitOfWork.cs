using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using LanguagePracticeSite.Models;

namespace LanguagePractice.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IWordManagementRepository<PresentIndicative> PresentIndicative { get; private set; }
        public IWordManagementRepository<PresentPerfect> PresentPerfect { get; private set; }
        public IWordManagementRepository<Imperfect> Imperfect { get; private set; }
        private readonly WordDatabaseContext _db;

        public UnitOfWork(WordDatabaseContext db)
        {
            _db = db;
            PresentIndicative = new WordManagementRepository<PresentIndicative>(_db);
            PresentPerfect = new WordManagementRepository<PresentPerfect>(_db);
            Imperfect = new WordManagementRepository<Imperfect>(_db);
        }
    }
}
