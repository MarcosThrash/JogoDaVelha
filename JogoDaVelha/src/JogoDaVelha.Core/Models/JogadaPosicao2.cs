using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao2 : Jogada
    {
        public JogadaPosicao2(int id, Jogador jogador, string rotulo) 
            : base(id, jogador, rotulo)
        {
            Posicao = 2;
        }

        public override bool Ganhou()
        {
            throw new NotImplementedException();
        }

        public override Jogada OndeJogar()
        {
            throw new NotImplementedException();
        }
    }
}
