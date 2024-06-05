using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proyectoGabineteAbogados.Models
{
    public class Asunto
    {
        [Key]
        public int AsuntoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}