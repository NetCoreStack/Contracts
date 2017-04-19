using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetCoreStack.Contracts
{
    public static class DictionaryExtensionsOf
    {
        public static void TransferToKeyList<T, L>(this IDictionary<T, List<L>> from, IDictionary<T, List<L>> to)
        {
            foreach (var fromKvp in from)
            {
                if (!to.ContainsKey(fromKvp.Key))
                {
                    to.Add(fromKvp.Key, fromKvp.Value.GetRange(0, fromKvp.Value.Count));
                }
                else
                {
                    var list = to[fromKvp.Key];
                    foreach (var parentItem in fromKvp.Value)
                    {
                        if (!list.Contains(parentItem))
                            list.Add(parentItem);
                    }
                }
            }
        }
    }

    internal static class DictionaryExtensions
    {
        public static void Merge(this IDictionary<string, object> instance, IDictionary<string, object> from)
        {
            instance.Merge(from, true);
        }

        public static void Merge(this IDictionary<string, object> instance, IDictionary<string, object> from, bool replaceExisting)
        {
            foreach (KeyValuePair<string, object> entry in from)
            {
                if (replaceExisting || !instance.ContainsKey(entry.Key))
                {
                    instance[entry.Key] = entry.Value;
                }
            }
        }

        public static IDictionary<string, object> ToDictionary(this object value)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);
            if (value != null)
            {
                var values = value as IDictionary<string, object>;
                if (values != null)
                {
                    return values;
                }

                PropertyInfo[] properties = TypeExtensions.GetProperties(value.GetType());

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