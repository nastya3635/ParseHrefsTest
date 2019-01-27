using System;
using TestAnastasiyaM.Helpers;

namespace TestAnastasiyaM
{
    class Program
    {
        private const int HrefsCount = 20;
        private const string OutputFileName = "ParsedHrefs.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите url адресс");
            string adress = Console.ReadLine();

            var content = WebRequestHelpers.GetContent(adress);
            var hrefs = WebRequestHelpers.ParseHrefs(content, HrefsCount);

            var filePath = FileHelpers.WriteToFileInTempFolder(hrefs, OutputFileName, false);
            Console.WriteLine($"Сылки сохранены в: {filePath}");
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
