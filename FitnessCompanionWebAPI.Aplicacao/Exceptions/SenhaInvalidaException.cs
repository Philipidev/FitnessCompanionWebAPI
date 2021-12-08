using System;

namespace FitnessCompanionWebAPI.Aplicacao.Exceptions
{
    [Serializable]
    public class SenhaInvalidaException : Exception
    {
        public SenhaInvalidaException()
        {

        }

        public SenhaInvalidaException(string message) : base(message)
        {

        }

        public SenhaInvalidaException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
