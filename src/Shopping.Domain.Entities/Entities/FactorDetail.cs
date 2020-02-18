using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities.Entities
{
    public partial class FactorDetail
    {
        public long Id { get; set; }

        public long FactorId { get; set; }

        public int GoodId { get; set; }

        public int Count { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual Factor Factor { get; set; }

        public virtual Good Good { get; set; }
    }
}
