using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasicoWebMVCCore.Models;

namespace BasicoWebMVCCore.Data
{
    public class BasicoWebMVCCoreContext : DbContext
    {
        public BasicoWebMVCCoreContext (DbContextOptions<BasicoWebMVCCoreContext> options)
            : base(options)
        {
        }

        public DbSet<BasicoWebMVCCore.Models.Movie> Movie { get; set; }
    }
}
