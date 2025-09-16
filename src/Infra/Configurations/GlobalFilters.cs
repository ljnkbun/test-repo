using System.Reflection;
using Core.Constants;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configurations
{
    public static class GlobalFilters
    {
        public static void ApplyGlobalFilters(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.IsAbstract()) continue;

                // Check nếu entity có property RecordStatus
                var property = entityType.FindProperty("RecordStatus");
                if (property != null && property.ClrType == typeof(int))
                {
                    var method = typeof(GlobalFilters)
                        .GetMethod(nameof(SetGlobalFilter), BindingFlags.NonPublic | BindingFlags.Static)
                        ?.MakeGenericMethod(entityType.ClrType);

                    method?.Invoke(null, new object[] { modelBuilder });
                }
            }
        }

        private static void SetGlobalFilter<TEntity>(ModelBuilder modelBuilder)
            where TEntity : class
        {
            var entity = modelBuilder.Entity<TEntity>();
            entity.HasQueryFilter(e => EF.Property<int>(e, "RecordStatus") == (int)AuditStatus.Active);
        }
    }
}
