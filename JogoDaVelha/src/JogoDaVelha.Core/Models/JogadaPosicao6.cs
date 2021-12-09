using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao6 : Jogada
    {
        public JogadaPosicao6(int id, Jogador jogador, List<Jogada> jogadas)
            : base(id, jogador, jogadas)
        {
            Posicao = 6;
        }

        public override JogadaResult SituacaoPosJogada() =>
            SituacaoPosJogadaDuasLinhasDeVerificacao(LinhaDeVerificacao.Horizontal_2,
                LinhaDeVerificacao.Vertical_3);

        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
