using System.Text.RegularExpressions;
using AppDomain.Entities;
using FluentValidation;

namespace AppDomain.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe nome do usuário.")
                .Length(3, 100).WithMessage("O nome do usuário deve ter no mínimo 3 caracteres e no máximo 100 caracteres");

            RuleFor(x => x.Cpf)
                .NotEmpty().WithMessage("Informe o CPF")
                .Must(x => CPFIsValid(x)).WithMessage("CPF inválido");

        }

        private bool CPFIsValid(string postalCode)
        {
            Regex Rgx = new Regex(@"/(\d{3})(\d{3})(\d{3})(\d{2})/");
            if (string.IsNullOrEmpty(postalCode) || !Rgx.IsMatch(postalCode)) return false;

            return true;
        }
    }
}