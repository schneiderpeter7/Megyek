using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Megyek
{
    public class Base64Encoder
    {
        public string Encode(string text)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text), Base64FormattingOptions.None).TrimEnd('=');
        }
        public string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
