﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORMdoga.Models;

#nullable disable

namespace ORMdoga.Migrations
{
    [DbContext(typeof(ZeneDBContext))]
    partial class ZeneDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ORMdoga.Models.Eloado", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EloadoNemzetiseg")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EloadoNev")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("SzamId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ZeneFajta")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("SzamId");

                    b.ToTable("Eloado");
                });

            modelBuilder.Entity("ORMdoga.Models.Szam", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SzamCim")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SzamMegjelenes")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Szam");
                });

            modelBuilder.Entity("ORMdoga.Models.Eloado", b =>
                {
                    b.HasOne("ORMdoga.Models.Szam", "Szam")
                        .WithMany()
                        .HasForeignKey("SzamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Szam");
                });
#pragma warning restore 612, 618
        }
    }
}
