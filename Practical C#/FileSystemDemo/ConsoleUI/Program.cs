using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Demos\FileSystem";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            //foreach (string dir in dirs )
            //{
            //    Console.WriteLine(dir);
            //}

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files) 
            //{
            //    //Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));
            //    var info = new FileInfo(file);

            //    Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");
            //}

            //string newPath = @"C:\Demos\FileSystem\SubFolderC\SubSubFolderD";
            //Directory.CreateDirectory(newPath);

            //bool directoryExists = Directory.Exists(newPath);

            //if (directoryExists)
            //{
            //    Console.WriteLine("The directory exists");
            //}
            //else
            //{
            //    Console.WriteLine("The directory does not exist");
            //    Directory.CreateDirectory(newPath);
            //}

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"C:\Demos\FileSystem\SubFolderA\";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{ destinationFolder}{ Path.GetFileName(file) }", true);
            //}

            //for(int i = 0; i < files.Length; i++) 
            //{
            //    File.Copy(files[i], $"{ destinationFolder}{ i }.txt", false);
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{ destinationFolder }{ Path.GetFileName(file) }");
            //}

            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //Console.WriteLine(Path.GetDirectoryName(file));
                //var info = new FileInfo(file);

                //Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            }

            Console.ReadLine();
        }
    }
}
