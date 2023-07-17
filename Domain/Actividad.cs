using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Actividad
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Ciudad { get; set; }
        public string Evento { get; set; }
    }
}