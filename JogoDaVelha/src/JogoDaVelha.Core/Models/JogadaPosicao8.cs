﻿using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao8 : Jogada
    {
        public JogadaPosicao8(int id, Jogador jogador, List<Jogada> jogadas)
            : base(id, jogador, jogadas)
        {
            Posicao = 8;
        }

        public override JogadaResult SituacaoPosJogada()
        {
            throw new NotImplementedException();
        }

        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
