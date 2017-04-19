using System.ComponentModel.DataAnnotations;

namespace NetCoreStack.Contracts
{
    public abstract class EntityBaseSql : EntityBase
    {
        [Key]
        public long Id { get; set; }
    }
}
