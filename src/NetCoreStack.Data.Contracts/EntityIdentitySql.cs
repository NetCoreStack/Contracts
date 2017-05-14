using NetCoreStack.Contracts;
using System.ComponentModel.DataAnnotations;

namespace NetCoreStack.Data.Contracts
{
    public class EntityIdentitySql : SqlEntityBase, IEntityIdentity<long>
    {
        [Key]
        public long Id { get; set; }
    }
}
