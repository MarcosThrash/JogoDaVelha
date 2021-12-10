using JogoDaVelha.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Exceptions
{
    [Serializable]
    public class JogadorRepetidoException: Exception
    {
        public JogadorRepetidoException(Jogador jogador)
            :base($"Não é permitido um mesmo jogador jogar duas vezes seguidas. Jogador infrator: {jogador}!")
        {

        }

        protected JogadorRepetidoException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
            :base(serializationInfo, streamingContext)
        {
            
        }
    }
}
