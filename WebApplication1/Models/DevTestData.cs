using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DevTestData
    {
        public enum Currency
        {
            NZD = 1,
            AUD = 2,
            USD = 3
        };

        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Decimal Price { get; set; }
        public Currency CurrencyCode { get; set; }
        public Int32 UnitsAvailable { get; set; }
        public String Description { get; set; }
        public Int32 DefaultSort { get; set; }

    }
}