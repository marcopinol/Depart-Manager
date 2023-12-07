using DepartManagerWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DepartManagerWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        //public DbSet<FuncionarioDepartamento> FuncionarioDepartamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<FuncionarioDepartamento>()
              //  .HasKey(AD => new { AD.FuncionarioId, AD.DepartamentoId });

            builder.Entity<Departamento>()
                .HasData(new List<Departamento>() {
                    new Departamento(1, "Tecnologia", "TI"),
                    new Departamento(2, "Entregas", "ETG"),
                    new Departamento(3,"Finanças", "FNC"),
                });

            builder.Entity<Funcionario>()
                .HasData(new List<Funcionario>() { 
                    new Funcionario (1, "Marco", "15489", 1),
                    new Funcionario (2, "Nicolas", "75964", 2),
                    new Funcionario (3, "Sergio", "78526", 3),
                    new Funcionario (4, "Gustavo", "96325", 3),
                    new Funcionario (5, "Eduardo", "85214", 2),
                    new Funcionario (6, "Nelo", "14785", 1),
                });

            /*builder.Entity<FuncionarioDepartamento>()
                .HasData(new List<FuncionarioDepartamento>() { 
                    new FuncionarioDepartamento() {FuncionarioId = 1, DepartamentoId = 1},
                    new FuncionarioDepartamento() {FuncionarioId = 6, DepartamentoId = 1 },
                    new FuncionarioDepartamento() {FuncionarioId = 3, DepartamentoId = 3},
                    new FuncionarioDepartamento() {FuncionarioId = 4, DepartamentoId = 3},
                    new FuncionarioDepartamento() {FuncionarioId = 2, DepartamentoId = 2 },
                    new FuncionarioDepartamento() {FuncionarioId = 5, DepartamentoId = 2},
                });
            */
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=Empresa;Data Source=DESKTOP-E63D58V");
        }
    }
}
