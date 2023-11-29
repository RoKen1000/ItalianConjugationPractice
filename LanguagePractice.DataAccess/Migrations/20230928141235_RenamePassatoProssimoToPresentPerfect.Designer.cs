﻿// <auto-generated />
using LanguagePractice.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LanguagePracticeSite.Migrations
{
    [DbContext(typeof(WordDatabaseContext))]
    [Migration("20230928141235_RenamePassatoProssimoToPresentPerfect")]
    partial class RenamePassatoProssimoToPresentPerfect
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LanguagePractice.Models.PresentIndicative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstPersonSingular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Infinitive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPersonSingular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPersonSingular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PresentIndicativeWords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstPersonPlural = "facciàmo",
                            FirstPersonSingular = "fàccio",
                            Infinitive = "fàre",
                            SecondPersonPlural = "fàte",
                            SecondPersonSingular = "fài",
                            ThirdPersonPlural = "fànno",
                            ThirdPersonSingular = "fà"
                        },
                        new
                        {
                            Id = 2,
                            FirstPersonPlural = "vediàmo",
                            FirstPersonSingular = "védo",
                            Infinitive = "vedére",
                            SecondPersonPlural = "vedéte",
                            SecondPersonSingular = "védi",
                            ThirdPersonPlural = "védono",
                            ThirdPersonSingular = "véde"
                        },
                        new
                        {
                            Id = 3,
                            FirstPersonPlural = "parliàmo",
                            FirstPersonSingular = "pàrlo",
                            Infinitive = "parlàre",
                            SecondPersonPlural = "parlàte",
                            SecondPersonSingular = "pàrli",
                            ThirdPersonPlural = "pàrlano",
                            ThirdPersonSingular = "pàrla"
                        });
                });

            modelBuilder.Entity("LanguagePracticeSite.Models.PresentPerfect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstPersonSingular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Infinitive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPersonSingular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPersonSingular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UsesEssere")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PresentPerfectPhrases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstPersonPlural = "abbiamo preparato",
                            FirstPersonSingular = "ho preparato",
                            Infinitive = "preparàre",
                            SecondPersonPlural = "avete preparato",
                            SecondPersonSingular = "hai preparato",
                            ThirdPersonPlural = "hanno preparato",
                            ThirdPersonSingular = "ha preparato",
                            UsesEssere = false
                        },
                        new
                        {
                            Id = 2,
                            FirstPersonPlural = "abbiamo venduto",
                            FirstPersonSingular = "ho venduto",
                            Infinitive = "véndere",
                            SecondPersonPlural = "avete venduto",
                            SecondPersonSingular = "hai venduto",
                            ThirdPersonPlural = "hanno venduto",
                            ThirdPersonSingular = "ha venduto",
                            UsesEssere = false
                        },
                        new
                        {
                            Id = 3,
                            FirstPersonPlural = "siamo andati",
                            FirstPersonSingular = "sono andato",
                            Infinitive = "andare",
                            SecondPersonPlural = "siete andati",
                            SecondPersonSingular = "sei andato",
                            ThirdPersonPlural = "sono andati",
                            ThirdPersonSingular = "è andato",
                            UsesEssere = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}