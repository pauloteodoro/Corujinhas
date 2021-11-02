using System.Text.RegularExpressions;
using AppDomain.Entities;
using FluentValidation;

namespace AppDomain.Validators
{
    public class ReceitaValidator : AbstractValidator<Receita>
    {
        public ReceitaValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe o assunto email.")
                .Length(1, 130).WithMessage("Assunto deve ter no mínimo 1 caracter e no máximo 130 caracteres");

            RuleFor(x => x.ModoPreparo)
                .NotEmpty().WithMessage("Informe o modo de preparo")
                .Length(1, 999).WithMessage("Assunto deve ter no mínimo 1 caracter e no máximo 999 caracteres");

            RuleFor(x => x.TempoPreparo)
                .NotEmpty().WithMessage("Informe o tempo de preparo");

        }
    }
}