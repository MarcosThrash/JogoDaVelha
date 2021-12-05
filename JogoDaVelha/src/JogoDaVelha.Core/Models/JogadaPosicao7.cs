using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao7 : Jogada
    {
        public JogadaPosicao7(int id, Jogador jogador) 
            : base(id, jogador)
        {
            Posicao = 7;
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
