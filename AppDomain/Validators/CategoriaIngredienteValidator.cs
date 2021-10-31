using System.Text.RegularExpressions;
using AppDomain.Entities;
using FluentValidation;

namespace AppDomain.Validators
{
    public class CategoriaIngredienteValidator : AbstractValidator<CategoriaIngrediente>
    {
        public CategoriaIngredienteValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe nome do ingrediente.")
                .Length(3, 100).WithMessage("O  mínimo 3 caracteres e no máximo 100 caracteres");


            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("Informe nome do ingrediente.");

        }
    }
}