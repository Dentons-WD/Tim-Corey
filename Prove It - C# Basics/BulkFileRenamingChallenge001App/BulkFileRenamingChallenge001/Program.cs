using System;

namespace BulkFileRenamingChallenge001
{
    // GOAL
    // Create a Console app that will rename every text file
    // in a folder to be standard casing (first letter of each
    // word capitalized). Also replace any instance of Acme
    // with TimCo in the names.

    // BONUS
    // Using the files in the advanced folder, rename the
    // files based upon the first line of each file. So, if File1.txt
    // has a first line of Testing, the new file name should be
    // Testing.txt. Make sure to retain the extension type.

    class Program
    {
        static void Main(string[] args)
        {
            FileLogic.RenameFiles();
        }
    }
}
