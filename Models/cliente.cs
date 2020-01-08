using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Change4Life.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public Guid IdUsuario { get; set; }
        public IList<UsuarioCliente> UsuarioCliente { get; set; }

    }
}