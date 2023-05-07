using AjudeiScanner.Domain.Entities;

namespace AjudeiScanner.Domain.Coupons.Interfaces
{
    public interface ICouponsRepository
    {
        Task<List<CouponEntityDomain>> FindCouponsAsync();

        Task<bool> CreateAsync(CouponEntityDomain entity);
    }
}
