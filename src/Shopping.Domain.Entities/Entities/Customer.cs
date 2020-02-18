using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities.Entities
{

    public partial class Customer: BaseEntity
    {
        public long Id { get; set; }


        [Required]
        [StringLength(50)]
        public string FName { get; set; }

        [StringLength(50)]
        public string LName { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        public bool IsBan { get; set; }


        public virtual ICollection<Factor> Factors => new Collection<Factor>();

    }
}
