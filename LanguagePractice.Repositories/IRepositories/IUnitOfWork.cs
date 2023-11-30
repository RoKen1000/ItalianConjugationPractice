using LanguagePracticeSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IWordManagementRepository<PresentIndicative> PresentIndicative { get; }
        IWordManagementRepository<PresentPerfect> PresentPerfect { get; }
        IWordManagementRepository<Imperfect> Imperfect { get; }
        void Save();
    }
}
