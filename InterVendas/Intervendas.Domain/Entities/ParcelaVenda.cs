using System;
using System.Collections.Generic;
using System.Text;

namespace Intervendas.Domain.Entities
{
    public class ParcelaVenda:Parcela
    {
        public virtual Venda Venda { get; set; }
    }
}
