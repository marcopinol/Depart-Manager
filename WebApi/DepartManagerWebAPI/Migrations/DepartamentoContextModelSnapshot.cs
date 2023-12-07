﻿// <auto-generated />
using DepartManagerWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepartManagerWebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DepartamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartManagerWebAPI.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia",
                            Sigla = "TI"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Entregas",
                            Sigla = "ETG"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Finanças",
                            Sigla = "FNC"
                        });
                });

            modelBuilder.Entity("DepartManagerWebAPI.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Funcionarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartamentoId = 1,
                            Nome = "Marco",
                            RG = "15489"
                        },
                        new
                        {
                            Id = 2,
                            DepartamentoId = 2,
                            Nome = "Nicolas",
                            RG = "75964"
                        },
                        new
                        {
                            Id = 3,
                            DepartamentoId = 3,
                            Nome = "Sergio",
                            RG = "78526"
                        },
                        new
                        {
                            Id = 4,
                            DepartamentoId = 3,
                            Nome = "Gustavo",
                            RG = "96325"
                        },
                        new
                        {
                            Id = 5,
                            DepartamentoId = 2,
                            Nome = "Eduardo",
                            RG = "85214"
                        },
                        new
                        {
                            Id = 6,
                            DepartamentoId = 1,
                            Nome = "Nelo",
                            RG = "14785"
                        });
                });

            modelBuilder.Entity("DepartManagerWebAPI.Models.Funcionario", b =>
                {
                    b.HasOne("DepartManagerWebAPI.Models.Departamento", null)
                        .WithMany("Funcionarios")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DepartManagerWebAPI.Models.Departamento", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
