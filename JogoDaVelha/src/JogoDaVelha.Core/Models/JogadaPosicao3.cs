using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao3 : Jogada
    {
        public JogadaPosicao3(int id, Jogador jogador, string rotulo) 
            : base(id, jogador, rotulo)
        {
            Posicao = 3;
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
