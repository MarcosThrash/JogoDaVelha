using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao6 : Jogada
    {
        public JogadaPosicao6(int id, Jogador jogador) 
            : base(id, jogador)
        {
            Posicao = 6;
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
