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
            string sourcePath = @"c:\tempo\file1.txt";
            string targetPath = @"c:\tempo\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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



