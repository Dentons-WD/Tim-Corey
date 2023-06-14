using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BulkFileRenamingChallenge001
{
    public class FileLogic
    {
        public static string rootDir = @"C:\Demos\Bulk File Renaming\BonusChallengeFiles\";

        public static void RenameFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(rootDir);

            List<FileInfo> files = directory.GetFiles().ToList();

            //foreach (FileInfo file in files)
            //{
            //    string fileName = Path.GetFileNameWithoutExtension(file.FullName);
            //    string extension  = Path.GetExtension(file.FullName);

            //    fileName = TitleCaseString(fileName);

            //    fileName = ReplaceAcmeWithTimCo(fileName);

            //    fileName = $"{ rootDir }{ fileName }{ extension }";

            //    file.MoveTo(fileName);
            //}

            List<string> lines = new List<string>();

            foreach (FileInfo file in files)
            {
                lines = File.ReadAllLines(file.FullName).ToList();

                string fileName = Path.GetFileNameWithoutExtension(file.FullName);
                string extension = Path.GetExtension(file.FullName);

                fileName = lines[0];

                fileName = $"{ rootDir }{ fileName }{ extension }";

                file.MoveTo(fileName);
            }
        }

        public static string TitleCaseString(string input)
        {
            string output = "";

            List<string> words = input.Split(' ').ToList();

            for (int i = 0; i < words.Count; i++)
            {
                string firstChar = words[i].Substring(0, 1).ToUpper();
                string remainingChars = words[i].Substring(1).ToLower();

                words[i] = $"{ firstChar }{ remainingChars }";
            }

            foreach (var word in words)
            {
                output = $"{ output } {word}";
            }

            output = output.Substring(1);

            return output;
        }

        public static string ReplaceAcmeWithTimCo(string input)
        {
            string output = "";

            output = input.Replace("Acme", "TimCo");

            return output;
        }
    }
}
