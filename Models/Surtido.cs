using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlmacenWeb.Models
{
    public class Surtido
    {
        public int IdSurtido { get; set; }

        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }
        public string NombreEncar { get; set; }
        public int cantidad { get; set; }
        public int IdPro { get; set; }
    }
}