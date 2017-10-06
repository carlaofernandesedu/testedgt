using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entidades
{
    public interface IRepositorio<TEntity> : IDisposable
        where TEntity : class 
    {
        IQueryable<TEntity> ObterTodos();
        IQueryable<TEntity> Obter(Func<TEntity, bool> predicate);
        TEntity Pesquisar(params object[] key);
        void Atualizar(TEntity obj);
        void SalvarModificacoes();
        void Adicionar(TEntity obj);
        void Excluir(Func<TEntity, bool> predicate);

    }
}
