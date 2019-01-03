using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Temp\somefile.jpg";
            File.Copy(@"C:\Temp\somefile.jpg", @"C:\Giannis\TestFolder\someFile.jpg", true);        
            File.Delete(path);

            if (File.Exists(path))
            {
                ///some code
            }

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"C:\Giannis\TestFolder\someFile.jpg");
            //fileInfo.Delete();
            if (fileInfo.Exists)
            {
                ///some code
            }

            //Directory Statements
            Directory.CreateDirectory(@"C:\Temp\TestFolder2");

            var files = Directory.GetFiles(@"C:\Temp", "*.*", SearchOption.AllDirectories);            
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Temp", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            //Path
            var somePath = @"C:\Temp\someFile.jpg";
            var dotIndex = somePath.IndexOf(".");
            var extension = somePath.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(somePath));
            Console.WriteLine("FileName: " + Path.GetFileName(somePath));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(somePath));
        }
    }
}
