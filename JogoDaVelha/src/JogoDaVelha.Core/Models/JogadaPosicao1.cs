using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    public class JogadaPosicao1 : Jogada
    {
        public JogadaPosicao1(int id, Jogador jogador, List<Jogada> jogadas) 
            : base(id, jogador, jogadas)
        {
            Posicao = 1;
        }

        public override JogadaResult SituacaoPosJogada() =>
            SituacaoPosJogadaTresLinhasDeVerificacao(LinhaDeVerificacao.Horizontal_1, 
                LinhaDeVerificacao.Vertical_1, LinhaDeVerificacao.Diagonal_1);
                    
        public override Jogada ProximaJogadaDaMaquina()
        {
            throw new NotImplementedException();
        }
    }
}
