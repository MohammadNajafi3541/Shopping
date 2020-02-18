using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Endpoint.ViewModel
{
    public class SellDetailModel
    {

        public int GoodId { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }
    }
}