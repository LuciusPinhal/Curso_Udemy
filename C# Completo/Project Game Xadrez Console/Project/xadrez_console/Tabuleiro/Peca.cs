﻿namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qteMovimentos = 0;
        }

        public void incrementarQtdMovimento()
        {
            qteMovimentos++;
        }
    }
}
