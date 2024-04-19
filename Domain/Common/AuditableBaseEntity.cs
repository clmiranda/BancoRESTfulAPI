﻿namespace Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        public required string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public required string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}