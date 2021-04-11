using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class Shipment
    {
        public string Id { get; set; }
        public string TrackingNumber { get; set; }
        public int? AddressId { get; set; }
        public int? WarehouseId { get; set; }
        public int? VendorId { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? LatestUpdatedDate { get; set; }
        public int? QuantityShipped { get; set; }
        public string Description { get; set; }
    }
}
