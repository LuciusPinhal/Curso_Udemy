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
            string path = @"c:\tempo\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
             
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
                
        }

    }
}




//try
//{
//    using (FileStream fs = new FileStream(path, FileMode.Open))
//    {
//        using (StreamReader sr = new StreamReader(fs))
//        {
//            while (!sr.EndOfStream)
//            {
//                string line = sr.ReadLine();
//                Console.WriteLine(line);
//            }
//        }
//    }
//}
//catch (IOException ex)
//{
//    Console.WriteLine(ex.Message);
//}
