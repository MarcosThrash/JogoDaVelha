using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Exceptions
{
    [Serializable]
    public class PosicaoInvalidaException : Exception
    {       
        public PosicaoInvalidaException(int posicao):base($"A posição {posicao} da jogada atual é inválida!")
        {

        }

        protected PosicaoInvalidaException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            :base(serializationInfo, streamingContext)
        {
            
        }
    }
}
