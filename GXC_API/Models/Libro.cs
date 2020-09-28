using System;
using System.Collections.Generic;

namespace GXC_API.Models
{
    public partial class Libro
    {
        public int Id { get; set; }
        public string NombreLibro { get; set; }
        public string Descripcion { get; set; }
        public string Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int NumeroEjemplares { get; set; }
        public decimal Costo { get; set; }
    }
}
