﻿namespace NetCoreStack.Contracts
{
    public class EntityTypeDefinition
    {
        public string PropertyName { get; set; }
        public string Metadata { get; set; }
        public bool IsCollection { get; set; }
    }
}
