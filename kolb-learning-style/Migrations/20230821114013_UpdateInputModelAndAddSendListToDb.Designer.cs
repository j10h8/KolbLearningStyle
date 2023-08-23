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
    [Migration("20230821114013_UpdateInputModelAndAddSendListToDb")]
    partial class UpdateInputModelAndAddSendListToDb
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
                });
#pragma warning restore 612, 618
        }
    }
}