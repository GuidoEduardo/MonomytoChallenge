﻿// <auto-generated />
#nullable enable
using FluentValidation;
using MonomytoChallenge.Data;
using MonomytoChallenge.Models;


namespace MonomytoChallenge.Validators
{
    public class VendaValidator : AbstractValidator<Venda>
    {
        private readonly ApiContext context;

        public VendaValidator(ApiContext context)
        {
            this.context = context;

            this.RuleFor(v => v.IdCliente)
                .NotEmpty()
                .Must(this.ClientExist).WithMessage("O Cliente inserido não existe.");

            this.RuleFor(v => v.Data)
                .NotEmpty().WithMessage("Requer inserção da Data.");
        }

        private bool ClientExist(Guid id)
        {
            return this.context.Clientes.Any(c => c.Id == id);
        }
    }
}