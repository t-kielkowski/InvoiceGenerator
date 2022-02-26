using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.InvoiceData
{
    public class Buyer
    {
        public int BuyerID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string NIP { get; set; }
    }
}
