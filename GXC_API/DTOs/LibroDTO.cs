using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GXC_API.DTOs
{
    public class LibroDTO
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
