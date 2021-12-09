using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao4 : Jogada
    {
        public JogadaPosicao4(int id, Jogador jogador, List<Jogada> jogadas)
            : base(id, jogador, jogadas)
        {
            Posicao = 4;
        }

        public override JogadaResult SituacaoPosJogada() =>
            SituacaoPosJogadaDuasLinhasDeVerificacao(LinhaDeVerificacao.Horizontal_2,
                LinhaDeVerificacao.Vertical_1);

        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
