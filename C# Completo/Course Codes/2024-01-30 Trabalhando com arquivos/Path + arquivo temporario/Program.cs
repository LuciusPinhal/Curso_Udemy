using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"c:\tempo\file1.txt";
        Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
        Console.WriteLine("PathSeparator: " + Path.PathSeparator);
        Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
        Console.WriteLine("GetFileName: " + Path.GetFileName(path));
        Console.WriteLine("GetExtension: " + Path.GetExtension(path));
        Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));

        //pegar a pasta temporaria do sistema para manipular arquivos
        Console.WriteLine("GetTempPath: " + Path.GetTempPath());

    }
}


