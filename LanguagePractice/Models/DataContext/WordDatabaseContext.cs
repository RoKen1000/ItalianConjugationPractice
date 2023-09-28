using LanguagePractice.Models;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PresentIndicative>().HasData(
                    new PresentIndicative { Id = 1, Infinitive = "fàre", FirstPersonSingular = "fàccio", SecondPersonSingular = "fài", ThirdPersonSingular = "fà", FirstPersonPlural = "facciàmo", SecondPersonPlural = "fàte", ThirdPersonPlural = "fànno"},
                    new PresentIndicative { Id = 2, Infinitive = "vedére", FirstPersonSingular = "védo", SecondPersonSingular = "védi", ThirdPersonSingular = "véde", FirstPersonPlural = "vediàmo", SecondPersonPlural = "vedéte", ThirdPersonPlural = "védono"},
                    new PresentIndicative { Id = 3, Infinitive = "parlàre", FirstPersonSingular = "pàrlo", SecondPersonSingular = "pàrli", ThirdPersonSingular = "pàrla", FirstPersonPlural = "parliàmo", SecondPersonPlural = "parlàte", ThirdPersonPlural = "pàrlano"}
                );

            modelBuilder.Entity<PresentPerfect>().HasData(
                    new PresentPerfect { Id = 1, Infinitive = "preparàre", FirstPersonSingular = "ho preparato", SecondPersonSingular = "hai preparato", ThirdPersonSingular = "ha preparato", FirstPersonPlural = "abbiamo preparato", SecondPersonPlural = "avete preparato", ThirdPersonPlural = "hanno preparato", UsesEssere = false },
                    new PresentPerfect { Id = 2, Infinitive = "véndere", FirstPersonSingular = "ho venduto", SecondPersonSingular = "hai venduto", ThirdPersonSingular = "ha venduto", FirstPersonPlural = "abbiamo venduto", SecondPersonPlural = "avete venduto", ThirdPersonPlural = "hanno venduto", UsesEssere = false},
                    new PresentPerfect { Id = 3, Infinitive = "andare", FirstPersonSingular = "sono andato", SecondPersonSingular = "sei andato", ThirdPersonSingular = "è andato", FirstPersonPlural = "siamo andati", SecondPersonPlural = "siete andati", ThirdPersonPlural = "sono andati", UsesEssere = true}
                );
        }
    }
}