using LanguagePractice.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguagePractice.DataAccess.DataContext
{
    public class WordDatabaseContext : DbContext
    {
        public WordDatabaseContext()
        {
            
        }

        public DbSet<PresentIndicative> PresentIndicatives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PresentIndicative>().HasData(
                    new PresentIndicative { Id = 1, Infinitive = "fare", FirstPersonSingular = "faccio", SecondPersonSingular = "fai", ThirdPersonSingular = "fa", FirstPersonPlural = "facciamo", SecondPersonPlural = "fate", ThirdPersonPlural = "fanno"},
                    new PresentIndicative { Id = 2, Infinitive = "vedere", FirstPersonSingular = "vedo", SecondPersonSingular = "vedi", ThirdPersonSingular = "vede", FirstPersonPlural = "vediamo", SecondPersonPlural = "vedete", ThirdPersonPlural = "vedono"},
                    new PresentIndicative { Id = 3, Infinitive = "parlare", FirstPersonSingular = "parlo", SecondPersonSingular = "parla", ThirdPersonSingular = "parla", FirstPersonPlural = "parliamo", SecondPersonPlural = "parlate", ThirdPersonPlural = "parlano"}
                );
        }
    }
}