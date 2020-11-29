using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez.XadrezCamada
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez (char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        //Converter a posição da matriz na posição do xadrez (Cada caracter tem um numero. a = 97)
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
