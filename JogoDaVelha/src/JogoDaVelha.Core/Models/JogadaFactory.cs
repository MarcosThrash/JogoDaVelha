using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Exceptions;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Models
{
    internal class JogadaFactory
    {
        public Jogada CriarJogada(int ordemSequencia, int posicaoJogada, Jogador jogador, List<Jogada> jogadasAnteriores) {
            return posicaoJogada switch
            {
                1 => new JogadaPosicao1(ordemSequencia, jogador, jogadasAnteriores),
                2 => new JogadaPosicao2(ordemSequencia, jogador, jogadasAnteriores),
                3 => new JogadaPosicao3(ordemSequencia, jogador, jogadasAnteriores),
                4 => new JogadaPosicao4(ordemSequencia, jogador, jogadasAnteriores),
                5 => new JogadaPosicao5(ordemSequencia, jogador, jogadasAnteriores),
                6 => new JogadaPosicao6(ordemSequencia, jogador, jogadasAnteriores),
                7 => new JogadaPosicao7(ordemSequencia, jogador, jogadasAnteriores),
                8 => new JogadaPosicao8(ordemSequencia, jogador, jogadasAnteriores),
                9 => new JogadaPosicao9(ordemSequencia, jogador, jogadasAnteriores),
                _ => throw new PosicaoInvalidaException(posicaoJogada)
            };
        }        
    }
}
