using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteAquario.Models;

namespace SiteAquario.Data
{
    public class SiteAquarioContext : DbContext
    {
        public SiteAquarioContext (DbContextOptions<SiteAquarioContext> options)
            : base(options)
        {
        }

        //public DbSet<ValoresSensor> ValoresSensor { get; set; }
        public DbSet<SiteAquario.Models.ValoresSensor> ValoresSensor { get; set; } = default!;
    }
}
