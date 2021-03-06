﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace NetCoreStack.Contracts
{
    public static class TypeHelper
    {
        public static bool IsEntity(Type type)
        {
            return typeof(IEntity).IsAssignableFrom(type);
        }

        public static bool IsIdModel(Type type)
        {
            if (typeof(IdModel).IsAssignableFrom(type))
            {
                return true;
            }

            return false;
        }

        public static bool IsKeyModel(Type type)
        {
            if (typeof(KeyModel).IsAssignableFrom(type))
            {
                return true;
            }

            return false;
        }

        public static string GetMemberName<T, TValue>(Expression<Func<T, TValue>> memberAccess)
        {
            return ((MemberExpression)memberAccess.Body).Member.Name;
        }

        public static void AddInterface(List<Type> types, Type type)
        {
            if (!types.Contains(type))
            {
                types.Add(type);
                Type[] interfaces = type.GetInterfaces();
                for (int i = 0; i < interfaces.Length; i++)
                {
                    Type intrfc = interfaces[i];
                    AddInterface(types, intrfc);
                }
            }
        }

        public static IList<T> CreateElementTypeAsGenericList<T>()
        {
            return (IList<T>)Activator.CreateInstance(typeof(List<>).MakeGenericType(new Type[] { typeof(T) }));
        }

        public static IEnumerable<T> CreateElementTypeAsEnumerable<T>()
        {
            return (IEnumerable<T>)Activator.CreateInstance(typeof(IEnumerable<>).MakeGenericType(new Type[] { typeof(T) }));
        }


        public static Type GetElementType(Type enumerableType)
        {
            return GetElementType(enumerableType, null);
        }

        public static Type GetElementType(Type enumerableType, IEnumerable enumerable)
        {
            if (enumerableType.HasElementType)
            {
                return enumerableType.GetElementType();
            }

            if (enumerableType.IsGenericType() &&
                enumerableType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            {
                return enumerableType.GetTypeInfo().GenericTypeArguments[0];
            }

            Type ienumerableType = GetIEnumerableType(enumerableType);
            if (ienumerableType != null)
            {
                return ienumerableType.GetTypeInfo().GenericTypeArguments[0];
            }

            if (typeof(IEnumerable).IsAssignableFrom(enumerableType))
            {
                var first = enumerable?.Cast<object>().FirstOrDefault();

                return first?.GetType() ?? typeof(object);
            }

            throw new ArgumentException($"Unable to find the element type for type '{enumerableType}'.", nameof(enumerableType));
        }

        private static Type GetIEnumerableType(Type enumerableType)
        {
            try
            {
                return enumerableType.GetTypeInfo().ImplementedInterfaces.FirstOrDefault(t => t.Name == "IEnumerable`1");
            }
            catch (AmbiguousMatchException)
            {
                if (enumerableType.BaseType() != typeof(object))
                    return GetIEnumerableType(enumerableType.BaseType());

                return null;
            }
        }
    }
}
