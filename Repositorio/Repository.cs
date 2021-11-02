using System;
using System.Collections.Generic;
using AppDomain.Entities;

namespace Repositorio
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private List<T> _entity;

        public void Adicionar(T entity)
        {
            _entity.Add(entity);
        }

        public void Excluir(T entity)
        {
            _entity.Remove(entity);
        }
    }
}
