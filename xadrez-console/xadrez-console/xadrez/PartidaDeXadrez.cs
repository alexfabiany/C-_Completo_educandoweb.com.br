﻿using System.Collections.Generic;
using tabuleiro;

namespace xadrez {
    class PartidaDeXadrez {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }
        public bool xeque { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        public PartidaDeXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            xeque = false;
            terminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public Peca executarMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdeMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
            if (pecaCapturada != null) {
                capturadas.Add(pecaCapturada);
            }
            return pecaCapturada;
        }

        public void desfazerMovimento(Posicao origem, Posicao destino, Peca pecaCapturada) {
            Peca p = tab.retirarPeca(destino);
            p.decrementarQtdeMovimentos();

            if (pecaCapturada != null) {
                tab.colocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);
            }

            tab.colocarPeca(p, origem);
        }

        public void realizarJogada(Posicao origem, Posicao destino) {
            Peca pecaCapturada = executarMovimento(origem, destino);

            if (estaEmXeque(jogadorAtual)) {
                desfazerMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em xeque!");
            }
            /*
            if (estaEmXeque(adversaria(jogadorAtual))) {
                xeque = true;
            }
            else {
                xeque = false;
            }
            */
            xeque = (estaEmXeque(adversaria(jogadorAtual)));
            turno++;
            mudarJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos) {
            if (tab.peca(pos) == null) {
                throw new TabuleiroException("Não existe peça na posição informada!");
            }
            if (jogadorAtual != tab.peca(pos).cor) {
                throw new TabuleiroException("A peça informada não é sua!");
            }
            if (!tab.peca(pos).existemMovimentosPossiveis()) {
                throw new TabuleiroException("Não há movimentos possíveis para a peça informada!");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino) {
            if (!tab.peca(origem).podeMoverPara(destino)) {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void mudarJogador() {
            if (jogadorAtual == Cor.Branca) {
                jogadorAtual = Cor.Preta;
            }
            else {
                jogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> pecasCapturadas(Cor cor) {
            HashSet<Peca> set = new HashSet<Peca>();
            foreach (Peca p in capturadas) {
                if (p.cor == cor) {
                    set.Add(p);
                }
            }
            return set;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor) {
            HashSet<Peca> set = new HashSet<Peca>();
            foreach (Peca p in pecas) {
                if (p.cor == cor) {
                    set.Add(p);
                }
            }
            set.ExceptWith(pecasCapturadas(cor));
            return set;
        }

        private Cor adversaria(Cor cor) {
            /*
            if (cor == Cor.Branca) {
                return Cor.Preta;
            }
            else {
                return Cor.Branca;
            }
            */
            return (cor == Cor.Branca ? Cor.Preta : Cor.Branca);
        }

        private Peca rei(Cor cor) {
            foreach (Peca peca in pecasEmJogo(cor)) {
                if (peca is Rei) {
                    return peca;
                }
            }
            return null;
        }

        public bool estaEmXeque(Cor cor) {
            Peca r = rei(cor);
            if (r == null) {
                throw new TabuleiroException($"Não tem rei da cor {cor} no tabuleiro!");
            }

            foreach (Peca p in pecasEmJogo(adversaria(cor))) {
                bool[,] matrix = p.movimentosPossiveis();

                if (matrix[r.posicao.linha, r.posicao.coluna]) {
                    return true;
                }
            }
            return false;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca) {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca);
        }

        private void colocarPecas() {
            colocarNovaPeca('c', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('c', 2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('d', 2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('e', 2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('e', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('d', 1, new Rei(tab, Cor.Branca));

            colocarNovaPeca('c', 7, new Torre(tab, Cor.Preta));
            colocarNovaPeca('c', 8, new Torre(tab, Cor.Preta));
            colocarNovaPeca('d', 7, new Torre(tab, Cor.Preta));
            colocarNovaPeca('e', 7, new Torre(tab, Cor.Preta));
            colocarNovaPeca('e', 8, new Torre(tab, Cor.Preta));
            colocarNovaPeca('d', 8, new Rei(tab, Cor.Preta));
        }
    }
}
