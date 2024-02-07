using System.Text.Json;
namespace PalBreeding
{

    public static class JsonExtensions
    {
        public static string ToJson(this object obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        public static T? ToObject<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }

}
