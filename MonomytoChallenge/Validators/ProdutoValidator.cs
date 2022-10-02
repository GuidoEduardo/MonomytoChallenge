﻿// <auto-generated />
#nullable enable
using FluentValidation;
using MonomytoChallenge.Models;


namespace MonomytoChallenge.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            this.RuleFor(p => p.Id)
                .NotEmpty().WithMessage("Requer a inserção do ID.");

            this.RuleFor(p => p.Marca)
                .NotEmpty().WithMessage("Requer a inserção da Marca.");

            this.RuleFor(p => p.Classificacao)
                .IsInEnum().WithMessage("Requer a inserção da Classificação.");

            this.RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Requer inserção do Nome.");

            this.RuleFor(p => p.TeorAlcoolico)
                .NotEmpty().WithMessage("Requer inserção do Teor Alcoólico.");
        }
    }
}