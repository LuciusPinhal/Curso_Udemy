using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\tempo\file1.txt";
            StreamReader rs = null;

            try
            {
                rs = File.OpenText(path);
                while (!rs.EndOfStream)
                {
                    string line = rs.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (rs != null) rs.Close();

            }
        }

    }
}




//string path = @"c:\tempo\file1.txt";
//FileStream fs = null;
//StreamReader rs = null;

//try
//{
//    fs = new FileStream(path, FileMode.Open);
//    rs = new StreamReader(fs);

//    string line = rs.ReadLine();
//    Console.WriteLine(line);

//}
//catch (IOException e)
//{
//    Console.WriteLine("Ocorreu um erro!");
//    Console.WriteLine(e.Message);
//}

//finally
//{
//    if (fs != null) fs.Close();
//    if (rs != null) rs.Close();

//}
//        }