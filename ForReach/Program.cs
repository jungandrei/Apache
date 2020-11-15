using System;

namespace ForReach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Andrei", "Paola", "Meg" };

            foreach (string obj in vetor)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
