using System;
using Repository.Pattern.Abstractions.Exceptions.Models;

namespace Repository.Pattern.Abstractions.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        public DomainModelUid[] DomainModelUids { get; set; }

        public AlreadyExistsException(string message) : base(message)
        {
        }
    }
}
