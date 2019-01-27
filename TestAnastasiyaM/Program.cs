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

            Console.WriteLine("Hrefs:");
            hrefs.ForEach(href => Console.WriteLine(href));
            
            Console.Read();
        }
    }
}
