using System;
using Xunit;

namespace NetCoreStack.Contracts.Tests
{
    public class EntityIdentityBson : IEntityIdentity<string>
    {
        // [BsonId]
        // [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // [BsonIgnore]
        public ObjectState ObjectState { get; set; }
    }

    [CollectionName("WithAttribute")]
    public class BsonCollectionWithAttribute
    {
    }

    public class GuidelineEntity : EntityIdentityBson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class CollectionNameTests
    {
        [Fact]
        public void Resolve_CollectionNames()
        {
        }
    }
}
