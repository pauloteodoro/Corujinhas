using System;
using System.Collections.Generic;
using AppDomain;
using AppDomain.Entities;
using AppDomain.Validators;
using Repositorio;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            EmailSend email = new EmailSend();

            UsuarioRepository ListaUsuarios = new UsuarioRepository();
            Usuario funcionario1 = new Usuario("Paulo Emannuel Nunes Teodoro", "589.303.123-06");
            Usuario funcionario2 = new Usuario("Pedro", "581.303.123-05");
            ListaUsuarios.AdicionarUsuario(funcionario1);
            ListaUsuarios.AdicionarUsuario(funcionario2);

            var validator = new UsuarioValidator();
            var result = validator.Validate(funcionario1);

            //email.EnviarEmail("paulo.teodoro.dev@gmail.com", "teste");
            email.EnviarEmail("devbrofficial@gmail.com", "teste");
            ListaUsuarios.ExibirUsuarios();
            ListaUsuarios.BuscarUsuario("581.303.123-05");

        }
    }
}
