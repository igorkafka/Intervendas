using System;
using System.Collections.Generic;
using System.Text;

namespace Intervendas.Domain.Entities
{
    public class SubCategoria
    {
        public Guid SubCategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public string Nome { get; set; }
    }
}
