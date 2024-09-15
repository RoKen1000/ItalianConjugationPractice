using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using LanguagePracticeSite.Models.Entities;
using LanguagePractice.Common.Result;
using Microsoft.EntityFrameworkCore;

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
            var retrievedImperfectWord = await _db.ImperfectWords.Skip(ProduceRandomOffset("imperfect")).FirstOrDefaultAsync();

            if(retrievedImperfectWord == null)
            {
                return Result<Imperfect>.Failure("Word does not exist");
            }

            return Result<Imperfect>.Success(retrievedImperfectWord);
        }

        public async Task<Result<PresentIndicative>> GetPresentIndicative()
        {
            var retrievedPresIndWord = await _db.PresentIndicativeWords.Skip(ProduceRandomOffset("present indicative")).FirstOrDefaultAsync();

            if(retrievedPresIndWord == null)
            {
                return Result<PresentIndicative>.Failure("Word does not exist");
            }

            return Result<PresentIndicative>.Success(retrievedPresIndWord); ;
        }

        public async Task<Result<PresentPerfect>> GetPresentPerfect()
        {
            var retrievedPresPerfWord = await _db.PresentPerfectPhrases.Skip(ProduceRandomOffset("present perfect")).FirstOrDefaultAsync();

            if(retrievedPresPerfWord == null)
            {
                return Result<PresentPerfect>.Failure("Word does not exist");
            }

            return Result<PresentPerfect>.Success(retrievedPresPerfWord);
        }

        private int ProduceRandomOffset(string verbTense)
        {
            int wordCount;

            switch (verbTense)
            {
                case "present indicative":
                    wordCount = _db.PresentIndicativeWords.Count();
                    break;
                case "present perfect":
                    wordCount = _db.PresentPerfectPhrases.Count();
                    break;
                case "imperfect":
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
