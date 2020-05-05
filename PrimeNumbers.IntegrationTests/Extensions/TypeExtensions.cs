using System;
using System.Reflection;

namespace PrimeNumbers.IntegrationTests.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsSimple(this Type type)
        {
            var typeInfo = type.GetTypeInfo();

            return typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(Nullable<>)
                ? typeInfo.GetGenericArguments()[0].IsSimple()
                : typeInfo.IsPrimitive
                  || typeInfo.IsEnum
                  || type.Equals(typeof(string))
                  || type.Equals(typeof(decimal))
                  || type.Equals(typeof(DateTime));
        }
    }
}

