using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Models
{
    public class JogoDaVelha : IJogoDaVelha
    {
        private SituacaoJogo SituacaoAtualJogo { get; set; }
        private Jogada JogadaAtual => null;
        private List<Jogada> ListaDeJogadas { get; set; }
        private JogadaFactory CriadorDeJogadas { get; set; }

        public JogoDaVelha()
        {
            ListaDeJogadas = new List<Jogada>();
            CriadorDeJogadas = new JogadaFactory();
            SituacaoAtualJogo = Enums.SituacaoJogo.Continua;
        }

        public JogadaResult AdicionarJogada(int ordemSequencia, int posicao, Jogador jogador, List<Jogada> jogadasAnteriores)
        {
            throw new NotImplementedException();
        }

        public List<Jogada> Jogadas() => ListaDeJogadas;

        public SituacaoJogo SituacaoJogo() => SituacaoAtualJogo;

        private bool VerificaJogadorRepetido(Jogador jogador) => JogadaAtual.Jogador == jogador;
        
        private bool VerificaJogadaRepetida(int posicao) => ListaDeJogadas.Any(j => j.IdSequencia == posicao);
        
    }
}
