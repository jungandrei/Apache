using System;

namespace StringInteressante
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            //MAISCULO
            string s1 = original.ToUpper();
            
            //MINUSCULO 
            string s2 = original.ToLower();

            //APAGAR ESPAÇOS EM BRANCO
            string s3 = original.Trim();

            //PROCURA O QUE ESTÁ NO PARAMETRO
            int n1 = original.IndexOf("bc");

            //PROCURA A ULTIMA OCORRENCIA DO PARAMETRO
            int n2 = original.LastIndexOf("bc");

            //CORTAR A STRING A PARTIR DA POSICAO DADA
            string s4 = original.Substring(3);

            //Vou começar cortando a partir da posicao 3, e só vou cortar 5 caracter
            string s5 = original.Substring(3, 5);

            //substituir uma string por outra. Onde tem a fica x
            string s6 = original.Replace("a", "x");

            //Testar se a variavel é vazia
            bool b1 = String.IsNullOrEmpty(original);

            //Testa se a variavel é nula ou um monte de espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);

            //
            var s7 = original.Split('a');

        }
    }
}
