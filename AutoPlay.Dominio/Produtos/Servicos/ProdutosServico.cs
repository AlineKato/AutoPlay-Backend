using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPlay.Dominio.Produtos.Entidades;
using AutoPlay.Dominio.Produtos.Servicos.Interfaces;

namespace AutoPlay.Dominio.Produtos.Servicos
{
    public class ProdutosServico : IProdutosServico
    {
        public void Deletar(Produto produto)
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

        public Produto Instanciar(int codigo, string? nome, decimal? valor, string? descricao, int? saldo)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Produto> Query()
        {
            throw new NotImplementedException();
        }

        public Produto Validar(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}