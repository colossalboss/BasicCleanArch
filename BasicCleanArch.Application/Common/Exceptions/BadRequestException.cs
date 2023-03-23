using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCleanArch.Application.Common.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {

        }

        public BadRequestException(string[] errors) : base("Multiple errors occurred. See more details")
        {
            errors = errors;
        }

        public string[] Errors { get; set; }
    }
}
