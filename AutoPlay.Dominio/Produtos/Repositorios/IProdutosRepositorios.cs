using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPlay.Dominio.Produtos.Entidades;

namespace AutoPlay.Dominio.Produtos.Repositorios
{
    public interface IProdutosRepositorios
    {
        Produto Recuperar(int codigo);
        Produto Inserir(Produto produto);
        Produto Editar(Produto produto);
        Produto Deletar(Produto produto);
        IQueryable<Produto> Query();
    }
}