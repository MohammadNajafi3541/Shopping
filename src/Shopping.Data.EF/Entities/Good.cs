using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Data.EF.Entities
{
    public class Good
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public bool IsActive { get; set; }

    }
}
