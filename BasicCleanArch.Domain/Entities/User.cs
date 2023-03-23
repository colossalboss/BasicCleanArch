using System;
using System.Collections.Generic;
using System.Text;
using BasicCleanArch.Domain.Common;

namespace BasicCleanArch.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
