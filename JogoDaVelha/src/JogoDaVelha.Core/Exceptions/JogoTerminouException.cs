using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Core.Exceptions
{
    [Serializable]
    public class JogoTerminouException : Exception
    {
        public JogoTerminouException() : base("O jogo está finalizado!")
        {
        }

        public JogoTerminouException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JogoTerminouException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
