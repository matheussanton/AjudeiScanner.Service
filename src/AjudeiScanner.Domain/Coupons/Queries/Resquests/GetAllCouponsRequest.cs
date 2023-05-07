using AjudeiScanner.Domain.Entities;
using MediatR;

namespace AjudeiScanner.Domain.Coupons.Queries.Resquests
{
    public class GetAllCouponsRequest : IRequest<List<CouponEntityDomain>>
    {
    }
}
