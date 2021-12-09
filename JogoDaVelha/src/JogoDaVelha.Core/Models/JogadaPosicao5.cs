using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao5 : Jogada
    {
        public JogadaPosicao5(int id, Jogador jogador, List<Jogada> jogadas)
            : base(id, jogador, jogadas)
        {
            Posicao = 5;
        }

        public override JogadaResult SituacaoPosJogada() => SituacaoPosJogadaQuatroLinhasDeVerificacao();

        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
