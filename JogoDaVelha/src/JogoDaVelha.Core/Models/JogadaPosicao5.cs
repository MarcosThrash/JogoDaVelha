using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao5 : Jogada
    {
        public JogadaPosicao5(int id, Jogador jogador) 
            : base(id, jogador)
        {
            Posicao = 5;
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
