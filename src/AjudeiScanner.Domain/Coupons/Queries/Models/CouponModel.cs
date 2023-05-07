namespace AjudeiScanner.Domain.Coupons.Queries.Models
{
    public class CouponModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
        public string? CustomerRegistrationNumber { get; set; }
    }
}
