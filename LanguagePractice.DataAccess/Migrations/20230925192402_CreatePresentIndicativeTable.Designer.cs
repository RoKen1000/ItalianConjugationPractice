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
    [Migration("20230925192402_CreatePresentIndicativeTable")]
    partial class CreatePresentIndicativeTable
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

                    b.ToTable("PresentIndicatives");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstPersonPlural = "facciamo",
                            FirstPersonSingular = "faccio",
                            Infinitive = "fare",
                            SecondPersonPlural = "fate",
                            SecondPersonSingular = "fai",
                            ThirdPersonPlural = "fanno",
                            ThirdPersonSingular = "fa"
                        },
                        new
                        {
                            Id = 2,
                            FirstPersonPlural = "vediamo",
                            FirstPersonSingular = "vedo",
                            Infinitive = "vedere",
                            SecondPersonPlural = "vedete",
                            SecondPersonSingular = "vedi",
                            ThirdPersonPlural = "vedono",
                            ThirdPersonSingular = "vede"
                        },
                        new
                        {
                            Id = 3,
                            FirstPersonPlural = "parliamo",
                            FirstPersonSingular = "parlo",
                            Infinitive = "parlare",
                            SecondPersonPlural = "parlate",
                            SecondPersonSingular = "parla",
                            ThirdPersonPlural = "parlano",
                            ThirdPersonSingular = "parla"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
