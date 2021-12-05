using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao4 : Jogada
    {
        public JogadaPosicao4(int id, Jogador jogador) 
            : base(id, jogador)
        {
            Posicao = 4;
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
