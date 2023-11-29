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
                    new PresentIndicative { Id = 3, Infinitive = "parlare", FirstPersonSingular = "parlo", SecondPersonSingular = "parli", ThirdPersonSingular = "parla", FirstPersonPlural = "parliamo", SecondPersonPlural = "parlate", ThirdPersonPlural = "parlano"},
                     new PresentIndicative { Id = 4, Infinitive = "venire", FirstPersonSingular = "vengo", SecondPersonSingular = "vieni", ThirdPersonSingular = "viene", FirstPersonPlural = "veniamo", SecondPersonPlural = "venite", ThirdPersonPlural = "vengono" },
                     new PresentIndicative { Id = 5, Infinitive = "andare", FirstPersonSingular = "vado", SecondPersonSingular = "vai", ThirdPersonSingular = "va", FirstPersonPlural = "andiamo", SecondPersonPlural = "andate", ThirdPersonPlural = "vanno" },
                     new PresentIndicative { Id = 6, Infinitive = "vìvere", FirstPersonSingular = "vivo", SecondPersonSingular = "vivi", ThirdPersonSingular = "vive", FirstPersonPlural = "viviamo", SecondPersonPlural = "vivete", ThirdPersonPlural = "vivono" },
                     new PresentIndicative { Id = 7, Infinitive = "dormire", FirstPersonSingular = "dormo", SecondPersonSingular = "dormi", ThirdPersonSingular = "dorme", FirstPersonPlural = "dormiamo", SecondPersonPlural = "dormite", ThirdPersonPlural = "dormono" },
                     new PresentIndicative { Id = 8, Infinitive = "chiedere", FirstPersonSingular = "chiedo", SecondPersonSingular = "chiedi", ThirdPersonSingular = "chiede", FirstPersonPlural = "chiediamo", SecondPersonPlural = "chiedete", ThirdPersonPlural = "chiedono" },
                     new PresentIndicative { Id = 9, Infinitive = "mettere", FirstPersonSingular = "metto", SecondPersonSingular = "metti", ThirdPersonSingular = "mette", FirstPersonPlural = "mettiamo", SecondPersonPlural = "mettete", ThirdPersonPlural = "mettono" },
                     new PresentIndicative { Id = 10, Infinitive = "vestire", FirstPersonSingular = "vesto", SecondPersonSingular = "vesti", ThirdPersonSingular = "veste", FirstPersonPlural = "vestiamo", SecondPersonPlural = "vestite", ThirdPersonPlural = "vestono" }
                );

            modelBuilder.Entity<PresentPerfect>().HasData(
                    new PresentPerfect { Id = 1, Infinitive = "preparare", FirstPersonSingular = "ho preparato", SecondPersonSingular = "hai preparato", ThirdPersonSingular = "ha preparato", FirstPersonPlural = "abbiamo preparato", SecondPersonPlural = "avete preparato", ThirdPersonPlural = "hanno preparato", UsesEssere = false },
                    new PresentPerfect { Id = 2, Infinitive = "vendere", FirstPersonSingular = "ho venduto", SecondPersonSingular = "hai venduto", ThirdPersonSingular = "ha venduto", FirstPersonPlural = "abbiamo venduto", SecondPersonPlural = "avete venduto", ThirdPersonPlural = "hanno venduto", UsesEssere = false},
                    new PresentPerfect { Id = 3, Infinitive = "andare", FirstPersonSingular = "sono andato", SecondPersonSingular = "sei andato", ThirdPersonSingular = "è andato", FirstPersonPlural = "siamo andati", SecondPersonPlural = "siete andati", ThirdPersonPlural = "sono andati", UsesEssere = true},
                    new PresentPerfect { Id = 4, Infinitive = "venire", FirstPersonSingular = "sono venuto", SecondPersonSingular = "sei venuto", ThirdPersonSingular = "è venuto", FirstPersonPlural = "siamo venuto", SecondPersonPlural = "siete venuto", ThirdPersonPlural = "sono venuto", UsesEssere = true },
                     new PresentPerfect { Id = 5, Infinitive = "fare", FirstPersonSingular = "ho fatto", SecondPersonSingular = "hai fatto", ThirdPersonSingular = "ha fatto", FirstPersonPlural = "abbiamo fatto", SecondPersonPlural = "avete fatto", ThirdPersonPlural = "hanno fatto", UsesEssere = false },
                     new PresentPerfect { Id = 6, Infinitive = "vìvere", FirstPersonSingular = "ho vissuto", SecondPersonSingular = "hai vissuto", ThirdPersonSingular = "ha vissuto", FirstPersonPlural = "abbiamo vissuto", SecondPersonPlural = "avete vissuto", ThirdPersonPlural = "hanno vissuto", UsesEssere = false },
                     new PresentPerfect { Id = 7, Infinitive = "dormire", FirstPersonSingular = "ho dormito", SecondPersonSingular = "hai dormito", ThirdPersonSingular = "ha dormito", FirstPersonPlural = "abbiamo dormito", SecondPersonPlural = "avete dormito", ThirdPersonPlural = "hanno dormito", UsesEssere = false },
                     new PresentPerfect { Id = 8, Infinitive = "chiedere", FirstPersonSingular = "ho chiesto", SecondPersonSingular = "hai chiesto", ThirdPersonSingular = "ha chiesto", FirstPersonPlural = "abbiamo chiesto", SecondPersonPlural = "avete chiesto", ThirdPersonPlural = "hanno chiesto", UsesEssere = false },
                     new PresentPerfect { Id = 9, Infinitive = "mettere", FirstPersonSingular = "ho messo", SecondPersonSingular = "hai messo", ThirdPersonSingular = "ha messo", FirstPersonPlural = "abbiamo messo", SecondPersonPlural = "avete messo", ThirdPersonPlural = "hanno messo", UsesEssere = false },
                     new PresentPerfect { Id = 10, Infinitive = "vestire", FirstPersonSingular = "ho vestito", SecondPersonSingular = "hai vestito", ThirdPersonSingular = "ha vestito", FirstPersonPlural = "abbiamo vestito", SecondPersonPlural = "avete vestito", ThirdPersonPlural = "hanno vestito", UsesEssere = false }
                );

            modelBuilder.Entity<Imperfect>().HasData(
                    new Imperfect { Id = 1, Infinitive = "vedere", FirstPersonSingular = "vedevo", SecondPersonSingular = "vedevi", ThirdPersonSingular = "vedeva", FirstPersonPlural = "vedevamo", SecondPersonPlural = "vedevate", ThirdPersonPlural = "vedevano"},
                    new Imperfect { Id = 2, Infinitive = "parlare", FirstPersonSingular = "parlavo", SecondPersonSingular = "parlavi", ThirdPersonSingular = "parlava", FirstPersonPlural = "parlavamo", SecondPersonPlural = "parlavate", ThirdPersonPlural = "parlavano" },
                    new Imperfect { Id = 3, Infinitive = "venire", FirstPersonSingular = "venivo", SecondPersonSingular = "venivi", ThirdPersonSingular = "veniva", FirstPersonPlural = "venivamo", SecondPersonPlural = "venivate", ThirdPersonPlural = "venivano" },
                    new Imperfect { Id = 4, Infinitive = "fare", FirstPersonSingular = "facevo", SecondPersonSingular = "facevi", ThirdPersonSingular = "facevama", FirstPersonPlural = "facevamo", SecondPersonPlural = "facevate", ThirdPersonPlural = "facevano" },
                    new Imperfect { Id = 5, Infinitive = "andare", FirstPersonSingular = "andavo", SecondPersonSingular = "andavi", ThirdPersonSingular = "andava", FirstPersonPlural = "andavamo", SecondPersonPlural = "andavate", ThirdPersonPlural = "andavano" },
                    new Imperfect { Id = 6, Infinitive = "vìvere", FirstPersonSingular = "vivevo", SecondPersonSingular = "vivevi", ThirdPersonSingular = "viveva", FirstPersonPlural = "vivevamo", SecondPersonPlural = "vivevate", ThirdPersonPlural = "vivevano" },
                    new Imperfect { Id = 7, Infinitive = "dormire", FirstPersonSingular = "dormivo", SecondPersonSingular = "dormivi", ThirdPersonSingular = "dormiva", FirstPersonPlural = "dormivamo", SecondPersonPlural = "dormivate", ThirdPersonPlural = "dormivano" },
                    new Imperfect { Id = 8, Infinitive = "chiedere", FirstPersonSingular = "chiedevo", SecondPersonSingular = "chiedevi", ThirdPersonSingular = "chiedeva", FirstPersonPlural = "chiedevamo", SecondPersonPlural = "chiedevate", ThirdPersonPlural = "chiedevano" },
                    new Imperfect { Id = 9, Infinitive = "mettere", FirstPersonSingular = "mettevo", SecondPersonSingular = "mettevi", ThirdPersonSingular = "metteva", FirstPersonPlural = "mettevamo", SecondPersonPlural = "mettevate", ThirdPersonPlural = "mettevano" },
                    new Imperfect { Id = 10, Infinitive = "vestire", FirstPersonSingular = "vestivo", SecondPersonSingular = "vestivi", ThirdPersonSingular = "vestiva", FirstPersonPlural = "vestivamo", SecondPersonPlural = "vestivate", ThirdPersonPlural = "vestivano" }
                );
        }
    }
}