using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorLab2.Shared;

namespace BlazorLab2.Server.Data
{
    public class BlazorLab2ServerContext : DbContext
    {
        public BlazorLab2ServerContext (DbContextOptions<BlazorLab2ServerContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorLab2.Shared.TaskItem> TaskItem { get; set; }
    }
}
