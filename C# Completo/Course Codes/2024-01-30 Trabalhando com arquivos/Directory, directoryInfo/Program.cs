using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"c:\tempo";
       
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(Path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                var files = Directory.EnumerateFiles(Path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("files");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }


                Directory.CreateDirectory(Path + @"\newFolder");


            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
                
        }

    }
}



//pegar todas as subpastas na pasta original

//IEnumerable<string> folders = Directory.EnumerateDirectories(Path, "*.*", SearchOption.AllDirectories);
//Console.WriteLine("FOLDERS");
//foreach (string item in folders)
//{
//    Console.WriteLine(item);
//}
