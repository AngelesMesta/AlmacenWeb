using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlmacenWeb.Models;

namespace AlmacenWeb.Data
{
    public class MVCProductosContext:DbContext
    {
        public MVCProductosContext(DbContextOptions<MVCProductosContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Producto { get; set; }
    }
}
