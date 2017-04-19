﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace NetCoreStack.Contracts
{
    public static class EnumHelper
    {
        internal static bool HasFlags(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            Type checkedType = Nullable.GetUnderlyingType(type) ?? type;
            return HasFlagsInternal(checkedType);
        }

        private static bool HasFlagsInternal(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            FlagsAttribute attribute = type.GetTypeInfo().GetCustomAttribute<FlagsAttribute>(inherit: false);

            return attribute != null;
        }

        // Return non-empty name specified in a [Display] attribute for the given field, if any; field's name otherwise
        private static string GetDisplayName(FieldInfo field)
        {
            DisplayAttribute display = field.GetCustomAttribute<DisplayAttribute>(inherit: false);
            if (display != null)
            {
                string name = display.Name;
                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }
            }

            return field.Name;
        }

        public static string GetDisplayName(this Enum instance)
        {
            if (instance == null)
                return string.Empty;
            var fieldInfo = instance.GetType().GetField(instance.ToString());
            return GetDisplayName(fieldInfo);
        }

        public static IList<IdTextPair> GetSelectList<TEnum>(bool includeUnset = false, params TEnum[] excludeValues) where TEnum : struct, IConvertible
        {
            return GetSelectList(typeof(TEnum), includeUnset, excludeValues.Cast<object>().ToArray());
        }

        public static IList<IdTextPair> GetSelectList(Type type, bool includeUnset = false, params object[] excludeValues)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            IList<IdTextPair> selectList = new List<IdTextPair>();
            Type checkedType = Nullable.GetUnderlyingType(type) ?? type;
            bool isNullable = false;
            if (checkedType != type)
            {
                isNullable = true;
                selectList.Add(new IdTextPair { Text = string.Empty, Id = string.Empty });
            }
            
            foreach (FieldInfo field in checkedType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static))
            {
                object fieldValue = field.GetRawConstantValue();
                if (fieldValue == null)
                    continue;

                var parsedEnum = Enum.Parse(checkedType, fieldValue.ToString());
                if (excludeValues.Contains(parsedEnum))
                    continue;

                if (!includeUnset)
                {
                    if (int.Parse(fieldValue.ToString()) == 0 && !isNullable)
                        continue;
                }

                selectList.Add(new IdTextPair { Text = GetDisplayName(field), Id = fieldValue.ToString() });
            }

            return selectList.OrderBy(x => x.Id).ToList();
        }

        public static IList<string> AsStringList<TEnum>(IList<TEnum> enums) where TEnum : struct, IConvertible
        {
            if (!typeof(TEnum).IsEnumType())
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            IList<string> resultList = new List<string>();
            foreach (var item in enums)
            {
                var parsedEnum = Enum.Parse(typeof(TEnum), item.ToString());
                resultList.Add(EnumHelper.GetDisplayName((Enum)parsedEnum));
            }

            return resultList;
        }

        /// <summary>
        /// Unique Flags Enum Converter
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumCommaList"></param>
        /// <returns></returns>
        public static TEnum ConvertEnum<TEnum>(string commaListed) where TEnum : struct
        {
            if (string.IsNullOrEmpty(commaListed))
            {
                throw new ArgumentNullException(nameof(commaListed));
            }

            return (TEnum)Enum.Parse(typeof(TEnum), commaListed);
        }
    }
}