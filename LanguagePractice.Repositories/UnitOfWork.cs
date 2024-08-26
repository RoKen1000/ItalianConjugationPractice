using AutoMapper;
using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using LanguagePracticeSite.Models.Entities;

namespace LanguagePractice.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IWordManagementRepository<PresentIndicative> PresentIndicative { get; private set; }
        public IWordManagementRepository<PresentPerfect> PresentPerfect { get; private set; }
        public IWordManagementRepository<Imperfect> Imperfect { get; private set; }
        private readonly WordDatabaseContext _db;
        private readonly IMapper _mapper;

        public UnitOfWork(WordDatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            PresentIndicative = new WordManagementRepository<PresentIndicative>(_db, _mapper);
            PresentPerfect = new WordManagementRepository<PresentPerfect>(_db, _mapper);
            Imperfect = new WordManagementRepository<Imperfect>(_db, _mapper);
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
