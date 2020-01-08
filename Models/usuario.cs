using System;
using System.Collections.Generic;

namespace Change4Life.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Senha { get; set; }
        public IList<UsuarioCliente> UsuarioCliente { get; set; }
    }
}