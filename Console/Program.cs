using System;
using System.Collections.Generic;
using AppDomain;
using AppDomain.Entities;
using AppDomain.Validators;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            EmailSend email = new EmailSend();

            List<Usuario> ListaUsuarios = new List<Usuario>();
            Usuario funcionario1 = new Usuario("Paulo Emannuel Nunes Teodoro", "000.000.000-00");
            ListaUsuarios.Add(funcionario1);

            var validator = new UsuarioValidator();
            var result = validator.Validate(funcionario1);



            email.EnviarEmail("paulo.teodoro.dev@gmail.com", "teste");

        }
    }
}
