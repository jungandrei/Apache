using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez.XadrezCamada
{
    class Torre : Peca
    {
        public Torre(TabuleiroClass tab, Cor cor) : base(tab, cor)
        {

        }

        //Quando imprimir "Torre" aparece "T"
        public override string ToString()
        {
            return "T";
        }

        //Testa se a casa ta livre ou tem inimigo
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Linhas];

            Posicao pos = new Posicao(0, 0);

            //ACIMA DA TORRE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            //Enquanto não bater no final do tabuleiro e Enquanto tiver lugar livre ou peca adversaria faz
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                //Quando bate em uma peça inimiga, para. Verifica a posicao se tem peca e se a cor é diferente
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                //Caso não ocorra, continua a verificar acima.
                pos.Linha = pos.Linha - 1;
            }

            //ABAIXO DA TORRE
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                //Caso não ocorra, continua a verificar abaixo.
                pos.Linha = pos.Linha + 1;
            }

            //DIREITA DA TORRE
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                //Caso não ocorra, continua a verificar a direita.
                pos.Coluna = pos.Coluna + 1;
            }

            //ESQUERDA
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                //Caso não ocorra, continua a verificar a esquerda.
                pos.Coluna = pos.Coluna - 1;
            }


            return mat;
        }
    }
}
