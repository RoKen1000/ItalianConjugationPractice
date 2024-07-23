using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using LanguagePracticeSite.Models;
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

        public async Task<Imperfect> GetImperfect()
        {
            var retrievedImperfectWord = await _db.ImperfectWords.Skip(ProduceRandomOffset("imperfect")).FirstOrDefaultAsync();

            if(retrievedImperfectWord == null)
            {
                throw new Exception("Word does not exist");
            }

            return retrievedImperfectWord;
        }

        public async Task<PresentIndicative> GetPresentIndicative()
        {
            var retrievedPresIndWord = await _db.PresentIndicativeWords.Skip(ProduceRandomOffset("present indicative")).FirstOrDefaultAsync();

            if(retrievedPresIndWord == null)
            {
                throw new Exception("Word does not exist");
            }

            return retrievedPresIndWord;
        }

        public async Task<PresentPerfect> GetPresentPerfect()
        {
            var retrievedPresPerfWord = await _db.PresentPerfectPhrases.Skip(ProduceRandomOffset("present perfect")).FirstOrDefaultAsync();

            if(retrievedPresPerfWord == null)
            {
                throw new Exception("Word does not exist");
            }

            return retrievedPresPerfWord;
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
