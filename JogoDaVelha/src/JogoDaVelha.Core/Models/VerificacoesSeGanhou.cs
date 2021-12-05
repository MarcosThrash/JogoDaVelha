using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoDaVelha.Core.Models
{
    public class VerificacoesSeGanhou : IVerficacoesSeGanhou
    {
        private readonly int[] posicoesHorizontal1 = { 1, 2, 3 };
        private readonly int[] posicoesHorizontal2 = { 4, 5, 6 };
        private readonly int[] posicoesHorizontal3 = { 7, 8, 9 };
        private readonly int[] posicoesVertical1 = { 1, 4, 7 };
        private readonly int[] posicoesVertical2 = { 2, 5, 8 };
        private readonly int[] posicoesVertical3 = { 3, 6, 9 };
        private readonly int[] posicoesDiagonal1= { 1, 5, 9 };
        private readonly int[] posicoesDiagonal2 = { 7, 5, 3 };

        public bool VerificaSeGanhouPorLinha(List<Jogada> jogadas, Jogada jogadaAtual, LinhaDeVerificacao linha)
        {
            return jogadas.Count(j => j.Jogador == jogadaAtual.Jogador &&
                                    RetornaVetorDaLinhaDeVerificacao(linha).Contains(j.Posicao)) == 2;
        }

        private int[] RetornaVetorDaLinhaDeVerificacao(LinhaDeVerificacao linha)
        {
            return linha switch
            {
                LinhaDeVerificacao.Horizontal_1 => posicoesHorizontal1,
                LinhaDeVerificacao.Horizontal_2 => posicoesHorizontal2,
                LinhaDeVerificacao.Horizontal_3 => posicoesHorizontal3,
                LinhaDeVerificacao.Vertical_1 => posicoesVertical1,
                LinhaDeVerificacao.Vertical_2 => posicoesVertical2,
                LinhaDeVerificacao.Vertical_3 => posicoesVertical3,
                LinhaDeVerificacao.Diagonal_1 => posicoesDiagonal1,
                LinhaDeVerificacao.Diagonal_2 => posicoesDiagonal2,
                _ => null
            };
        }
        
    }
}
