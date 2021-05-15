using System;
using Repository.Pattern.Abstractions.Exceptions.Models;

namespace Repository.Pattern.Abstractions.Exceptions
{
    public class DoesNotExistsException : Exception
    {
        public DomainModelUid[] DomainModelUids { get; set; }

        public DoesNotExistsException(string message) : base(message)
        {
        }
    }
}
