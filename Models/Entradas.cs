using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlmacenWeb.Models
{
    public class Entradas
    { 
        public int IdEnSa { get; set; }
        public int tipo { get; set; }
        public string SucEnvia { get; set; }
        public string SucRecibe { get; set; }

        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }
        
        public int IdPro { get; set; }
        public int cantidad { get; set; }
    }
}