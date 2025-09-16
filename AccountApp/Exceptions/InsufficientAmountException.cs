using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Exceptions
{
    internal class InsufficientAmountException : Exception
    {
        public InsufficientAmountException() : base("Insufficient Amount for the transaction") { }

        public InsufficientAmountException(string message) : base(message) { }

        public InsufficientAmountException(string? message ,Exception? InnerException) : base(message, InnerException) { }
    }

    
}
