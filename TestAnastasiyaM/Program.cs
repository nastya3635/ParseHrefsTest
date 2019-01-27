using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using TestAnastasiyaM.Helpers;

namespace TestAnastasiyaM
{
    class Program
    {
        private const int HrefsCount = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите url адресс");
            string adress = Console.ReadLine();

            var content = WebRequestHelpers.GetContent(adress);
            var hrefs = WebRequestHelpers.ParseHrefs(content, HrefsCount);
            hrefs.ForEach(href => Console.WriteLine(href));
            //WebResponse response = request.GetResponse();

            //using (Stream stream = response.GetResponseStream())
            //{
            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        StreamWriter file = new StreamWriter(Path.GetFullPath(@"..\..\..\")+"TestFile.txt");
            //        string content = reader.ReadToEnd();
            //        var matches = Regex.Matches(content, "<a.+?href=\"(.+?)\"");
            //        for (int i=0; i<20 && i<=matches.Count; i++)
            //        { 
            //            Console.WriteLine(matches[i].Groups[1]);
            //            file.Write(matches[i].Groups[1]+"\n");
            //        }
            //        file.Close();
            //    }
            //}
            //response.Close();
            Console.Read();
        }
    }
}
