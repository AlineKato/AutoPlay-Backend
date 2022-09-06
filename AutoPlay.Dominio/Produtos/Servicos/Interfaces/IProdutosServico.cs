using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPlay.Dominio.Produtos.Entidades;

namespace AutoPlay.Dominio.Produtos.Servicos.Interfaces
{
    public interface IProdutosServico
    {
        Produto Validar(int codigo);
        Produto Instanciar(int codigo, string? nome, decimal? valor, string? descricao, int? saldo);
        Produto Inserir(Produto produto);
        Produto Editar(Produto produto);
        void Deletar (Produto produto);
        //quando mappear produto, queryble retorna lista de objetos
        IQueryable<Produto> Query();
    }
}