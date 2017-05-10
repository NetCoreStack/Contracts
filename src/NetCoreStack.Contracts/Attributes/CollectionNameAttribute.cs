using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class CollectionNameAttribute : Attribute
    {
        public CollectionNameAttribute(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }
        
        public string Name { get; set; }
    }
}
