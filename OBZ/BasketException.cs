using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class  BasketException : Exception
    {
        public override string Message { get; }

        public BasketException(string message) : base(message)
        {
            Message = message;
        }
    }

    class BasketOverloadException : BasketException
    {
        public int BasketSize { get; }
        public override string Message { get; }

        public BasketOverloadException(int size, string message) : base(message)
        {
            BasketSize = size;
            Message = message;
        }
    }

    class BasketBadIndexException : BasketException
    {
        public BasketBadIndexException() : base(message: $"Index doesn't exist")
        {
            //EMPTY BODY
        }
    }

}
