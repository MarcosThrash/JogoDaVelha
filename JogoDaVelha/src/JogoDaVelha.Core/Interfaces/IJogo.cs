using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Interfaces
{
    public interface IJogo
    {
        SituacaoJogo AdicionarJogada(int posicao, string rotulo);
    }
}
