using System.Text.RegularExpressions;
using AppDomain.Entities;
using FluentValidation;

namespace AppDomain.Validators
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(x => x.Assunto)
                .NotEmpty().WithMessage("Informe o assunto email.")
                .Length(1, 130).WithMessage("Assunto deve ter no mínimo 1 caracter e no máximo 130 caracteres");

            RuleFor(x => x.Destinatario)
                .NotEmpty().WithMessage("Informe o email do destinatario")
                .Must(x => ValidadorEmail(x)).WithMessage("Email de destinatario inválido");

        }

        private bool ValidadorEmail(string postalCode)
        {
            Regex regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (string.IsNullOrEmpty(postalCode) || !regex.IsMatch(postalCode)) return false;

            return true;
        }
    }
}