using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPlay.Dominio.Produtos.Entidades;
using FluentNHibernate.Mapping;

namespace AutoPlay.Infra.Produtos.Mapeamentos
{
    public class ProdutosMap : ClassMap<Produto>
    {
        public ProdutosMap()
        {
            Schema("DELTA");
            Table("PRODUTO");
            Id(x => x.Codigo).Column("CODPRODUTO");
            Map(x => x.Nome).Column("NOMEPRODUTO");
            Map(x => x.Descricao).Column("DESCPRODUTO");
            Map(x => x.Valor).Column("VALOR");
            Map(x => x.Saldo).Column("SALDO");
        }
    }
}