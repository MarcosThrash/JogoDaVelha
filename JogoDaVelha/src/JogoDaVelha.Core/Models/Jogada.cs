using JogoDaVelha.Core.Enums;
using System.Collections.Generic;
using System.Linq;

namespace JogoDaVelha.Core.Models
{
    public abstract class Jogada: VerificacoesSeGanhou
    {
        public int IdSequencia { get; set; }
        public int Posicao { get; set; }
        public Jogador Jogador { get; set; }
        public string Rotulo { get; set; }
        protected List<Jogada> JogadasAnteriores { get; }
        protected int NumeroDeJogadas { get; }

        protected Jogada(int id, Jogador jogador, List<Jogada> jogadas)
        {
            IdSequencia = id;
            Jogador = jogador;
            Rotulo = jogador==Jogador.Humano ? "X" : "Y";
            JogadasAnteriores = jogadas;
            NumeroDeJogadas = jogadas.Count;
        }

        public abstract JogadaResult SituacaoPosJogada();

        public abstract Jogada ProximaJogadaDaMaquina();

        protected JogadaResult SituacaoPosJogadaTresLinhasDeVerificacao(LinhaDeVerificacao linha1, LinhaDeVerificacao linha2, LinhaDeVerificacao linha3)
        {
            var situacaoAux = Jogador == Jogador.Humano ? Enums.SituacaoJogo.HumanoGanhou : Enums.SituacaoJogo.MaquinaGanhou;
            var linhaAux = LinhaDeVerificacao.SemLinha;
            if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, linha1))
            {
                linhaAux = LinhaDeVerificacao.Horizontal_1;
            }
            else if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, linha2))
            {
                linhaAux = LinhaDeVerificacao.Vertical_1;
            }
            else if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, linha3))
            {
                linhaAux = LinhaDeVerificacao.Diagonal_1;
            }
            else if (NumeroDeJogadas == 8)
            {
                situacaoAux = SituacaoJogo.NinguemGanhou;
            }
            else
            {
                situacaoAux = SituacaoJogo.Continua;
            }
            return new JogadaResult(situacaoAux, linhaAux, this);
        }

        protected JogadaResult SituacaoPosJogadaDuasLinhasDeVerificacao(LinhaDeVerificacao linha1, LinhaDeVerificacao linha2)
        {
            var situacaoAux = Jogador == Jogador.Humano ? Enums.SituacaoJogo.HumanoGanhou : Enums.SituacaoJogo.MaquinaGanhou;
            var linhaAux = LinhaDeVerificacao.SemLinha;
            if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, linha1))
            {
                linhaAux = LinhaDeVerificacao.Horizontal_1;
            }
            else if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, linha2))
            {
                linhaAux = LinhaDeVerificacao.Vertical_1;
            }            
            else if (NumeroDeJogadas == 8)
            {
                situacaoAux = SituacaoJogo.NinguemGanhou;
            }
            else
            {
                situacaoAux = SituacaoJogo.Continua;
            }
            return new JogadaResult(situacaoAux, linhaAux, this);
        }

        /// <summary>
        /// Verificação em Quatro Linhas exlusiva da Posição 5
        /// </summary>
        /// <returns></returns>
        protected JogadaResult SituacaoPosJogadaQuatroLinhasDeVerificacao()
        {
            var situacaoAux = Jogador == Jogador.Humano ? Enums.SituacaoJogo.HumanoGanhou : Enums.SituacaoJogo.MaquinaGanhou;
            var linhaAux = LinhaDeVerificacao.SemLinha;
            if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, LinhaDeVerificacao.Horizontal_2))
            {
                linhaAux = LinhaDeVerificacao.Horizontal_2;
            }
            else if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, LinhaDeVerificacao.Vertical_2))
            {
                linhaAux = LinhaDeVerificacao.Vertical_2;
            }
            else if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, LinhaDeVerificacao.Diagonal_1))
            {
                linhaAux = LinhaDeVerificacao.Diagonal_1;
            }
            else if (VerificaSeGanhouPorLinha(JogadasAnteriores, this, LinhaDeVerificacao.Diagonal_2))
            {
                linhaAux = LinhaDeVerificacao.Diagonal_2;
            }
            else if (NumeroDeJogadas == 8)
            {
                situacaoAux = SituacaoJogo.NinguemGanhou;
            }
            else
            {
                situacaoAux = SituacaoJogo.Continua;
            }
            return new JogadaResult(situacaoAux, linhaAux, this);
        }
    }
}
