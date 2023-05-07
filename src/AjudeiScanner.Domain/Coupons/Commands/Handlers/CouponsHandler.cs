using AjudeiScanner.Domain.Coupons.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudeiScanner.Domain.Coupons.Commands.Handlers
{
    public class CouponsHandler : IRequestHandler<CreateCouponCommand, bool>
    {
        private readonly ICouponsRepository _repository;

        public CouponsHandler(ICouponsRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Handle(CreateCouponCommand request, CancellationToken cancellationToken)
        {
            var entity = request.Parse();
            return await _repository.CreateAsync(entity);
        }
    }
}
