using System.ComponentModel;
using System.Reflection;

namespace PalBreeding
{
    public static class DescriptionExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString())!;
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
        public static string GetDescription<T>(string propertyName)
        {
            var propertyInfo = typeof(T).GetProperty(propertyName)
                ?? throw new ArgumentException($"'{propertyName}' is not a valid property of type '{typeof(T).Name}'.");
            var attribute = propertyInfo.GetCustomAttribute<DescriptionAttribute>();
            return attribute != null ? attribute.Description : string.Empty;
        }
    }

}
