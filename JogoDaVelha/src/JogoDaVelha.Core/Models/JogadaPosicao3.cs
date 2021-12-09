﻿using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao3 : Jogada
    {
        public JogadaPosicao3(int id, Jogador jogador, List<Jogada> jogadas)
            : base(id, jogador, jogadas)
        {
            Posicao = 3;
        }

        public override JogadaResult SituacaoPosJogada() =>
            SituacaoPosJogadaTresLinhasDeVerificacao(LinhaDeVerificacao.Horizontal_1,
                LinhaDeVerificacao.Vertical_3, LinhaDeVerificacao.Diagonal_2);

        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
