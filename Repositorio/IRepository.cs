namespace Repositorio
{
    public interface IRepository<T>
    {
         void Adicionar(T entity);
         void Excluir(T entity);
    }
}