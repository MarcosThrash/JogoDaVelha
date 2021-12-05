﻿using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao3 : Jogada
    {
        public JogadaPosicao3(int id, Jogador jogador) 
            : base(id, jogador)
        {
            Posicao = 3;
        }

        public override bool Ganhou()
        {
            throw new NotImplementedException();
        }

        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
