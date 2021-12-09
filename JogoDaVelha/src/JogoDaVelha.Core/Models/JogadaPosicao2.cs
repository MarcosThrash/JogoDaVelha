using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao2 : Jogada
    {
        public JogadaPosicao2(int id, Jogador jogador, List<Jogada> jogadas)
            : base(id, jogador, jogadas)
        {
            Posicao = 2;
        }

        public override JogadaResult SituacaoPosJogada() =>
            SituacaoPosJogadaDuasLinhasDeVerificacao(LinhaDeVerificacao.Horizontal_1,
                LinhaDeVerificacao.Vertical_2);

        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
