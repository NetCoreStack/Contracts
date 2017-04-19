using System;

namespace NetCoreStack.Contracts.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class BsonCollectionName : Attribute
    {
        public BsonCollectionName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }
        
        public string Name { get; set; }
    }
}
