namespace ECommerce.Core.Models.OrderAggregate
{
    public enum OrderStatus
    {
        None = 0,
        Ready = 10,
        Submitted = 20,
        Pending = 30,
        PendingSubmitted = 40,
        Filled = 50,
        Closed = 60,// is it same with Fill?
        Cancelled = 70
    }
}
