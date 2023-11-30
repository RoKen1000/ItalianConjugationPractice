using System.Linq.Expressions;

namespace LanguagePractice.Repositories.IRepositories
{
    public interface IWordManagement<T> where T : class
    {
        void Create(T word);
        void Update(T word);
        void Delete(T word);
        IEnumerable<T> GetAll();
        T GetSingle(Expression<Func<T, bool>> filter);
    }
}
