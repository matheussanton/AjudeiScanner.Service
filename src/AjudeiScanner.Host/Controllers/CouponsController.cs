using AjudeiScanner.Domain.Coupons.Commands;
using AjudeiScanner.Domain.Coupons.Commands.Handlers;
using AjudeiScanner.Domain.Coupons.Queries;
using AjudeiScanner.Domain.Coupons.Queries.Resquests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AjudeiScanner.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CouponsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CouponsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCoupons(
            [FromServices] CouponsQueryHandler handler)
        {
            GetAllCouponsRequest command = new GetAllCouponsRequest();
            var coupons = await handler.Handle(command, new CancellationToken());
            return Ok(coupons);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCupon(
            [FromServices] CouponsHandler handler,
            [FromBody] CreateCouponCommand command)
        {
            var created = await handler.Handle(command, new CancellationToken());

            return Ok(created);
        }
    }
}
