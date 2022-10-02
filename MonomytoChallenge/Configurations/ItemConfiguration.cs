﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonomytoChallenge.Models;


namespace MonomytoChallenge.Configurations
{
    //  Realiza a configuração dos campos da entidade Item
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(i => i.PrecoUnitario)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.Property(i => i.Quantidade)
                .IsRequired();

            builder.HasOne(i => i.Produto)
                .WithMany(p => p.Vendas)
                .HasForeignKey(i => i.IdProduto);

            builder.HasOne(i => i.Venda)
                .WithMany(v => v.Itens)
                .HasForeignKey(i => i.IdVenda);
        }
    }
}