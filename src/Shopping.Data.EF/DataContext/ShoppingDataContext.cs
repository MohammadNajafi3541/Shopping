using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.Data.EF.Entities;

namespace Shopping.Data.EF.DataContext
{
    public class ShoppingDataContext : DbContext
    {
        public ShoppingDataContext() : base(@"Initial Catalog=Shopping;Data Source=.\sqlEXPRESS2014;Integrated Security=true")
        {
        }

        
        public virtual DbSet<Good> Goods { get; set; }



    }
}
