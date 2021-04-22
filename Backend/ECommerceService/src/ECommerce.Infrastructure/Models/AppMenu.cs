using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class AppMenu
    {
        public string Id { get; set; }
        public string UsedBy { get; set; }
        public string ParentId { get; set; }
        public string MenuName { get; set; }
        public string MenuType { get; set; }
        public string Visibility { get; set; }
        public string Availability { get; set; }
        public DateTimeOffset? LatestUpdatedDate { get; set; }
        public string Description { get; set; }
    }
}
