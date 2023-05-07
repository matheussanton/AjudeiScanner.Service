using AjudeiScanner.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudeiScanner.Domain.Coupons.Commands
{
    public class CreateCouponCommand : IRequest<bool>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
        public string? CustomerRegistrationNumber { get; set; }


        public CouponEntityDomain Parse()
            => new CouponEntityDomain(
                Guid.NewGuid(),
                Code,
                Date,
                Amount,
                CustomerRegistrationNumber
            );
    }
}
