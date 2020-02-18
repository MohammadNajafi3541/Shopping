using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Endpoint.ViewModel
{
    public class SellModel
    {
        public int CustomerId { get; set; }

        public DateTime Date { get; set; }

        public long FactorNumber { get; set; }

        public List<SellDetailModel> FactorDetails => new List<SellDetailModel>();

    }


}