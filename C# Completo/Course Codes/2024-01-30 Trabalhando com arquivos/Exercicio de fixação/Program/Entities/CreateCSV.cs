using System.IO;
using System.Text;

namespace Basic.Entities
{
    class CreateCSV
    {
       public CreateCSV() { }
        
        public void Create(string path)
        {
            string[][] dados = new string[][]
           {
                new string[] {"PS3", "1000", "3"},
                new string[] {"Cell", "3000", "1"},
                new string[] {"Camisa", "50.3", "10"},
           };

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string[] linha in dados)
                {
                    StringBuilder linhaCSV = new StringBuilder();
                    for (int i = 0; i < linha.Length; i++)
                    {
                        // Adicionar aspas em torno do valor para lidar com vírgulas ou quebras de linha
                        linhaCSV.Append('"' + linha[i] + '"');

                        // Adicionar vírgula, exceto para o último valor
                        if (i < linha.Length - 1)
                            linhaCSV.Append(',');
                    }
                    sw.WriteLine(linhaCSV.ToString());
                }
            }
        }
    }
}
