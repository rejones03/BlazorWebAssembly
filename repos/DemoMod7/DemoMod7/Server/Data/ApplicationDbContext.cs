using DemoMod7.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingTasks.Shared;

namespace DemoMod7.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<BlazingTasks.Shared.TaskItem> TaskItem { get; set; }
        public DbSet<BlazingTasks.Shared.Tag> Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring a many-to-many special -> tag relationship that is friendly for serialization
            modelBuilder.Entity<TaskTag>().HasKey(pst => new { pst.TaskItemId, pst.TagId });
            modelBuilder.Entity<TaskTag>().HasOne<TaskItem>().WithMany(ps => ps.Tags);
            modelBuilder.Entity<TaskTag>().HasOne(pst => pst.Tag).WithMany();

            modelBuilder.Entity<Tag>().HasData(
                new Tag { TagId = 1, TagName = "Email", TagColor = "green" },
                new Tag { TagId = 2, TagName = "Quick", TagColor = "red" },
                new Tag { TagId = 3, TagName = "Shopping", TagColor = "orange" }
            );
        }
    }
}
