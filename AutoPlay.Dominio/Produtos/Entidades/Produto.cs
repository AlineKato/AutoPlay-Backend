using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPlay.Dominio.Produtos.Entidades
{
    public class Produto
    {
        public   virtual  int Codigo {get; protected set;}
        public   virtual  string? Nome{ get; protected set;}
        public   virtual  decimal? Valor { get; protected set;}
        public   virtual  string? Descricao  { get; protected set;}
        public   virtual  int? Saldo { get; protected set;}
        public Produto(string? nome, decimal? valor, string? descricao, int? saldo)
        {
            SetNome(nome);
            SetValor(valor);
            SetDescricao(descricao);
            SetSaldo(saldo);
        }
        
        public void SetCodigo(int codigo)
        {
            Codigo = codigo;
        }
        public void SetNome(string? nome)
        {
            if(string.IsNullOrEmpty(nome))
            {
                throw new Exception("O nome é obrigatório no produto");
            }
            Nome = nome;
        }
        public void SetValor(decimal? valor)
        {
            if(!valor.HasValue)
            {
                throw new Exception("O valor é obrigatório no produto");
            }

            if(valor.Value <= 3)
            {
                throw new Exception("O valor mínimo é 3,00");
            }
            Valor = valor;
        }
        public void SetDescricao(string? descricao)
        {
            if(!string.IsNullOrEmpty(descricao) && descricao.Length < 20)
            {
                throw new Exception("A descrição deve possuir no mínimo 20 caracteres");
            }
            Descricao = descricao;
        }
        public void SetSaldo(int? saldo)
        {
            if(saldo.HasValue && saldo.Value <= 0)
            {
                throw new Exception("Saldo é obrigatório no produto e não pode ser menor que 0");
            }
            Saldo = saldo;
        }
    }
}