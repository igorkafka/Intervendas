using System;
using System.Collections.Generic;
using System.Text;

namespace Intervendas.Domain.Entities
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string Celular { get; set; }
        public string Cidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
