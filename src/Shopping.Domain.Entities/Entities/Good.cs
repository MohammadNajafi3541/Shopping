using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities.Entities
{
    public class Good : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Caption { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public bool IsActive { get; set; }


        public virtual ICollection<FactorDetail> FactorDetails  => new Collection<FactorDetail>();

    }
}
