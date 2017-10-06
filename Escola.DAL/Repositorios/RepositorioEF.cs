using Escola.DAL.Contexto;
using System;
using System.Linq;
using Escola.Entidades;

namespace Escola.DAL.Repositorios
{
    public class Repositorio<TEntity> : IRepositorio<TEntity>
        where TEntity : class
    {
        private EscolaContext _ctx = new EscolaContext();
        public void Adicionar(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            _ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(x => _ctx.Set<TEntity>().Remove(x));
        }

        public IQueryable<TEntity> Obter(Func<TEntity, bool> predicate)
        {
            return ObterTodos().Where(predicate).AsQueryable();
        }

        public IQueryable<TEntity> ObterTodos()
        {
            return _ctx.Set<TEntity>().AsQueryable();
        }

        public TEntity Pesquisar(params object[] key)
        {
            return _ctx.Set<TEntity>().Find(key);
        }

        public void SalvarModificacoes()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
