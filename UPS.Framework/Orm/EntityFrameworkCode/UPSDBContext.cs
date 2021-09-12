
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UPS.Framework.Orm.Models;
using UPS.Framework.Models;

namespace UPS.Framework.Orm.EntityFrameworkCode
{
    public class UPSDBContext : DbContext
    {
        //********************************************************************************************************
        //Variables:
        //Todo: fix DI
        public RequestContext _requestContext { get; set; }
        //********************************************************************************************************

        public UPSDBContext(DbContextOptions options, RequestContext requestContext) : base(options)
        {
            _requestContext = requestContext;
        }
        //********************************************************************************************************
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        //********************************************************************************************************
        public override int SaveChanges()
        {
            ApplyUPSConcepts();
            return base.SaveChanges();
        }
        //********************************************************************************************************
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ApplyUPSConcepts();
            return await base.SaveChangesAsync(cancellationToken);
        }
        //********************************************************************************************************
        private void ApplyUPSConcepts()
        {
            var userId = GetAuditUserId();
            foreach (var entry in base.ChangeTracker.Entries().ToList())
            {
                ApplyUPSConcepts(entry, userId);
            }
        }
        //********************************************************************************************************
        private void ApplyUPSConcepts(EntityEntry entry, long? userId)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    ApplyAbpConceptsForAddedEntity(entry, userId);
                    break;
                case EntityState.Modified:
                    ApplyAbpConceptsForModifiedEntity(entry, userId);
                    break;
                case EntityState.Deleted:
                    //Do nothing
                    //It can be used for safe delete.
                    break;
                case EntityState.Unchanged:
                    //Do nothing.
                    break;
            }
        }

        //********************************************************************************************************
        private void ApplyAbpConceptsForModifiedEntity(EntityEntry entry, long? userId)
        {
            if (entry.Entity is IModificationConcept modifiedEntity)
            {
                modifiedEntity.LastModificationTime = DateTime.Now;
                modifiedEntity.LastModifierUserId = userId;
            }
        }
        //********************************************************************************************************
        private void ApplyAbpConceptsForAddedEntity(EntityEntry entry, long? userId)
        {
            if (entry.Entity is ICreationConcept createdEntity)
            {
                createdEntity.CreationTime = DateTime.Now;
                createdEntity.CreatorUserId = userId;
            }
        }

        //********************************************************************************************************
        private long? GetAuditUserId()
        {
            //return the current user unique number.
            return _requestContext?.UserId;
        }

        //********************************************************************************************************
    }

}
