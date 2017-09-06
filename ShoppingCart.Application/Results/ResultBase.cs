using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Results
{
    public class ResultBase
    {
        public Status Status { get; }

        public string Message { get; }

        public Exception Exception { get; }

        public ResultBase(Status status, string message = "", Exception exception = null)
        {
            Status = status;
            Message = message;
            Exception = exception;
        }
    }
}
