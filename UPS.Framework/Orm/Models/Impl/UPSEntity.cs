using System;
using System.Collections.Generic;
using System.Text;

namespace UPS.Framework.Orm.Models.Impl
{
    public abstract class UPSEntity<TPrimaryKey> : IUPSEntity, ICreationConcept, IModificationConcept
    {
        public TPrimaryKey Id { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
    }
}
