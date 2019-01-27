using System;
using System.Collections.Generic;
using System.IO;

namespace TestAnastasiyaM.Helpers
{
    public class FileHelpers
    {
        public const string ApplicationTempFolderName = "HrefsParser";

        /// <returns> File path </returns>
        public static string WriteToFileInTempFolder(List<string> rows, string outputFileName, bool append)
        {
            var tempPath = Path.GetTempPath();
            var outputDirectory = Path.Combine(tempPath, ApplicationTempFolderName);
            Directory.CreateDirectory(outputDirectory);

            var outputPath = Path.Combine(outputDirectory, outputFileName);
            WriteToFile(rows, outputPath, append);

            return outputPath;
        }

        public static void WriteToFile(List<string> rows, string outputPath, bool append)
        {
            using (var file = new StreamWriter(outputPath, append))
            {
                foreach (var row in rows)
                {
                    file.WriteLine(row);
                }
            }
        }
    }
}
