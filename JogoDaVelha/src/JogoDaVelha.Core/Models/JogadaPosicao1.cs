using JogoDaVelha.Core.Enums;
using System;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao1 : Jogada
    {
        public JogadaPosicao1(int id, Jogador jogador, string rotulo) 
            : base(id, jogador, rotulo)
        {
            Posicao = 1;
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
