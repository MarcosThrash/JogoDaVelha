using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Exceptions
{
    [Serializable]
    public class JogadaRepetidaException: Exception
    {
        public JogadaRepetidaException(int posicao)
            :base($"Não é permitido jogar duas vezes na mesma posicão. A posição: {posicao} já esta ocupada!"){

        }

        public JogadaRepetidaException()
            : base($"Não é permitido jogar duas vezes na mesma posicão.")
        {

        }

        protected JogadaRepetidaException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            :base(serializationInfo, streamingContext)
        {

        }
    }
}
