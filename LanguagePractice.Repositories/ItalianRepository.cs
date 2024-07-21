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

        public async Task<Imperfect> Imperfect()
        {
            var retrievedWord = await _db.ImperfectWords.Skip(ProduceRandomOffset("imperfect")).FirstOrDefaultAsync();

            return retrievedWord;
        }

        public PresentIndicative PresentIndicative()
        {
            PresentIndicative retrievedWord = _db.PresentIndicativeWords.Skip(ProduceRandomOffset("present indicative")).FirstOrDefault();

            return retrievedWord;
        }

        public PresentPerfect PresentPerfect()
        {
            PresentPerfect retrievedWord = _db.PresentPerfectPhrases.Skip(ProduceRandomOffset("present perfect")).FirstOrDefault();

            return retrievedWord;
        }

        public int ProduceRandomOffset(string verbTense)
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
