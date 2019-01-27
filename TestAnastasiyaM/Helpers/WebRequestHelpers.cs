using System.IO;
using System.Net;

namespace TestAnastasiyaM.Helpers
{
    public class WebRequestHelpers
    {
        public static string GetContent(string urladress)
        {
            var request = WebRequest.Create(urladress);
            string content;
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        content = reader.ReadToEnd();
                    }
                }
            }

            return content;
        }
    }
}
