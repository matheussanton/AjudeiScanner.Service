using AjudeiScanner.Domain.Coupons.Interfaces;
using AjudeiScanner.Domain.Coupons.Queries.Resquests;
using AjudeiScanner.Domain.Entities;
using MediatR;

namespace AjudeiScanner.Domain.Coupons.Queries
{
    public class CouponsQueryHandler : IRequestHandler<GetAllCouponsRequest, List<CouponEntityDomain>>
    {
        private readonly ICouponsRepository _repository;

        public CouponsQueryHandler(ICouponsRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CouponEntityDomain>> Handle(GetAllCouponsRequest request, CancellationToken cancellationToken)
        {
            return (await _repository.FindCouponsAsync());
        }
    }
}
