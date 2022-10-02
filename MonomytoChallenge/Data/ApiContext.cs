﻿// <auto-generated />
#nullable enable
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MonomytoChallenge.Models;


namespace MonomytoChallenge.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
            this.Clientes = this.Set<Cliente>();
            this.Produtos = this.Set<Produto>();
            this.Vendas = this.Set<Venda>();
            this.Itens = this.Set<Item>();

            this.Database.EnsureCreated();
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Venda> Vendas { get; set; }

        public DbSet<Item> Itens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                    .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                    .EnableSensitiveDataLogging();
    }
}
