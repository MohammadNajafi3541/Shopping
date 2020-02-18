using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Endpoint.ViewModel.Validations
{
   public class SellModelValidation : AbstractValidator<SellModel>
    {
        public SellModelValidation()
        {
            // validation
            RuleFor(x => x.Date.Date).GreaterThanOrEqualTo(DateTime.Now.Date);
            RuleFor(c => c.FactorDetails.Any()).Equal(true);
        }
    }
}
