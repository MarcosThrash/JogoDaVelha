using JogoDaVelha.Core.Models;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Interfaces
{
    public interface IVerficacoesSeGanhou
    {
        bool VerificaSeGanhouHorizontal1(List<Jogada> jogadas, Jogada jogadaAtual);
        bool VerificaSeGanhouHorizontal2(List<Jogada> jogadas, Jogada jogadaAtual);
        bool VerificaSeGanhouHorizontal3(List<Jogada> jogadas, Jogada jogadaAtual);
        bool VerificaSeGanhouVertical1(List<Jogada> jogadas, Jogada jogadaAtual);
        bool VerificaSeGanhouVertical2(List<Jogada> jogadas, Jogada jogadaAtual);
        bool VerificaSeGanhouVertical3(List<Jogada> jogadas, Jogada jogadaAtual);
        bool VerificaSeGanhouDiagonal1(List<Jogada> jogadas, Jogada jogadaAtual);
        bool VerificaSeGanhouDiagonal2(List<Jogada> jogadas, Jogada jogadaAtual);
    }
}
