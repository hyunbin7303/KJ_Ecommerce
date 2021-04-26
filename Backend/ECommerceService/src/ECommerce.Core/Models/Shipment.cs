using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public partial class Shipment : Entity<string>
    {
        public string TrackingNumber { get; private set; }
        public int? AddressId { get; private set; }
        public int? WarehouseId { get; private set; }
        public int? VendorId { get; private set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? LatestUpdatedDate { get; set; }
        public int? QuantityShipped { get; set; }
        public string Description { get; set; }
    }
}
