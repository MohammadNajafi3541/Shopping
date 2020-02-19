using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.Domain.Entities.Entities;

namespace Shopping.Domain.Contract.Extentions
{
    public static class ChangeTrackerExtensions
    {
        public static void ApplyAuditInformation(this DbChangeTracker changeTracker)
        {
            foreach (var entry in changeTracker.Entries())
            {
                if (!(entry.Entity is BaseEntity baseAudit)) continue;

                var now = DateTime.UtcNow;
                switch (entry.State)
                {
                    case EntityState.Modified:
                        baseAudit.Created = now;
                        baseAudit.Modified = now;
                        break;

                    case EntityState.Added:
                        baseAudit.Created = now;
                        break;
                }
            }
        }
    }
}
