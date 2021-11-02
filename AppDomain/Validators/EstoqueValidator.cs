using System.Text.RegularExpressions;
using AppDomain.Entities;
using FluentValidation;

namespace AppDomain.Validators
{
    public class EstoqueValidator : AbstractValidator<Estoque>
    {
        public EstoqueValidator()
        {
            RuleFor(x => x.QuantidadeAtual)
                .NotEmpty().WithMessage("Informe quantidade Atual");

            RuleFor(x => x.QuantidadeMaxima)
                .NotEmpty().WithMessage("Informe quantidade maxima do produto");

            RuleFor(x => x.QuantidadeMinima)
                .NotEmpty().WithMessage("Informe quantidade miníma do produto");

            RuleFor(x => x.UnidadeMedidaID)
                .NotEmpty().WithMessage("Unidade de medida obrigatória");

            RuleFor(x => x.IngredienteID)
                .NotEmpty().WithMessage("Ingrediente obrigatório");

        }
    }
}