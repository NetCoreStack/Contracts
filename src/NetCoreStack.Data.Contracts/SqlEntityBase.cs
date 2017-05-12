using NetCoreStack.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreStack.Data.Contracts
{
    public abstract class SqlEntityBase : IEntity
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}
