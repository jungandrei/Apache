using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Directoty_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\temp\myFolder";

            try
            {
                //Listar todas as subpastas a partir da pasta myfolder
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //Listar todos os arquivos a partir de uma pasta informada
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Criando uma pasta
                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
                
            }
        }
    }
}
