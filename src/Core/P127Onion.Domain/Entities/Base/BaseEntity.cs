using System;
using System.Collections.Generic;
using System.Text;

namespace P127Onion.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
