using Shopping.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Services.Interfaces
{
   public interface IFactorService
    {
        IEnumerable<Factor> GetAll(int page=1,int pagesize=10);
        long GetNewFactorNumber();
        Factor Add(Factor entity);
    }
}
