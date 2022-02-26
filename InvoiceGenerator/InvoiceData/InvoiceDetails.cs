using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.InvoiceData
{
    internal class InvoiceDetails
    {
        public string InvoiceNumber { get; set; }
        public string BankName{ get; set; }
        public string AccountNumber{ get; set; }
        public decimal HourlyRate{ get; set; }
    }
}
