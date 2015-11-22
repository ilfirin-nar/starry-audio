using System;
using System.Linq;

namespace Starry.Common.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsImplements<TInterface>(this Type type)
        {
            var interfaceType = typeof (TInterface);
            return type.IsImplements(interfaceType);
        }

        public static bool IsImplements(this Type type, Type interfaceType)
        {
            return type.GetInterfaces().Any(it => it == interfaceType);
        }
    }
}