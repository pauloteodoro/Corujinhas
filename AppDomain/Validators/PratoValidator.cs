using System.Text.RegularExpressions;
using AppDomain.Entities;
using FluentValidation;

namespace AppDomain.Validators
{
    public class PratoValidator : AbstractValidator<Prato>
    {
        public PratoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe nome do prato.")
                .Length(3, 100).WithMessage("O  mínimo 3 caracteres e no máximo 100 caracteres");

            RuleFor(x => x.Preco)
                .NotEmpty().WithMessage("Informe valor do prato.");


        }
    }
}