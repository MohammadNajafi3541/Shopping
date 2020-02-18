using Shopping.Application.Services.Interfaces;
using Shopping.Domain.Contract.Abstract;
using Shopping.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Services.Services
{
    public class FactorService : IFactorService
    {
        private readonly IBaseRepository<Factor> factorRepo;

        public FactorService(IBaseRepository<Factor> FactorRepo)
        {
            factorRepo = FactorRepo;
        }

        public Factor Add(Factor entity)
        {
            var number = GetNewFactorNumber();
            entity.FactorNumber = number;

            return   factorRepo.Insert(entity);
             
        }

        public IEnumerable<Factor> GetAll(int page = 1, int pagesize = 10)
        {
            return factorRepo.GetAll(page, pagesize,true, null, x => x.OrderBy(y => y.Id), x => x.Customer, x => x.FactorDetails);
        }

        public long GetNewFactorNumber()
        {
            var number= (factorRepo.GetAll()?.Max(x => x.FactorNumber));

            return (number==null? 1 : (long)number + 1);

        }
    }
}
