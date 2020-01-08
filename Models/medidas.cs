using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Change4Life.Models
{
    public class Medidas
    {
        public Guid Id { get; set; }
        public int Altura { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Peso { get; set; }
        public int Triceps { get; set; }
        public int Abdomen { get; set; }
        public int Torax { get; set; }
        public int Biceps { get; set; }
        public int Cintura { get; set; }
        public int Coxa { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}