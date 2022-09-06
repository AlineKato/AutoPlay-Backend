using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPlay.Dominio.Produtos.Entidades;
using AutoPlay.Dominio.Produtos.Repositorios;
using NHibernate;

namespace AutoPlay.Infra.Produtos
{
    public class ProdutosRepositorios : IProdutosRepositorios
    {
        private readonly ISession session;
        public ProdutosRepositorios(ISession session)
        {
            this.session = session;
        }
        public Produto Deletar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto Editar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto Inserir(Produto produto)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Produto> Query()
        {
            throw new NotImplementedException();
        }

        public Produto Recuperar(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}