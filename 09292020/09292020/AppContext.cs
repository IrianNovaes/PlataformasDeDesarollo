using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09292020
{
    public class AppContext : DbContext
    {
        public DbSet<Actividad> Actividades { get; set; }
    }
}
