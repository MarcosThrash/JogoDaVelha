﻿using JogoDaVelha.Core.Enums;
using JogoDaVelha.Core.Models;
using System.Collections.Generic;

namespace JogoDaVelha.Core.Interfaces
{
    public interface IVerficacoesSeGanhou
    {
        bool VerificaSeGanhouPorLinha(List<Jogada> jogadas, Jogada jogadaAtual, LinhaDeVerificacao linha);        
    }
}
