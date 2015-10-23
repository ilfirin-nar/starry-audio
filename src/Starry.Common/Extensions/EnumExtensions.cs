using System;
using System.ComponentModel;

namespace Starry.Common.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            return GetAttributeOf<DescriptionAttribute>(value)?.Description;
        }

        public static T GetAttributeOf<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memInfo = type.GetMember(value.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
    }
}