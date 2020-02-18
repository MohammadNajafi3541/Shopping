using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities.Entities
{
    public abstract class BaseEntity
    {
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
