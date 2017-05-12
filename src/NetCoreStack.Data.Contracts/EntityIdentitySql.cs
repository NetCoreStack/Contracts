using System;
using NetCoreStack.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreStack.Data.Contracts
{
    public class EntityIdentitySql : SqlEntityBase, IEntityIdentity<long>
    {
        public long Id { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}
