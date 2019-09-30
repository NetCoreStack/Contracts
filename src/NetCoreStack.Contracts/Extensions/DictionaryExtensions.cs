using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetCoreStack.Contracts
{
    internal static class DictionaryExtensions
    {
        internal static void Merge(this IDictionary<string, object> instance, IDictionary<string, object> from)
        {
            instance.Merge(from, true);
        }

        internal static void Merge(this IDictionary<string, object> instance, IDictionary<string, object> from, bool replaceExisting)
        {
            foreach (KeyValuePair<string, object> entry in from)
            {
                if (replaceExisting || !instance.ContainsKey(entry.Key))
                {
                    instance[entry.Key] = entry.Value;
                }
            }
        }

        internal static IDictionary<string, object> ToDictionary(this object value)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);
            if (value != null)
            {
                var values = value as IDictionary<string, object>;
                if (values != null)
                {
                    return values;
                }

                PropertyInfo[] properties = value.GetType().GetProperties();

                for (int i = 0; i < properties.Length; i++)
                {
                    PropertyInfo propertyInfo = properties[i];
                    dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(value));
                }
            }

            return dictionary;
        }
    }
}