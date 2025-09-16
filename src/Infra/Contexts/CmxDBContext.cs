using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infra.Contexts
{
    public class CmxDBContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CmxDBContext(DbContextOptions<CmxDBContext> options
            , IHttpContextAccessor httpContextAccessor
            ) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _httpContextAccessor = httpContextAccessor;
        }

        public CmxDBContext() { }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var curUserId = _httpContextAccessor.HttpContext != null ? _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(x => x.Type == "id")!.Value : Convert.ToString(1); ;
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedOn = DateTime.Now;
                        entry.Entity.UserCreatedId = int.Parse(curUserId);

                        entry.Entity.ModifiedOn = DateTime.Now;
                        entry.Entity.UserModifiedId = int.Parse(curUserId);
                        break;

                    case EntityState.Modified:
                        entry.Entity.ModifiedOn = DateTime.Now;
                        entry.Entity.UserModifiedId = int.Parse(curUserId);
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
