using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.InvoiceData
{
    public class InvoiceDetails
    {
        [Key]
        public string InvoiceNumber { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
