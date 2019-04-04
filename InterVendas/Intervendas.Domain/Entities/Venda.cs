using System;
using System.Collections.Generic;
using System.Text;

namespace Intervendas.Domain.Entities
{
    public class Venda
    {
        public DateTime DataCadastro { get; set; }
        public Guid VendaId { get; set; }
        public string NotaFiscal { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public virtual IList<ItemVenda> ItemVendas { get; set; }
        public virtual IList<ParcelaVenda> ParcelaVendas { get; set; }
    }
}
