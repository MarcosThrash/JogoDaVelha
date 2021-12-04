using JogoDaVelha.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Models
{
    public class VerificacoesSeGanhou : IVerficacoesSeGanhou
    {

        private readonly int[] posicoesHorizontal1 = { 1, 2, 3 };
        private readonly int[] posicoesHorizontal2 = { 4, 5, 6 };
        private readonly int[] posicoesHorizontal3 = { 7, 8, 9 };

        public bool VerificaSeGanhouDiagonal1(List<Jogada> jogadas, Jogada jogadaAtual)
        {
            throw new NotImplementedException();
        }

        public bool VerificaSeGanhouDiagonal2(List<Jogada> jogadas, Jogada jogadaAtual)
        {
            throw new NotImplementedException();
        }

        public bool VerificaSeGanhouHorizontal1(List<Jogada> jogadas, Jogada jogadaAtual)
        => (jogadas.Where(j => j.Rotulo.Equals(jogadaAtual.Rotulo) && 
                posicoesHorizontal1.Contains(j.Posicao)).Count()) == 2;                   

        public bool VerificaSeGanhouHorizontal2(List<Jogada> jogadas, Jogada jogadaAtual)
        => (jogadas.Where(j => j.Rotulo.Equals(jogadaAtual.Rotulo) &&
                posicoesHorizontal2.Contains(j.Posicao)).Count()) == 2;

        public bool VerificaSeGanhouHorizontal3(List<Jogada> jogadas, Jogada jogadaAtual)
        => (jogadas.Where(j => j.Rotulo.Equals(jogadaAtual.Rotulo) &&
                posicoesHorizontal3.Contains(j.Posicao)).Count()) == 2;

        public bool VerificaSeGanhouVertical1(List<Jogada> jogadas, Jogada jogadaAtual)
        {
            throw new NotImplementedException();
        }

        public bool VerificaSeGanhouVertical2(List<Jogada> jogadas, Jogada jogadaAtual)
        {
            throw new NotImplementedException();
        }

        public bool VerificaSeGanhouVertical3(List<Jogada> jogadas, Jogada jogadaAtual)
        {
            throw new NotImplementedException();
        }
    }
}
