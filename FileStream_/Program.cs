using System;
using System.IO;

namespace FileStream_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //Abrir o arquivo
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);                           //sr = File.OpenText(path); -> Poderia ser assim tb, porem apagando o FileStream

                //Enquanto não chegar no final do arquivo
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                //Fechando os arquivos manualmente
                if (sr != null)
                    sr.Close();

                if (fs != null)
                    fs.Close();
            }
        }
    }
}
