using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Endpoint.MVC.Models
{
    public class SellModel
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public long FactorNumber { get; set; }

        public List<SellDetailModel> FactorDetails => new List<SellDetailModel>();

    }


}