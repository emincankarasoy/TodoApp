using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Application.DTOs.Common
{
    public abstract class BaseDTO
    {
        public Guid ID { get; set; }
    }
}
