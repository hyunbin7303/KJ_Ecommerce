using System.ComponentModel;
using System.Reflection;

namespace ECommerce.Infrastructure.Helpers
{
    public static class EnumExtensions
    {
        public static string ToDescriptionString<TEnum>(this TEnum @enum)
        {
            FieldInfo info = @enum.GetType().GetField(@enum.ToString());
            var attributes = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);

            var check = @enum.ToString();

            return attributes?[0].Description ?? @enum.ToString();
        }
    }
}
