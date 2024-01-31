using Basic.Entities;
using System;
using System.Globalization;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        //lembre-se de substituir o caminho da pasta
        string path = @"c:\Lubilus2\Program\Programação\Aulas C# everest\Aulinha C# Arquivos\C# Completo\Course Codes\2024-01-30 Trabalhando com arquivos\Exercicio de fixação\Pasta\SourceFile.csv";
        try
        {
           CreateCSV CriarArquivo = new CreateCSV();
           CriarArquivo.Create(path);

            string[] lines = File.ReadAllLines(path);
            string sourceFolderPath = Path.GetDirectoryName(path);
            string targetFolderPath = sourceFolderPath + @"\out";
            string targetFilePath = targetFolderPath + @"\summary.csv";

            Directory.CreateDirectory(targetFolderPath);

            using (StreamWriter sw = File.AppendText(targetFilePath))
            {
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    
                    string name = fields[0].Trim().Trim('"');
                    double price = double.Parse(fields[1].Trim().Trim('"'), CultureInfo.InvariantCulture);
                    int quantity = int.Parse(fields[2].Trim().Trim('"'));

                    Produto p = new Produto(name, price, quantity);

                    Console.WriteLine(p);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}


