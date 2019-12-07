using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskCratty
{

    
    public class DeskQuote

    {

        public string CustomerName { get; set; }

        public DateTime QuoteData { get; set; }

        public string ShippingType { get; set; }

        public Decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }

    }
}