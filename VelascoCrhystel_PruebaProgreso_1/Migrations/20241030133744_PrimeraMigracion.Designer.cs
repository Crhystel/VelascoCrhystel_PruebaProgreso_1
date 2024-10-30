﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VelascoCrhystel_PruebaProgreso_1.Data;

#nullable disable

namespace VelascoCrhystel_PruebaProgreso_1.Migrations
{
    [DbContext(typeof(VelascoCrhystel_PruebaProgreso_1Context))]
    [Migration("20241030133744_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VelascoCrhystel_PruebaProgreso_1.Models.Celular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("VelascoCrhystel_PruebaProgreso_1.Models.Velasco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Dia")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCelular")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Promedio")
                        .HasColumnType("float");

                    b.Property<bool>("TieneGanasEstudiar")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdCelular");

                    b.ToTable("Velasco");
                });

            modelBuilder.Entity("VelascoCrhystel_PruebaProgreso_1.Models.Velasco", b =>
                {
                    b.HasOne("VelascoCrhystel_PruebaProgreso_1.Models.Celular", "Celular")
                        .WithMany()
                        .HasForeignKey("IdCelular")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Celular");
                });
#pragma warning restore 612, 618
        }
    }
}
