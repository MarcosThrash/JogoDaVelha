using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao1 : Jogada
    {
        public JogadaPosicao1(int id, Jogador jogador) 
            : base(id, jogador)
        {
            Posicao = 1;
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
