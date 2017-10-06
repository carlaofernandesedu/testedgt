using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entidades
{
    public interface IServicoNegocio<TEntity>
        where TEntity : Base 
    {
        IQueryable<TEntity> ObterTodos();
        IQueryable<TEntity> Obter(Func<TEntity, bool> predicate);
        TEntity Pesquisar(params object[] key);
        void Salvar(TEntity obj);
        void Excluir(Func<TEntity, bool> predicate);

        void Dispose();
    }
}
