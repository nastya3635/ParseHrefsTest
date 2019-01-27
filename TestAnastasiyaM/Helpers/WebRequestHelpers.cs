using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

        public static List<string> ParseHrefs(string htmlString, int maxHrefsCount)
        {
            const string HrefGroupPattern = "<a.+?href=\"(.+?)\"";
            var matches = Regex.Matches(htmlString, HrefGroupPattern);
            var hrefs = matches
                .Select(x => x.Groups[1].Value)
                .Take(maxHrefsCount)
                .ToList();

            return hrefs;
        }
    }
}
