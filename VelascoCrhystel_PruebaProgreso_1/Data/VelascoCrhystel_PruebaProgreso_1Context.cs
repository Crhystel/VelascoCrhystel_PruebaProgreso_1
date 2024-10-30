using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VelascoCrhystel_PruebaProgreso_1.Models;

namespace VelascoCrhystel_PruebaProgreso_1.Data
{
    public class VelascoCrhystel_PruebaProgreso_1Context : DbContext
    {
        public VelascoCrhystel_PruebaProgreso_1Context (DbContextOptions<VelascoCrhystel_PruebaProgreso_1Context> options)
            : base(options)
        {
        }

        public DbSet<VelascoCrhystel_PruebaProgreso_1.Models.Velasco> Velasco { get; set; } = default!;
        public DbSet<VelascoCrhystel_PruebaProgreso_1.Models.Celular> Celular { get; set; } = default!;
    }
}
