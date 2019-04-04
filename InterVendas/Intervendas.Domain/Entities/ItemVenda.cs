using System;
using System.Collections.Generic;
using System.Text;

namespace Intervendas.Domain.Entities
{
    public class ItemVenda
    {
        public virtual Venda Venda { get; set; }
        public Guid ItemVendaId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public virtual IList<Produto> Produtos { get; set; }
    }
}
