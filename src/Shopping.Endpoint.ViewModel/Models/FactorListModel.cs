using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Endpoint.ViewModel
{
    public class FactorListModel
    {
        public long Id { get; set; }

        public string CustomerName { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalPrice { get; set; }

        public long FactorNumber { get; set; }

        public int CountDetail { get; set; }
    }
}