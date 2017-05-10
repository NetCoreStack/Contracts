﻿using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreStack.Contracts
{
    public abstract class EntityBase : IObjectState
    {
        [NotMapped]
        public virtual ObjectState ObjectState { get; set; }
    }
}