using AjudeiScanner.Domain.Coupons.Interfaces;
using AjudeiScanner.Domain.Entities;
using AjudeiScanner.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AjudeiScanner.Infra.Data.Repositories.Coupons
{
    public class CouponsRepository : ICouponsRepository
    {
        public AppDbContext _context { get; }
        public CouponsRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<CouponEntityDomain>> FindCouponsAsync()
        {
            return (await _context.Coupons.ToListAsync());
        }

        public async Task<bool> CreateAsync(CouponEntityDomain entity)
        {
            try
            {
                _context.Coupons.Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
