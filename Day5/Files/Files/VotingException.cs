using System;
using System.Runtime.Serialization;

namespace Files
{
         [Serializable]
    
        internal class VotingException : ApplicationException
        {
            public VotingException(string error) : base(error)
            {

            }
        }
    
}