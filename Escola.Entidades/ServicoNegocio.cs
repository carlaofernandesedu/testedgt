using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entidades
{
    public class ServicoNegocio<TEntity> : IServicoNegocio<TEntity>
        where TEntity : Base
    {
        private IRepositorio<TEntity> _repo;
        public ServicoNegocio(IRepositorio<TEntity> repo)
        {
            _repo = repo;
        }
        public void Excluir(Func<TEntity, bool> predicate)
        {
            _repo.Excluir(predicate);
            _repo.SalvarModificacoes();
        }

        public IQueryable<TEntity> Obter(Func<TEntity, bool> predicate)
        {
            return _repo.Obter(predicate);
        }

        public IQueryable<TEntity> ObterTodos()
        {
            return _repo.ObterTodos();
        }

        public TEntity Pesquisar(params object[] key)
        {
            return _repo.Pesquisar(key);
        }

        public void Salvar(TEntity obj)
        {
            if (obj.ID > 0)
            {
                _repo.Atualizar(obj);
            }
            else
            {
                _repo.Adicionar(obj);
            }
            _repo.SalvarModificacoes();
                 
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
