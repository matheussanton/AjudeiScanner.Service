using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AjudeiScanner.Domain.Entities
{
    public class CouponEntityDomain
    {
        public CouponEntityDomain(
            Guid id,
            string code,
            DateTime date,
            Decimal amount,
            string? customerRegistrationNumber = null
        )
        {
            Id = id;
            Code = code;
            Date = date;
            Amount = amount;
            CustomerRegistrationNumber = customerRegistrationNumber;
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
        public string? CustomerRegistrationNumber { get; set; }
    }
}
