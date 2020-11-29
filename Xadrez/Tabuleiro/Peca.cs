using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; set; }
        public TabuleiroClass Tab { get; set; }

        public Peca (TabuleiroClass tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            QteMovimentos++;
        }

        public void DecrementarQtdMovimentos()
        {
            QteMovimentos--;
        }

        //Testar se a peca não esta bloqueada de movimentos
        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        //Se a peça pode mover para uma dada posição
        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        //Matriz de booleanos. Onde as peças de xadrez são obrigadas a implementar este método
        public abstract bool[,] MovimentosPossiveis();
    }
}
