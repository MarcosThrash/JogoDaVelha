using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Interfaces
{
    public interface IJogoDaVelha
    {
        JogadaResult AdicionarJogada(int ordemSequencia, int posicao, Jogador jogador, List<Jogada> jogadasAnteriores);
        List<Jogada> Jogadas();
        SituacaoJogo SituacaoJogo();        
    }
}
