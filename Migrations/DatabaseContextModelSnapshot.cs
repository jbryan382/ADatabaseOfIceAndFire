﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using adatabaseoficeandfire;

namespace adatabaseoficeandfire.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ADatabaseOfIceAndFire.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<int>("HouseId");

                    b.Property<bool>("Living");

                    b.Property<string>("Name");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("ADatabaseOfIceAndFire.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoatOfArms");

                    b.Property<bool>("Extinct");

                    b.Property<string>("HouseName");

                    b.Property<string>("HouseWords");

                    b.Property<int>("MyProperty");

                    b.HasKey("Id");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("ADatabaseOfIceAndFire.Models.Character", b =>
                {
                    b.HasOne("ADatabaseOfIceAndFire.Models.House", "Houses")
                        .WithMany("Characters")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
