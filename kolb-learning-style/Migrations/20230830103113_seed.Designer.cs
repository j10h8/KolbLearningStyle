﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kolb_learning_style.Data;

#nullable disable

namespace kolb_learning_style.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230830103113_seed")]
    partial class seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kolb_learning_style.Models.EmailAddressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SendList");
                });

            modelBuilder.Entity("kolb_learning_style.Models.ResultModel", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultId"));

                    b.Property<int>("Explainer")
                        .HasColumnType("int");

                    b.Property<int>("Gatherer")
                        .HasColumnType("int");

                    b.Property<int>("IdeaGiver")
                        .HasColumnType("int");

                    b.Property<int>("Tester")
                        .HasColumnType("int");

                    b.HasKey("ResultId");

                    b.ToTable("Results");

                    b.HasData(
                        new
                        {
                            ResultId = 1,
                            Explainer = 20,
                            Gatherer = 8,
                            IdeaGiver = 5,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 2,
                            Explainer = 9,
                            Gatherer = 15,
                            IdeaGiver = 12,
                            Tester = 17
                        },
                        new
                        {
                            ResultId = 3,
                            Explainer = 8,
                            Gatherer = 14,
                            IdeaGiver = 17,
                            Tester = 12
                        },
                        new
                        {
                            ResultId = 4,
                            Explainer = 12,
                            Gatherer = 19,
                            IdeaGiver = 6,
                            Tester = 11
                        },
                        new
                        {
                            ResultId = 5,
                            Explainer = 10,
                            Gatherer = 17,
                            IdeaGiver = 9,
                            Tester = 16
                        },
                        new
                        {
                            ResultId = 6,
                            Explainer = 5,
                            Gatherer = 10,
                            IdeaGiver = 6,
                            Tester = 6
                        },
                        new
                        {
                            ResultId = 7,
                            Explainer = 13,
                            Gatherer = 5,
                            IdeaGiver = 16,
                            Tester = 19
                        },
                        new
                        {
                            ResultId = 8,
                            Explainer = 14,
                            Gatherer = 5,
                            IdeaGiver = 17,
                            Tester = 14
                        },
                        new
                        {
                            ResultId = 9,
                            Explainer = 9,
                            Gatherer = 11,
                            IdeaGiver = 18,
                            Tester = 6
                        },
                        new
                        {
                            ResultId = 10,
                            Explainer = 13,
                            Gatherer = 11,
                            IdeaGiver = 15,
                            Tester = 18
                        },
                        new
                        {
                            ResultId = 11,
                            Explainer = 20,
                            Gatherer = 13,
                            IdeaGiver = 9,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 12,
                            Explainer = 17,
                            Gatherer = 20,
                            IdeaGiver = 20,
                            Tester = 5
                        },
                        new
                        {
                            ResultId = 13,
                            Explainer = 16,
                            Gatherer = 17,
                            IdeaGiver = 19,
                            Tester = 14
                        },
                        new
                        {
                            ResultId = 14,
                            Explainer = 19,
                            Gatherer = 8,
                            IdeaGiver = 17,
                            Tester = 18
                        },
                        new
                        {
                            ResultId = 15,
                            Explainer = 14,
                            Gatherer = 17,
                            IdeaGiver = 18,
                            Tester = 19
                        },
                        new
                        {
                            ResultId = 16,
                            Explainer = 20,
                            Gatherer = 15,
                            IdeaGiver = 14,
                            Tester = 7
                        },
                        new
                        {
                            ResultId = 17,
                            Explainer = 5,
                            Gatherer = 19,
                            IdeaGiver = 10,
                            Tester = 19
                        },
                        new
                        {
                            ResultId = 18,
                            Explainer = 18,
                            Gatherer = 20,
                            IdeaGiver = 8,
                            Tester = 17
                        },
                        new
                        {
                            ResultId = 19,
                            Explainer = 11,
                            Gatherer = 14,
                            IdeaGiver = 14,
                            Tester = 15
                        },
                        new
                        {
                            ResultId = 20,
                            Explainer = 18,
                            Gatherer = 19,
                            IdeaGiver = 7,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 21,
                            Explainer = 11,
                            Gatherer = 14,
                            IdeaGiver = 14,
                            Tester = 7
                        },
                        new
                        {
                            ResultId = 22,
                            Explainer = 19,
                            Gatherer = 19,
                            IdeaGiver = 7,
                            Tester = 8
                        },
                        new
                        {
                            ResultId = 23,
                            Explainer = 15,
                            Gatherer = 14,
                            IdeaGiver = 16,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 24,
                            Explainer = 7,
                            Gatherer = 11,
                            IdeaGiver = 9,
                            Tester = 12
                        },
                        new
                        {
                            ResultId = 25,
                            Explainer = 13,
                            Gatherer = 10,
                            IdeaGiver = 8,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 26,
                            Explainer = 13,
                            Gatherer = 11,
                            IdeaGiver = 10,
                            Tester = 11
                        },
                        new
                        {
                            ResultId = 27,
                            Explainer = 6,
                            Gatherer = 9,
                            IdeaGiver = 20,
                            Tester = 10
                        },
                        new
                        {
                            ResultId = 28,
                            Explainer = 15,
                            Gatherer = 19,
                            IdeaGiver = 9,
                            Tester = 7
                        },
                        new
                        {
                            ResultId = 29,
                            Explainer = 6,
                            Gatherer = 15,
                            IdeaGiver = 9,
                            Tester = 16
                        },
                        new
                        {
                            ResultId = 30,
                            Explainer = 19,
                            Gatherer = 12,
                            IdeaGiver = 18,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 31,
                            Explainer = 8,
                            Gatherer = 12,
                            IdeaGiver = 17,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 32,
                            Explainer = 8,
                            Gatherer = 8,
                            IdeaGiver = 18,
                            Tester = 7
                        },
                        new
                        {
                            ResultId = 33,
                            Explainer = 8,
                            Gatherer = 20,
                            IdeaGiver = 12,
                            Tester = 14
                        },
                        new
                        {
                            ResultId = 34,
                            Explainer = 6,
                            Gatherer = 7,
                            IdeaGiver = 18,
                            Tester = 17
                        },
                        new
                        {
                            ResultId = 35,
                            Explainer = 20,
                            Gatherer = 7,
                            IdeaGiver = 12,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 36,
                            Explainer = 16,
                            Gatherer = 18,
                            IdeaGiver = 10,
                            Tester = 16
                        },
                        new
                        {
                            ResultId = 37,
                            Explainer = 12,
                            Gatherer = 9,
                            IdeaGiver = 14,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 38,
                            Explainer = 14,
                            Gatherer = 6,
                            IdeaGiver = 19,
                            Tester = 11
                        },
                        new
                        {
                            ResultId = 39,
                            Explainer = 20,
                            Gatherer = 14,
                            IdeaGiver = 16,
                            Tester = 6
                        },
                        new
                        {
                            ResultId = 40,
                            Explainer = 12,
                            Gatherer = 7,
                            IdeaGiver = 5,
                            Tester = 11
                        },
                        new
                        {
                            ResultId = 41,
                            Explainer = 6,
                            Gatherer = 18,
                            IdeaGiver = 13,
                            Tester = 19
                        },
                        new
                        {
                            ResultId = 42,
                            Explainer = 19,
                            Gatherer = 16,
                            IdeaGiver = 9,
                            Tester = 18
                        },
                        new
                        {
                            ResultId = 43,
                            Explainer = 18,
                            Gatherer = 9,
                            IdeaGiver = 8,
                            Tester = 17
                        },
                        new
                        {
                            ResultId = 44,
                            Explainer = 18,
                            Gatherer = 6,
                            IdeaGiver = 18,
                            Tester = 10
                        },
                        new
                        {
                            ResultId = 45,
                            Explainer = 5,
                            Gatherer = 19,
                            IdeaGiver = 16,
                            Tester = 7
                        },
                        new
                        {
                            ResultId = 46,
                            Explainer = 20,
                            Gatherer = 18,
                            IdeaGiver = 6,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 47,
                            Explainer = 11,
                            Gatherer = 8,
                            IdeaGiver = 11,
                            Tester = 14
                        },
                        new
                        {
                            ResultId = 48,
                            Explainer = 12,
                            Gatherer = 9,
                            IdeaGiver = 16,
                            Tester = 11
                        },
                        new
                        {
                            ResultId = 49,
                            Explainer = 19,
                            Gatherer = 14,
                            IdeaGiver = 14,
                            Tester = 20
                        },
                        new
                        {
                            ResultId = 50,
                            Explainer = 8,
                            Gatherer = 6,
                            IdeaGiver = 18,
                            Tester = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
