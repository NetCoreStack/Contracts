using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class PropertyDescriptorAttribute : Attribute
    {
        public string Name { get; set; }
        public string QueryStringName { get; set; }
        public string ComparableWith { get; set; }
        public bool EnableFilter { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsSelectable { get; set; }
        public bool IsCheckable { get; set; }
        public string DataSourceUrl { get; set; }
        public int MinimumInputLength { get; set; }
        public string[] Args { get; set; }
        public string CascadeFrom { get; set; }
        public string Mask { get; set; }
        public bool Sanitation { get; set; }
        public int Order { get; set; }
        public FilterOperator DefaultFilterBehavior { get; set; } = FilterOperator.IsEqualTo;

        public PropertyDescriptorAttribute()
        {
            // Convention!
            EnableFilter = true;
        }
    }
}
