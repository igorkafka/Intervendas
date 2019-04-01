using System;
using System.Collections.Generic;
using System.Text;

namespace InterVendas.Entities
{
    public class Cliente
    {
        public string Celular { get; set; }
        public decimal Cep { get; set; }
        public string CepFormatado { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
