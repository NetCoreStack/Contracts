using NetCoreStack.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreStack.Data.Contracts
{
    public class EntityIdentitySql : IEntity, IEntityIdentity<long>
    {
        [Key]
        public long Id { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}
