using System;
using System.Collections.Generic;
using System.Text;

namespace Intervendas.Domain.Entities
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        public string Nome { get; set; }
        public virtual IList<SubCategoria> SubCategorias { get; set; }
        public virtual IList<Produto> Produtos { get; set; }
    }
}
