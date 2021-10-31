using System.Text.RegularExpressions;
using AppDomain.Entities;
using FluentValidation;

namespace AppDomain.Validators
{
    public class IngredienteValidator : AbstractValidator<Ingrediente>
    {
        public IngredienteValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe nome do ingrediente.")
                .Length(3, 100).WithMessage("O  mínimo 3 caracteres e no máximo 100 caracteres");

        }
    }
}