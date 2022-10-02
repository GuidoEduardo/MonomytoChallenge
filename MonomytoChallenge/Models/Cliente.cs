﻿// <auto-generated />
#nullable enable

namespace MonomytoChallenge.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public string? Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        // Relationship
        public virtual ICollection<Venda>? Compras { get; set; }
    }

    public class ClienteReport
    {
        public Guid Id { get; set; }

        public string? Nome { get; set; }

        public IEnumerable<ProdutoReport>? Produtos { get; set; }

        public float TotalValor { get; set; }

        public int TotalVendas { get; set; }
    }
}
