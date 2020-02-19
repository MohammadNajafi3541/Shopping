using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.Domain.Entities.Entities;

namespace Shopping.Domain.Contract.Mapping
{
    public class GoodMap
    {
        public GoodMap(EntityTypeConfiguration<Good> entityBuilder)
        {
          //  entityBuilder.HasKey(g => g.Id).HasRequired(g=>g.Caption);
            
        }
    }
}
