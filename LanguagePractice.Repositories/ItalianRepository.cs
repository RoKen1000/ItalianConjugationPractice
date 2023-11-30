using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using LanguagePracticeSite.Models;

namespace LanguagePractice.Repositories
{
    public class ItalianRepository : IItalianRepository
    {
        private readonly WordDatabaseContext _db;

        public ItalianRepository(WordDatabaseContext db)
        {
            _db = db;
        }

        public Imperfect Imperfect()
        {
            Imperfect retrievedWord = _db.ImperfectWords.Skip(ProduceRandomOffset("imperfect")).FirstOrDefault();

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
