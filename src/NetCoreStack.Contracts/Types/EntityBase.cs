using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreStack.Contracts
{
    public abstract class EntityBase : IObjectState
    {
        [NotMapped]
        [BsonIgnore]
        public ObjectState ObjectState { get; set; }
    }
}