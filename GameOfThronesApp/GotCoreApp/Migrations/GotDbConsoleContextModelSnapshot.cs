﻿// <auto-generated />
using System;
using GotCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GotCoreApp.Migrations
{
    [DbContext(typeof(GotDbConsoleContext))]
    partial class GotDbConsoleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GotCoreApp.Models.Bolumlers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actors");

                    b.Property<string>("Awards");

                    b.Property<string>("Country");

                    b.Property<string>("Director");

                    b.Property<string>("Episode");

                    b.Property<string>("Genre");

                    b.Property<string>("ImdbId")
                        .HasColumnName("imdbID");

                    b.Property<string>("ImdbRating")
                        .HasColumnName("imdbRating");

                    b.Property<string>("ImdbVotes")
                        .HasColumnName("imdbVotes");

                    b.Property<string>("Language");

                    b.Property<string>("Metascore");

                    b.Property<string>("Plot");

                    b.Property<string>("Poster");

                    b.Property<string>("Rated");

                    b.Property<string>("Released");

                    b.Property<string>("Response");

                    b.Property<string>("Runtime");

                    b.Property<string>("Season");

                    b.Property<int>("SeasonId");

                    b.Property<string>("SeriesId")
                        .HasColumnName("seriesID");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.Property<string>("Writer");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.ToTable("Bolumlers");
                });

            modelBuilder.Entity("GotCoreApp.Models.MigrationHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150);

                    b.Property<string>("ContextKey")
                        .HasMaxLength(300);

                    b.Property<byte[]>("Model")
                        .IsRequired();

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("MigrationId", "ContextKey");

                    b.ToTable("__MigrationHistory");
                });

            modelBuilder.Entity("GotCoreApp.Models.Ratings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BolumlerId")
                        .HasColumnName("Bolumler_Id");

                    b.Property<string>("Source");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("BolumlerId")
                        .HasName("IX_Bolumler_Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("GotCoreApp.Models.Seasons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BolumlerId");

                    b.Property<string>("Season");

                    b.HasKey("Id");

                    b.HasIndex("BolumlerId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("GotCoreApp.Models.Ratings", b =>
                {
                    b.HasOne("GotCoreApp.Models.Bolumlers", "Bolumler")
                        .WithMany("Ratings")
                        .HasForeignKey("BolumlerId")
                        .HasConstraintName("FK_dbo.Ratings_dbo.Bolumlers_Bolumler_Id");
                });

            modelBuilder.Entity("GotCoreApp.Models.Seasons", b =>
                {
                    b.HasOne("GotCoreApp.Models.Bolumlers", "Bolumler")
                        .WithMany("Seasons")
                        .HasForeignKey("BolumlerId");
                });
#pragma warning restore 612, 618
        }
    }
}
