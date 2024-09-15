using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using LanguagePracticeSite.Models.Entities;
using LanguagePractice.Common.Result;
using Microsoft.EntityFrameworkCore;
using LanguagePractice.Common.Enums;

namespace LanguagePractice.Repositories
{
    public class ItalianRepository : IItalianRepository
    {
        private readonly WordDatabaseContext _db;

        public ItalianRepository(WordDatabaseContext db)
        {
            _db = db;
        }

        public async Task<Result<Imperfect>> GetImperfect()
        {
            var retrievedImperfectWord = await _db.ImperfectWords.Skip(ProduceRandomOffset(VerbTense.Imperfect)).FirstOrDefaultAsync();

            if(retrievedImperfectWord == null)
            {
                return Result<Imperfect>.Failure("Word does not exist");
            }

            return Result<Imperfect>.Success(retrievedImperfectWord);
        }

        public async Task<Result<PresentIndicative>> GetPresentIndicative()
        {
            var retrievedPresIndWord = await _db.PresentIndicativeWords.Skip(ProduceRandomOffset(VerbTense.PresentIndicative)).FirstOrDefaultAsync();

            if(retrievedPresIndWord == null)
            {
                return Result<PresentIndicative>.Failure("Word does not exist");
            }

            return Result<PresentIndicative>.Success(retrievedPresIndWord); ;
        }

        public async Task<Result<PresentPerfect>> GetPresentPerfect()
        {
            var retrievedPresPerfWord = await _db.PresentPerfectPhrases.Skip(ProduceRandomOffset(VerbTense.PresentPerfect)).FirstOrDefaultAsync();

            if(retrievedPresPerfWord == null)
            {
                return Result<PresentPerfect>.Failure("Word does not exist");
            }

            return Result<PresentPerfect>.Success(retrievedPresPerfWord);
        }

        private int ProduceRandomOffset(VerbTense verbTense)
        {
            int wordCount;

            switch ((int)verbTense)
            {
                case 0:
                    wordCount = _db.PresentIndicativeWords.Count();
                    break;
                case 1:
                    wordCount = _db.PresentPerfectPhrases.Count();
                    break;
                case 2:
                    wordCount = _db.ImperfectWords.Count();
                    break;
                default:
                    wordCount = 0;
                    break;
            }

            Random r = new Random();
            int offset = r.Next(0, wordCount);

            return offset;
        }
    }
}
