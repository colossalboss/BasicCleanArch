using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCleanArch.Application.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
