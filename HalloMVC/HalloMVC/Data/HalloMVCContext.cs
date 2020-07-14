using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HalloMVC.Models;

namespace HalloMVC.Data
{
    public class HalloMVCContext : DbContext
    {
        public HalloMVCContext (DbContextOptions<HalloMVCContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<HalloMVC.Models.Eis> Eis { get; set; }
    }
}
