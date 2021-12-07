using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Models
{
    public sealed class JogadaResult
    {
        public SituacaoJogo SituacaoJogo { get; }
        public LinhaDeVerificacao LinhaVitoria { get; }
        
        public JogadaResult(SituacaoJogo situacaoJogo, LinhaDeVerificacao linhaVitoria)
        {
            SituacaoJogo = situacaoJogo;
            LinhaVitoria = linhaVitoria;
        }
    }
}
