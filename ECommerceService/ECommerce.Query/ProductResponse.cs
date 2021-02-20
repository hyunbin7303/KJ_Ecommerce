
namespace ECommerce.Query
{

    // Can be used in Service Layer.
    public class ProductResponse<T> : BaseResponse<T>
    {
        public ProductResponse(T product) : base(product) { }

        public ProductResponse(string message) : base(message) { }
    }
}
