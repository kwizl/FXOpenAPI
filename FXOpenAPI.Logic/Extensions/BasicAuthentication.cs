using System.Text;

namespace FXOpenAPI.Logic.Extensions
{
    public static class BasicAuthentication
    {
        public static string ConvertToBase64(string id, string key, string secret)
        {
            string text =  $"{id}:{key}:{secret}";
            byte[] encodedByte = ASCIIEncoding.UTF8.GetBytes(text);
            string base64EncodedText = Convert.ToBase64String(encodedByte);

            return base64EncodedText;
        }

        public static string ConvertToSting(string id, string key, string secret)
        {
            string text = $"{id}:{key}:{secret}";

            return text;
        }
    }
}
