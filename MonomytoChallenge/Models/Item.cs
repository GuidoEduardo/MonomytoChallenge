﻿// <auto-generated />
#nullable enable
using Newtonsoft.Json;


namespace MonomytoChallenge.Models
{
    public class Item
    {
        [JsonProperty("ItemId")]
        public Guid Id { get; set; }

        public float PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        // Relationship
        [JsonProperty("Id")]
        public Guid IdProduto { get; set; }

        public virtual Produto? Produto { get; set; }

        public Guid IdVenda { get; set; }

        public virtual Venda? Venda { get; set; }
    }

    public class ItemVenda
    {
        public Guid Id { get; set; }

        public virtual Produto? Produto { get; set; }

        public float PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

    }
}