using System;
using System.Collections.Generic;
using System.Text;

namespace Intervendas.Domain.Entities
{
    public class Produto
    {
        public string Descricao { get; set; }
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal ValorPago { get; set; }
        public virtual IList<Categoria> Categorias { get; set; }
    }
}
