using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"E:\temp\file1.txt";
            string targetPath = @"E:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                //Ler todas as linhas do arquivo e guardar cada linha como elemento do vetor. Depois imprimi cada linha na tela
                string[] lines = File.ReadAllLines(sourcePath);         
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
                
            }
        }

        
    }
}
