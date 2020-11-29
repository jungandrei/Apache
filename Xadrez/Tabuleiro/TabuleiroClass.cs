using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Xadrez.Tabuleiro
{
    class TabuleiroClass
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public TabuleiroClass(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas,colunas];
        }

        //Métoda para acessar a matriz privada
        public Peca Peca (int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        
        //Retorna a peça na posição dada
        public Peca Peca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }
        
        //Verifica se existe uma peça em uma determinada posição. E se a posição é valida
        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }

            Pecas[pos.Linha, pos.Coluna] = p;   //Jogando a peca na matriz 
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            //Caso não exista peca e retorna nulo
            if (Peca(pos) == null)
            {
                return null;
            }

            //Variavel recebe a peca na posicao informada. Agora a peça não está em nenhuma posição. E limpa do tabuleiro. Depois mostra a peca
            Peca aux = Peca(pos);
            aux.Posicao = null;        
            Pecas[pos.Linha, pos.Coluna] = null; 
            return aux;
        }


        //Testando se uma posição é valida
        public bool PosicaoValida(Posicao pos)
        {
            //Não pode ser menor que zero ou não pode ultrapassar o limite do tabuleiro
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }

            return true;
        }

        //Caso a posição não seja válida, vai lançar uma exceção
        public void ValidarPosicao(Posicao pos)
        {
            //Se a minha posição não for válida. Lanço uma exceção
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }

    }
}
