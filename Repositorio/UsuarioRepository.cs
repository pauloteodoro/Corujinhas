using System;
using System.Collections.Generic;
using System.Linq;
using AppDomain.Entities;

namespace Repositorio
{
    public class UsuarioRepository
    {
        private List<Usuario> _usuarios;

        public UsuarioRepository()
        {
            _usuarios = new List<Usuario>();
        }

        public void ExibirUsuario()
        {
            foreach(Usuario usuario in _usuarios)
            {
                Console.WriteLine(usuario.Nome + " " + usuario.Cpf +" " + usuario.Status);
            }
        }

        public List<Usuario> ListarUsuario()
        {
            return _usuarios.OrderBy( u => u.Cpf).ToList();
        }

        public void BuscarUsuario(string cpf)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Cpf == cpf);
            
            Console.WriteLine(usuario.Nome + " " + usuario.Cpf + " " + usuario.Status);
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }
    }
}
