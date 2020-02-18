using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities.Entities
{

    public partial class Factor : BaseEntity
    {

        public long Id { get; set; }

        public long CustomerId { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        public long FactorNumber { get; set; }

        public virtual Customer Customer { get; set; }


        public virtual ICollection<FactorDetail> FactorDetails => new Collection<FactorDetail>();
    }
}
