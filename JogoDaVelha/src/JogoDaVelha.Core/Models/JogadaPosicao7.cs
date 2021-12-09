using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao7 : Jogada
    {
        public JogadaPosicao7(int id, Jogador jogador, List<Jogada> jogadas)
            : base(id, jogador, jogadas)
        {
            Posicao = 7;
        }

        public override JogadaResult SituacaoPosJogada() =>
            SituacaoPosJogadaTresLinhasDeVerificacao(LinhaDeVerificacao.Horizontal_3,
                LinhaDeVerificacao.Vertical_1, LinhaDeVerificacao.Diagonal_2);

        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
