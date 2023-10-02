using LanguagePracticeSite.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguagePractice.DataAccess.DataContext
{
    public class WordDatabaseContext : DbContext
    {
        public WordDatabaseContext(DbContextOptions<WordDatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<PresentIndicative> PresentIndicativeWords { get; set; }
        public DbSet<PresentPerfect> PresentPerfectPhrases { get; set; }
        public DbSet<Imperfect> ImperfectWords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PresentIndicative>().HasData(
                    new PresentIndicative { Id = 1, Infinitive = "fare", FirstPersonSingular = "faccio", SecondPersonSingular = "fai", ThirdPersonSingular = "fa", FirstPersonPlural = "facciamo", SecondPersonPlural = "fate", ThirdPersonPlural = "fanno"},
                    new PresentIndicative { Id = 2, Infinitive = "vedere", FirstPersonSingular = "vedo", SecondPersonSingular = "vedi", ThirdPersonSingular = "vede", FirstPersonPlural = "vediamo", SecondPersonPlural = "vedete", ThirdPersonPlural = "vedono"},
                    new PresentIndicative { Id = 3, Infinitive = "parlare", FirstPersonSingular = "parlo", SecondPersonSingular = "parli", ThirdPersonSingular = "parla", FirstPersonPlural = "parliamo", SecondPersonPlural = "parlate", ThirdPersonPlural = "parlano"}
                );

            modelBuilder.Entity<PresentPerfect>().HasData(
                    new PresentPerfect { Id = 1, Infinitive = "preparare", FirstPersonSingular = "ho preparato", SecondPersonSingular = "hai preparato", ThirdPersonSingular = "ha preparato", FirstPersonPlural = "abbiamo preparato", SecondPersonPlural = "avete preparato", ThirdPersonPlural = "hanno preparato", UsesEssere = false },
                    new PresentPerfect { Id = 2, Infinitive = "vendere", FirstPersonSingular = "ho venduto", SecondPersonSingular = "hai venduto", ThirdPersonSingular = "ha venduto", FirstPersonPlural = "abbiamo venduto", SecondPersonPlural = "avete venduto", ThirdPersonPlural = "hanno venduto", UsesEssere = false},
                    new PresentPerfect { Id = 3, Infinitive = "andare", FirstPersonSingular = "sono andato", SecondPersonSingular = "sei andato", ThirdPersonSingular = "è andato", FirstPersonPlural = "siamo andati", SecondPersonPlural = "siete andati", ThirdPersonPlural = "sono andati", UsesEssere = true}
                );

            modelBuilder.Entity<Imperfect>().HasData(
                    new Imperfect { Id = 1, Infinitive = "vedere", FirstPersonSingular = "vedevo", SecondPersonSingular = "vedevi", ThirdPersonSingular = "vedeva", FirstPersonPlural = "vedevamo", SecondPersonPlural = "vedevate", ThirdPersonPlural = "vedevano"},
                    new Imperfect { Id = 2, Infinitive = "parlare", FirstPersonSingular = "parlavo", SecondPersonSingular = "parlavi", ThirdPersonSingular = "parlava", FirstPersonPlural = "parlavamo", SecondPersonPlural = "parlavate", ThirdPersonPlural = "parlavano" },
                    new Imperfect { Id = 3, Infinitive = "venire", FirstPersonSingular = "venivo", SecondPersonSingular = "venivi", ThirdPersonSingular = "veniva", FirstPersonPlural = "venivamo", SecondPersonPlural = "venivate", ThirdPersonPlural = "venivano" }
                );
        }
    }
}