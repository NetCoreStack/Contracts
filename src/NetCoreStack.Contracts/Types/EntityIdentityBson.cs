using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NetCoreStack.Contracts
{
    public abstract class EntityIdentityBson : EntityBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
