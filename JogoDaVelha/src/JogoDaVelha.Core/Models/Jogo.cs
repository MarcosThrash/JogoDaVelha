using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Exceptions;
using JogoDaVelha.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace JogoDaVelha.Core.Models
{
    public class Jogo : IJogo
    {
        private SituacaoJogo SituacaoAtualJogo { get; set; }
        private Jogada JogadaAtual { get; set; }
        private List<Jogada> ListaDeJogadas { get; set; }
        private JogadaFactory CriadorDeJogadas { get; set; }

        public Jogo()
        {
            ListaDeJogadas = new List<Jogada>();
            CriadorDeJogadas = new JogadaFactory();
            SituacaoAtualJogo = Enums.SituacaoJogo.Continua;
        }

        public JogadaResult AdicionarJogada(int ordemSequencia, int posicao, Jogador jogador)
        {
            if (ListaDeJogadas.Any())
            {
                if (SituacaoAtualJogo != Enums.SituacaoJogo.Continua)
                    throw new JogoTerminouException();

                if (VerificaJogadorRepetido(jogador))
                    throw new JogadorRepetidoException(jogador);

                if (VerificaJogadaRepetida(posicao))
                    throw new JogadaRepetidaException();
            }
            
            var novaJogada = CriadorDeJogadas.CriarJogada(ordemSequencia, posicao, jogador, ListaDeJogadas);

            var resultadoPosJogada = novaJogada.SituacaoPosJogada();

            if (resultadoPosJogada.SituacaoJogo == Enums.SituacaoJogo.Continua)
            {
                JogadaAtual = resultadoPosJogada.JogadaAtual;
                ListaDeJogadas.Add(JogadaAtual);
                SituacaoAtualJogo = resultadoPosJogada.SituacaoJogo;
            }

            return resultadoPosJogada;
        }

        public List<Jogada> Jogadas() => ListaDeJogadas;

        public SituacaoJogo SituacaoJogo() => SituacaoAtualJogo;

        private bool VerificaJogadorRepetido(Jogador jogador) => JogadaAtual.Jogador == jogador;
        
        private bool VerificaJogadaRepetida(int posicao) => JogadaAtual.Posicao == posicao;
        
    }    
}
